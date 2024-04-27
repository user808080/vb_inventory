Public Class Add_supplier_dialog
    Private ID = ""
    Public Sub New()
        InitializeComponent()
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
        link_label_add_products.Visible = False
    End Sub
    Public Sub New(ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.ID = id

        Dim dataArray As List(Of String()) = Supplier_modules.GetSpecificSupplierById(Me.ID)
        For Each arr As String() In dataArray
            tbox_supplier_name.Text = arr(1)
            tbox_contact_no.Text = arr(2)
            tbox_address.Text = arr(3)

            Dim paymentTerms() As String = arr(4).Split(",")
            For Each term As String In paymentTerms
                If term = checkbox_cash.Text Then
                    checkbox_cash.Checked = True
                End If

                If term = checkbox_gcash.Text Then
                    checkbox_gcash.Checked = True
                End If

                If term = checkbox_cheque.Text Then
                    checkbox_cheque.Checked = True
                End If

                If term = checkbox_bank_transfer.Text Then
                    checkbox_bank_transfer.Checked = True
                End If
            Next
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
        link_label_add_products.Visible = True
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim valid = PassValidate()

        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes
                btn_update.Enabled = False
                btn_delete.Enabled = False
                Dim paymentTerms As String

                paymentTerms = ""
                If checkbox_cash.Checked Then
                    paymentTerms &= checkbox_cash.Text & ","
                End If
                If checkbox_gcash.Checked Then
                    paymentTerms &= checkbox_gcash.Text & ","
                End If
                If checkbox_cheque.Checked Then
                    paymentTerms &= checkbox_cheque.Text & ","
                End If
                If checkbox_bank_transfer.Checked Then
                    paymentTerms &= checkbox_bank_transfer.Text & ","
                End If

                paymentTerms = paymentTerms.Remove(paymentTerms.Length - 1)

                If Supplier_modules.AddSupplier(tbox_supplier_name.Text.Trim, tbox_contact_no.Text.Trim, tbox_address.Text.Trim, paymentTerms) Then
                    Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully added a supplier! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If saveResultDialog = DialogResult.Yes Then
                        ResetFields()
                        tbox_supplier_name.Focus()
                        Dim previousForm As Manage_supplier = Application.OpenForms.OfType(Of Manage_supplier)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            Datagridview_modules.DisplaySupplier(previousForm.dgv_supplier_list)
                        End If
                    Else
                        Me.Close()
                    End If

                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Public Function PassValidate() As Boolean
        Dim valid = True

        If tbox_supplier_name.Text.Trim = "" Then
            MessageBox.Show("Please enter supplier name.", "Supplier name is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_contact_no.Text.Trim = "" Then
            MessageBox.Show("Please enter contact number.", "Contact number is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_address.Text.Trim = "" Then
            MessageBox.Show("Please enter supplier address.", "Supplier address is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If checkbox_cash.Checked = False And checkbox_gcash.Checked = False And checkbox_cheque.Checked = False And checkbox_bank_transfer.Checked = False Then
            MessageBox.Show("Please select at least one payment terms.", "Payment term(s) is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If


        Return valid
    End Function

    Public Sub ResetFields()
        tbox_supplier_name.Clear()
        tbox_contact_no.Clear()
        tbox_address.Clear()

        checkbox_cash.Checked = False
        checkbox_gcash.Checked = False
        checkbox_cheque.Checked = False
        checkbox_bank_transfer.Checked = False
    End Sub

    Private Sub link_label_add_products_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_label_add_products.LinkClicked
        Dim dialogAddProductsOffered As New Add_products_offered_dialog(Me.ID)
        dialogAddProductsOffered.ShowDialog()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update supplier data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes                
                Dim paymentTerms As String

                paymentTerms = ""
                If checkbox_cash.Checked Then
                    paymentTerms &= checkbox_cash.Text & ","
                End If
                If checkbox_gcash.Checked Then
                    paymentTerms &= checkbox_gcash.Text & ","
                End If
                If checkbox_cheque.Checked Then
                    paymentTerms &= checkbox_cheque.Text & ","
                End If
                If checkbox_bank_transfer.Checked Then
                    paymentTerms &= checkbox_bank_transfer.Text & ","
                End If

                paymentTerms = paymentTerms.Remove(paymentTerms.Length - 1)
                If Supplier_modules.UpdateSupplier(Me.ID, tbox_supplier_name.Text, tbox_contact_no.Text(), tbox_address.Text(), paymentTerms) Then
                    MessageBox.Show("You have successfully updated supplier data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE supplier?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Supplier_modules.DeleteSupplier(Me.ID) Then
                MessageBox.Show("You have successfully deleted supplier!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Add_supplier_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class