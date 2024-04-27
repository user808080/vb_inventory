<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_supplier_dialog
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
        Me.dgv_supplier_list = New System.Windows.Forms.DataGridView()
        Me.tbox_search_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplier_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_supplier_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_supplier_list
        '
        Me.dgv_supplier_list.AllowUserToAddRows = False
        Me.dgv_supplier_list.AllowUserToDeleteRows = False
        Me.dgv_supplier_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_supplier_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_supplier_list.ColumnHeadersHeight = 50
        Me.dgv_supplier_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_supplier_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.supplier_name})
        Me.dgv_supplier_list.Location = New System.Drawing.Point(40, 95)
        Me.dgv_supplier_list.Name = "dgv_supplier_list"
        Me.dgv_supplier_list.ReadOnly = True
        Me.dgv_supplier_list.RowHeadersWidth = 51
        Me.dgv_supplier_list.RowTemplate.Height = 24
        Me.dgv_supplier_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_supplier_list.Size = New System.Drawing.Size(720, 308)
        Me.dgv_supplier_list.TabIndex = 22
        '
        'tbox_search_box
        '
        Me.tbox_search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_search_box.Location = New System.Drawing.Point(295, 60)
        Me.tbox_search_box.Name = "tbox_search_box"
        Me.tbox_search_box.Size = New System.Drawing.Size(465, 30)
        Me.tbox_search_box.TabIndex = 21
        Me.tbox_search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Search Supplier:"
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
        Me.supplier_name.HeaderText = "Supplier Name"
        Me.supplier_name.MinimumWidth = 6
        Me.supplier_name.Name = "supplier_name"
        Me.supplier_name.ReadOnly = True
        '
        'Search_supplier_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgv_supplier_list)
        Me.Controls.Add(Me.tbox_search_box)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Search_supplier_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier List"
        CType(Me.dgv_supplier_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_supplier_list As DataGridView
    Friend WithEvents tbox_search_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents supplier_name As DataGridViewTextBoxColumn
End Class
