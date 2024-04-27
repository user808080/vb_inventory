Public Class Search_rice_dialog
    Private formSwitch
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Me.formSwitch = "stock_in"
    End Sub
    Public Sub New(ByVal formType As String)

        ' This call is required by the designer.
        InitializeComponent()
        Me.formSwitch = formType
    End Sub
    Private Sub Search_rice_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowRice()
    End Sub

    Private Sub dgv_rice_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rice_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_rice_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_rice_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()
            Dim name = selectedRow.Cells(2).Value.ToString()
            Dim price = selectedRow.Cells(3).Value.ToString()

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to select this rice?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes
                Select Case Me.formSwitch
                    Case "stock_in"
                        Dim previousForm As Add_stock_in_dialog = Application.OpenForms.OfType(Of Add_stock_in_dialog)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            ' Assign the selected id to the riceID property of the previous form
                            previousForm.riceID = id
                            previousForm.riceName = name
                            Me.Close() ' Close the current form
                        End If

                    Case "stock_out"
                        Dim previousForm As Add_stock_out_dialog = Application.OpenForms.OfType(Of Add_stock_out_dialog)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            ' Assign the selected id to the riceID property of the previous form
                            previousForm.riceID = id
                            previousForm.riceName = name
                            Me.Close() ' Close the current form
                        End If

                    Case "sale"
                        Dim previousForm As Add_sale_dialog = Application.OpenForms.OfType(Of Add_sale_dialog)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            ' Assign the selected id to the riceID property of the previous form
                            previousForm.riceID = id
                            previousForm.riceName = name
                            previousForm.price = price
                            Me.Close() ' Close the current form
                        End If

                    Case "rice_ledger"
                        Dim previousForm As Report_rice_ledger = Application.OpenForms.OfType(Of Report_rice_ledger)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            ' Assign the selected id to the riceID property of the previous form
                            previousForm.riceID = id
                            previousForm.riceName = name
                            Me.Close() ' Close the current form
                        End If
                    Case Else
                End Select


                'Me.Close()
            End If
        End If
    End Sub

    Public Sub ShowRice()
        If tbox_search_box.Text.Trim = "" Then
            Datagridview_modules.DisplayRice(dgv_rice_list)
        Else
            Datagridview_modules.DisplaySearchRice(dgv_rice_list, tbox_search_box.Text.Trim)
        End If
    End Sub

    Private Sub tbox_search_box_TextChanged(sender As Object, e As EventArgs) Handles tbox_search_box.TextChanged
        ShowRice()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class