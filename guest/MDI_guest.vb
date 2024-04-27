Public Class MDI_guest
    Public mdiFormWidth As Integer
    Public mdiFormHeight As Integer

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub MDI_guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mdiFormWidth = Me.Size.Width
        mdiFormHeight = Me.Size.Height

        Dim childForm As New Home(mdiFormWidth, mdiFormHeight, "Guest/Visitor")
        childForm.MdiParent = Me
        childForm.Show()
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        mdiFormWidth = Me.Size.Width
        mdiFormHeight = Me.Size.Height

        Dim childForm As New Home(mdiFormWidth, mdiFormHeight, "Guest/Visitor")
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub

    Private Sub MDI_guest_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            e.Cancel = False
            Application.Exit()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub OfferredProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfferredProductsToolStripMenuItem.Click

        Dim childForm As New Products_offered()
        childForm.MdiParent = Me
        Me.ActiveMdiChild.Close()
        childForm.Show()
    End Sub
End Class