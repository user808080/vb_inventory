<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_employee
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
        Me.ms_nav = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_nav.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_nav
        '
        Me.ms_nav.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_nav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.TransactionToolStripMenuItem})
        Me.ms_nav.Location = New System.Drawing.Point(0, 0)
        Me.ms_nav.Name = "ms_nav"
        Me.ms_nav.Size = New System.Drawing.Size(1344, 30)
        Me.ms_nav.TabIndex = 0
        Me.ms_nav.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalesToolStripMenuItem, Me.StockInToolStripMenuItem, Me.StockOutToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.TransactionToolStripMenuItem.Text = "Transaction"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.SalesToolStripMenuItem.Text = "Sale(s)"
        '
        'StockInToolStripMenuItem
        '
        Me.StockInToolStripMenuItem.Name = "StockInToolStripMenuItem"
        Me.StockInToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.StockInToolStripMenuItem.Text = "Stock In"
        '
        'StockOutToolStripMenuItem
        '
        Me.StockOutToolStripMenuItem.Name = "StockOutToolStripMenuItem"
        Me.StockOutToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.StockOutToolStripMenuItem.Text = "Stock Out"
        '
        'MDI_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 717)
        Me.Controls.Add(Me.ms_nav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.ms_nav
        Me.Name = "MDI_employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management System - Employee Access"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ms_nav.ResumeLayout(False)
        Me.ms_nav.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_nav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOutToolStripMenuItem As ToolStripMenuItem
End Class
