Imports MySql.Data.MySqlClient

Module StockIn_modules
    Dim db As New Database()
    Public Function GetAllStockIn(ByVal searchTerm As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If searchTerm.Trim <> "" Then
                    With sqlCommand
                        .CommandText = "SELECT si.id, si.rice, r.rice_name, si.supplier, s.supplier_name, si.storage, stg.storage_name, si.cost_per_kilo, si.stock_per_kilo FROM stock_in si INNER JOIN rice r ON(r.id = si.rice) INNER JOIN supplier s ON(s.id = si.supplier) INNER JOIN storage stg ON(stg.id = si.storage) WHERE r.rice_name LIKE @rice_name OR stg.storage_name LIKE @storage_name OR s.supplier_name LIKE @supplier_name"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@rice_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@supplier_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@storage_name", "%" & searchTerm & "%")
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT si.id, si.rice, r.rice_name, si.supplier, s.supplier_name, si.storage, stg.storage_name, si.cost_per_kilo, si.stock_per_kilo FROM stock_in si INNER JOIN rice r ON(r.id = si.rice) INNER JOIN supplier s ON(s.id = si.supplier) INNER JOIN storage stg ON(stg.id = si.storage) WHERE 1"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                    End With
                End If

                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("supplier").ToString(), reader("supplier_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("cost_per_kilo").ToString(), reader("stock_per_kilo").ToString()}
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

    Public Function AddStockIn(ByVal riceID As String, ByVal supplierID As String, ByVal storageID As String, ByVal costPerKG As Decimal, ByVal stockPerKG As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO stock_in (`rice`, `supplier`, `storage`, `cost_per_kilo`, `stock_per_kilo`) values (@rice, @supplier, @storage, @cost_per_kilo, @stock_per_kilo)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@rice", riceID)
                    .Parameters.AddWithValue("@supplier", supplierID)
                    .Parameters.AddWithValue("@storage", storageID)
                    .Parameters.AddWithValue("@cost_per_kilo", costPerKG)
                    .Parameters.AddWithValue("@stock_per_kilo", stockPerKG)
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

    Public Function GetSpecificStockInById(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT si.id, si.rice, r.rice_name, si.supplier, s.supplier_name, si.storage, stg.storage_name, si.cost_per_kilo, si.stock_per_kilo FROM stock_in si INNER JOIN rice r ON(r.id = si.rice) INNER JOIN supplier s ON(s.id = si.supplier) INNER JOIN storage stg ON(stg.id = si.storage) WHERE si.id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("supplier").ToString(), reader("supplier_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("cost_per_kilo").ToString(), reader("stock_per_kilo").ToString()}
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

    Public Function GetSpecificStockInByRiceID(ByVal riceID As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT si.id, si.rice, r.rice_name, si.supplier, s.supplier_name, si.storage, stg.storage_name, si.cost_per_kilo, si.stock_per_kilo FROM stock_in si INNER JOIN rice r ON(r.id = si.rice) INNER JOIN supplier s ON(s.id = si.supplier) INNER JOIN storage stg ON(stg.id = si.storage) WHERE si.rice = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", riceID)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("supplier").ToString(), reader("supplier_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("cost_per_kilo").ToString(), reader("stock_per_kilo").ToString()}
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

    Public Function UpdateStockIn(ByVal id As String, ByVal riceID As String, ByVal supplierID As String, ByVal storageID As String, ByVal costPerKG As Decimal, ByVal stockPerKG As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE stock_in SET `rice` = @rice, `supplier` = @supplier, `storage` = @storage, `cost_per_kilo` = @cost_per_kilo, `stock_per_kilo` = @stock_per_kilo WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@rice", riceID)
                    .Parameters.AddWithValue("@supplier", supplierID)
                    .Parameters.AddWithValue("@storage", storageID)
                    .Parameters.AddWithValue("@cost_per_kilo", costPerKG)
                    .Parameters.AddWithValue("@stock_per_kilo", stockPerKG)
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

    Public Function DeleteStockIn(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM stock_in WHERE `id` = @id"
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

End Module
