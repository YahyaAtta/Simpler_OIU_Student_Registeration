Public Class Loading
    Dim i As Integer
    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        CircularProgressBar1.ResetText()
        Dim load As New Media.SoundPlayer
        load.SoundLocation = Application.StartupPath & "\Database Scan.wav"
        load.Play()
        i = 1
        Timer1.Enabled = True
        CircularProgressBar1.Maximum = 100
    End Sub
    Dim sound As New Media.SoundPlayer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblLoading.Text = "Loading Data"
        CircularProgressBar1.Text = CircularProgressBar1.Value
        CircularProgressBar1.Value = i + 1
        i += 1
        If CircularProgressBar1.Value = 100 Then
            Timer1.Stop()
            CircularProgressBar1.Text = 100
            If CircularProgressBar1.Text = 100 Then
                sound.SoundLocation = Application.StartupPath & "\Windows XP Startup.wav"
                sound.Play()
                Me.Close()
                Main.Show()
            End If
        End If


    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        sound.Stop()
        Timer1.Stop()
        CircularProgressBar1.ResetText()
        CircularProgressBar1.Text = 0
        Me.Close()
        Login.Show()
    End Sub
End Class