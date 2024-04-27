Public Class Transaction_stock_out
    Private Sub Transaction_stock_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplayStockOut(dgv_stock_out, "")
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialogAddStockOut As New Add_stock_out_dialog()
        dialogAddStockOut.ShowDialog()
        Datagridview_modules.DisplayStockOut(dgv_stock_out, "")
    End Sub

    Private Sub dgv_stock_out_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stock_out.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_stock_out.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_stock_out.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim dialogAddStockOut As New Add_stock_out_dialog(id)
            dialogAddStockOut.ShowDialog()
            Datagridview_modules.DisplayStockOut(dgv_stock_out, "") 'reload the datagrid
        End If
    End Sub
End Class