<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_supplier
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_supplier_list = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payment_terms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_supplier_list, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgv_supplier_list
        '
        Me.dgv_supplier_list.AllowUserToAddRows = False
        Me.dgv_supplier_list.AllowUserToDeleteRows = False
        Me.dgv_supplier_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supplier_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_supplier_list.ColumnHeadersHeight = 50
        Me.dgv_supplier_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_supplier_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.supplier_name, Me.contact_no, Me.address, Me.payment_terms})
        Me.dgv_supplier_list.Location = New System.Drawing.Point(36, 98)
        Me.dgv_supplier_list.Name = "dgv_supplier_list"
        Me.dgv_supplier_list.ReadOnly = True
        Me.dgv_supplier_list.RowHeadersWidth = 51
        Me.dgv_supplier_list.RowTemplate.Height = 24
        Me.dgv_supplier_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supplier_list.Size = New System.Drawing.Size(1257, 496)
        Me.dgv_supplier_list.TabIndex = 10
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'supplier_name
        '
        Me.supplier_name.HeaderText = "Supplier"
        Me.supplier_name.MinimumWidth = 6
        Me.supplier_name.Name = "supplier_name"
        Me.supplier_name.ReadOnly = True
        '
        'contact_no
        '
        Me.contact_no.HeaderText = "Contact Number"
        Me.contact_no.MinimumWidth = 6
        Me.contact_no.Name = "contact_no"
        Me.contact_no.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.MinimumWidth = 6
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'payment_terms
        '
        Me.payment_terms.HeaderText = "Payment Terms"
        Me.payment_terms.MinimumWidth = 6
        Me.payment_terms.Name = "payment_terms"
        Me.payment_terms.ReadOnly = True
        '
        'Manage_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_supplier_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 10)
        Me.Name = "Manage_supplier"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Manage Supplier"
        CType(Me.dgv_supplier_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_supplier_list As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As DataGridViewTextBoxColumn
    Friend WithEvents contact_no As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents payment_terms As DataGridViewTextBoxColumn
End Class
