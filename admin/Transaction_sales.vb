Public Class Transaction_sales
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim dialogAddSales As New Add_sale_dialog()
        dialogAddSales.ShowDialog()
        Datagridview_modules.DisplaySale(dgv_sales, "")
    End Sub

    Private Sub Transaction_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplaySale(dgv_sales, "")
    End Sub

    Private Sub dgv_sales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_sales.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_sales.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_sales.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim dialogAddSale As New Add_sale_dialog(id)
            dialogAddSale.ShowDialog()
            Datagridview_modules.DisplaySale(dgv_sales, "")
        End If
    End Sub
End Class