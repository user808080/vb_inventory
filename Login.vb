Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If ValidateLogIn() Then
            Dim logIn = Useraccess_modules.LogIn(cbox_user_type.SelectedItem.ToString(), tbox_username.Text, tbox_password.Text)

            If logIn(0) Then
                MessageBox.Show("Log In Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Select Case cbox_user_type.SelectedItem.ToString()
                    Case "Admin"
                        Dim mainForm As New MDI_admin()
                        Me.Hide()
                        mainForm.Show()

                    Case "Employee"
                        Dim mainForm As New MDI_admin()
                        Me.Hide()
                        mainForm.Show()
                    Case Else
                End Select
            Else
                MessageBox.Show("Account not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        'Dim connectionString As String = "server=localhost;user id=bam_admin;password=budget2019;database=eps;"
        'Dim connection As New MySqlConnection(connectionString)
        'MessageBox.Show(cbox_user_type.SelectedItem.ToString())
        'Try
        '    connection.Open()

        '    ' Connection opened successfully, perform database operations here
        '    MessageBox.Show("Connection Successful")

        '    connection.Close()
        '    Dim mdiAdmin As New MDI_admin()
        '    mdiAdmin.Show()
        '    Me.Hide()
        'Catch ex As Exception
        '    MessageBox.Show("Error: " & ex.Message)
        'Finally
        '    If connection.State = ConnectionState.Open Then
        '        connection.Close()
        '    End If
        'End Try

    End Sub

    Private Function ValidateLogIn() As Boolean
        Dim valid = True

        If tbox_username.Text = "" Then
            valid = False
            MessageBox.Show("Please enter a username.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        If tbox_password.Text = "" Then
            valid = False
            MessageBox.Show("Please enter a password.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        Return valid
    End Function

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to EXIT?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            Application.Exit()
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_user_type.SelectedIndex = 0
    End Sub
End Class
