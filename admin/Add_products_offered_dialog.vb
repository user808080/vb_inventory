Public Class Add_products_offered_dialog
    Private supplierID As String
    Public Sub New(ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.supplierID = id

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Add_products_offered_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplayRice(dgv_rice_list)
        Datagridview_modules.DisplaySupplierProductsOffered(dgv_products_offered, Me.supplierID)
    End Sub

    Public Sub ShowRice()
        If tbox_search_box.Text.Trim = "" Then
            Datagridview_modules.DisplayRice(dgv_rice_list)
        Else
            Datagridview_modules.DisplaySearchRice(dgv_rice_list, tbox_search_box.Text.Trim)
        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        ShowRice()
    End Sub

    Private Sub tbox_search_box_TextChanged(sender As Object, e As EventArgs) Handles tbox_search_box.TextChanged
        ShowRice()
    End Sub

    Private Sub dgv_rice_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rice_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_rice_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_rice_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add this to the supplier product offered?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes

                If Supplier_modules.AddProductsOffered(Me.supplierID, id) Then
                    MessageBox.Show("You have successfully added a products offered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Datagridview_modules.DisplaySupplierProductsOffered(dgv_products_offered, Me.supplierID)
                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
    End Sub

    Private Sub dgv_products_offered_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_products_offered.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_rice_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_rice_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to REMOVE this to the supplier product offered?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes

                If Supplier_modules.DeleteProductsOffered(id) Then
                    MessageBox.Show("You have successfully REMOVED a product!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Datagridview_modules.DisplaySupplierProductsOffered(dgv_products_offered, Me.supplierID)
                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End If
        End If
    End Sub
End Class