<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manage_employee
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
        Me.dgv_employee_list = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.first_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.middle_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.last_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.extension_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_add_employee = New System.Windows.Forms.Button()
        CType(Me.dgv_employee_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_employee_list
        '
        Me.dgv_employee_list.AllowUserToAddRows = False
        Me.dgv_employee_list.AllowUserToDeleteRows = False
        Me.dgv_employee_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_employee_list.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_employee_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_employee_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.employee_no, Me.first_name, Me.middle_name, Me.last_name, Me.extension_name, Me.contact_number})
        Me.dgv_employee_list.Location = New System.Drawing.Point(24, 58)
        Me.dgv_employee_list.Name = "dgv_employee_list"
        Me.dgv_employee_list.ReadOnly = True
        Me.dgv_employee_list.RowHeadersWidth = 51
        Me.dgv_employee_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgv_employee_list.RowTemplate.Height = 24
        Me.dgv_employee_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_employee_list.Size = New System.Drawing.Size(1259, 549)
        Me.dgv_employee_list.TabIndex = 0
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'employee_no
        '
        Me.employee_no.HeaderText = "Employee Number"
        Me.employee_no.MinimumWidth = 6
        Me.employee_no.Name = "employee_no"
        Me.employee_no.ReadOnly = True
        '
        'first_name
        '
        Me.first_name.HeaderText = "First Name"
        Me.first_name.MinimumWidth = 6
        Me.first_name.Name = "first_name"
        Me.first_name.ReadOnly = True
        '
        'middle_name
        '
        Me.middle_name.HeaderText = "Middle Name"
        Me.middle_name.MinimumWidth = 6
        Me.middle_name.Name = "middle_name"
        Me.middle_name.ReadOnly = True
        '
        'last_name
        '
        Me.last_name.HeaderText = "Last Name"
        Me.last_name.MinimumWidth = 6
        Me.last_name.Name = "last_name"
        Me.last_name.ReadOnly = True
        '
        'extension_name
        '
        Me.extension_name.HeaderText = "Extension Name"
        Me.extension_name.MinimumWidth = 6
        Me.extension_name.Name = "extension_name"
        Me.extension_name.ReadOnly = True
        '
        'contact_number
        '
        Me.contact_number.HeaderText = "Contact Number"
        Me.contact_number.MinimumWidth = 6
        Me.contact_number.Name = "contact_number"
        Me.contact_number.ReadOnly = True
        '
        'btn_add_employee
        '
        Me.btn_add_employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add_employee.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add_employee.Location = New System.Drawing.Point(1137, 12)
        Me.btn_add_employee.Name = "btn_add_employee"
        Me.btn_add_employee.Size = New System.Drawing.Size(146, 40)
        Me.btn_add_employee.TabIndex = 12
        Me.btn_add_employee.Text = "Add Employee"
        Me.btn_add_employee.UseVisualStyleBackColor = True
        '
        'Manage_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_add_employee)
        Me.Controls.Add(Me.dgv_employee_list)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 10)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Manage_employee"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Manage Employee"
        CType(Me.dgv_employee_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_employee_list As DataGridView
    Friend WithEvents btn_add_employee As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents employee_no As DataGridViewTextBoxColumn
    Friend WithEvents first_name As DataGridViewTextBoxColumn
    Friend WithEvents middle_name As DataGridViewTextBoxColumn
    Friend WithEvents last_name As DataGridViewTextBoxColumn
    Friend WithEvents extension_name As DataGridViewTextBoxColumn
    Friend WithEvents contact_number As DataGridViewTextBoxColumn
End Class
