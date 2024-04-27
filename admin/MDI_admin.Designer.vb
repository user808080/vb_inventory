<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI_admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ms_navigation = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiceDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StorageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OthersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiceLedgerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_navigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_navigation
        '
        Me.ms_navigation.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_navigation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.ManageToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.OthersToolStripMenuItem})
        Me.ms_navigation.Location = New System.Drawing.Point(0, 0)
        Me.ms_navigation.Name = "ms_navigation"
        Me.ms_navigation.Size = New System.Drawing.Size(1348, 28)
        Me.ms_navigation.TabIndex = 1
        Me.ms_navigation.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'ManageToolStripMenuItem
        '
        Me.ManageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeToolStripMenuItem, Me.RiceDataToolStripMenuItem, Me.SupplierToolStripMenuItem, Me.StorageToolStripMenuItem})
        Me.ManageToolStripMenuItem.Name = "ManageToolStripMenuItem"
        Me.ManageToolStripMenuItem.Size = New System.Drawing.Size(77, 26)
        Me.ManageToolStripMenuItem.Text = "Manage"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'RiceDataToolStripMenuItem
        '
        Me.RiceDataToolStripMenuItem.Name = "RiceDataToolStripMenuItem"
        Me.RiceDataToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.RiceDataToolStripMenuItem.Text = "Rice Data"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'StorageToolStripMenuItem
        '
        Me.StorageToolStripMenuItem.Name = "StorageToolStripMenuItem"
        Me.StorageToolStripMenuItem.Size = New System.Drawing.Size(158, 26)
        Me.StorageToolStripMenuItem.Text = "Storage"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockInToolStripMenuItem, Me.StockOutToolStripMenuItem, Me.SalesToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(98, 26)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'StockInToolStripMenuItem
        '
        Me.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem"
        Me.StockInToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StockInToolStripMenuItem.Text = "Stock In"
        '
        'StockOutToolStripMenuItem
        '
        Me.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem"
        Me.StockOutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.StockOutToolStripMenuItem.Text = "Stock Out"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RiceLedgerToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(74, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'OthersToolStripMenuItem
        '
        Me.OthersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogOutToolStripMenuItem})
        Me.OthersToolStripMenuItem.Name = "OthersToolStripMenuItem"
        Me.OthersToolStripMenuItem.Size = New System.Drawing.Size(66, 26)
        Me.OthersToolStripMenuItem.Text = "Others"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(145, 26)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'RiceLedgerToolStripMenuItem
        '
        Me.RiceLedgerToolStripMenuItem.Name = "RiceLedgerToolStripMenuItem"
        Me.RiceLedgerToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RiceLedgerToolStripMenuItem.Text = "Rice Ledger"
        '
        'MDI_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.ms_navigation)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.ms_navigation
        Me.Name = "MDI_admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management System - Admin Access"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ms_navigation.ResumeLayout(False)
        Me.ms_navigation.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_navigation As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiceDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StorageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OthersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RiceLedgerToolStripMenuItem As ToolStripMenuItem
End Class
