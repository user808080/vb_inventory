<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_sale_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_sale_dialog))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbox_available_stocks = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_select_storage = New System.Windows.Forms.Button()
        Me.btn_remove_storage = New System.Windows.Forms.Button()
        Me.tbox_price = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_select_rice = New System.Windows.Forms.Button()
        Me.btn_remove_rice = New System.Windows.Forms.Button()
        Me.tbox_quantity = New System.Windows.Forms.TextBox()
        Me.tbox_storage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_rice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbox_change_amount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbox_total_cost = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbox_tender_amount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(434, 398)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(125, 38)
        Me.btn_delete.TabIndex = 53
        Me.btn_delete.Text = "Remove"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(561, 398)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 38)
        Me.btn_update.TabIndex = 52
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(688, 398)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 38)
        Me.btn_add.TabIndex = 50
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbox_available_stocks)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btn_select_storage)
        Me.GroupBox1.Controls.Add(Me.btn_remove_storage)
        Me.GroupBox1.Controls.Add(Me.tbox_price)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btn_select_rice)
        Me.GroupBox1.Controls.Add(Me.btn_remove_rice)
        Me.GroupBox1.Controls.Add(Me.tbox_quantity)
        Me.GroupBox1.Controls.Add(Me.tbox_storage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.tbox_rice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 329)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sale(s) Information"
        '
        'tbox_available_stocks
        '
        Me.tbox_available_stocks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_available_stocks.Enabled = False
        Me.tbox_available_stocks.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_available_stocks.Location = New System.Drawing.Point(199, 117)
        Me.tbox_available_stocks.MaxLength = 14
        Me.tbox_available_stocks.Name = "tbox_available_stocks"
        Me.tbox_available_stocks.Size = New System.Drawing.Size(428, 40)
        Me.tbox_available_stocks.TabIndex = 55
        Me.tbox_available_stocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Available Stock(s):"
        '
        'btn_select_storage
        '
        Me.btn_select_storage.BackgroundImage = CType(resources.GetObject("btn_select_storage.BackgroundImage"), System.Drawing.Image)
        Me.btn_select_storage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_select_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_storage.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_storage.Location = New System.Drawing.Point(661, 79)
        Me.btn_select_storage.Name = "btn_select_storage"
        Me.btn_select_storage.Size = New System.Drawing.Size(35, 30)
        Me.btn_select_storage.TabIndex = 51
        Me.btn_select_storage.UseVisualStyleBackColor = True
        '
        'btn_remove_storage
        '
        Me.btn_remove_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove_storage.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_storage.Location = New System.Drawing.Point(630, 79)
        Me.btn_remove_storage.Name = "btn_remove_storage"
        Me.btn_remove_storage.Size = New System.Drawing.Size(28, 30)
        Me.btn_remove_storage.TabIndex = 50
        Me.btn_remove_storage.Text = "X"
        Me.btn_remove_storage.UseVisualStyleBackColor = True
        '
        'tbox_price
        '
        Me.tbox_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_price.Enabled = False
        Me.tbox_price.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_price.Location = New System.Drawing.Point(199, 166)
        Me.tbox_price.MaxLength = 14
        Me.tbox_price.Name = "tbox_price"
        Me.tbox_price.Size = New System.Drawing.Size(428, 40)
        Me.tbox_price.TabIndex = 57
        Me.tbox_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 25)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Rice Price (P):"
        '
        'btn_select_rice
        '
        Me.btn_select_rice.BackgroundImage = CType(resources.GetObject("btn_select_rice.BackgroundImage"), System.Drawing.Image)
        Me.btn_select_rice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_select_rice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_rice.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_rice.Location = New System.Drawing.Point(661, 40)
        Me.btn_select_rice.Name = "btn_select_rice"
        Me.btn_select_rice.Size = New System.Drawing.Size(35, 30)
        Me.btn_select_rice.TabIndex = 47
        Me.btn_select_rice.UseVisualStyleBackColor = True
        '
        'btn_remove_rice
        '
        Me.btn_remove_rice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove_rice.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_rice.Location = New System.Drawing.Point(630, 40)
        Me.btn_remove_rice.Name = "btn_remove_rice"
        Me.btn_remove_rice.Size = New System.Drawing.Size(28, 30)
        Me.btn_remove_rice.TabIndex = 46
        Me.btn_remove_rice.Text = "X"
        Me.btn_remove_rice.UseVisualStyleBackColor = True
        '
        'tbox_quantity
        '
        Me.tbox_quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_quantity.Location = New System.Drawing.Point(199, 238)
        Me.tbox_quantity.MaxLength = 100000000
        Me.tbox_quantity.Name = "tbox_quantity"
        Me.tbox_quantity.Size = New System.Drawing.Size(428, 30)
        Me.tbox_quantity.TabIndex = 30
        Me.tbox_quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbox_storage
        '
        Me.tbox_storage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_storage.Enabled = False
        Me.tbox_storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_storage.Location = New System.Drawing.Point(199, 79)
        Me.tbox_storage.MaxLength = 14
        Me.tbox_storage.Name = "tbox_storage"
        Me.tbox_storage.Size = New System.Drawing.Size(428, 30)
        Me.tbox_storage.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Storage:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Rice: "
        '
        'tbox_rice
        '
        Me.tbox_rice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_rice.Enabled = False
        Me.tbox_rice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_rice.Location = New System.Drawing.Point(199, 40)
        Me.tbox_rice.MaxLength = 50
        Me.tbox_rice.Name = "tbox_rice"
        Me.tbox_rice.Size = New System.Drawing.Size(428, 30)
        Me.tbox_rice.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Quantity (Kg) :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbox_change_amount)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tbox_total_cost)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tbox_tender_amount)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(763, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(487, 329)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tender"
        '
        'tbox_change_amount
        '
        Me.tbox_change_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_change_amount.Enabled = False
        Me.tbox_change_amount.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_change_amount.Location = New System.Drawing.Point(29, 237)
        Me.tbox_change_amount.MaxLength = 10000000
        Me.tbox_change_amount.Name = "tbox_change_amount"
        Me.tbox_change_amount.Size = New System.Drawing.Size(428, 40)
        Me.tbox_change_amount.TabIndex = 65
        Me.tbox_change_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(24, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 25)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Change Amount:"
        '
        'tbox_total_cost
        '
        Me.tbox_total_cost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_total_cost.Enabled = False
        Me.tbox_total_cost.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_total_cost.Location = New System.Drawing.Point(27, 68)
        Me.tbox_total_cost.MaxLength = 10000000
        Me.tbox_total_cost.Name = "tbox_total_cost"
        Me.tbox_total_cost.Size = New System.Drawing.Size(428, 40)
        Me.tbox_total_cost.TabIndex = 63
        Me.tbox_total_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 25)
        Me.Label8.TabIndex = 62
        Me.Label8.Text = "Total Cost:"
        '
        'tbox_tender_amount
        '
        Me.tbox_tender_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_tender_amount.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_tender_amount.Location = New System.Drawing.Point(27, 148)
        Me.tbox_tender_amount.MaxLength = 10000000
        Me.tbox_tender_amount.Name = "tbox_tender_amount"
        Me.tbox_tender_amount.Size = New System.Drawing.Size(428, 40)
        Me.tbox_tender_amount.TabIndex = 61
        Me.tbox_tender_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 25)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Tender Amount:"
        '
        'Add_sale_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 487)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_sale_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbox_available_stocks As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_select_storage As Button
    Friend WithEvents btn_remove_storage As Button
    Friend WithEvents btn_select_rice As Button
    Friend WithEvents btn_remove_rice As Button
    Friend WithEvents tbox_quantity As TextBox
    Friend WithEvents tbox_storage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbox_rice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbox_price As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbox_change_amount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbox_total_cost As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbox_tender_amount As TextBox
    Friend WithEvents Label6 As Label
End Class
