Public Class UserDto
    Private userNameValue As String
    Private userPasswordValue As String
    Private userAddressValue As String
    Private userAgeValue As Integer

    Public Sub New()

    End Sub

    Public Sub New(userNameValue As String, userPasswordValue As String, userAddressValue As String, userAgeValue As Integer)
        Me.userNameValue = userNameValue
        Me.userPasswordValue = userPasswordValue
        Me.userAddressValue = userAddressValue
        Me.userAgeValue = userAgeValue
    End Sub

    Public Property UserName() As String
        Get
            Return userNameValue
        End Get
        Set(ByVal value As String)
            userNameValue = value
        End Set
    End Property

    Public Property UserPassword() As String
        Get
            Return userPasswordValue
        End Get
        Set(ByVal value As String)
            userPasswordValue = value
        End Set
    End Property

    Public Property UserAddress() As String
        Get
            Return userAddressValue
        End Get
        Set(ByVal value As String)
            userAddressValue = value
        End Set
    End Property

    Public Property UserAge() As String
        Get
            Return userAgeValue
        End Get
        Set(ByVal value As String)
            userAgeValue = value
        End Set
    End Property

End Class
