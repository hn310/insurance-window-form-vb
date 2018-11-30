Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Client.OracleException

Public Class AddUserForm
    Private Sub Back_Btn_Click(sender As Object, e As EventArgs) Handles Back_Btn.Click
        ListUserForm.Show()
        Me.Close()
    End Sub

    Private Sub Add_Btn_Click(sender As Object, e As EventArgs) Handles Add_Btn.Click
        Try
            Dim user As UserDto = getNewUserInfo()
            If (checkUserValidity(user) = False) Then
                MessageBox.Show("Invalid user information" & vbNewLine & "Try again")
                Return
            End If
            'if all fieds are filled, add user to db
            addUserToDB(user)
            MessageBox.Show("Add successfully")
        Catch ex As Exception
            MessageBox.Show("Exception Occurred. Try again!")
        End Try
    End Sub

    Private Function getNewUserInfo() As UserDto
        Dim user As New UserDto()
        Dim username As String = AddUsernameTextBox.Text
        Dim age As String = AddAgeTextBox.Text
        Dim address As String = AddAddressTextBox.Text
        Dim password As String = AddPasswordTextBox.Text
        user.UserName = username
        user.UserAge = age
        user.UserAddress = address
        user.UserPassword = password
        Return user
    End Function

    Private Function checkUserValidity(user As UserDto) As Boolean
        If (StringUtil.isEmpty(user.UserName) = False OrElse
            StringUtil.isEmpty(user.UserName) = False OrElse
            StringUtil.isEmpty(user.UserName) = False OrElse
            StringUtil.isEmpty(user.UserName) = False) Then
            Return False
        End If

        Return True
    End Function

    Private Sub addUserToDB(user As UserDto)
        Dim conn As OracleConnection = DatabaseUtil.initConnection()
        Dim query As String = "INSERT INTO USER_INFO (USER_NAME, USER_PASSWORD, USER_AGE, USER_ADDRESS) VALUES (:username, :password, :age, :address)"
        Dim command As OracleCommand = New OracleCommand(query, conn)
        command.Parameters.Add(New OracleParameter("username", OracleDbType.Varchar2)).Value = user.UserName
        command.Parameters.Add(New OracleParameter("password", OracleDbType.Varchar2)).Value = user.UserPassword
        command.Parameters.Add(New OracleParameter("age", OracleDbType.Int32)).Value = Convert.ToInt32(user.UserAge)
        command.Parameters.Add(New OracleParameter("address", OracleDbType.Varchar2)).Value = user.UserAddress
        command.ExecuteReader()
        DatabaseUtil.closeConnection(conn)
    End Sub

End Class