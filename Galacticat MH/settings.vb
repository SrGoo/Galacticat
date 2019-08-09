Public Class settings

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        badguynumber = 9
        badguysspeed = 6
         Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        badguynumber = 3
        badguysspeed = 3
        Me.Hide()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        badguynumber = 300
        badguysspeed = 50
        Me.Hide()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        badguynumber = 15
        badguysspeed = 9
        Me.Hide()
    End Sub
End Class