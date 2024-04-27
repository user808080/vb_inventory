Imports MySql.Data.MySqlClient

Module Employee_modules
    Dim db As New Database()
    Public Sub DisplaySampleMessage()
        MessageBox.Show("Hi There! This is a sample message.")
    End Sub

    Public Function AddEmployee(ByVal userName As String, ByVal password As String, ByVal employeeNo As String, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String, ByVal extensionName As String, ByVal contactNo As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO employee (`username`, `password`, `employee_number`, `first_name`, `middle_name`, `last_name`, `extension_name`, `contact_no`) values (@username, @password, @employee_no, @first_name, @middle_name, @last_name, @extension_name, @contact_no)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@username", userName)
                    .Parameters.AddWithValue("@password", password)
                    .Parameters.AddWithValue("@employee_no", employeeNo)
                    .Parameters.AddWithValue("@first_name", firstName)
                    .Parameters.AddWithValue("@middle_name", middleName)
                    .Parameters.AddWithValue("@last_name", lastName)
                    .Parameters.AddWithValue("@extension_name", extensionName)
                    .Parameters.AddWithValue("@contact_no", contactNo)
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

    Public Function GetAllEmployee() As List(Of String())

        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT * FROM employee WHERE 1"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("employee_number").ToString(), reader("first_name").ToString(), reader("middle_name").ToString(), reader("last_name").ToString(), reader("extension_name").ToString(), reader("contact_no").ToString()}
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

    Public Function UpdateEmployee(ByVal id As String, ByVal userName As String, ByVal password As String, ByVal employeeNumber As String, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String, ByVal extensionName As String, ByVal contactNo As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE employee SET `employee_number` = @employee_no, `username` = @username, `password` = @password, `first_name` = @first_name, `middle_name` = @middle_name, `last_name` = @last_name, `extension_name` = @extension_name, `contact_no`= @contact_no WHERE `id` = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                    .Parameters.AddWithValue("@username", userName)
                    .Parameters.AddWithValue("@password", password)
                    .Parameters.AddWithValue("@employee_no", employeeNumber)
                    .Parameters.AddWithValue("@first_name", firstName)
                    .Parameters.AddWithValue("@middle_name", middleName)
                    .Parameters.AddWithValue("@last_name", lastName)
                    .Parameters.AddWithValue("@extension_name", extensionName)
                    .Parameters.AddWithValue("@contact_no", contactNo)
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

    Public Function DeleteEmployee(ByVal id As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "DELETE FROM employee WHERE `id` = @id"
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

    Public Function GetSpecificEmployeeData(ByVal id As String) As List(Of String())
        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT * FROM employee WHERE id = @id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@id", id)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("username").ToString(), reader("password").ToString(), reader("employee_number").ToString(), reader("first_name").ToString(), reader("middle_name").ToString(), reader("last_name").ToString(), reader("extension_name").ToString(), reader("contact_no").ToString()}
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

End Module
