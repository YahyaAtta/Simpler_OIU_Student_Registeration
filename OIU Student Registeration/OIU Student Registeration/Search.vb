Imports System.Data
Imports System.Data.OleDb
Public Class Search
    Dim SQL1 As String
    Dim m As New Main
    Public Sub GeneralSearch()
        If RdName.Checked = True Then
            SQL = "Select * from Student Where Name like'%" & TextBox1.Text & "%'"
        ElseIf RdPhone.Checked = True Then
            SQL = "Select * from Student Where Phone like%" & TextBox1.Text & "%"
        ElseIf RdID.Checked = True Then
            SQL = "Select * from Student Where ID like%" & TextBox1.Text & "%"
        End If
    End Sub
    Public Sub ExactSearch()
        If RdName.Checked = True Then
            SQL = "Select * from Student Where Name='" & TextBox1.Text & "'"
        ElseIf RdPhone.Checked = True Then
            SQL = "Select * from Student Where Phone=" & TextBox1.Text & ""
        ElseIf RdID.Checked = True Then
            SQL = "Select * from Student Where ID=" & TextBox1.Text & ""
        End If
    End Sub
    Private Sub cmdBack_Click(sender As Object, e As EventArgs) Handles cmdBack.Click
        Me.Close()
        m.Show()
    End Sub

    Private Sub Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        RdName.Checked = True
        RdGeneral.Checked = True
        Me.CenterToScreen()
        ds.Reset()
    End Sub

    Private Sub cmdNew_Click(sender As Object, e As EventArgs) Handles cmdNew.Click
        ds.Reset()
        cmdNew.Enabled = False
        cmdSearch.Enabled = True
        Dim s As New Search
        Me.Close()
        s.Show()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        If TextBox1.Text = "" Then
            MsgBox("No Information Has Entered", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If RdExact.Checked = True Then
            ExactSearch()
            SQL1 = SQL
        ElseIf RdGeneral.Checked = True Then
            GeneralSearch()
            SQL1 = SQL
        End If
        dbcon.Open()
        Dim ad1 As New OleDbDataAdapter(SQL, dbcon)
        ad1.Fill(ds, "Student")
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
        cmdSearch.Enabled = False
        cmdNew.Enabled = True
        If Me.BindingContext(ds, "Student").Count = 0 Then
            MsgBox("No Result", MsgBoxStyle.Critical)
            Exit Sub
        End If
        cmdChange.Enabled = True
        cmdDelete.Enabled = True
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MessageBox.Show("Do You Want To Save Changes Current Record?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            Exit Sub
            cmdSave.Enabled = False
            cmdCancel.Enabled = False
        End If
        SQL = "Delete from Student Where ID=" & txtID.Text & ""
        Dim delete As New OleDbCommand(SQL, dbcon)
        dbcon.Open()
        delete.ExecuteNonQuery()
        ds.Clear()
        Dim ad2 As New OleDbDataAdapter(SQL1, dbcon)
        ad2.Fill(ds, "Student")
        dbcon.Close()
        MsgBox("Delete Successfully", MsgBoxStyle.Information)
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
        Dim s As New OleDbDataAdapter(SQL1, dbcon)
        s.Fill(ds, "Student")
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

    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
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
End Class