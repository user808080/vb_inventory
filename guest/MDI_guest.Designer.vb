<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI_guest
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
        Me.OfferredProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ms_nav.SuspendLayout()
        Me.SuspendLayout()
        '
        'ms_nav
        '
        Me.ms_nav.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ms_nav.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.OfferredProductsToolStripMenuItem})
        Me.ms_nav.Location = New System.Drawing.Point(0, 0)
        Me.ms_nav.Name = "ms_nav"
        Me.ms_nav.Size = New System.Drawing.Size(1344, 28)
        Me.ms_nav.TabIndex = 1
        Me.ms_nav.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'OfferredProductsToolStripMenuItem
        '
        Me.OfferredProductsToolStripMenuItem.Name = "OfferredProductsToolStripMenuItem"
        Me.OfferredProductsToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.OfferredProductsToolStripMenuItem.Text = "Offerred Product(s)"
        '
        'MDI_guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 717)
        Me.Controls.Add(Me.ms_nav)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.ms_nav
        Me.Name = "MDI_guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management System - GUEST access"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ms_nav.ResumeLayout(False)
        Me.ms_nav.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ms_nav As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OfferredProductsToolStripMenuItem As ToolStripMenuItem
End Class
