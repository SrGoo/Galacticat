Public Class Winform

    Private Sub Winform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\Win.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles RetryButton.Click
        badguynumber += 5
        Hide()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Quit = True
        Hide()
    End Sub
End Class