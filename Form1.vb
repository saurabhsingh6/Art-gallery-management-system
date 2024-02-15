Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        usernameLabel.Text = "Username"
        passwordLabel.Text = "Password"
        loginButton.Text = "Log In"
        companyNameTextbox.Text = "Art Gallery Management System"
        Label4.Text = "Admin Login Page"


    End Sub

    Private Sub passwordTextbox_Click(sender As Object, e As EventArgs) Handles passwordLabel.Click

    End Sub

    Private Sub loginButton_Click(sender As Object, e As EventArgs) Handles loginButton.Click

        Dim username As String = usernameLabel.Text
        Dim password As String = passwordLabel.Text
        Dim lc As New LoginController()
        Dim b As Boolean = lc.loginController(username, password)
        If b = True Then
            MessageBox.Show("logged In")
            Me.Visible = False
            Admin_dashboard.Visible = True
        Else
            MessageBox.Show("can't log in")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
