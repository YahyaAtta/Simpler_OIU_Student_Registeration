Imports System.Data
Imports System.Data.OleDb
Module connect
    Public con As String = "Provider=Microsoft.ACE.OleDb.12.0;" & "data source=" & Application.StartupPath & "\Student.accdb"
    Public dbcon As New OleDbConnection(con)
    Public SQL As String
    Public ds As New DataSet
End Module
