<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_supplier_dialog
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbox_address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbox_contact_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbox_supplier_name = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkbox_cheque = New System.Windows.Forms.CheckBox()
        Me.checkbox_cash = New System.Windows.Forms.CheckBox()
        Me.checkbox_gcash = New System.Windows.Forms.CheckBox()
        Me.checkbox_bank_transfer = New System.Windows.Forms.CheckBox()
        Me.link_label_add_products = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(151, 405)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(125, 38)
        Me.btn_delete.TabIndex = 35
        Me.btn_delete.Text = "Remove"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(278, 405)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 38)
        Me.btn_update.TabIndex = 34
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(405, 405)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 38)
        Me.btn_add.TabIndex = 32
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbox_address)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbox_contact_no)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbox_supplier_name)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 233)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supplier Information"
        '
        'tbox_address
        '
        Me.tbox_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_address.Location = New System.Drawing.Point(177, 115)
        Me.tbox_address.MaxLength = 200
        Me.tbox_address.Multiline = True
        Me.tbox_address.Name = "tbox_address"
        Me.tbox_address.Size = New System.Drawing.Size(428, 87)
        Me.tbox_address.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Address:"
        '
        'tbox_contact_no
        '
        Me.tbox_contact_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_contact_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_contact_no.Location = New System.Drawing.Point(177, 79)
        Me.tbox_contact_no.MaxLength = 11
        Me.tbox_contact_no.Name = "tbox_contact_no"
        Me.tbox_contact_no.Size = New System.Drawing.Size(428, 30)
        Me.tbox_contact_no.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Supplier Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Contact No:"
        '
        'tbox_supplier_name
        '
        Me.tbox_supplier_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_supplier_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_supplier_name.Location = New System.Drawing.Point(177, 40)
        Me.tbox_supplier_name.MaxLength = 100
        Me.tbox_supplier_name.Name = "tbox_supplier_name"
        Me.tbox_supplier_name.Size = New System.Drawing.Size(428, 30)
        Me.tbox_supplier_name.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkbox_cheque)
        Me.GroupBox2.Controls.Add(Me.checkbox_cash)
        Me.GroupBox2.Controls.Add(Me.checkbox_gcash)
        Me.GroupBox2.Controls.Add(Me.checkbox_bank_transfer)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(634, 100)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Terms"
        '
        'checkbox_cheque
        '
        Me.checkbox_cheque.AutoSize = True
        Me.checkbox_cheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_cheque.Location = New System.Drawing.Point(262, 45)
        Me.checkbox_cheque.Name = "checkbox_cheque"
        Me.checkbox_cheque.Size = New System.Drawing.Size(172, 24)
        Me.checkbox_cheque.TabIndex = 2
        Me.checkbox_cheque.Text = "Cheque/Checked"
        Me.checkbox_cheque.UseVisualStyleBackColor = True
        '
        'checkbox_cash
        '
        Me.checkbox_cash.AutoSize = True
        Me.checkbox_cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_cash.Location = New System.Drawing.Point(18, 45)
        Me.checkbox_cash.Name = "checkbox_cash"
        Me.checkbox_cash.Size = New System.Drawing.Size(74, 24)
        Me.checkbox_cash.TabIndex = 1
        Me.checkbox_cash.Text = "Cash"
        Me.checkbox_cash.UseVisualStyleBackColor = True
        '
        'checkbox_gcash
        '
        Me.checkbox_gcash.AutoSize = True
        Me.checkbox_gcash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_gcash.Location = New System.Drawing.Point(135, 45)
        Me.checkbox_gcash.Name = "checkbox_gcash"
        Me.checkbox_gcash.Size = New System.Drawing.Size(88, 24)
        Me.checkbox_gcash.TabIndex = 0
        Me.checkbox_gcash.Text = "GCash"
        Me.checkbox_gcash.UseVisualStyleBackColor = True
        '
        'checkbox_bank_transfer
        '
        Me.checkbox_bank_transfer.AutoSize = True
        Me.checkbox_bank_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkbox_bank_transfer.Location = New System.Drawing.Point(460, 45)
        Me.checkbox_bank_transfer.Name = "checkbox_bank_transfer"
        Me.checkbox_bank_transfer.Size = New System.Drawing.Size(145, 24)
        Me.checkbox_bank_transfer.TabIndex = 3
        Me.checkbox_bank_transfer.Text = "Bank transfer"
        Me.checkbox_bank_transfer.UseVisualStyleBackColor = True
        '
        'link_label_add_products
        '
        Me.link_label_add_products.AutoSize = True
        Me.link_label_add_products.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_label_add_products.LinkColor = System.Drawing.Color.ForestGreen
        Me.link_label_add_products.Location = New System.Drawing.Point(497, 365)
        Me.link_label_add_products.Name = "link_label_add_products"
        Me.link_label_add_products.Size = New System.Drawing.Size(135, 16)
        Me.link_label_add_products.TabIndex = 37
        Me.link_label_add_products.TabStop = True
        Me.link_label_add_products.Text = "+ Products Offered"
        Me.link_label_add_products.Visible = False
        '
        'Add_supplier_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 470)
        Me.Controls.Add(Me.link_label_add_products)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_supplier_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbox_contact_no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbox_supplier_name As TextBox
    Friend WithEvents tbox_address As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents checkbox_bank_transfer As CheckBox
    Friend WithEvents checkbox_cheque As CheckBox
    Friend WithEvents checkbox_cash As CheckBox
    Friend WithEvents checkbox_gcash As CheckBox
    Friend WithEvents link_label_add_products As LinkLabel
End Class
