Public Class Report_rice_ledger
    Public riceID As String = ""
    Public riceName As String = ""
    Private Sub Report_rice_ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbox_transaction.SelectedIndex = 0
    End Sub

    Private Sub btn_select_rice_Click(sender As Object, e As EventArgs) Handles btn_select_rice.Click
        Dim dialogSearchRice As New Search_rice_dialog("rice_ledger")
        dialogSearchRice.ShowDialog()
        tbox_rice.Text = Me.riceName
        DisplayLedger()
    End Sub

    Private Sub btn_remove_rice_Click(sender As Object, e As EventArgs) Handles btn_remove_rice.Click
        Me.riceID = ""
        Me.riceName = ""
        tbox_rice.Clear()
    End Sub

    Public Sub DisplayLedger()
        If cbox_transaction.SelectedItem.ToString() <> "" And Me.riceID <> "" Then
            Datagridview_modules.DisplayRiceLedger(dgv_ledger, cbox_transaction.SelectedItem.ToString(), Me.riceID.ToString())
        Else
            dgv_ledger.Rows.Clear()
        End If
    End Sub

    Private Sub cbox_transaction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbox_transaction.SelectedIndexChanged
        DisplayLedger()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If cbox_transaction.SelectedItem.ToString() <> "" And Me.riceID <> "" Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to generate rice ledger to excel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim excel As New ExcelExport()
                excel.GenerateRiceLedger(General_modules.GetCurrentDirectory() & "\RiceLedger.xlsx", cbox_transaction.SelectedItem.ToString(), Me.riceID)
            End If
        Else
            MessageBox.Show("Please filter the data first.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class