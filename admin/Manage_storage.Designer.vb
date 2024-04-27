<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_storage
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
        Me.dgv_storage_list = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storage_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.storage_location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.capacity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_storage_list, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgv_storage_list
        '
        Me.dgv_storage_list.AllowUserToAddRows = False
        Me.dgv_storage_list.AllowUserToDeleteRows = False
        Me.dgv_storage_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_storage_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_storage_list.ColumnHeadersHeight = 50
        Me.dgv_storage_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_storage_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.storage_name, Me.storage_location, Me.capacity})
        Me.dgv_storage_list.Location = New System.Drawing.Point(36, 98)
        Me.dgv_storage_list.Name = "dgv_storage_list"
        Me.dgv_storage_list.ReadOnly = True
        Me.dgv_storage_list.RowHeadersWidth = 51
        Me.dgv_storage_list.RowTemplate.Height = 24
        Me.dgv_storage_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_storage_list.Size = New System.Drawing.Size(1257, 496)
        Me.dgv_storage_list.TabIndex = 10
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
        'storage_location
        '
        Me.storage_location.HeaderText = "Location"
        Me.storage_location.MinimumWidth = 6
        Me.storage_location.Name = "storage_location"
        Me.storage_location.ReadOnly = True
        '
        'capacity
        '
        Me.capacity.HeaderText = "Capacity (In Kilos)"
        Me.capacity.MinimumWidth = 6
        Me.capacity.Name = "capacity"
        Me.capacity.ReadOnly = True
        '
        'Manage_storage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_storage_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Manage_storage"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Manage Storage"
        CType(Me.dgv_storage_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_storage_list As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents storage_name As DataGridViewTextBoxColumn
    Friend WithEvents storage_location As DataGridViewTextBoxColumn
    Friend WithEvents capacity As DataGridViewTextBoxColumn
End Class
