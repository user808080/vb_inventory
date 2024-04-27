Imports MySql.Data.MySqlClient
Module Storage_modules
    Dim db As New Database()

    Public Function AddStorage(ByVal storageName As String, ByVal location As String, ByVal capacity As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO storage (`storage_name`, `location`, `capacity`) values (@storage_name, @location, @capacity)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@storage_name", storageName)
                    .Parameters.AddWithValue("@location", location)
                    .Parameters.AddWithValue("@capacity", capacity)
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

    Public Function GetAllStorage() As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT id, storage_name, location, capacity FROM storage WHERE 1"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("storage_name").ToString(), reader("location").ToString(), reader("capacity").ToString()}
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

    Public Function SearchStorage(ByVal searchTerm As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If searchTerm.Trim <> "" Then
                    With sqlCommand
                        .CommandText = "SELECT id, storage_name, location, capacity FROM storage WHERE storage_name LIKE @storage_name OR location LIKE @location"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@location", "%" & searchTerm & "%")
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT id, storage_name, location, capacity FROM storage WHERE 1"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                    End With
                End If

                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("storage_name").ToString(), reader("location").ToString(), reader("capacity").ToString()}
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

    'Public Function SearchStorage(ByVal searchTerm As String) As List(Of String())

    '    Dim dataList As New List(Of String())
    '    Using SQLConnection As New MySqlConnection(db.ConnectionString())
    '        Using sqlCommand As New MySqlCommand()
    '            With sqlCommand
    '                .CommandText = "SELECT r.id, rc.category_name, r.rice_name, r.price, r.stock_level  FROM rice r INNER JOIN rice_category rc ON(rc.id = r.rice_category) WHERE r.rice_name LIKE @rice_name OR rc.category_name LIKE @category_name"
    '                .Connection = SQLConnection
    '                .CommandType = CommandType.Text
    '                .Parameters.AddWithValue("@rice_name", "%" & searchTerm & "%")
    '                .Parameters.AddWithValue("@category_name", "%" & searchTerm & "%")
    '            End With
    '            Try
    '                SQLConnection.Open()
    '                Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

    '                While reader.Read()
    '                    Dim data = New String() {reader("id").ToString(), reader("category_name").ToString(), reader("rice_name").ToString(), reader("price").ToString(), reader("stock_level").ToString()}
    '                    dataList.Add(data)
    '                End While

    '            Catch ex As MySqlException
    '                MessageBox.Show(ex.Message.ToString())
    '            Finally
    '                If SQLConnection.State = ConnectionState.Open Then
    '                    SQLConnection.Close()
    '                End If
    '            End Try
    '        End Using
    '    End Using
    '    Return dataList
    'End Function

    Public Function GetSpecificStorageById(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT id, storage_name, location, capacity FROM storage WHERE id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("storage_name").ToString(), reader("location").ToString(), reader("capacity").ToString()}
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

    Public Function UpdateStorage(ByVal id As String, ByVal storageName As String, ByVal location As String, ByVal capacity As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE storage SET `storage_name` = @storage_name, `location` = @location, `capacity` = @capacity WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@storage_name", storageName)
                    .Parameters.AddWithValue("@location", location)
                    .Parameters.AddWithValue("@capacity", capacity)
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

    Public Function DeleteStorage(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM storage WHERE `id` = @id"
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

    Public Function GetStorageCapacity(ByVal id As String) As Decimal

        Dim capacity As Decimal = 0
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT capacity FROM storage WHERE id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        capacity = Convert.ToDecimal(reader("capacity").ToString())
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
        Return capacity
    End Function

    Public Function GetStorageRemainingCapacity(ByVal storageID As String) As Decimal
        Dim remainingCapacity As Decimal
        Dim stockIn As Decimal
        Dim stockOut As Decimal
        Dim stockSale As Decimal
        Dim currentCapacity As Decimal

        currentCapacity = GetStorageCapacity(storageID)
        stockIn = GetStorageStockIn(storageID, "")
        stockOut = GetStorageStockOut(storageID, "")
        stockSale = GetStorageSale(storageID, "")

        remainingCapacity = (currentCapacity + stockOut + stockSale) - stockIn
        Return remainingCapacity
    End Function

    Public Function GetStorageCurrentStocks(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim currentStocks As Decimal
        Dim stockIn As Decimal
        Dim stockOut As Decimal
        Dim stockSale As Decimal

        stockIn = GetStorageStockIn(storageID, riceID) 'riceID can be empty to get all rice 
        stockOut = GetStorageStockOut(storageID, riceID) 'riceID can be empty to get all rice
        stockSale = GetStorageSale(storageID, riceID) 'riceID can be empty to get all rice

        currentStocks = stockIn - (stockOut + stockSale)
        Return currentStocks
    End Function

    Private Function GetStorageStockIn(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim stocks As Decimal
        stocks = 0.00
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If riceID = "" Then
                    With sqlCommand
                        .CommandText = "SELECT stock_per_kilo FROM stock_in WHERE storage = @storage"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage", storageID)
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

    Private Function GetStorageStockOut(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim stocks As Decimal
        stocks = 0.00
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If riceID = "" Then
                    With sqlCommand
                        .CommandText = "SELECT stock_per_kilo FROM stock_out WHERE storage = @storage"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage", storageID)
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

    Private Function GetStorageSale(ByVal storageID As String, ByVal riceID As String) As Decimal
        Dim stocks As Decimal
        stocks = 0.00
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If riceID = "" Then
                    With sqlCommand
                        .CommandText = "SELECT quantity_per_kilo FROM sale WHERE storage = @storage"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@storage", storageID)
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
End Module
