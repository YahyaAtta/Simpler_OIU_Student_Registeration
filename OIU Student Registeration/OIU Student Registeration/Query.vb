Imports System.Data
Imports System.Data.OleDb
Public Class Query
   
    Private Sub cmdback_Click(sender As Object, e As EventArgs) Handles cmdback.Click
        Me.Close()
        Main.Show()
    End Sub
    Public Sub ChangePosition()
        lblprogress.Text = "Record " & Me.BindingContext(ds, "Student").Position & " From " & Me.BindingContext(ds, "Student").Count - 1
    End Sub
    Private Sub Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ChangePosition()
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        Me.BindingContext(ds, "Student").Position = 0
        ChangePosition()
    End Sub

    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
        Me.BindingContext(ds, "Student").Position += 1
        ChangePosition()
    End Sub

    Private Sub cmdPrev_Click(sender As Object, e As EventArgs) Handles cmdPrev.Click
        Me.BindingContext(ds, "Student").Position -= 1
        ChangePosition()
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        Me.BindingContext(ds, "Student").Position = Me.BindingContext(ds, "Student").Count - 1
        ChangePosition()
    End Sub
End Class