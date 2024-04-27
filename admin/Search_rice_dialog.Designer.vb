<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_rice_dialog
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
        Me.dgv_rice_list = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rice_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbox_search_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_rice_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_rice_list
        '
        Me.dgv_rice_list.AllowUserToAddRows = False
        Me.dgv_rice_list.AllowUserToDeleteRows = False
        Me.dgv_rice_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_rice_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_rice_list.ColumnHeadersHeight = 50
        Me.dgv_rice_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_rice_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.category, Me.rice_name, Me.price})
        Me.dgv_rice_list.Location = New System.Drawing.Point(34, 61)
        Me.dgv_rice_list.Name = "dgv_rice_list"
        Me.dgv_rice_list.ReadOnly = True
        Me.dgv_rice_list.RowHeadersWidth = 51
        Me.dgv_rice_list.RowTemplate.Height = 24
        Me.dgv_rice_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_rice_list.Size = New System.Drawing.Size(720, 296)
        Me.dgv_rice_list.TabIndex = 19
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
        Me.price.HeaderText = "Price Per Kilo"
        Me.price.MinimumWidth = 6
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'tbox_search_box
        '
        Me.tbox_search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_search_box.Location = New System.Drawing.Point(289, 26)
        Me.tbox_search_box.Name = "tbox_search_box"
        Me.tbox_search_box.Size = New System.Drawing.Size(465, 30)
        Me.tbox_search_box.TabIndex = 18
        Me.tbox_search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(159, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Search Rice:"
        '
        'Search_rice_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 393)
        Me.Controls.Add(Me.dgv_rice_list)
        Me.Controls.Add(Me.tbox_search_box)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Search_rice_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rice List"
        CType(Me.dgv_rice_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_rice_list As DataGridView
    Friend WithEvents tbox_search_box As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents rice_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
End Class
