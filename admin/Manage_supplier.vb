Public Class Manage_supplier

    Private Sub Manage_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplaySupplier(dgv_supplier_list)
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialogAddSupplier As New Add_supplier_dialog()
        dialogAddSupplier.ShowDialog()
        Datagridview_modules.DisplaySupplier(dgv_supplier_list)
    End Sub

    Private Sub dgv_supplier_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_supplier_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_supplier_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_supplier_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim dialogAddSupplier As New Add_supplier_dialog(id)
            dialogAddSupplier.ShowDialog()
            Datagridview_modules.DisplaySupplier(dgv_supplier_list) 'reload the datagrid
        End If
    End Sub
End Class