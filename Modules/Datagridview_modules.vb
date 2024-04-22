Imports System.Windows.Forms
Module Datagridview_modules
    Public Sub DisplayEmployee(ByVal dgvName As DataGridView)
        Dim dataArray As List(Of String()) = Employee_modules.GetAllEmployee()
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3))
        Next
    End Sub
End Module
