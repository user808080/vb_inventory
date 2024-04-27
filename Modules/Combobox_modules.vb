Imports System.Windows.Forms
Module Combobox_modules
    Public Sub LoadRiceCategory(ByVal cbox_name As ComboBox)
        Dim dataArray As List(Of String()) = Rice_modules.GetAllRiceCategory()
        cbox_name.Items.Clear()
        For Each arr As String() In dataArray
            cbox_name.Items.Add(arr(0) & "-" & arr(1))
        Next
        cbox_name.SelectedIndex = 0
    End Sub

    Public Function SetSelectedItem(ByVal cbox_name As ComboBox, ByVal strCompare As String) As Integer
        Dim index As Integer
        For i As Integer = 0 To cbox_name.Items.Count - 1
            ' Check if the current item's text matches the search string
            If cbox_name.Items(i).ToString() = strCompare Then
                ' If found, set the selectedIndex and exit the loop
                cbox_name.SelectedIndex = i
                index = i
                Exit For
            End If
        Next
        Return index
    End Function
End Module
