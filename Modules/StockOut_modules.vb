Imports MySql.Data.MySqlClient

Module StockOut_modules
    Dim db As New Database()
    Public Function GetAllStockOut(ByVal searchTerm As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If searchTerm.Trim <> "" Then
                    With sqlCommand
                        .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.stock_per_kilo FROM stock_out so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE r.rice_name LIKE @rice_name OR stg.storage_name LIKE @storage_name"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@rice_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@supplier_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@storage_name", "%" & searchTerm & "%")
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.stock_per_kilo FROM stock_out so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE 1"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                    End With
                End If

                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("stock_per_kilo").ToString()}
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

    Public Function AddStockOut(ByVal riceID As String, ByVal storageID As String, ByVal stockPerKG As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO stock_out (`rice`, `storage`, `stock_per_kilo`) values (@rice, @storage, @stock_per_kilo)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@rice", riceID)
                    .Parameters.AddWithValue("@storage", storageID)
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

    Public Function GetSpecificStockOutById(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.stock_per_kilo FROM stock_out so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE so.id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("stock_per_kilo").ToString()}
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

    Public Function GetSpecificStockOutByRiceID(ByVal riceID As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.stock_per_kilo FROM stock_out so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE so.rice = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", riceID)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("stock_per_kilo").ToString()}
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

    Public Function UpdateStockOut(ByVal id As String, ByVal riceID As String, ByVal storageID As String, ByVal stockPerKG As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE stock_out SET `rice` = @rice, `storage` = @storage, `stock_per_kilo` = @stock_per_kilo WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@rice", riceID)
                    .Parameters.AddWithValue("@storage", storageID)
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

    Public Function DeleteStockOut(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM stock_out WHERE `id` = @id"
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
