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
        CType(Me.pbox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(548, 182)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(95, 35)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(431, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory Management System"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(447, 182)
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
        Me.pbox_logo.Location = New System.Drawing.Point(24, 22)
        Me.pbox_logo.Name = "pbox_logo"
        Me.pbox_logo.Size = New System.Drawing.Size(182, 154)
        Me.pbox_logo.TabIndex = 3
        Me.pbox_logo.TabStop = False
        '
        'tbox_username
        '
        Me.tbox_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_username.Location = New System.Drawing.Point(218, 86)
        Me.tbox_username.Name = "tbox_username"
        Me.tbox_username.Size = New System.Drawing.Size(425, 34)
        Me.tbox_username.TabIndex = 4
        '
        'tbox_password
        '
        Me.tbox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_password.Location = New System.Drawing.Point(218, 142)
        Me.tbox_password.Name = "tbox_password"
        Me.tbox_password.Size = New System.Drawing.Size(425, 34)
        Me.tbox_password.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 237)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbox_password)
        Me.Controls.Add(Me.tbox_username)
        Me.Controls.Add(Me.pbox_logo)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_login)
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
End Class
