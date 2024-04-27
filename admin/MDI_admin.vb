Imports MySql.Data.MySqlClient

Public Class MDI_admin
    Private fullname As String
    Public mdiFormWidth As Integer
    Public mdiFormHeight As Integer

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal fullName As String)
        InitializeComponent()
        Me.fullname = fullName
    End Sub
    Private Sub MDI_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdiFormWidth = Me.Size.Width
        mdiFormHeight = Me.Size.Height

        Dim childForm As New Home(mdiFormWidth, mdiFormHeight, Me.fullname)
        childForm.MdiParent = Me
        childForm.Show()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim childForm As New Home(mdiFormWidth, mdiFormHeight, Me.fullname)
        Me.ActiveMdiChild.Close()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Dim childForm As New Manage_employee()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            Application.Exit()
        End If
    End Sub

    Private Sub RiceDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiceDataToolStripMenuItem.Click
        Dim childForm As New Manage_rice_data()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub MDI_admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            e.Cancel = False
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Dim childForm As New Manage_supplier()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub StorageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StorageToolStripMenuItem.Click
        Dim childForm As New Manage_storage()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub StockInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockInToolStripMenuItem.Click
        Dim childForm As New Transaction_stock_in()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub StockOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOutToolStripMenuItem.Click
        Dim childForm As New Transaction_stock_out()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub SalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesToolStripMenuItem.Click
        Dim childForm As New Transaction_sales()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub RiceLedgerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiceLedgerToolStripMenuItem.Click
        Dim childForm As New Report_rice_ledger()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub
End Class