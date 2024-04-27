<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_storage_dialog
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
        Me.dgv_storage_list = New System.Windows.Forms.DataGridView()
        Me.tbox_search_box = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_storage_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_storage_list
        '
        Me.dgv_storage_list.AllowUserToAddRows = False
        Me.dgv_storage_list.AllowUserToDeleteRows = False
        Me.dgv_storage_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_storage_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_storage_list.ColumnHeadersHeight = 50
        Me.dgv_storage_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_storage_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.storage_name, Me.capacity})
        Me.dgv_storage_list.Location = New System.Drawing.Point(41, 84)
        Me.dgv_storage_list.Name = "dgv_storage_list"
        Me.dgv_storage_list.ReadOnly = True
        Me.dgv_storage_list.RowHeadersWidth = 51
        Me.dgv_storage_list.RowTemplate.Height = 24
        Me.dgv_storage_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_storage_list.Size = New System.Drawing.Size(720, 296)
        Me.dgv_storage_list.TabIndex = 22
        '
        'tbox_search_box
        '
        Me.tbox_search_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_search_box.Location = New System.Drawing.Point(296, 49)
        Me.tbox_search_box.Name = "tbox_search_box"
        Me.tbox_search_box.Size = New System.Drawing.Size(465, 30)
        Me.tbox_search_box.TabIndex = 21
        Me.tbox_search_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Search Storage:"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'storage_name
        '
        Me.storage_name.HeaderText = "Storage Name"
        Me.storage_name.MinimumWidth = 6
        Me.storage_name.Name = "storage_name"
        Me.storage_name.ReadOnly = True
        '
        'capacity
        '
        Me.capacity.HeaderText = "Capacity"
        Me.capacity.MinimumWidth = 6
        Me.capacity.Name = "capacity"
        Me.capacity.ReadOnly = True
        '
        'Search_storage_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 431)
        Me.Controls.Add(Me.dgv_storage_list)
        Me.Controls.Add(Me.tbox_search_box)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Search_storage_dialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Storage"
        CType(Me.dgv_storage_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_storage_list As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents storage_name As DataGridViewTextBoxColumn
    Friend WithEvents capacity As DataGridViewTextBoxColumn
    Friend WithEvents tbox_search_box As TextBox
    Friend WithEvents Label1 As Label
End Class
