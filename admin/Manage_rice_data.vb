Public Class Manage_rice_data

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialogAddRice As New Add_rice_dialog()
        dialogAddRice.ShowDialog()
        Datagridview_modules.DisplayRice(dgv_rice_list)
    End Sub

    Private Sub Manage_rice_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplayRice(dgv_rice_list)
    End Sub

    Private Sub dgv_rice_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rice_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_rice_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_rice_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim dialogAddRice As New Add_rice_dialog(id)
            dialogAddRice.ShowDialog()
            Datagridview_modules.DisplayRice(dgv_rice_list) 'reload the datagrid
        End If
    End Sub

    Private Sub dgv_rice_list_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rice_list.CellContentClick

    End Sub
End Class