Public Class Add_stock_in_dialog
    Public ID
    Public riceID As String = ""
    Public supplierID As String = ""
    Public storageID As String = ""

    Public oldCapacity As Decimal = 0
    Public storageCapacity As String = ""
    Public riceName As String = ""
    Public supplierName As String = ""
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

        Dim dataArray As List(Of String()) = StockIn_modules.GetSpecificStockInById(Me.ID)
        'New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("supplier").ToString(), reader("supplier_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("cost_per_kilo").ToString(), reader("stock_per_kilo").ToString()}
        For Each arr As String() In dataArray

            Me.riceID = arr(1)
            tbox_rice.Text = arr(2)
            Me.supplierID = arr(3)
            tbox_supplier.Text = arr(4)
            Me.storageID = arr(5)
            tbox_storage.Text = arr(6)
            Me.oldCapacity = Storage_modules.GetStorageRemainingCapacity(Me.storageID) + arr(8)
            tbox_capacity.Text = Storage_modules.GetStorageRemainingCapacity(Me.storageID)
            tbox_cost_per_kg.Text = arr(7)
            tbox_stock_per_kg.Text = arr(8)
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True

        btn_select_rice.Enabled = False
        btn_select_storage.Enabled = False
        btn_select_supplier.Enabled = False

        btn_remove_rice.Enabled = False
        btn_remove_supplier.Enabled = False
        btn_remove_storage.Enabled = False
    End Sub
    Private Sub Add_stock_in_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim valid = PassValidate()
        If valid Then

            If Storage_modules.GetStorageRemainingCapacity(storageID) - Convert.ToDecimal(tbox_stock_per_kg.Text) >= 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to add rice stock(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' User clicked Yes

                    If StockIn_modules.AddStockIn(Me.riceID, Me.supplierID, Me.storageID, Convert.ToDecimal(tbox_cost_per_kg.Text), Convert.ToDecimal(tbox_stock_per_kg.Text)) Then
                        'update rice stock level
                        Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                        Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                        Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully added a rice stock(s)! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If saveResultDialog = DialogResult.Yes Then
                            ResetFields()
                            btn_remove_rice.Focus()

                            Dim previousForm As Transaction_stock_in = Application.OpenForms.OfType(Of Transaction_stock_in)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                Datagridview_modules.DisplayStockIn(previousForm.dgv_stock_in, "")
                            End If
                        Else
                            Me.Close()
                        End If

                    Else
                        MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("There is no available space for the selected storage. Please select another storage.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Public Function PassValidate() As Boolean
        Dim valid = True

        If tbox_cost_per_kg.Text = "" Then
            MessageBox.Show("Please enter cost per kilo.", "Cost is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf IsNumeric(tbox_cost_per_kg.Text) = False Then
            MessageBox.Show("Please enter a valid cost.", "Cost is must be a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf Convert.ToDecimal(tbox_cost_per_kg.Text) <= 0 Then
            MessageBox.Show("Please enter a cost greater than Zero.", "Cost must be a greater than zero.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_stock_per_kg.Text = "" Then
            MessageBox.Show("Please enter stock(s) per kilo.", "Stock is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf IsNumeric(tbox_stock_per_kg.Text) = False Then
            MessageBox.Show("Please enter a valid stocks(s).", "Stock is must be a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf Convert.ToDecimal(tbox_stock_per_kg.Text) <= 0 Then
            MessageBox.Show("Please enter a stock greater than Zero.", "Stock must be a greater than zero.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_rice.Text.Trim = "" Or riceID = "" Then
            MessageBox.Show("Please select rice.", "Rice is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_supplier.Text.Trim = "" Or supplierID = "" Then
            MessageBox.Show("Please select a supplier.", "Supplier is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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
        tbox_supplier.Clear()
        tbox_storage.Clear()
        tbox_cost_per_kg.Clear()
        tbox_stock_per_kg.Clear()
        tbox_storage.Clear()
        tbox_capacity.Clear()
        tbox_total_amount.Clear()
    End Sub

    Private Sub btn_select_rice_Click(sender As Object, e As EventArgs) Handles btn_select_rice.Click
        Dim dialogSearchRice As New Search_rice_dialog()
        dialogSearchRice.ShowDialog()
        tbox_rice.Text = Me.riceName
    End Sub

    Private Sub btn_select_supplier_Click(sender As Object, e As EventArgs) Handles btn_select_supplier.Click
        Dim dialogSearchSupplier As New Search_supplier_dialog()
        dialogSearchSupplier.ShowDialog()
        tbox_supplier.Text = Me.supplierName
    End Sub

    Private Sub btn_select_storage_Click(sender As Object, e As EventArgs) Handles btn_select_storage.Click
        Dim dialogSearchStorage As New Search_storage_dialog()
        dialogSearchStorage.ShowDialog()
        tbox_storage.Text = Me.storageName
        Me.oldCapacity = Storage_modules.GetStorageRemainingCapacity(Me.storageID) 'for update
        tbox_capacity.Text = Storage_modules.GetStorageRemainingCapacity(Me.storageID)
    End Sub

    Private Sub btn_remove_rice_Click(sender As Object, e As EventArgs) Handles btn_remove_rice.Click
        tbox_rice.Clear()
        Me.riceID = ""
        Me.riceName = ""
    End Sub

    Private Sub btn_remove_supplier_Click(sender As Object, e As EventArgs) Handles btn_remove_supplier.Click
        tbox_supplier.Clear()
        Me.supplierID = ""
        Me.supplierName = ""
    End Sub

    Private Sub btn_remove_storage_Click(sender As Object, e As EventArgs) Handles btn_remove_storage.Click
        tbox_storage.Clear()
        Me.storageID = ""
        Me.storageName = ""
        Me.storageCapacity = ""
    End Sub

    Private Sub tbox_cost_per_kg_TextChanged(sender As Object, e As EventArgs) Handles tbox_cost_per_kg.TextChanged
        ComputeTotalAmount()
    End Sub

    Private Sub tbox_stock_per_kg_TextChanged(sender As Object, e As EventArgs) Handles tbox_stock_per_kg.TextChanged
        ComputeTotalAmount()
    End Sub

    Public Sub ComputeTotalAmount()
        If IsNumeric(tbox_cost_per_kg.Text.Trim) = True And IsNumeric(tbox_stock_per_kg.Text.Trim) = True Then
            tbox_total_amount.Text = Convert.ToDecimal(tbox_cost_per_kg.Text.Trim) * Convert.ToDecimal(tbox_stock_per_kg.Text.Trim)
        Else
            tbox_total_amount.Clear()
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim valid = PassValidate()
        If valid Then
            If Me.oldCapacity - Convert.ToDecimal(tbox_stock_per_kg.Text) >= 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update Stock-In data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' User clicked Yes            
                    If StockIn_modules.UpdateStockIn(Me.ID, Me.riceID, Me.supplierID, Me.storageID, Convert.ToDecimal(tbox_cost_per_kg.Text), Convert.ToDecimal(tbox_stock_per_kg.Text)) Then
                        'update rice stock level
                        Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                        Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                        MessageBox.Show("You have successfully updated Stock-In data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("There is no available space for the selected storage. Please select another storage.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE Stock-In? This may cause negation of stock(s) or even imbalance ledger.", "Proceed with caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If StockIn_modules.DeleteStockIn(Me.ID) Then
                'update rice stock level
                Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                MessageBox.Show("You have successfully deleted Stock-In data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class