<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_sales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_sales = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rice_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity_per_kilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_sales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(1168, 54)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 38)
        Me.btn_add.TabIndex = 15
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgv_sales
        '
        Me.dgv_sales.AllowUserToAddRows = False
        Me.dgv_sales.AllowUserToDeleteRows = False
        Me.dgv_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_sales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_sales.ColumnHeadersHeight = 50
        Me.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_sales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.rice_name, Me.storage_name, Me.quantity_per_kilo, Me.price})
        Me.dgv_sales.Location = New System.Drawing.Point(36, 98)
        Me.dgv_sales.Name = "dgv_sales"
        Me.dgv_sales.ReadOnly = True
        Me.dgv_sales.RowHeadersWidth = 51
        Me.dgv_sales.RowTemplate.Height = 24
        Me.dgv_sales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_sales.Size = New System.Drawing.Size(1257, 496)
        Me.dgv_sales.TabIndex = 14
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'rice_name
        '
        Me.rice_name.HeaderText = "Rice Name"
        Me.rice_name.MinimumWidth = 6
        Me.rice_name.Name = "rice_name"
        Me.rice_name.ReadOnly = True
        '
        'storage_name
        '
        Me.storage_name.HeaderText = "Storage"
        Me.storage_name.MinimumWidth = 6
        Me.storage_name.Name = "storage_name"
        Me.storage_name.ReadOnly = True
        '
        'quantity_per_kilo
        '
        Me.quantity_per_kilo.HeaderText = "Quantity (Kgs.)"
        Me.quantity_per_kilo.MinimumWidth = 6
        Me.quantity_per_kilo.Name = "quantity_per_kilo"
        Me.quantity_per_kilo.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price (Per Kg)"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'Transaction_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_sales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transaction_sales"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sales"
        CType(Me.dgv_sales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_sales As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents rice_name As DataGridViewTextBoxColumn
    Friend WithEvents storage_name As DataGridViewTextBoxColumn
    Friend WithEvents quantity_per_kilo As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
End Class
