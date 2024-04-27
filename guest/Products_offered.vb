Public Class Products_offered
    Private Sub Products_offered_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dataArray() As String = Rice_modules.GetTop3BestSeller()

        lbl_top1.Visible = False
        lbl_top2.Visible = False
        lbl_top3.Visible = False

        If dataArray(0) <> "x" Then
            lbl_top1.Text = dataArray(0)
            lbl_top1.Visible = True
        End If

        If dataArray(1) <> "x" Then
            lbl_top2.Text = dataArray(1)
            lbl_top2.Visible = True
        End If

        If dataArray(2) <> "x" Then
            lbl_top3.Text = dataArray(2)
            lbl_top3.Visible = True
        End If


        ShowRice()
    End Sub

    Public Sub ShowRice()
        If tbox_search_box.Text.Trim = "" Then
            Datagridview_modules.DisplayRice(dgv_rice_list)
        Else
            Datagridview_modules.DisplaySearchRice(dgv_rice_list, tbox_search_box.Text.Trim)
        End If
    End Sub

    Private Sub tbox_search_box_TextChanged(sender As Object, e As EventArgs) Handles tbox_search_box.TextChanged
        ShowRice()
    End Sub
End Class