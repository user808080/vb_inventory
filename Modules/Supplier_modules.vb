Imports MySql.Data.MySqlClient
Module Supplier_modules
    Dim db As New Database()
    Public Function GetAllSupplier() As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT id, supplier_name, contact_no, address, payment_terms FROM supplier WHERE 1"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("supplier_name").ToString(), reader("contact_no").ToString(), reader("address").ToString(), reader("payment_terms").ToString()}
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

    Public Function SearchSupplier(ByVal searchTerm As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                If searchTerm.Trim <> "" Then
                    With sqlCommand
                        .CommandText = "SELECT id, supplier_name, contact_no, address, payment_terms FROM supplier WHERE supplier_name LIKE @supplier_name OR address LIKE @address"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                        .Parameters.AddWithValue("@supplier_name", "%" & searchTerm & "%")
                        .Parameters.AddWithValue("@address", "%" & searchTerm & "%")
                    End With
                Else
                    With sqlCommand
                        .CommandText = "SELECT id, supplier_name, contact_no, address, payment_terms FROM supplier WHERE 1"
                        .Connection = SQLConnection
                        .CommandType = CommandType.Text
                    End With
                End If

                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("supplier_name").ToString(), reader("contact_no").ToString(), reader("address").ToString(), reader("payment_terms").ToString()}
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

    Public Function AddSupplier(ByVal supplierName As String, ByVal contactNo As String, ByVal address As String, ByVal paymentTerms As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO supplier (`supplier_name`, `contact_no`, `address`, `payment_terms`) values (@supplier_name, @contact_no, @address, @payment_terms)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@supplier_name", supplierName)
                    .Parameters.AddWithValue("@contact_no", contactNo)
                    .Parameters.AddWithValue("@address", address)
                    .Parameters.AddWithValue("@payment_terms", paymentTerms)
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

    Public Function GetSpecificSupplierById(ByVal id As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT id, supplier_name, contact_no, address, payment_terms FROM supplier WHERE id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("supplier_name").ToString(), reader("contact_no").ToString(), reader("address").ToString(), reader("payment_terms").ToString()}
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

    Public Function UpdateSupplier(ByVal id As String, ByVal supplierName As String, ByVal contactNo As String, ByVal address As String, ByVal paymentTerms As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE supplier SET `supplier_name` = @supplier_name, `contact_no` = @contact_no, `address` = @address, `payment_terms` = @payment_terms WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@supplier_name", supplierName)
                    .Parameters.AddWithValue("@contact_no", contactNo)
                    .Parameters.AddWithValue("@address", address)
                    .Parameters.AddWithValue("@payment_terms", paymentTerms)
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

    Public Function DeleteSupplier(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM supplier WHERE `id` = @id"
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

    Public Function AddProductsOffered(ByVal supplierID As String, ByVal riceID As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO products_offered (`supplier`, `rice`) values (@supplier, @rice)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@supplier", supplierID)
                    .Parameters.AddWithValue("@rice", riceID)
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

    Public Function GetAllProductsOfferedBySupplier(ByVal supplierID As String) As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT po.id, s.supplier_name, r.rice_name, rc.category_name FROM products_offered po INNER JOIN supplier s ON(s.id = po.supplier) INNER JOIN rice r ON(r.id = po.rice) INNER JOIN rice_category rc ON(rc.id = r.rice_category) WHERE po.supplier = @supplier_id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@supplier_id", supplierID)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("category_name").ToString(), reader("rice_name").ToString()}
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

    Public Function DeleteProductsOffered(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM products_offered WHERE `id` = @id"
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
