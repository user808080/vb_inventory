Public Class Manage_storage

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Manage_storage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplayStorage(dgv_storage_list)
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialogAddStorage As New Add_storage_dialog()
        dialogAddStorage.ShowDialog()
        Datagridview_modules.DisplayStorage(dgv_storage_list)
    End Sub

    Private Sub dgv_storage_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_storage_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_storage_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_storage_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim dialogAddStorage As New Add_storage_dialog(id)
            dialogAddStorage.ShowDialog()
            Datagridview_modules.DisplayStorage(dgv_storage_list) 'reload the datagrid
        End If
    End Sub
End Class