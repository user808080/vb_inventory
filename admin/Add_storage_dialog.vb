Public Class Add_storage_dialog
    Private ID

    Public Sub New()
        InitializeComponent()
        btn_add.Enabled = True
        btn_update.Enabled = False
        btn_delete.Enabled = False
    End Sub
    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.ID = id

        Dim dataArray As List(Of String()) = Storage_modules.GetSpecificStorageById(Me.ID)
        For Each arr As String() In dataArray
            tbox_storage_name.Text = arr(1)
            tbox_location.Text = arr(2)
            tbox_capacity.Text = arr(3)
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
    End Sub
    Private Sub Add_storage_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add storage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes

                If Storage_modules.AddStorage(tbox_storage_name.Text(), tbox_location.Text(), Convert.ToDecimal(tbox_capacity.Text)) Then
                    Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully added a storage! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If saveResultDialog = DialogResult.Yes Then
                        ResetFields()
                        tbox_storage_name.Focus()
                        Dim previousForm As Manage_storage = Application.OpenForms.OfType(Of Manage_storage)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            Datagridview_modules.DisplayStorage(previousForm.dgv_storage_list)
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

        If tbox_storage_name.Text = "" Then
            MessageBox.Show("Please enter storage name.", "Storage name is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_location.Text = "" Then
            MessageBox.Show("Please enter storage location.", "Storage location is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If

        If tbox_capacity.Text = "" Then
            MessageBox.Show("Please enter storage capacity.", "Storage capacity is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf IsNumeric(tbox_capacity.Text) = False Then
            MessageBox.Show("Please enter a valid capacity.", "Capacity is must be a number.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        ElseIf Convert.ToDecimal(tbox_capacity.Text) <= 0 Then
            MessageBox.Show("Please enter a capacity greater than Zero.", "Capacity must be a greater than zero.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid = False
        End If


        Return valid
    End Function

    Public Sub ResetFields()
        tbox_storage_name.Clear()
        tbox_location.Clear()
        tbox_capacity.Clear()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update storage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes            
                If Storage_modules.UpdateStorage(Me.ID, tbox_storage_name.Text(), tbox_location.Text(), Convert.ToDecimal(tbox_capacity.Text)) Then
                    MessageBox.Show("You have successfully updated storage!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE storage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If Storage_modules.DeleteStorage(Me.ID) Then
                MessageBox.Show("You have successfully deleted storage!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class