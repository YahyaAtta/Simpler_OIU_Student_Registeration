Imports System.Data
Imports System.Data.OleDb
Public Class Delete

    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Do You Want To Delete Current Record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If
        SQL = "Delete from Student Where ID=" & txtID.Text & ""
        Dim delete As New OleDbCommand(SQL, dbcon)
        dbcon.Open()
        delete.ExecuteNonQuery()
        ds.Clear()
        Dim SQL1 As String = "Select * from Student"
        Dim ad1 As New OleDbDataAdapter(SQL1, dbcon)
        ad1.Fill(ds, "Student")
        dbcon.Close()
        MsgBox("Delete Successfully", MsgBoxStyle.Information)
    End Sub

    Private Sub Delete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ds.Reset()
        SQL = "Select * from Student"
        dbcon.Open()
        Dim ap1 As New OleDbDataAdapter(SQL, dbcon)
        ap1.Fill(ds, "Student")
        dbcon.Close()
        txtName.DataBindings.Add("text", ds, "Student.Name")
        txtCollege.DataBindings.Add("text", ds, "Student.College")
        txtLevel.DataBindings.Add("text", ds, "Student.Level")
        txtID.DataBindings.Add("text", ds, "Student.ID")
        txtFee.DataBindings.Add("text", ds, "Student.Fee")
        txtPhone.DataBindings.Add("text", ds, "Student.Phone")
        txtEmail.DataBindings.Add("text", ds, "Student.Email")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Student"
    End Sub
End Class