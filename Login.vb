Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim connectionString As String = "server=localhost;user id=bam_admin;password=budget2019;database=eps;"
        Dim connection As New MySqlConnection(connectionString)

        Try
            connection.Open()

            ' Connection opened successfully, perform database operations here
            MessageBox.Show("Connection Successful")

            connection.Close()
            Dim mdiAdmin As New MDI_admin()
            mdiAdmin.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try

    End Sub
End Class
