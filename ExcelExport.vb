Imports Microsoft.Office.Interop

Public Class ExcelExport

    Public Sub GenerateRiceLedger(existingFilePath As String, ByVal transactionType As String, ByVal riceID As String)
        ' Create a new Excel application
        Dim excelApp As New Excel.Application()

        ' Open the existing workbook
        Dim workbook As Excel.Workbook = excelApp.Workbooks.Open(existingFilePath)

        ' Get the first worksheet in the workbook
        Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

        Dim startRow = 5
        ' Write data to Excel cells in the next available row
        Dim dataArray As List(Of String()) = Report_rice_ledger_modules.GetRiceLedger(transactionType, riceID)

        For Each arr As String() In dataArray

            worksheet.Cells(startRow, 1) = arr(1)
            worksheet.Cells(startRow, 2) = arr(2)
            worksheet.Cells(startRow, 3) = arr(3)
            worksheet.Cells(startRow, 4) = arr(4)
            worksheet.Cells(startRow, 5) = arr(5)
            worksheet.Cells(startRow, 6) = arr(6)
            startRow += 1
        Next

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx"
        saveFileDialog.FilterIndex = 2
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Save the workbook to the selected location
            workbook.SaveAs(saveFileDialog.FileName)
        End If

        ' Save the changes to the workbook
        'workbook.Save()

        ' Close the workbook and Excel application
        workbook.Close()
        excelApp.Quit()

        ' Release Excel objects from memory
        ReleaseComObject(worksheet)
        ReleaseComObject(workbook)
        ReleaseComObject(excelApp)
    End Sub

    Private Sub ReleaseComObject(obj As Object)
        If obj IsNot Nothing Then
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        End If
    End Sub

End Class
