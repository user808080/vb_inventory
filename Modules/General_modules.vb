Module General_modules

    Public Function GetCurrentDirectory() As String
        Dim currentDirectory As String = Application.StartupPath
        Return currentDirectory
    End Function
End Module
