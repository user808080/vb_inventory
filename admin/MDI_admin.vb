Public Class MDI_admin
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        Dim childForm As New Home()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeToolStripMenuItem.Click
        Dim childForm As New Manage_employee()
        childForm.MdiParent = Me
        childForm.Show()
    End Sub
End Class