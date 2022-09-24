Imports System.Data
Imports System.Data.OleDb
Module loginconnect
    Public logincon As String = "Provider=Microsoft.ACE.OleDb.12.0;" & "data source=" & Application.StartupPath & "\Login.accdb"
    Public dblogin As New OleDbConnection(logincon)
    Public loginSQL As String
End Module
