Imports Oracle.DataAccess.Client

Module DatabaseUtil
    Private conn As OracleConnection

    Public Function initConnection() As OracleConnection
        conn = New OracleConnection("Data Source=localhost:1522/test;User ID=root;Password=root")
        conn.Open()
        Return conn
    End Function

    Public Sub closeConnection(connection As OracleConnection)
        connection.Dispose()
    End Sub
End Module
