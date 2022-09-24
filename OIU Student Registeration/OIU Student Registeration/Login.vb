Imports System.Data
Imports System.Data.OleDb
Public Class Login

    Private Sub cmdLogin_Click(sender As Object, e As EventArgs) Handles cmdLogin.Click
        Dim wmp As New Media.SoundPlayer
        loginSQL = "SELECT * FROM login WHERE Username='" & txtName.Text & "' and password='" & txtPassword.Text & "'"
        Dim cmd As New OleDbCommand(loginSQL, dblogin)
        dblogin.Open()
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()
        If dr.Read() Then
            wmp.SoundLocation = Application.StartupPath & "\Windows XP Startup.wav"
            Dim Username As String = txtName.Text
            txtName.Text = ""
            txtPassword.Text = ""
            txtName.Focus()
            wmp.Play()
            Me.Hide()
            Loading.Show()
            Main.lblWelcome.Text = "Welcome" + " " + Username
        Else
            MsgBox("Wrong Username or Password", MsgBoxStyle.Critical)
        End If
        dr.Close()
        dblogin.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class