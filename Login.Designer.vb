<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.btn_login = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.pbox_logo = New System.Windows.Forms.PictureBox()
        Me.tbox_username = New System.Windows.Forms.TextBox()
        Me.tbox_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbox_user_type = New System.Windows.Forms.ComboBox()
        CType(Me.pbox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Location = New System.Drawing.Point(548, 229)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(95, 35)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory Management System"
        '
        'btn_exit
        '
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Location = New System.Drawing.Point(447, 229)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(95, 35)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'pbox_logo
        '
        Me.pbox_logo.BackgroundImage = CType(resources.GetObject("pbox_logo.BackgroundImage"), System.Drawing.Image)
        Me.pbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbox_logo.ImageLocation = ""
        Me.pbox_logo.Location = New System.Drawing.Point(12, 12)
        Me.pbox_logo.Name = "pbox_logo"
        Me.pbox_logo.Size = New System.Drawing.Size(227, 233)
        Me.pbox_logo.TabIndex = 3
        Me.pbox_logo.TabStop = False
        '
        'tbox_username
        '
        Me.tbox_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_username.Location = New System.Drawing.Point(260, 133)
        Me.tbox_username.Name = "tbox_username"
        Me.tbox_username.Size = New System.Drawing.Size(383, 34)
        Me.tbox_username.TabIndex = 4
        Me.tbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbox_password
        '
        Me.tbox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_password.Location = New System.Drawing.Point(260, 189)
        Me.tbox_password.Name = "tbox_password"
        Me.tbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbox_password.Size = New System.Drawing.Size(383, 34)
        Me.tbox_password.TabIndex = 5
        Me.tbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbox_password.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(257, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "User Type:"
        '
        'cbox_user_type
        '
        Me.cbox_user_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_user_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_user_type.FormattingEnabled = True
        Me.cbox_user_type.ItemHeight = 29
        Me.cbox_user_type.Items.AddRange(New Object() {"Admin", "Employee", "Guest"})
        Me.cbox_user_type.Location = New System.Drawing.Point(260, 74)
        Me.cbox_user_type.Name = "cbox_user_type"
        Me.cbox_user_type.Size = New System.Drawing.Size(383, 37)
        Me.cbox_user_type.TabIndex = 10
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(681, 283)
        Me.Controls.Add(Me.cbox_user_type)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbox_password)
        Me.Controls.Add(Me.tbox_username)
        Me.Controls.Add(Me.pbox_logo)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.pbox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents pbox_logo As PictureBox
    Friend WithEvents tbox_username As TextBox
    Friend WithEvents tbox_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbox_user_type As ComboBox
End Class
