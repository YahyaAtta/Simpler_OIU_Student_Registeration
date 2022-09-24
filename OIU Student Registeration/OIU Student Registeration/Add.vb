Imports System.Data
Imports System.Data.OleDb
Public Class Add

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        txtName.Text = ""
        txtCollege.Text = ""
        txtLevel.Text = ""
        txtID.Text = ""
        txtFee.Text = ""
        txtPhone.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If txtName.Text = "" Or txtCollege.Text = "" Or txtLevel.Text = "" Or txtID.Text = "" Or txtFee.Text = "" Or txtFee.Text = "" Then
            Exit Sub
        End If
        SQL = "Insert into Student " & _
            "Values('" & txtName.Text & "','" & txtCollege.Text & "','" & txtLevel.Text & "','" & txtID.Text & "','" & txtFee.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "')"
        Dim savinto As New OleDbCommand(SQL, dbcon)
        dbcon.Open()
        savinto.ExecuteNonQuery()
        dbcon.Close()
        MsgBox("Added Successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
       