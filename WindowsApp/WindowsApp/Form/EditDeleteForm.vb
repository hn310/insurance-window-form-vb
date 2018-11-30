Imports Oracle.DataAccess.Client

Public Class EditDeleteForm

    Private isInViewMode As Boolean = True

    Private user As UserDto

    Private Sub EditDeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EditUsernameTextBox.Text = user.UserName
        EditAgeTextBox.Text = user.UserAge
        EditAddressTextBox.Text = user.UserAddress
        EditAddressTextBox.Text = user.UserAddress
        'hide password region
        EditPasswordLabel.Hide()
        EditPasswordTextBox.Hide()
    End Sub

    Public Sub setUserInfo(user As UserDto)
        Me.user = user
    End Sub

    Private Sub Back_Btn_Click(sender As Object, e As EventArgs) Handles Back_Btn.Click
        ListUserForm.Show()
        Me.Close()
    End Sub

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click
        Dim msgBoxResult As MsgBoxResult = MessageBox.Show("Do you want to delete this user?", "Delete user", MessageBoxButtons.YesNo)
        If msgBoxResult = DialogResult.Yes Then
            deleteUser(user)
            MessageBox.Show("Delete successfully")
            'back to list user screen
            ListUserForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub deleteUser(user As UserDto)
        Dim conn As OracleConnection = DatabaseUtil.initConnection()
        Dim query As String = "DELETE FROM USER_INFO WHERE USER_NAME = :username"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        command.Parameters.Add(New OracleParameter("username", OracleDbType.Varchar2)).Value = user.UserName
        command.ExecuteReader()
        DatabaseUtil.closeConnection(conn)
    End Sub

    Private Sub Edit_Btn_Click(sender As Object, e As EventArgs) Handles Edit_Btn.Click
        If (isInViewMode) Then
            isInViewMode = False
            EditUsernameTextBox.ReadOnly = False
            EditAgeTextBox.ReadOnly = False
            EditAddressTextBox.ReadOnly = False
            EditPasswordLabel.Show()
            EditPasswordTextBox.Show()
            Edit_Btn.Text = "Save"
        Else
            Dim msgBoxResult As MsgBoxResult = MessageBox.Show("Do you want to update this user?", "Update user", MessageBoxButtons.YesNo)
            If msgBoxResult = DialogResult.Yes Then
                Try
                    user.UserName = EditUsernameTextBox.Text
                    user.UserAge = EditAgeTextBox.Text
                    user.UserAddress = EditAddressTextBox.Text
                    user.UserPassword = EditPasswordTextBox.Text
                    updateUser(user)
                    'back to list user screen
                    ListUserForm.Show()
                    Me.Close()
                    isInViewMode = True
                Catch ex As Exception
                    MessageBox.Show("Invalid value. Try again!")
                End Try
            End If
        End If
    End Sub

    Private Sub updateUser(user As UserDto)
        Dim conn As OracleConnection = DatabaseUtil.initConnection()
        Dim query As String = "UPDATE USER_INFO SET USER_PASSWORD = :password, USER_AGE = :age, USER_ADDRESS = :address WHERE USER_NAME = :username"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        command.Parameters.Add(New OracleParameter("password", OracleDbType.Varchar2)).Value = user.UserPassword
        command.Parameters.Add(New OracleParameter("age", OracleDbType.Int32)).Value = Convert.ToInt32(user.UserAge)
        command.Parameters.Add(New OracleParameter("address", OracleDbType.Varchar2)).Value = user.UserAddress
        command.Parameters.Add(New OracleParameter("username", OracleDbType.Varchar2)).Value = user.UserName
        Dim affectedRecords As Integer = command.ExecuteNonQuery()
        DatabaseUtil.closeConnection(conn)
        If (affectedRecords = 0) Then
            Throw New System.Exception()
        End If
    End Sub
End Class