Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\loose.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        Quit = True
        Hide()
    End Sub

    Private Sub PlayAgain_Click(sender As Object, e As EventArgs) Handles PlayAgain.Click
        Hide()
    End Sub
End Class