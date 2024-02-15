<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        companyNameTextbox = New Label()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        loginButton = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        passwordLabel = New Label()
        usernameLabel = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(companyNameTextbox)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(884, 98)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' companyNameTextbox
        ' 
        companyNameTextbox.AutoSize = True
        companyNameTextbox.Font = New Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point)
        companyNameTextbox.ForeColor = SystemColors.ControlLightLight
        companyNameTextbox.Location = New Point(33, 34)
        companyNameTextbox.Name = "companyNameTextbox"
        companyNameTextbox.Size = New Size(114, 41)
        companyNameTextbox.TabIndex = 0
        companyNameTextbox.Text = "Label3"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = SystemColors.Desktop
        GroupBox2.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(loginButton)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(TextBox1)
        GroupBox2.Controls.Add(passwordLabel)
        GroupBox2.Controls.Add(usernameLabel)
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(212, 126)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(492, 407)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(28, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 41)
        Label4.TabIndex = 5
        Label4.Text = "Label1"
        ' 
        ' loginButton
        ' 
        loginButton.BackColor = Color.Lime
        loginButton.Location = New Point(92, 284)
        loginButton.Name = "loginButton"
        loginButton.Size = New Size(194, 38)
        loginButton.TabIndex = 4
        loginButton.Text = "Button1"
        loginButton.UseVisualStyleBackColor = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(188, 196)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(213, 27)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(188, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(213, 27)
        TextBox1.TabIndex = 2
        ' 
        ' passwordLabel
        ' 
        passwordLabel.AutoSize = True
        passwordLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        passwordLabel.Location = New Point(63, 196)
        passwordLabel.Name = "passwordLabel"
        passwordLabel.Size = New Size(69, 28)
        passwordLabel.TabIndex = 1
        passwordLabel.Text = "Label2"
        ' 
        ' usernameLabel
        ' 
        usernameLabel.AutoSize = True
        usernameLabel.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        usernameLabel.Location = New Point(63, 79)
        usernameLabel.Name = "usernameLabel"
        usernameLabel.Size = New Size(69, 28)
        usernameLabel.TabIndex = 0
        usernameLabel.Text = "Label1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1037, 562)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents companyNameTextbox As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents passwordLabel As Label
    Friend WithEvents usernameLabel As Label
    Friend WithEvents Label4 As Label
End Class
