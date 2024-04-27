Imports MySql.Data.MySqlClient
Module Report_rice_ledger_modules
    Dim db As New Database()

    Public Function GetRiceLedger(ByVal transaction As String, ByVal riceID As String) As List(Of String())
        Dim dataList As New List(Of String())

        Select Case transaction
            Case "Stock-In"
                Dim totalDebit As Decimal = 0
                Dim totalCredit As Decimal = 0
                Dim totalCost As Decimal = 0

                Dim balance As Decimal = 0
                Dim stockData As List(Of String()) = StockIn_modules.GetSpecificStockInByRiceID(riceID)
                '{reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("supplier").ToString(), reader("supplier_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("cost_per_kilo").ToString(), reader("stock_per_kilo").ToString()}
                For Each arr As String() In stockData

                    Dim cost As Decimal = Convert.ToDecimal(arr(7)) * Convert.ToDecimal(arr(8))
                    balance += Convert.ToDecimal(arr(8))
                    totalCost += cost
                    totalDebit += Convert.ToDecimal(arr(8))
                    totalCredit += 0

                    'id, ricename, transaction type, cost/amount, debit, credit, balance
                    Dim data = New String() {arr(0), arr(2), "Stock-In", cost, arr(8), "", balance}
                    dataList.Add(data)
                Next

                Dim gdata = New String() {"GRAND TOTAL", "", "", totalCost, totalDebit, "", balance}
                dataList.Add(gdata)

            Case "Stock-Out"
                Dim totalDebit As Decimal = 0
                Dim totalCredit As Decimal = 0
                Dim totalCost As Decimal = 0

                Dim balance As Decimal = 0
                Dim stockData As List(Of String()) = StockOut_modules.GetSpecificStockOutByRiceID(riceID)
                'Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("stock_per_kilo").ToString()}
                For Each arr As String() In stockData

                    Dim cost As Decimal = 0
                    balance += Convert.ToDecimal(arr(5))
                    totalCost += cost
                    totalDebit += 0
                    totalCredit += Convert.ToDecimal(arr(5))

                    'id, ricename, transaction type, cost/amount, debit, credit, balance
                    Dim data = New String() {arr(0), arr(2), "Stock-Out", "", "", arr(5), balance}
                    dataList.Add(data)
                Next

                Dim gdata = New String() {"GRAND TOTAL", "", "", "", "", totalCredit, balance}
                dataList.Add(gdata)

            Case "Sales"

                Dim totalDebit As Decimal = 0
                Dim totalCredit As Decimal = 0
                Dim totalCost As Decimal = 0

                Dim balance As Decimal = 0
                Dim stockData As List(Of String()) = Sales_modules.GetSpecificSaleByRiceID(riceID)
                '{reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("quantity_per_kilo").ToString(), reader("price").ToString(), reader("tender_amount").ToString()}
                For Each arr As String() In stockData

                    Dim cost As Decimal = Convert.ToDecimal(arr(6)) * Convert.ToDecimal(arr(7))
                    balance += Convert.ToDecimal(arr(6))
                    totalCost += cost
                    totalDebit += 0
                    totalCredit += Convert.ToDecimal(arr(6))

                    'id, ricename, transaction type, cost/amount, debit, credit, balance
                    Dim data = New String() {arr(0), arr(2), "Sales", cost, "", arr(6), balance}
                    dataList.Add(data)
                Next

                Dim gdata = New String() {"GRAND TOTAL", "", "", totalCost, "", totalCredit, balance}
                dataList.Add(gdata)

            Case Else
        End Select

        Return dataList
    End Function

End Module
