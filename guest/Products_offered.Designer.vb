<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products_offered
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_rice_list = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_top1 = New System.Windows.Forms.Label()
        Me.lbl_top2 = New System.Windows.Forms.Label()
        Me.lbl_top3 = New System.Windows.Forms.Label()
        Me.tbox_search_box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rice_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock_level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_rice_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_rice_list
        '
        Me.dgv_rice_list.AllowUserToAddRows = False
        Me.dgv_rice_list.AllowUserToDeleteRows = False
        Me.dgv_rice_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_rice_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_rice_list.ColumnHeadersHeight = 50
        Me.dgv_rice_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_rice_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.category, Me.rice_name, Me.price, Me.stock_level})
        Me.dgv_rice_list.Location = New System.Drawing.Point(38, 257)
        Me.dgv_rice_list.Name = "dgv_rice_list"
        Me.dgv_rice_list.ReadOnly = True
        Me.dgv_rice_list.RowHeadersWidth = 51
        Me.dgv_rice_list.RowTemplate.Height = 24
        Me.dgv_rice_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_rice_list.Size = New System.Drawing.Size(1257, 339)
        Me.dgv_rice_list.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 32)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "List of Rice Offered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 24)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Top 3 Best Seller:"
        '
        'lbl_top1
        '
        Me.lbl_top1.AutoSize = True
        Me.lbl_top1.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_top1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_top1.Location = New System.Drawing.Point(58, 123)
        Me.lbl_top1.Name = "lbl_top1"
        Me.lbl_top1.Size = New System.Drawing.Size(26, 22)
        Me.lbl_top1.TabIndex = 13
        Me.lbl_top1.Text = "1."
        '
        'lbl_top2
        '
        Me.lbl_top2.AutoSize = True
        Me.lbl_top2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_top2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_top2.Location = New System.Drawing.Point(59, 155)
        Me.lbl_top2.Name = "lbl_top2"
        Me.lbl_top2.Size = New System.Drawing.Size(23, 19)
        Me.lbl_top2.TabIndex = 14
        Me.lbl_top2.Text = "2."
        '
        'lbl_top3
        '
        Me.lbl_top3.AutoSize = True
        Me.lbl_top3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_top3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_top3.Location = New System.Drawing.Point(62, 184)
        Me.lbl_top3.Name = "lbl_top3"
        Me.lbl_top3.Size = New System.Drawing.Size(20, 18)
        Me.lbl_top3.TabIndex = 15
        Me.lbl_top3.Text = "3."
        '
        'tbox_search_box
        '
        Me.tbox_search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_search_box.Location = New System.Drawing.Point(830, 221)
        Me.tbox_search_box.Name = "tbox_search_box"
        Me.tbox_search_box.Size = New System.Drawing.Size(465, 30)
        Me.tbox_search_box.TabIndex = 20
        Me.tbox_search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(700, 224)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Search Rice:"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.MinimumWidth = 6
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'rice_name
        '
        Me.rice_name.HeaderText = "Rice Name"
        Me.rice_name.MinimumWidth = 6
        Me.rice_name.Name = "rice_name"
        Me.rice_name.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'stock_level
        '
        Me.stock_level.HeaderText = "Available Stock (Kg.)"
        Me.stock_level.MinimumWidth = 6
        Me.stock_level.Name = "stock_level"
        Me.stock_level.ReadOnly = True
        '
        'Products_offered
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 653)
        Me.ControlBox = False
        Me.Controls.Add(Me.tbox_search_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_top3)
        Me.Controls.Add(Me.lbl_top2)
        Me.Controls.Add(Me.lbl_top1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_rice_list)
        Me.Location = New System.Drawing.Point(0, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Products_offered"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Products Offered"
        CType(Me.dgv_rice_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_rice_list As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_top1 As Label
    Friend WithEvents lbl_top2 As Label
    Friend WithEvents lbl_top3 As Label
    Friend WithEvents tbox_search_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents rice_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents stock_level As DataGridViewTextBoxColumn
End Class
