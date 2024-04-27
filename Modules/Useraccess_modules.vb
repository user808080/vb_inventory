Imports MySql.Data.MySqlClient

Module Useraccess_modules
    Dim db As New Database()
    Public Function LogIn(ByVal userType As String, ByVal userName As String, ByVal password As String) As Array
        Dim dataList As New List(Of String())
        Dim accountData() As String
        accountData = New String() {False, "name"}
        Dim myQuery As String

        Select Case userType
            Case "Admin"
                myQuery = "SELECT id, CONCAT(first_name, ' ', IF(middle_name != '' , CONCAT(LEFT(middle_name, 1), '.'), ''), ' ', last_name, IF(extension_name != '', extension_name, '')) AS full_name FROM admin WHERE username = @username AND password = @password AND status = @status"

            Case "Employee"
                myQuery = "SELECT id, CONCAT(first_name, ' ', IF(middle_name != '' , CONCAT(LEFT(middle_name, 1), '.'), ''), ' ', last_name, IF(extension_name != '', extension_name, '')) AS full_name FROM employee WHERE username = @username AND password = @password AND status = @status"
            Case "Guest"

                myQuery = "SELECT id, CONCAT(first_name, ' ', IF(middle_name != '' , CONCAT(LEFT(middle_name, 1), '.'), ''), ' ', last_name, IF(extension_name != '', extension_name, '')) AS full_name FROM employee WHERE username = @username AND password = @password AND status = @status"
            Case Else
                myQuery = "SELECT id, CONCAT(first_name, ' ', IF(middle_name != '' , CONCAT(LEFT(middle_name, 1), '.'), ''), ' ', last_name, IF(extension_name != '', extension_name, '')) AS full_name FROM employee WHERE username = @username AND password = @password AND status = @status"
        End Select

        Using SQLConnection As New MySqlConnection(db.ConnectionString())
            Using sqlCommand As New MySqlCommand()
                With sqlCommand
                    .CommandText = myQuery
                    .Connection = SQLConnection
                    .CommandType = CommandType.Text
                    .Parameters.AddWithValue("@username", userName)
                    .Parameters.AddWithValue("@password", password)
                    .Parameters.AddWithValue("@status", 1)
                End With
                Try
                    SQLConnection.Open()
                    Dim reader As MySqlDataReader = sqlCommand.ExecuteReader()

                    While reader.Read()
                        Dim data = New String() {reader("id").ToString(), reader("full_name").ToString()}
                        dataList.Add(data)
                        accountData = New String() {True, reader("full_name").ToString()}

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

        Return accountData
    End Function
End Module
