Imports MySql.Data.MySqlClient
Module Rice_modules
    Dim db As New Database()
    Public Function GetAllRiceCategory() As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT * FROM rice_category WHERE 1"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("category_name").ToString()}
                        dataList.Add(data)
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return dataList
    End Function

    Public Function AddRice(ByVal riceCategory As Integer, ByVal riceName As String, ByVal price As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO rice (`rice_category`, `rice_name`, `price`, `stock_level`) values (@rice_category, @rice_name, @price, @stock_level)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@rice_category", riceCategory)
                    .Parameters.AddWithValue("@rice_name", riceName)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@stock_level", 0)
                End With
                Try
                    SQLConnection.Open()
                    sqlCommand.ExecuteNonQuery()

                    iReturn = True
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                    iReturn = False
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using

        Return iReturn
    End Function

    Public Function GetAllRice() As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT r.id, rc.category_name, r.rice_name, r.price, r.stock_level  FROM rice r INNER JOIN rice_category rc ON(rc.id = r.rice_category) WHERE 1"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("category_name").ToString(), reader("rice_name").ToString(), reader("price").ToString(), reader("stock_level").ToString()}
                        dataList.Add(data)
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return dataList
    End Function

    Public Function SearchRice(ByVal searchTerm As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT r.id, rc.category_name, r.rice_name, r.price, r.stock_level  FROM rice r INNER JOIN rice_category rc ON(rc.id = r.rice_category) WHERE r.rice_name LIKE @rice_name OR rc.category_name LIKE @category_name"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@rice_name", "%" & searchTerm & "%")
                    .Parameters.AddWithValue("@category_name", "%" & searchTerm & "%")
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("category_name").ToString(), reader("rice_name").ToString(), reader("price").ToString(), reader("stock_level").ToString()}
                        dataList.Add(data)
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return dataList
    End Function

    Public Function GetSpecificRiceById(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT r.id, rc.category_name, r.rice_name, r.price, r.stock_level, r.rice_category  FROM rice r INNER JOIN rice_category rc ON(rc.id = r.rice_category) WHERE r.id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice_category").ToString(), reader("category_name").ToString(), reader("rice_name").ToString(), reader("price").ToString(), reader("stock_level").ToString()}
                        dataList.Add(data)
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return dataList
    End Function

    Public Function UpdateRice(ByVal id As String, ByVal riceCategory As String, ByVal riceName As String, ByVal price As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE rice SET `rice_category` = @rice_category, `rice_name` = @rice_name, `price` = @price WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@rice_category", riceCategory)
                    .Parameters.AddWithValue("@rice_name", riceName)
                    .Parameters.AddWithValue("@price", price)
                End With
                Try
                    SQLConnection.Open()
                    sqlCommand.ExecuteNonQuery()

                    iReturn = True
                Catch ex As MySqlException

                    iReturn = False
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using

        Return iReturn
    End Function

    Public Function DeleteRice(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM rice WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    sqlCommand.ExecuteNonQuery()

                    iReturn = True
                Catch ex As MySqlException

                    iReturn = False
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using

        Return iReturn
    End Function

    Public Function UpdateStockLevel(ByVal id As String, ByVal stockLevel As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE rice SET `stock_level` = @stock_level WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@stock_level", stockLevel)
                End With
                Try
                    SQLConnection.Open()
                    sqlCommand.ExecuteNonQuery()

                    iReturn = True
                Catch ex As MySqlException

                    iReturn = False
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using

        Return iReturn
    End Function


    Public Function GetRiceCurrentStocks(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim currentStocks As Decimal
        Dim stockIn As Decimal
        Dim stockOut As Decimal
        Dim stockSale As Decimal

        stockIn = GetRiceStockIn(storageID, riceID) 'storageID can be empty to get all rice 
        stockOut = GetRiceStockOut(storageID, riceID) 'storageID can be empty to get all rice
        stockSale = GetRiceSale(storageID, riceID) 'storageID can be empty to get all rice

        currentStocks = stockIn - (stockOut + stockSale)
        Return currentStocks
    End Function

    Private Function GetRiceStockIn(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim stocks As Decimal
        stocks = 0.00
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If storageID = "" Then
                    With sqlCommand
                        .CommandText = "SELECT stock_per_kilo FROM stock_in WHERE rice = @rice"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@rice", riceID)
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT stock_per_kilo FROM stock_in WHERE storage = @storage AND rice = @rice"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage", storageID)
                        .Parameters.AddWithValue("@rice", riceID)
                    End With
                End If

                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        stocks += Convert.ToDecimal(reader("stock_per_kilo").ToString())
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return stocks
    End Function

    Private Function GetRiceStockOut(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim stocks As Decimal
        stocks = 0.00
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If storageID = "" Then
                    With sqlCommand
                        .CommandText = "SELECT stock_per_kilo FROM stock_out WHERE rice = @rice"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@rice", riceID)
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT stock_per_kilo FROM stock_out WHERE storage = @storage AND rice = @rice"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage", storageID)
                        .Parameters.AddWithValue("@rice", riceID)
                    End With
                End If
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        stocks += Convert.ToDecimal(reader("stock_per_kilo").ToString())
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return stocks
    End Function

    Private Function GetRiceSale(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim stocks As Decimal
        stocks = 0.00
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If storageID = "" Then
                    With sqlCommand
                        .CommandText = "SELECT quantity_per_kilo FROM sale WHERE rice = @rice"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@rice", riceID)
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT quantity_per_kilo FROM sale WHERE storage = @storage AND rice = @rice"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage", storageID)
                        .Parameters.AddWithValue("@rice", riceID)
                    End With
                End If
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        stocks += Convert.ToDecimal(reader("quantity_per_kilo").ToString())
                    End While

                Catch ex As MySqlException
                    MessageBox.Show(ex.Message.ToString())
                Finally
                    If SQLConnection.State = ConnectionState.Open Then
                        SQLConnection.Close()
                    End If
                End Try
            End Using
        End Using
        Return stocks
    End Function

    Public Function GetTop3BestSeller() As String()

        Dim topSellerName() As String = {"x", "x", "x"}
        Dim topSellerItem() As Decimal = {0, 0, 0}

        Dim dataArray As List(Of String()) = GetAllRice()
        For Each arr As String() In dataArray
            Dim riceID As String = arr(0)

            If Sales_modules.GetTotalSaleOfRiceID(riceID).Count.ToString > 0 Then
                Dim totalSale = Sales_modules.GetTotalSaleOfRiceID(riceID)(0)(2) 'get the total salestock of rice by rice ID
                If totalSale > topSellerItem(0) Then
                    topSellerName(0) = "1. " & arr(2) & " with total salestock: " & totalSale & " kilogram(s)"
                    topSellerItem(0) = totalSale
                ElseIf totalSale > topSellerItem(1) Then
                    topSellerName(1) = "2. " & arr(2) & " with total salestock: " & totalSale & " kilogram(s)"
                    topSellerItem(1) = totalSale
                ElseIf totalSale > topSellerItem(2) Then
                    topSellerName(2) = "3. " & arr(2) & " with total salestock: " & totalSale & " kilogram(s)"
                    topSellerItem(2) = totalSale
                End If

            End If

        Next


        Return topSellerName
    End Function
End Module

