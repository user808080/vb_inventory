Imports MySql.Data.MySqlClient

Module Sales_modules
    Dim db As New Database()
    Public Function GetAllSale(ByVal searchTerm As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If searchTerm.Trim <> "" Then
                    With sqlCommand
                        .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.quantity_per_kilo, so.price, so.tender_amount FROM sale so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE r.rice_name LIKE @rice_name OR stg.storage_name LIKE @storage_name"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@rice_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@supplier_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@storage_name", "%" & searchTerm & "%")
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.quantity_per_kilo, so.price, so.tender_amount FROM sale so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE 1"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                    End With
                End If

                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("quantity_per_kilo").ToString(), reader("price").ToString(), reader("tender_amount").ToString()}
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

    Public Function AddSale(ByVal riceID As String, ByVal storageID As String, ByVal stockPerKG As Decimal, ByVal price As Decimal, ByVal tenderAmount As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO sale (`rice`, `storage`, `quantity_per_kilo`, `price`, `tender_amount`) values (@rice, @storage, @quantity_per_kilo, @price, @tender_amount)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@rice", riceID)
                    .Parameters.AddWithValue("@storage", storageID)
                    .Parameters.AddWithValue("@quantity_per_kilo", stockPerKG)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@tender_amount", tenderAmount)
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

    Public Function GetSpecificSaleById(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.quantity_per_kilo, so.price,so.tender_amount FROM sale so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE so.id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("quantity_per_kilo").ToString(), reader("price").ToString(), reader("tender_amount").ToString()}
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

    Public Function GetSpecificSaleByRiceID(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT so.id, so.rice, r.rice_name, so.storage, stg.storage_name, so.quantity_per_kilo, so.price,so.tender_amount FROM sale so INNER JOIN rice r ON(r.id = so.rice) INNER JOIN storage stg ON(stg.id = so.storage) WHERE so.rice = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("rice").ToString(), reader("rice_name").ToString(), reader("storage").ToString(), reader("storage_name").ToString(), reader("quantity_per_kilo").ToString(), reader("price").ToString(), reader("tender_amount").ToString()}
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

    Public Function GetTotalSaleOfRiceID(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT id, SUM(price * quantity_per_kilo) as total_sale, SUM(quantity_per_kilo) as total_kilo FROM sale WHERE rice = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        If reader("total_kilo").ToString() <> "" Then
                            Dim data = New String() {reader("id").ToString(), reader("total_sale").ToString(), reader("total_kilo").ToString()}
                            dataList.Add(data)
                        End If

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

    Public Function UpdateSale(ByVal id As String, ByVal riceID As String, ByVal storageID As String, ByVal stockPerKG As Decimal, ByVal price As Decimal, ByVal tenderAmount As Decimal) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE sale SET `rice` = @rice, `storage` = @storage, `quantity_per_kilo` = @quantity_per_kilo, `price` = @price, `tender_amount` = @tender_amount WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@rice", riceID)
                    .Parameters.AddWithValue("@storage", storageID)
                    .Parameters.AddWithValue("@quantity_per_kilo", stockPerKG)
                    .Parameters.AddWithValue("@price", price)
                    .Parameters.AddWithValue("@tender_amount", tenderAmount)
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

    Public Function DeleteSale(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM sale WHERE `id` = @id"
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
