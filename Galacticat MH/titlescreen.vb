Public Class titlescreen

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        MainForm.ShowDialog()
    End Sub


    Private Sub titlescreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        badguynumber = 0
    End Sub
End Class