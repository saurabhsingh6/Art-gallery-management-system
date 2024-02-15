Public Class LoginController
    Public Function loginController(username As String, password As String) As Boolean
        Dim ld As New Logindao()
        Dim b As Boolean = ld.logindao(username, password)
        Return b
    End Function
End Class
