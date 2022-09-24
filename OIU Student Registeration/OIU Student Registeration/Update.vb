Imports System.Data
Imports System.Data.OleDb
Public Class SUpdate
 
    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub SUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If MessageBox.Show("Do You Want To Save Changes Current Record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
            cmdSave.Enabled = False
            cmdCancel.Enabled = False
        End If
        SQL = "UPDATE Student SET [Name]='" & txtName.Text & "', [College]='" & txtCollege.Text & "', [Level]='" & txtLevel.Text & "', [ID]=" & txtID.Text & ", [Fee]=" & txtFee.Text & ", [Phone]=" & txtPhone.Text & ", [Email]='" & txtEmail.Text & "' Where [ID]=" & txtID.Text & ""
        Dim change As New OleDbCommand(SQL, dbcon)
        dbcon.Open()
        change.ExecuteNonQuery()
        ds.Clear()
        Dim SQL1 As String = "Select * From Student"
        Dim ad As New OleDbDataAdapter(SQL1, dbcon)
        ad.Fill(ds, "Student")
        dbcon.Close()
        MsgBox("Update Successfully", MsgBoxStyle.Information)
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        txtName.ReadOnly = True
        txtCollege.ReadOnly = True
        txtLevel.ReadOnly = True
        txtID.ReadOnly = True
        txtFee.ReadOnly = True
        txtPhone.ReadOnly = True
        txtEmail.ReadOnly = True
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        txtName.ReadOnly = False
        txtCollege.ReadOnly = False
        txtLevel.ReadOnly = False
        txtID.ReadOnly = False
        txtFee.ReadOnly = False
        txtPhone.ReadOnly = False
        txtEmail.ReadOnly = False
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        txtName.ReadOnly = True
        txtCollege.ReadOnly = True
        txtLevel.ReadOnly = True
        txtID.ReadOnly = True
        txtFee.ReadOnly = True
        txtPhone.ReadOnly = True
        txtEmail.ReadOnly = True
    End Sub
End Class