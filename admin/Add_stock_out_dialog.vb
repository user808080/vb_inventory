Public Class Add_stock_out_dialog
    Public ID
    Public riceID As String = ""
    Public storageID As String = ""

    Public oldStocks As Decimal = 0
    Public storageCurrentStocks As Decimal = 0
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

        Dim dataArray As List(Of String()) = StockOut_modules.GetSpecificStockOutById(Me.ID)
        '{reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("stock_per_kilo").ToString()}
        For Each arr As String() In dataArray

            Me.riceID = arr(1)
            tbox_rice.Text = arr(2)
            Me.storageID = arr(3)
            tbox_storage.Text = arr(4)
            tbox_stock_per_kg.Text = arr(5)
            Me.storageCurrentStocks = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID) + arr(5)
            tbox_available_stocks.Text = Me.storageCurrentStocks
            'tbox_stock_per_kg.Text = arr(8)
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True

        btn_select_rice.Enabled = False
        btn_select_storage.Enabled = False

        btn_remove_rice.Enabled = False
        btn_remove_storage.Enabled = False
    End Sub
    Private Sub Add_stock_out_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_select_rice_Click(sender As Object, e As EventArgs) Handles btn_select_rice.Click
        Dim dialogSearchRice As New Search_rice_dialog("stock_out")
        dialogSearchRice.ShowDialog()
        tbox_rice.Text = Me.riceName

        If Me.storageID <> "" Then

            Me.storageCurrentStocks = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
            tbox_available_stocks.Text = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
        End If
    End Sub

    Private Sub btn_select_storage_Click(sender As Object, e As EventArgs) Handles btn_select_storage.Click
        Dim dialogSearchStorage As New Search_storage_dialog("stock_out", Me.riceID)
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

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim valid = PassValidate()
        If valid Then

            If Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID) - Convert.ToDecimal(tbox_stock_per_kg.Text) >= 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to DEDUCT rice stock(s)?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' User clicked Yes
                    If StockOut_modules.AddStockOut(Me.riceID, Me.storageID, Convert.ToDecimal(tbox_stock_per_kg.Text)) Then
                        'update rice stock level
                        Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                        Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                        Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully deducted a rice stock(s)! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If saveResultDialog = DialogResult.Yes Then
                            ResetFields()
                            btn_select_rice.Focus()

                            Dim previousForm As Transaction_stock_out = Application.OpenForms.OfType(Of Transaction_stock_out)().FirstOrDefault()
                            If previousForm IsNot Nothing Then
                                Datagridview_modules.DisplayStockOut(previousForm.dgv_stock_out, "")
                            End If
                        Else
                            Me.Close()
                        End If

                    Else
                        MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("There is no available stock(s) for the selected storage. Please select another storage.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub


    Public Function PassValidate() As Boolean
        Dim valid = True

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
        tbox_stock_per_kg.Clear()
    End Sub

    Private Sub tbox_rice_TextChanged(sender As Object, e As EventArgs) Handles tbox_rice.TextChanged
        Me.oldStocks = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
        tbox_available_stocks.Text = Storage_modules.GetStorageCurrentStocks(Me.storageID, Me.riceID)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE Stock-Out data? This may cause overstock(s) or even imbalance ledger.", "Proceed with caution", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If StockOut_modules.DeleteStockOut(Me.ID) Then
                'update rice stock level
                Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                MessageBox.Show("You have successfully deleted Stock-Out data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim valid = PassValidate()
        If valid Then
            If Me.storageCurrentStocks - Convert.ToDecimal(tbox_stock_per_kg.Text) >= 0 Then
                Dim result As DialogResult = MessageBox.Show("Are you sure you want to update Stock-Out data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' User clicked Yes            
                    If StockOut_modules.UpdateStockOut(Me.ID, Me.riceID, Me.storageID, Convert.ToDecimal(tbox_stock_per_kg.Text)) Then
                        'update rice stock level
                        Dim stockLevel As Decimal = Rice_modules.GetRiceCurrentStocks("", Me.riceID)
                        Rice_modules.UpdateStockLevel(Me.riceID, stockLevel)

                        MessageBox.Show("You have successfully updated Stock-Out data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("There is no available stock(s) for the selected storage. Please select another storage.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        End If
    End Sub
End Class