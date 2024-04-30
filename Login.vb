Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If cbox_user_type.SelectedItem.ToString() <> "Guest" Then
            If ValidateLogIn() Then
                Dim logIn = Useraccess_modules.LogIn(cbox_user_type.SelectedItem.ToString(), tbox_username.Text, tbox_password.Text)

                If logIn(0) Then
                    MessageBox.Show("Log In Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Select Case cbox_user_type.SelectedItem.ToString()
                        Case "Admin"
                            Dim mainForm As New MDI_admin(logIn(1))
                            Me.Hide()
                            mainForm.Show()

                        Case "Employee"
                            Dim mainForm As New MDI_employee(logIn(1))
                            Me.Hide()
                            mainForm.Show()

                        Case "Guest"
                            Dim mainForm As New MDI_guest()
                            Me.Hide()
                            mainForm.Show()
                        Case Else
                    End Select
                Else
                    MessageBox.Show("Account not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            Dim mainForm As New MDI_guest()
            Me.Hide()
            mainForm.Show()
        End If

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
        cbox_user_type.SelectedIndex = 0S
    End Sub

    Private Sub cbox_user_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_user_type.SelectedIndexChanged
        If cbox_user_type.SelectedItem.ToString() = "Guest" Then
            SwitchUser(True)
        Else
            SwitchUser(False)
        End If
    End Sub

    Public Sub SwitchUser(ByVal typeGuest As Boolean)
        If typeGuest Then
            tbox_username.Enabled = False
            tbox_password.Enabled = False
            btn_login.Text = "Proceed"
        Else
            tbox_username.Enabled = True
            tbox_password.Enabled = True
            btn_login.Text = "Log In"
        End If

    End Sub
End Class
