
Imports MySql.Data.MySqlClient


Public Class DBConnection
    Public con As MySqlConnection
    Public Function getConnection() As MySqlConnection
        con = New MySqlConnection()
        con.ConnectionString = "server = localhost;user = root; password = W@2915djkq#;database = art_gallery_mgmt_system"
        Try
            con.Open()
            MessageBox.Show("connected to database.")
        Catch ex As Exception
            MessageBox.Show("can't connect to database")
        End Try
        Return con
    End Function
End Class
