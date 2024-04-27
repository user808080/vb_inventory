Imports MySql.Data.MySqlClient

Public Class Manage_employee
    Private Sub Manage_employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datagridview_modules.DisplayEmployee(dgv_employee_list)
    End Sub

    Private Sub dgv_employee_list_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_employee_list.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_employee_list.Rows.Count Then
            Dim selectedRow As DataGridViewRow = dgv_employee_list.Rows(e.RowIndex)
            Dim id = selectedRow.Cells(0).Value.ToString()

            Dim diagAddEmployee As New Add_employee_dialog(id)
            diagAddEmployee.ShowDialog()
            Datagridview_modules.DisplayEmployee(dgv_employee_list) 'reload the datagrid
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_add_employee.Click
        Dim dialogAddEmployee As New Add_employee_dialog()
        dialogAddEmployee.ShowDialog()
        Datagridview_modules.DisplayEmployee(dgv_employee_list)
    End Sub
End Class