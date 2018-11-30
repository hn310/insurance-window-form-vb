Module StringUtil

    Public Function isEmpty(input As String) As Boolean
        If IsNothing(input) Then
            Return False
        End If

        If input.Trim().Length = 0 Then
            Return False
        End If

        Return True
    End Function

End Module
