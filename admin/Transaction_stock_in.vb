Public Class Transaction_stock_in

    Private Sub Transaction_stock_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplayStockIn(dgv_stock_in, "")
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialogAddStockIn As New Add_stock_in_dialog()
        dialogAddStockIn.ShowDialog()
        Datagridview_modules.DisplayStockIn(dgv_stock_in, "")
    End Sub

    Private Sub dgv_stock_in_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stock_in.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_stock_in.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_stock_in.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim dialogAddStockIn As New Add_stock_in_dialog(id)
            dialogAddStockIn.ShowDialog()
            Datagridview_modules.DisplayStockIn(dgv_stock_in, "") 'reload the datagrid
        End If
    End Sub

    Private Sub dgv_stock_in_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_stock_in.CellContentClick

    End Sub
End Class