Imports MySql.Data.MySqlClient

Module Employee_modules
    Dim db As New Database()
    Public Sub DisplaySampleMessage()
        MessageBox.Show("Hi There! This is a sample message.")
    End Sub

    Public Function AddEmployee(ByVal employeeId As String, ByVal firstName As String, ByVal lastName As String, ByVal contactNo As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "INSERT INTO employee (`employee_id`, `first_name`, `last_name`, `contact_no`) values (@employee_id,@first_name,@last_name,@contact_no)"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@employee_id", employeeId)
                    .Parameters.AddWithValue("@first_name", firstName)
                    .Parameters.AddWithValue("@last_name", lastName)
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
                        Dim data = New String() {reader("employee_id").ToString(), reader("first_name").ToString(), reader("last_name").ToString(), reader("contact_no").ToString()}
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

    Public Function UpdateEmployee(ByVal employeeId As String, ByVal firstName As String, ByVal lastName As String, ByVal contactNo As String) As Boolean
        Dim iReturn As Boolean
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "UPDATE employee SET `first_name` = @first_name, `last_name` = @last_name, `contact_no`= @contact_no WHERE `employee_id` = @employee_id"
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@employee_id", employeeId)
                    .Parameters.AddWithValue("@first_name", firstName)
                    .Parameters.AddWithValue("@last_name", lastName)
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

End Module
