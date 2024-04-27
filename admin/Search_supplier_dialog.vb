Public Class Search_supplier_dialog
    Private Sub Search_supplier_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub
    Public Sub ShowData()
        If tbox_search_box.Text.Trim = "" Then
            Datagridview_modules.DisplaySupplier(dgv_supplier_list)
        Else
            Datagridview_modules.DisplaySearchSupplier(dgv_supplier_list, tbox_search_box.Text.Trim)
        End If
    End Sub

    Private Sub tbox_search_box_TextChanged(sender As Object, e As EventArgs) Handles tbox_search_box.TextChanged
        ShowData()
    End Sub

    Private Sub dgv_supplier_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_supplier_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_supplier_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_supplier_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()
            Dim name = selectedRow.Cells(1).Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to select this supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes             
                Dim previousForm As Add_stock_in_dialog = Application.OpenForms.OfType(Of Add_stock_in_dialog)().FirstOrDefault()
                If previousForm IsNot Nothing Then
                    ' Assign the selected id to the riceID property of the previous form
                    previousForm.supplierID = id
                    previousForm.supplierName = name
                    Me.Close() ' Close the current form
                End If
                'Me.Close()
            End If
        End If
    End Sub
End Class