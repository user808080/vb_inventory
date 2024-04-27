Imports System.Windows.Forms
Module Datagridview_modules
    Public Sub DisplayEmployee(ByVal dgvName As DataGridView)
        Dim dataArray As List(Of String()) = Employee_modules.GetAllEmployee()
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6))
        Next
    End Sub

    Public Sub DisplayRice(ByVal dgvName As DataGridView)
        Dim dataArray As List(Of String()) = Rice_modules.GetAllRice()
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4))
        Next
    End Sub

    Public Sub DisplaySearchRice(ByVal dgvName As DataGridView, ByVal searchTerm As String)
        Dim dataArray As List(Of String()) = Rice_modules.SearchRice(searchTerm)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4))
        Next
    End Sub

    Public Sub DisplaySupplier(ByVal dgvName As DataGridView)
        Dim dataArray As List(Of String()) = Supplier_modules.GetAllSupplier()
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4))
        Next
    End Sub

    Public Sub DisplaySearchSupplier(ByVal dgvName As DataGridView, ByVal searchTerm As String)
        Dim dataArray As List(Of String()) = Supplier_modules.SearchSupplier(searchTerm)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1))
        Next
    End Sub

    Public Sub DisplaySupplierProductsOffered(ByVal dgvName As DataGridView, ByVal supplierID As String)
        Dim dataArray As List(Of String()) = Supplier_modules.GetAllProductsOfferedBySupplier(supplierID)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2))
        Next
    End Sub

    Public Sub DisplayStorage(ByVal dgvName As DataGridView)
        Dim dataArray As List(Of String()) = Storage_modules.GetAllStorage()
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3))
        Next
    End Sub

    Public Sub DisplaySearchStorage(ByVal dgvName As DataGridView, ByVal searchTerm As String)
        Dim dataArray As List(Of String()) = Storage_modules.SearchStorage(searchTerm)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(3))
        Next
    End Sub

    Public Sub DisplayStockIn(ByVal dgvName As DataGridView, ByVal searchTerm As String)
        Dim dataArray As List(Of String()) = StockIn_modules.GetAllStockIn(searchTerm)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(2), arr(4), arr(6), arr(7), arr(8))
        Next
    End Sub

    Public Sub DisplayStockOut(ByVal dgvName As DataGridView, ByVal searchTerm As String)
        Dim dataArray As List(Of String()) = StockOut_modules.GetAllStockOut(searchTerm)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(2), arr(4), arr(5))
        Next
    End Sub

    Public Sub DisplaySale(ByVal dgvName As DataGridView, ByVal searchTerm As String)
        Dim dataArray As List(Of String()) = Sales_modules.GetAllSale(searchTerm)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            '{reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("quantity_per_kilo").ToString(), reader("price").ToString()}
            dgvName.Rows.Add(arr(0), arr(2), arr(4), arr(5), arr(6))
        Next
    End Sub

    Public Sub DisplayRiceLedger(ByVal dgvName As DataGridView, ByVal transactionType As String, ByVal riceID As String)
        Dim dataArray As List(Of String()) = Report_rice_ledger_modules.GetRiceLedger(transactionType, riceID)
        dgvName.Rows.Clear()
        For Each arr As String() In dataArray
            dgvName.Rows.Add(arr(0), arr(1), arr(2), arr(3), arr(4), arr(5), arr(6))
        Next
    End Sub



End Module
