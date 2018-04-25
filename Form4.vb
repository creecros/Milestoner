Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userName.Text = My.Settings.username
        passWord.Text = My.Settings.password
        webHook.Text = My.Settings.webhook

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click

        My.Settings.username = userName.Text
        My.Settings.password = passWord.Text
        My.Settings.webhook = webHook.Text
        My.Settings.Save()
        Me.Hide()

    End Sub
End Class