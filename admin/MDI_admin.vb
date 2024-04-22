Imports MySql.Data.MySqlClient

Public Class MDI_admin
    Public fullname As String
    Private Sub MDI_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim version As Version = GetType(MySqlConnection).Assembly.GetName().Version
        MessageBox.Show(version.ToString())
        Dim childForm As New Home()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim childForm As New Home()
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


End Class