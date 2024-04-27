Public Class Add_rice_dialog
    Private ID
    Private selectedCategoryIndexItem As String

    Public Sub New()
        InitializeComponent()
        Me.selectedCategoryIndexItem = "none"
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub
    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.ID = id

        Dim dataArray As List(Of String()) = Rice_modules.GetSpecificRiceById(Me.ID)
        For Each arr As String() In dataArray
            Me.selectedCategoryIndexItem = arr(1) & "-" & arr(2)
            tbox_rice_name.Text = arr(3)
            tbox_price.Text = arr(4)
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
    End Sub
    Private Sub Add_rice_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Combobox_modules.LoadRiceCategory(cbox_rice_category)
        If Me.selectedCategoryIndexItem <> "none" Then
            Combobox_modules.SetSelectedItem(cbox_rice_category, Me.selectedCategoryIndexItem)
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add rice?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes
                btn_update.Enabled = False
                btn_delete.Enabled = False
                If Rice_modules.AddRice(cbox_rice_category.SelectedItem.ToString.Split("-")(0), tbox_rice_name.Text(), Convert.ToDecimal(tbox_price.Text)) Then
                    Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully added a rice! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If saveResultDialog = DialogResult.Yes Then
                        ResetFields()
                        tbox_rice_name.Focus()

                        Dim previousForm As Manage_rice_data = Application.OpenForms.OfType(Of Manage_rice_data)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            Datagridview_modules.DisplayRice(previousForm.dgv_rice_list)
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

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update rice data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes            
                If Rice_modules.UpdateRice(Me.ID, cbox_rice_category.SelectedItem.ToString.Split("-")(0), tbox_rice_name.Text(), Convert.ToDecimal(tbox_price.Text())) Then
                    MessageBox.Show("You have successfully updated rice data!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Public Function PassValidate() As Boolean
        Dim valid = True

        If tbox_rice_name.Text = "" Then
            MessageBox.Show("Please enter rice name.", "Rice name is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_price.Text = "" Then
            MessageBox.Show("Please enter price.", "Price is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf IsNumeric(tbox_price.Text) = False Then
            MessageBox.Show("Please enter a valid price.", "Price is must be a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If


        Return valid
    End Function

    Public Sub ResetFields()
        tbox_price.Clear()
        tbox_rice_name.Clear()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE rice? This will action will delete all record(s) of this rice in the database. Proceed with caution.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            If Rice_modules.DeleteRice(Me.ID) Then
                MessageBox.Show("You have successfully deleted rice and its record!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class