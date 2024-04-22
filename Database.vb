Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class Database
    Private conn As String

    ' Constructor
    Public Sub New()
        Dim server As String = ConfigurationManager.AppSettings("server")
        Dim port As String = ConfigurationManager.AppSettings("port")
        Dim dbname As String = ConfigurationManager.AppSettings("dbname")
        Dim user As String = ConfigurationManager.AppSettings("user")
        Dim password As String = ConfigurationManager.AppSettings("password")

        conn = "Server=" & server & ";Database=" & dbname & ";Uid=" & user & ";Pwd=" & password & ";"
    End Sub

    Public Function ConnectionString() As String
        Return conn
    End Function

End Class
