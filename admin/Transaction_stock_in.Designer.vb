<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_stock_in
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
        Me.dgv_stock_in = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rice_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost_per_kilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_per_kilo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_stock_in, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(1168, 54)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(125, 38)
        Me.btn_add.TabIndex = 11
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgv_stock_in
        '
        Me.dgv_stock_in.AllowUserToAddRows = False
        Me.dgv_stock_in.AllowUserToDeleteRows = False
        Me.dgv_stock_in.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_stock_in.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_stock_in.ColumnHeadersHeight = 50
        Me.dgv_stock_in.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_stock_in.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.rice_name, Me.supplier_name, Me.storage_name, Me.cost_per_kilo, Me.stock_per_kilo})
        Me.dgv_stock_in.Location = New System.Drawing.Point(36, 98)
        Me.dgv_stock_in.Name = "dgv_stock_in"
        Me.dgv_stock_in.ReadOnly = True
        Me.dgv_stock_in.RowHeadersWidth = 51
        Me.dgv_stock_in.RowTemplate.Height = 24
        Me.dgv_stock_in.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_stock_in.Size = New System.Drawing.Size(1257, 496)
        Me.dgv_stock_in.TabIndex = 10
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
        'supplier_name
        '
        Me.supplier_name.HeaderText = "Supplier"
        Me.supplier_name.MinimumWidth = 6
        Me.supplier_name.Name = "supplier_name"
        Me.supplier_name.ReadOnly = True
        '
        'storage_name
        '
        Me.storage_name.HeaderText = "Storage"
        Me.storage_name.MinimumWidth = 6
        Me.storage_name.Name = "storage_name"
        Me.storage_name.ReadOnly = True
        '
        'cost_per_kilo
        '
        Me.cost_per_kilo.HeaderText = "Cost (Per Kg)"
        Me.cost_per_kilo.MinimumWidth = 6
        Me.cost_per_kilo.Name = "cost_per_kilo"
        Me.cost_per_kilo.ReadOnly = True
        '
        'stock_per_kilo
        '
        Me.stock_per_kilo.HeaderText = "Stock-In (Per Kg)"
        Me.stock_per_kilo.MinimumWidth = 6
        Me.stock_per_kilo.Name = "stock_per_kilo"
        Me.stock_per_kilo.ReadOnly = True
        '
        'Transaction_stock_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_stock_in)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Transaction_stock_in"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Stock In"
        CType(Me.dgv_stock_in, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_stock_in As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents rice_name As DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As DataGridViewTextBoxColumn
    Friend WithEvents storage_name As DataGridViewTextBoxColumn
    Friend WithEvents cost_per_kilo As DataGridViewTextBoxColumn
    Friend WithEvents stock_per_kilo As DataGridViewTextBoxColumn
End Class
