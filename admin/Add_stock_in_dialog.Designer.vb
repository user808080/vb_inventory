<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_stock_in_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_stock_in_dialog))
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbox_capacity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbox_total_amount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_remove_storage = New System.Windows.Forms.Button()
        Me.btn_remove_supplier = New System.Windows.Forms.Button()
        Me.btn_remove_rice = New System.Windows.Forms.Button()
        Me.tbox_stock_per_kg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbox_cost_per_kg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbox_storage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbox_supplier = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbox_rice = New System.Windows.Forms.TextBox()
        Me.btn_select_storage = New System.Windows.Forms.Button()
        Me.btn_select_supplier = New System.Windows.Forms.Button()
        Me.btn_select_rice = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_delete
        '
        Me.btn_delete.Enabled = False
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(231, 433)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(125, 38)
        Me.btn_delete.TabIndex = 45
        Me.btn_delete.Text = "Remove"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Enabled = False
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(358, 433)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(125, 38)
        Me.btn_update.TabIndex = 44
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(485, 433)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 38)
        Me.btn_add.TabIndex = 42
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbox_capacity)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbox_total_amount)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btn_select_storage)
        Me.GroupBox1.Controls.Add(Me.btn_remove_storage)
        Me.GroupBox1.Controls.Add(Me.btn_select_supplier)
        Me.GroupBox1.Controls.Add(Me.btn_remove_supplier)
        Me.GroupBox1.Controls.Add(Me.btn_select_rice)
        Me.GroupBox1.Controls.Add(Me.btn_remove_rice)
        Me.GroupBox1.Controls.Add(Me.tbox_stock_per_kg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbox_cost_per_kg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tbox_storage)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbox_supplier)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbox_rice)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(730, 361)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stock-In Information"
        '
        'tbox_capacity
        '
        Me.tbox_capacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_capacity.Enabled = False
        Me.tbox_capacity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_capacity.Location = New System.Drawing.Point(199, 157)
        Me.tbox_capacity.MaxLength = 14
        Me.tbox_capacity.Name = "tbox_capacity"
        Me.tbox_capacity.Size = New System.Drawing.Size(428, 30)
        Me.tbox_capacity.TabIndex = 55
        Me.tbox_capacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 25)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Storage Capacity:"
        '
        'tbox_total_amount
        '
        Me.tbox_total_amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_total_amount.Enabled = False
        Me.tbox_total_amount.Font = New System.Drawing.Font("Arial Black", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_total_amount.Location = New System.Drawing.Point(199, 290)
        Me.tbox_total_amount.MaxLength = 10000000
        Me.tbox_total_amount.Name = "tbox_total_amount"
        Me.tbox_total_amount.Size = New System.Drawing.Size(428, 46)
        Me.tbox_total_amount.TabIndex = 53
        Me.tbox_total_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 25)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Total Amount:"
        '
        'btn_remove_storage
        '
        Me.btn_remove_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove_storage.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_storage.Location = New System.Drawing.Point(630, 120)
        Me.btn_remove_storage.Name = "btn_remove_storage"
        Me.btn_remove_storage.Size = New System.Drawing.Size(28, 30)
        Me.btn_remove_storage.TabIndex = 50
        Me.btn_remove_storage.Text = "X"
        Me.btn_remove_storage.UseVisualStyleBackColor = True
        '
        'btn_remove_supplier
        '
        Me.btn_remove_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove_supplier.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_supplier.Location = New System.Drawing.Point(630, 79)
        Me.btn_remove_supplier.Name = "btn_remove_supplier"
        Me.btn_remove_supplier.Size = New System.Drawing.Size(28, 30)
        Me.btn_remove_supplier.TabIndex = 48
        Me.btn_remove_supplier.Text = "X"
        Me.btn_remove_supplier.UseVisualStyleBackColor = True
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
        'tbox_stock_per_kg
        '
        Me.tbox_stock_per_kg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_stock_per_kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_stock_per_kg.Location = New System.Drawing.Point(199, 242)
        Me.tbox_stock_per_kg.MaxLength = 100000000
        Me.tbox_stock_per_kg.Name = "tbox_stock_per_kg"
        Me.tbox_stock_per_kg.Size = New System.Drawing.Size(428, 30)
        Me.tbox_stock_per_kg.TabIndex = 30
        Me.tbox_stock_per_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 25)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "StockIn (Per Kg.) :"
        '
        'tbox_cost_per_kg
        '
        Me.tbox_cost_per_kg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_cost_per_kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_cost_per_kg.Location = New System.Drawing.Point(199, 201)
        Me.tbox_cost_per_kg.MaxLength = 100000000
        Me.tbox_cost_per_kg.Name = "tbox_cost_per_kg"
        Me.tbox_cost_per_kg.Size = New System.Drawing.Size(428, 30)
        Me.tbox_cost_per_kg.TabIndex = 28
        Me.tbox_cost_per_kg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Cost (Per Kg.) :"
        '
        'tbox_storage
        '
        Me.tbox_storage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_storage.Enabled = False
        Me.tbox_storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_storage.Location = New System.Drawing.Point(199, 120)
        Me.tbox_storage.MaxLength = 14
        Me.tbox_storage.Name = "tbox_storage"
        Me.tbox_storage.Size = New System.Drawing.Size(428, 30)
        Me.tbox_storage.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Storage:"
        '
        'tbox_supplier
        '
        Me.tbox_supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_supplier.Enabled = False
        Me.tbox_supplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_supplier.Location = New System.Drawing.Point(199, 79)
        Me.tbox_supplier.MaxLength = 14
        Me.tbox_supplier.Name = "tbox_supplier"
        Me.tbox_supplier.Size = New System.Drawing.Size(428, 30)
        Me.tbox_supplier.TabIndex = 2
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 25)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Supplier: "
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
        'btn_select_storage
        '
        Me.btn_select_storage.BackgroundImage = CType(resources.GetObject("btn_select_storage.BackgroundImage"), System.Drawing.Image)
        Me.btn_select_storage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_select_storage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_storage.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_storage.Location = New System.Drawing.Point(661, 120)
        Me.btn_select_storage.Name = "btn_select_storage"
        Me.btn_select_storage.Size = New System.Drawing.Size(35, 30)
        Me.btn_select_storage.TabIndex = 51
        Me.btn_select_storage.UseVisualStyleBackColor = True
        '
        'btn_select_supplier
        '
        Me.btn_select_supplier.BackgroundImage = CType(resources.GetObject("btn_select_supplier.BackgroundImage"), System.Drawing.Image)
        Me.btn_select_supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_select_supplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_supplier.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_supplier.Location = New System.Drawing.Point(661, 79)
        Me.btn_select_supplier.Name = "btn_select_supplier"
        Me.btn_select_supplier.Size = New System.Drawing.Size(35, 30)
        Me.btn_select_supplier.TabIndex = 49
        Me.btn_select_supplier.UseVisualStyleBackColor = True
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
        'Add_stock_in_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 517)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_stock_in_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock-In Entry"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_select_supplier As Button
    Friend WithEvents btn_remove_supplier As Button
    Friend WithEvents btn_select_rice As Button
    Friend WithEvents btn_remove_rice As Button
    Friend WithEvents tbox_stock_per_kg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbox_cost_per_kg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbox_storage As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbox_supplier As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbox_rice As TextBox
    Friend WithEvents btn_select_storage As Button
    Friend WithEvents btn_remove_storage As Button
    Friend WithEvents tbox_total_amount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbox_capacity As TextBox
    Friend WithEvents Label7 As Label
End Class
