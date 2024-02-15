
Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class Logindao
    Public con As MySqlConnection
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public Function logindao(username As String, password As String) As Boolean
        Dim db As New DBConnection
        con = db.getConnection()
        cmd = New MySqlCommand("select * from admin_login_creds;", con)
        dr = cmd.ExecuteReader()
        If dr.Read Then
            Return True
        End If
        Return False
    End Function
End Class
