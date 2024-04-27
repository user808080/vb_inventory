Public Class MDI_employee
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

    Private Sub MDI_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdiFormWidth = Me.Size.Width
        mdiFormHeight = Me.Size.Height

        Dim childForm As New Home(mdiFormWidth, mdiFormHeight, Me.fullname)
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        mdiFormWidth = Me.Size.Width
        mdiFormHeight = Me.Size.Height

        Dim childForm As New Home(mdiFormWidth, mdiFormHeight, Me.fullname)
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

    Private Sub MDI_employee_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            e.Cancel = False
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub
End Class