<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_employee_dialog
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.tbox_contact_no = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbox_last_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbox_first_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_employee_no = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbox_middle_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbox_extension_name = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbox_password = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_username = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(129, 495)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(125, 38)
        Me.btn_delete.TabIndex = 10
        Me.btn_delete.Text = "Remove"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(256, 495)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 38)
        Me.btn_update.TabIndex = 9
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(383, 495)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 38)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'tbox_contact_no
        '
        Me.tbox_contact_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_contact_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_contact_no.Location = New System.Drawing.Point(160, 218)
        Me.tbox_contact_no.MaxLength = 11
        Me.tbox_contact_no.Name = "tbox_contact_no"
        Me.tbox_contact_no.Size = New System.Drawing.Size(382, 30)
        Me.tbox_contact_no.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 25)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Contact No:"
        '
        'tbox_last_name
        '
        Me.tbox_last_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_last_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_last_name.Location = New System.Drawing.Point(160, 146)
        Me.tbox_last_name.MaxLength = 50
        Me.tbox_last_name.Name = "tbox_last_name"
        Me.tbox_last_name.Size = New System.Drawing.Size(382, 30)
        Me.tbox_last_name.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Last Name:"
        '
        'tbox_first_name
        '
        Me.tbox_first_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_first_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_first_name.Location = New System.Drawing.Point(160, 69)
        Me.tbox_first_name.MaxLength = 50
        Me.tbox_first_name.Name = "tbox_first_name"
        Me.tbox_first_name.Size = New System.Drawing.Size(382, 30)
        Me.tbox_first_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "First Name:"
        '
        'tbox_employee_no
        '
        Me.tbox_employee_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_employee_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_employee_no.Location = New System.Drawing.Point(160, 33)
        Me.tbox_employee_no.MaxLength = 20
        Me.tbox_employee_no.Name = "tbox_employee_no"
        Me.tbox_employee_no.Size = New System.Drawing.Size(382, 30)
        Me.tbox_employee_no.TabIndex = 2
        Me.tbox_employee_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Emp. No:"
        '
        'tbox_middle_name
        '
        Me.tbox_middle_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_middle_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_middle_name.Location = New System.Drawing.Point(160, 110)
        Me.tbox_middle_name.MaxLength = 50
        Me.tbox_middle_name.Name = "tbox_middle_name"
        Me.tbox_middle_name.Size = New System.Drawing.Size(382, 30)
        Me.tbox_middle_name.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Middle Name:"
        '
        'tbox_extension_name
        '
        Me.tbox_extension_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_extension_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_extension_name.Location = New System.Drawing.Point(160, 182)
        Me.tbox_extension_name.MaxLength = 20
        Me.tbox_extension_name.Name = "tbox_extension_name"
        Me.tbox_extension_name.Size = New System.Drawing.Size(382, 30)
        Me.tbox_extension_name.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 25)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Ext. Name:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbox_contact_no)
        Me.GroupBox1.Controls.Add(Me.tbox_extension_name)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbox_employee_no)
        Me.GroupBox1.Controls.Add(Me.tbox_middle_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbox_first_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbox_last_name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 282)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Information"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbox_password)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tbox_username)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 151)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Access"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Password:"
        '
        'tbox_password
        '
        Me.tbox_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_password.Location = New System.Drawing.Point(158, 86)
        Me.tbox_password.MaxLength = 100
        Me.tbox_password.Name = "tbox_password"
        Me.tbox_password.Size = New System.Drawing.Size(382, 30)
        Me.tbox_password.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "User Name:"
        '
        'tbox_username
        '
        Me.tbox_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_username.Location = New System.Drawing.Point(158, 45)
        Me.tbox_username.MaxLength = 50
        Me.tbox_username.Name = "tbox_username"
        Me.tbox_username.Size = New System.Drawing.Size(382, 30)
        Me.tbox_username.TabIndex = 0
        '
        'Add_employee_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 559)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_employee_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents tbox_contact_no As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbox_last_name As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbox_first_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbox_employee_no As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbox_middle_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbox_extension_name As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbox_password As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbox_username As TextBox
End Class
