Imports Oracle.DataAccess.Client

Public Class ListUserForm

    Private Const numberOfRecordsPerPage As Integer = 5
    Private currentPage As Integer = 1
    Private totalRecords As Integer = 0

    Private users As New List(Of UserDto)

    Private Sub ListUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'init
        currentPage = 1

        'get data from DB
        users = getUserInfo()
        'display
        displayDataTable(users)
    End Sub

    Private Sub displayDataTable(users As List(Of UserDto))
        'fill data to DataGridView
        UserDataGridView.DataSource = Nothing
        UserDataGridView.Rows.Clear()
        UserDataGridView.Rows.Add(users.Count) 'add n new rows to data grid view

        For i As Integer = 0 To users.Count - 1
            UserDataGridView.Rows(i).Cells("user_name").Value = users(i).UserName
            UserDataGridView.Rows(i).Cells("user_age").Value = users(i).UserAge
            UserDataGridView.Rows(i).Cells("user_address").Value = users(i).UserAddress
        Next
    End Sub

    Private Function getUserInfo() As List(Of UserDto)
        Dim users As New List(Of UserDto)
        Dim conn As OracleConnection
        Dim command As OracleCommand
        Dim dataReader As OracleDataReader
        Dim query As String

        'pagination area
        Dim startQueryPosition As Integer = 0
        Dim endQueryPosition As Integer = 0
        totalRecords = PaginationUtil.getTotalRecords()
        startQueryPosition = PaginationUtil.getStartQueryPosition(currentPage, numberOfRecordsPerPage)
        endQueryPosition = PaginationUtil.getEndQueryPostion(startQueryPosition, numberOfRecordsPerPage, totalRecords)

        'display current page label
        PagingDisplay.Text = currentPage & "/" & PaginationUtil.getTotalPages(totalRecords, numberOfRecordsPerPage)

        conn = DatabaseUtil.initConnection()
        query = "SELECT * from ( select m.*, rownum r from USER_INFO m) where r >= :startQueryPosition and r <= :endQueryPosition"
        command = New OracleCommand(query, conn)

        command.Parameters.Add(New OracleParameter("startQueryPosition", OracleDbType.Int32)).Value = startQueryPosition
        command.Parameters.Add(New OracleParameter("endQueryPosition", OracleDbType.Int32)).Value = endQueryPosition

        'read data
        dataReader = command.ExecuteReader()
        While dataReader.Read()
            Dim user As New UserDto()
            user.UserName = dataReader("USER_NAME").ToString
            user.UserAddress = dataReader("USER_ADDRESS").ToString
            user.UserAge = Convert.ToInt32(dataReader("USER_AGE").ToString)
            users.Add(user)
        End While

        'close connection
        DatabaseUtil.closeConnection(conn)

        Return users
    End Function

    Private Sub UserDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles UserDataGridView.CellContentClick
        Dim currentValue As String = UserDataGridView.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Dim usernameInSameRow As String = UserDataGridView.Rows(e.RowIndex).Cells("user_name").Value

        'link activated only when click on username column
        If String.Equals(currentValue, usernameInSameRow) Then
            'pass data to EditDeleteForm
            Dim user As New UserDto()
            For i = 0 To (users.Count - 1)
                If users(i).UserName.Equals(currentValue) Then
                    user = users(i)
                End If
            Next
            EditDeleteForm.setUserInfo(user)
            EditDeleteForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub MoveToAddFormBtn_Click(sender As Object, e As EventArgs) Handles MoveToAddFormBtn.Click
        AddUserForm.Show()
        Me.Close()
    End Sub

    Private Sub PagingBackBtn_Click(sender As Object, e As EventArgs) Handles PagingBackBtn.Click
        currentPage -= 1
        If (currentPage = 0) Then
            currentPage = 1
            MessageBox.Show("You are already at first page")
            Return
        End If
        users = getUserInfo()
        displayDataTable(users)
    End Sub

    Private Sub PagingNextBtn_Click(sender As Object, e As EventArgs) Handles PagingNextBtn.Click
        Dim totalPages As Integer = PaginationUtil.getTotalPages(totalRecords, numberOfRecordsPerPage)

        If (currentPage + 1 > totalPages) Then
            currentPage = totalPages
            MessageBox.Show("You are already at last page")
            Return
        Else
            currentPage += 1
        End If
        users = getUserInfo()
        displayDataTable(users)
    End Sub
End Class