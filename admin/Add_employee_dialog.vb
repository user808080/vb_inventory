Public Class Add_employee_dialog
    Private userName As String
    Private password As String
    Private employeeNo As String
    Private firstName As String
    Private middleName As String
    Private lastName As String
    Private extensionName As String
    Private contactNo As String
    Private dgv As DataGridView

    Private ID As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal dgv As DataGridView)
        InitializeComponent()
        Me.dgv = dgv
    End Sub

    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.ID = id

        Dim dataArray As List(Of String()) = Employee_modules.GetSpecificEmployeeData(Me.ID)
        For Each arr As String() In dataArray
            tbox_username.Text = arr(1)
            tbox_password.Text = arr(2)
            tbox_employee_no.Text = arr(3)
            tbox_first_name.Text = arr(4)
            tbox_middle_name.Text = arr(5)
            tbox_last_name.Text = arr(6)
            tbox_extension_name.Text = arr(7)
            tbox_contact_no.Text = arr(8)
        Next

        btn_add.Enabled = False
        btn_update.Enabled = True
        btn_delete.Enabled = True
    End Sub
    Public Sub New(ByVal userName As String, ByVal password As String, ByVal employeeNo As String, ByVal firstName As String, ByVal middleName As String, ByVal lastName As String, ByVal extensionName As String, ByVal contactNo As String)
        InitializeComponent()
        Me.userName = userName
        Me.password = password
        Me.employeeNo = employeeNo
        Me.firstName = firstName
        Me.middleName = middleName
        Me.lastName = lastName
        Me.extensionName = extensionName
        Me.contactNo = contactNo
    End Sub


    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to add employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' User clicked Yes
                btn_update.Enabled = False
                btn_delete.Enabled = False
                If Employee_modules.AddEmployee(tbox_username.Text.Trim, tbox_password.Text.Trim, tbox_employee_no.Text.Trim, tbox_first_name.Text.Trim, tbox_middle_name.Text.Trim, tbox_last_name.Text.Trim, tbox_extension_name.Text.Trim, tbox_contact_no.Text.Trim) Then
                    'Datagridview_modules.DisplayEmployee(Me.dgv)

                    Dim saveResultDialog As DialogResult = MessageBox.Show("You have successfully added an employee! Do you want to add more?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If saveResultDialog = DialogResult.Yes Then
                        ResetFields()
                        tbox_username.Focus()
                        Dim previousForm As Manage_employee = Application.OpenForms.OfType(Of Manage_employee)().FirstOrDefault()
                        If previousForm IsNot Nothing Then
                            Datagridview_modules.DisplayEmployee(previousForm.dgv_employee_list)
                        End If
                    Else
                        Me.Close()
                    End If

                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        Dim valid = PassValidate()
        If valid Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to update employee data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                If Employee_modules.UpdateEmployee(Me.ID, tbox_username.Text(), tbox_password.Text(), tbox_employee_no.Text(), tbox_first_name.Text(), tbox_middle_name.Text(), tbox_last_name.Text(), tbox_extension_name.Text(), tbox_contact_no.Text()) Then
                    MessageBox.Show("You have successfully updated an employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to DELETE employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' User clicked Yes
            btn_update.Enabled = False
            btn_delete.Enabled = False
            If Employee_modules.DeleteEmployee(Me.ID) Then
                MessageBox.Show("You have successfully deleted an employee!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("There's seem to be a problem with the data.", "Cannot Proceed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Function PassValidate() As Boolean
        Dim valid = True

        If tbox_username.Text = "" Then
            valid = False
            MessageBox.Show("Please enter a username.", "Username is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid
        End If

        If tbox_password.Text.Trim = "" Then
            valid = False
            MessageBox.Show("Please enter a password.", "Password is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid
        End If

        If tbox_employee_no.Text.Trim = "" Then
            valid = False
            MessageBox.Show("Please enter an employee number.", "Employee number is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid
        End If

        If tbox_first_name.Text.Trim = "" Then
            valid = False
            MessageBox.Show("Please enter a firstname.", "Firstname is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid
        End If

        If tbox_last_name.Text.Trim = "" Then
            valid = False
            MessageBox.Show("Please enter a lastname.", "Lastname is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid
        End If

        If tbox_contact_no.Text.Trim = "" Then
            valid = False
            MessageBox.Show("Please enter a contact number.", "Contact number is required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return valid
        Else
            If IsNumeric(tbox_contact_no.Text.Trim) = False Then
                valid = False
                MessageBox.Show("Please enter a valid contact number.", "Contact number must be a number(s)", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return valid
            End If
        End If

        Return valid
    End Function

    Public Sub ResetFields()
        tbox_username.Clear()
        tbox_password.Clear()
        tbox_employee_no.Clear()
        tbox_first_name.Clear()
        tbox_middle_name.Clear()
        tbox_last_name.Clear()
        tbox_extension_name.Clear()
        tbox_contact_no.Clear()
    End Sub

    Private Sub Add_employee_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class