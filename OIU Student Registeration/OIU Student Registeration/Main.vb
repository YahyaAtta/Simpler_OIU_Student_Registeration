Public Class Main
    Private Sub cmdLogout_Click(sender As Object, e As EventArgs) Handles cmdLogout.Click
        If MsgBox("Do You Want To Sign out?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        Else
            Me.Close()
            Logging_out.Show()
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cmdQuery.Enabled = True
        cmdAdd.Enabled = True
        cmdUpdateS.Enabled = True
        cmdDelete.Enabled = True
        cmdSearch.Enabled = True
        cmdLogout.Enabled = True
        cmdAbout.Enabled = True
        lblWelcome.Text = ""
        Timer1.Stop()
    End Sub

    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        Me.Close()
        Query.Show()
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Me.Close()
        Add.Show()
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdateS.Click
        Me.Close()
        SUpdate.Show()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Me.Close()
        Delete.Show()
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Me.Close()
        Search.Show()
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        Me.Close()
        About.Show()
    End Sub
End Class