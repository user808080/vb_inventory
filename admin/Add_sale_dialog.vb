Public Class Add_sale_dialog
    Public ID
    Public riceID As String = ""
    Public storageID As String = ""

    Public storageCurrentStocks As Decimal = 0
    Public price As Decimal = 0
    Public riceName As String = ""
    Public storageName As String = ""

    Public Sub New()
        InitializeComponent()
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub

    Public Sub New(ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ID = id

        Dim dataArray As List(Of String()) = Sales_modules.GetSpecificSaleById(Me.ID)
        For Each arr As String() In dataArray
            '{reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("quantity_per_kilo").ToString(), reader("price").ToString(), reader("tender_amount").ToString()}
            Me.riceID = arr(1)
            tbox_rice.Text = arr(2)
            Me.storageID = arr(3)
            tbox_storage.Text = arr(4)

            Me.storageCurrentStocks = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID) + arr(5)
            tbox_available_stocks.Text = Me.storageCurrentStocks
            tbox_quantity.Text = arr(5)
            Me.price = Convert.ToDecimal(arr(6))
            tbox_price.Text = arr(6)
            tbox_tender_amount.Text = arr(7)
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True

        btn_select_rice.Enabled = False
        btn_select_storage.Enabled = False

        btn_remove_rice.Enabled = False
        btn_remove_storage.Enabled = False
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim valid = PassValidate()
        If valid Then
            Dim finalvalid = PassFinalValidate()
            If finalvalid Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to add rice sale(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    If Sales_modules.AddSale(Me.riceID, Me.storageID, Convert.ToDecimal(tbox_quantity.Text.Trim), Me.price, Convert.ToDecimal(tbox_tender_amount.Text.Trim)) Then
                        'update rice stock level
                        Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                        Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)
                        Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully a rice sale(s)! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If saveResultDialog = DialogResult.Yes Then
                            ResetFields()
                            btn_select_rice.Focus()

                            Dim previousForm As Transaction_sales = Application.OpenForms.OfType(Of Transaction_sales)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                Datagridview_modules.DisplaySale(previousForm.dgv_sales, "")
                            End If
                        Else
                            Me.Close()
                        End If

                    Else
                        MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Public Function PassFinalValidate() As Boolean
        Dim valid = True

        If Me.storageCurrentStocks - Convert.ToDecimal(tbox_quantity.Text) < 0 Then
            MessageBox.Show("Insufficient rice stock(s) in the selected storage. Please select another rice or check different storage.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If Convert.ToDecimal(tbox_total_cost.Text.Trim) > Convert.ToDecimal(tbox_tender_amount.Text.Trim) Then
            MessageBox.Show("The tendered amount is less than the total cost. Please make sure that the tendered amount is greater than or equal to the total cost.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If
        Return valid
    End Function

    Public Function PassValidate() As Boolean
        Dim valid = True

        If tbox_quantity.Text.Trim = "" Then
            MessageBox.Show("Please enter quantity(s) per kilo.", "Rice quantity is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf IsNumeric(tbox_quantity.Text) = False Then
            MessageBox.Show("Please enter a valid quantity(s).", "Quantity must be a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf Convert.ToDecimal(tbox_quantity.Text) <= 0 Then
            MessageBox.Show("Please enter a quantity greater than Zero.", "Quantity must be a greater than zero.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_tender_amount.Text.Trim = "" Then
            MessageBox.Show("Please enter tender amount.", "Tender amount is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf IsNumeric(tbox_tender_amount.Text) = False Then
            MessageBox.Show("Please enter a valid tender amount.", "Tender amount must be a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf Convert.ToDecimal(tbox_tender_amount.Text) <= 0 Then
            MessageBox.Show("Please enter a tender amount greater than Zero.", "Tender amount must be a greater than zero.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_rice.Text.Trim = "" Or riceID = "" Then
            MessageBox.Show("Please select rice.", "Rice is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_storage.Text.Trim = "" Or storageID = "" Then
            MessageBox.Show("Please select a storage.", "Storage is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        Return valid
    End Function

    Public Sub ResetFields()
        tbox_rice.Clear()
        tbox_storage.Clear()
        tbox_available_stocks.Clear()
        tbox_price.Clear()
        tbox_total_cost.Clear()
        tbox_tender_amount.Clear()
        tbox_change_amount.Clear()
        tbox_quantity.Clear()
    End Sub

    Private Sub tbox_quantity_TextChanged(sender As Object, e As EventArgs) Handles tbox_quantity.TextChanged
        If IsNumeric(tbox_quantity.Text) = True And Me.price <> 0 Then

            tbox_total_cost.Text = Convert.ToDecimal(tbox_quantity.Text) * Me.price
        Else
            tbox_total_cost.Text = "Invalid"
        End If


    End Sub

    Private Sub btn_select_rice_Click(sender As Object, e As EventArgs) Handles btn_select_rice.Click
        Dim dialogSearchRice As New Search_rice_dialog("sale")
        dialogSearchRice.ShowDialog()
        tbox_rice.Text = Me.riceName
        tbox_price.Text = Me.price

        If Me.storageID <> "" Then

            Me.storageCurrentStocks = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
            tbox_available_stocks.Text = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
        End If
    End Sub

    Private Sub btn_select_storage_Click(sender As Object, e As EventArgs) Handles btn_select_storage.Click
        Dim dialogSearchStorage As New Search_storage_dialog("sale", Me.riceID)
        dialogSearchStorage.ShowDialog()
        tbox_storage.Text = Me.storageName
        Me.storageCurrentStocks = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
        tbox_available_stocks.Text = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
    End Sub

    Private Sub btn_remove_rice_Click(sender As Object, e As EventArgs) Handles btn_remove_rice.Click
        Me.riceID = ""
        Me.riceName = ""
        tbox_rice.Clear()
    End Sub

    Private Sub btn_remove_storage_Click(sender As Object, e As EventArgs) Handles btn_remove_storage.Click
        Me.storageID = ""
        Me.storageName = ""
        tbox_storage.Clear()
    End Sub

    Private Sub tbox_tender_amount_TextChanged(sender As Object, e As EventArgs) Handles tbox_tender_amount.TextChanged
        If IsNumeric(tbox_total_cost.Text) = True And IsNumeric(tbox_tender_amount.Text) Then

            tbox_change_amount.Text = Convert.ToDecimal(tbox_tender_amount.Text) - Convert.ToDecimal(tbox_total_cost.Text)
        Else
            tbox_change_amount.Text = "Invalid"
        End If

    End Sub

    Private Sub tbox_price_TextChanged(sender As Object, e As EventArgs) Handles tbox_price.TextChanged
        If IsNumeric(tbox_quantity.Text) = True And Me.price <> 0 Then

            tbox_total_cost.Text = Convert.ToDecimal(tbox_quantity.Text) * Me.price
        Else
            tbox_total_cost.Text = "Invalid"
        End If
    End Sub

    Private Sub tbox_total_cost_TextChanged(sender As Object, e As EventArgs) Handles tbox_total_cost.TextChanged
        If IsNumeric(tbox_total_cost.Text) = True And IsNumeric(tbox_tender_amount.Text) Then

            tbox_change_amount.Text = Convert.ToDecimal(tbox_tender_amount.Text) - Convert.ToDecimal(tbox_total_cost.Text)
        Else
            tbox_change_amount.Text = "Invalid"
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim valid = PassValidate()
        If valid Then
            Dim finalvalid = PassFinalValidate()
            If finalvalid Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update rice sale(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    If Sales_modules.UpdateSale(Me.ID, Me.riceID, Me.storageID, Convert.ToDecimal(tbox_quantity.Text.Trim), Me.price, Convert.ToDecimal(tbox_tender_amount.Text.Trim)) Then
                        'update rice stock level
                        Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                        Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                        Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully updated a rice sale(s)! Do you want to close update window?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If saveResultDialog = DialogResult.No Then
                            ResetFields()
                            btn_select_rice.Focus()

                            Dim previousForm As Transaction_sales = Application.OpenForms.OfType(Of Transaction_sales)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                Datagridview_modules.DisplaySale(previousForm.dgv_sales, "")
                            End If
                        Else
                            Me.Close()
                        End If

                    Else
                        MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE Sale(s) data? This may cause overstock(s) or even imbalance ledger.", "Proceed with caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If Sales_modules.DeleteSale(Me.ID) Then
                'update rice stock level
                Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)
                MessageBox.Show("You have successfully deleted sale(s) data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class