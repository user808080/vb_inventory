Imports MySql.Data.MySqlClient

Module Useraccess_modules
    Dim db As New Database()
    Public Function LogIn(ByVal userName As String, ByVal password As String) As List(Of String())
        Dim dataList As New List(Of String())
        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = "SELECT id FROM user_account WHERE username = @username AND password = @password"
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
End Module
