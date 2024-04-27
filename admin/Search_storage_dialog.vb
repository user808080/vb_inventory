Public Class Search_storage_dialog
    Private formSwitch
    Private riceID
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.formSwitch = "stock_in"
        Me.riceID = ""
    End Sub
    Public Sub New(ByVal formType As String, ByVal rice As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.formSwitch = formType
        Me.riceID = rice
    End Sub
    Private Sub Search_storage_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Public Sub ShowData()
        If tbox_search_box.Text.Trim = "" Then
            Datagridview_modules.DisplaySearchStorage(dgv_storage_list, tbox_search_box.Text.Trim)
        Else
            Datagridview_modules.DisplaySearchStorage(dgv_storage_list, tbox_search_box.Text.Trim)
        End If
    End Sub

    Private Sub dgv_storage_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_storage_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_storage_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_storage_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()
            Dim name = selectedRow.Cells(1).Value.ToString()
            Dim capacity = selectedRow.Cells(2).Value.ToString()

            Select Case Me.formSwitch
                Case "stock_in"

                    If Storage_modules.GetStorageRemainingCapacity(id) > 0 Then
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to select this storage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            ' User clicked Yes                                 
                            Dim previousForm As Add_stock_in_dialog = Application.OpenForms.OfType(Of Add_stock_in_dialog)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                ' Assign the selected id to the riceID property of the previous form
                                previousForm.storageID = id
                                previousForm.storageName = name
                                previousForm.storageCapacity = capacity
                                Me.Close() ' Close the current form
                            End If
                        End If
                    Else
                        MessageBox.Show("The selected storage has no available space. Please select another.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Case "stock_out"
                    If Storage_modules.GetStorageCurrentStocks(id, Me.riceID) > 0 Then
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to get stock(s) from this storage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            ' User clicked Yes                                 
                            Dim previousForm As Add_stock_out_dialog = Application.OpenForms.OfType(Of Add_stock_out_dialog)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                ' Assign the selected id to the riceID property of the previous form
                                previousForm.storageID = id
                                previousForm.storageName = name
                                Me.Close() ' Close the current form
                            End If
                        End If
                    Else
                        MessageBox.Show("The selected storage has no available stock(s). Please select another.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Case "sale"
                    If Storage_modules.GetStorageCurrentStocks(id, Me.riceID) > 0 Then
                        Dim result As DialogResult = MessageBox.Show("Are you sure you want to get stock(s) from this storage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                        If result = DialogResult.Yes Then
                            ' User clicked Yes                                 
                            Dim previousForm As Add_sale_dialog = Application.OpenForms.OfType(Of Add_sale_dialog)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                ' Assign the selected id to the riceID property of the previous form
                                previousForm.storageID = id
                                previousForm.storageName = name
                                Me.Close() ' Close the current form
                            End If
                        End If
                    Else
                        MessageBox.Show("The selected storage has no available stock(s). Please select another.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If


                Case Else
            End Select

        End If
    End Sub

    Private Sub tbox_search_box_TextChanged(sender As Object, e As EventArgs) Handles tbox_search_box.TextChanged
        ShowData()
    End Sub
End Class