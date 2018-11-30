Imports Oracle.DataAccess.Client

Public Class LoginForm
    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        login()
    End Sub

    Private Sub login()
        Dim username As String
        Dim password As String
        Dim conn As OracleConnection
        Dim command As OracleCommand
        Dim dataReader As OracleDataReader
        Dim query As String

        username = UsernameTextBox.Text
        password = PasswordTextBox.Text

        'init data
        conn = DatabaseUtil.initConnection()
        query = "SELECT * FROM USER_INFO WHERE user_name = :username AND user_password = :password"
        command = New OracleCommand(query, conn)

        Dim p_user_name As OracleParameter = New OracleParameter()
        p_user_name.OracleDbType = OracleDbType.Varchar2
        p_user_name.Value = username

        Dim p_user_password As OracleParameter = New OracleParameter()
        p_user_password.OracleDbType = OracleDbType.Varchar2
        p_user_password.Value = password

        command.Parameters.Add(p_user_name)
        command.Parameters.Add(p_user_password)

        'read data
        dataReader = command.ExecuteReader()

        If dataReader.HasRows Then
            ListUserForm.Show()
            Me.Close()
        Else
            MessageBox.Show("Login false" & vbNewLine & "Try again")
        End If

        'close connection
        DatabaseUtil.closeConnection(conn)
    End Sub

End Class
