Public Class Logging_out
    Dim i As Integer
    Private Sub Logging_out_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CircularProgressBar1.ResetText()
        CircularProgressBar1.Text = 0
        Dim wmp2 As New Media.SoundPlayer
        wmp2.SoundLocation = Application.StartupPath & "\Windows XP Logoff Sound.wav"
        wmp2.Play()
        logout.Start()
        i = 0
        CircularProgressBar1.Maximum = 100
    End Sub

    Private Sub logout_Tick(sender As Object, e As EventArgs) Handles logout.Tick
        lblLoading.Text = "Logging out"
        CircularProgressBar1.Text = CircularProgressBar1.Value
        CircularProgressBar1.Value = i
        i += 5
        If CircularProgressBar1.Value = 100 Then
            logout.Stop()
            Me.Close()
            Login.Show()
        End If
    End Sub
End Class