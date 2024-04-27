<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Report_rice_ledger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_rice_ledger))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btn_remove_rice = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbox_rice = New System.Windows.Forms.TextBox()
        Me.btn_select_rice = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.dgv_ledger = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rice_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transaction_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbox_transaction = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_ledger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_remove_rice
        '
        Me.btn_remove_rice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove_rice.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_remove_rice.Location = New System.Drawing.Point(1025, 62)
        Me.btn_remove_rice.Name = "btn_remove_rice"
        Me.btn_remove_rice.Size = New System.Drawing.Size(28, 30)
        Me.btn_remove_rice.TabIndex = 50
        Me.btn_remove_rice.Text = "X"
        Me.btn_remove_rice.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(533, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Rice: "
        '
        'tbox_rice
        '
        Me.tbox_rice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbox_rice.Enabled = False
        Me.tbox_rice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbox_rice.Location = New System.Drawing.Point(594, 62)
        Me.tbox_rice.MaxLength = 50
        Me.tbox_rice.Name = "tbox_rice"
        Me.tbox_rice.Size = New System.Drawing.Size(428, 30)
        Me.tbox_rice.TabIndex = 48
        '
        'btn_select_rice
        '
        Me.btn_select_rice.BackgroundImage = CType(resources.GetObject("btn_select_rice.BackgroundImage"), System.Drawing.Image)
        Me.btn_select_rice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_select_rice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_rice.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_select_rice.Location = New System.Drawing.Point(1056, 62)
        Me.btn_select_rice.Name = "btn_select_rice"
        Me.btn_select_rice.Size = New System.Drawing.Size(35, 30)
        Me.btn_select_rice.TabIndex = 51
        Me.btn_select_rice.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.Location = New System.Drawing.Point(1130, 54)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(163, 38)
        Me.btn_add.TabIndex = 53
        Me.btn_add.Text = "Export to Excel"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'dgv_ledger
        '
        Me.dgv_ledger.AllowUserToAddRows = False
        Me.dgv_ledger.AllowUserToDeleteRows = False
        Me.dgv_ledger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_ledger.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_ledger.ColumnHeadersHeight = 50
        Me.dgv_ledger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_ledger.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.rice_name, Me.transaction_type, Me.cost, Me.debit, Me.credit, Me.balance})
        Me.dgv_ledger.Location = New System.Drawing.Point(36, 98)
        Me.dgv_ledger.Name = "dgv_ledger"
        Me.dgv_ledger.ReadOnly = True
        Me.dgv_ledger.RowHeadersWidth = 51
        Me.dgv_ledger.RowTemplate.Height = 24
        Me.dgv_ledger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_ledger.Size = New System.Drawing.Size(1257, 496)
        Me.dgv_ledger.TabIndex = 52
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
        'transaction_type
        '
        Me.transaction_type.HeaderText = "Transaction Type"
        Me.transaction_type.MinimumWidth = 6
        Me.transaction_type.Name = "transaction_type"
        Me.transaction_type.ReadOnly = True
        '
        'cost
        '
        Me.cost.HeaderText = "Cost/Amount"
        Me.cost.MinimumWidth = 6
        Me.cost.Name = "cost"
        Me.cost.ReadOnly = True
        '
        'debit
        '
        Me.debit.HeaderText = "Stock Debit"
        Me.debit.MinimumWidth = 6
        Me.debit.Name = "debit"
        Me.debit.ReadOnly = True
        '
        'credit
        '
        Me.credit.HeaderText = "Stock Credit"
        Me.credit.MinimumWidth = 6
        Me.credit.Name = "credit"
        Me.credit.ReadOnly = True
        '
        'balance
        '
        Me.balance.HeaderText = "Balance"
        Me.balance.MinimumWidth = 6
        Me.balance.Name = "balance"
        Me.balance.ReadOnly = True
        '
        'cbox_transaction
        '
        Me.cbox_transaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_transaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbox_transaction.FormattingEnabled = True
        Me.cbox_transaction.ItemHeight = 29
        Me.cbox_transaction.Items.AddRange(New Object() {"Stock-In", "Stock-Out", "Sales"})
        Me.cbox_transaction.Location = New System.Drawing.Point(36, 55)
        Me.cbox_transaction.Name = "cbox_transaction"
        Me.cbox_transaction.Size = New System.Drawing.Size(383, 37)
        Me.cbox_transaction.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Transaction :"
        '
        'Report_rice_ledger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 649)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbox_transaction)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.dgv_ledger)
        Me.Controls.Add(Me.btn_select_rice)
        Me.Controls.Add(Me.btn_remove_rice)
        Me.Controls.Add(Me.tbox_rice)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(0, 10)
        Me.Name = "Report_rice_ledger"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Rice Ledger"
        CType(Me.dgv_ledger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_select_rice As Button
    Friend WithEvents btn_remove_rice As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbox_rice As TextBox
    Friend WithEvents btn_add As Button
    Friend WithEvents dgv_ledger As DataGridView
    Friend WithEvents cbox_transaction As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents rice_name As DataGridViewTextBoxColumn
    Friend WithEvents transaction_type As DataGridViewTextBoxColumn
    Friend WithEvents cost As DataGridViewTextBoxColumn
    Friend WithEvents debit As DataGridViewTextBoxColumn
    Friend WithEvents credit As DataGridViewTextBoxColumn
    Friend WithEvents balance As DataGridViewTextBoxColumn
End Class
