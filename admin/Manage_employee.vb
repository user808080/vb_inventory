Imports MySql.Data.MySqlClient

Public Class Manage_employee
    Private Sub Manage_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim dataArray As List(Of String()) = Employee_modules.GetAllEmployee()
        'For Each arr As String() In dataArray
        '    'Dim employeeID As String
        '    'Dim firstName As String
        '    'Dim lastName As String
        '    'Dim contactNo As String

        '    'For Each item As String In arr

        '    'Next
        '    dgv_employee_list.Rows.Add(arr(0), arr(1), arr(2), arr(3))
        'Next

        Datagridview_modules.DisplayEmployee(dgv_employee_list)
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to add employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            btn_update.Enabled = False
            btn_delete.Enabled = False
            If Employee_modules.AddEmployee(tbox_employee_id.Text(), tbox_first_name.Text(), tbox_last_name.Text(), tbox_contact_no.Text()) Then
                Datagridview_modules.DisplayEmployee(dgv_employee_list)
                MessageBox.Show("You have successfully added an employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub dgv_employee_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_employee_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_employee_list.Rows.Count Then
            ' Get data from the double-clicked row
            Dim selectedRow As DataGridViewRow = dgv_employee_list.Rows(e.RowIndex)
            'Dim rowData As New List(Of String)

            'For Each cell As DataGridViewCell In selectedRow.Cells
            '    rowData.Add(cell.Value.ToString())

            'Next

            tbox_employee_id.Text = selectedRow.Cells(0).Value.ToString()
            tbox_first_name.Text = selectedRow.Cells(1).Value.ToString()
            tbox_last_name.Text = selectedRow.Cells(2).Value.ToString()
            tbox_contact_no.Text = selectedRow.Cells(3).Value.ToString()
            btn_update.Enabled = True
            btn_delete.Enabled = True
            ' Display the data (you can modify this part based on your requirement)
            'MessageBox.Show("Double-clicked row data: " & String.Join(", ", rowData))
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to update employee data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            btn_update.Enabled = False
            btn_delete.Enabled = False
            If Employee_modules.UpdateEmployee(tbox_employee_id.Text(), tbox_first_name.Text(), tbox_last_name.Text(), tbox_contact_no.Text()) Then
                Datagridview_modules.DisplayEmployee(dgv_employee_list)
                MessageBox.Show("You have successfully updated an employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim modal As New Home()
        modal.ShowDialog()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            btn_update.Enabled = False
            btn_delete.Enabled = False
            If Employee_modules.DeleteEmployee(tbox_employee_id.Text()) Then
                Datagridview_modules.DisplayEmployee(dgv_employee_list)
                MessageBox.Show("You have successfully deleted an employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub
End Class