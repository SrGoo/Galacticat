Public Class MainForm


    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If Max.state = ALIVE Or Max.state = REVIVE Then

            Max.state = ALIVE

            If e.KeyCode = Keys.A Then
                Max.Speed.X = -Max.Startspeed.X
                Max.FacingRight = False

            End If

            If e.KeyCode = Keys.D Then
                Max.Speed.X = Max.Startspeed.X
                Max.FacingRight = True
            End If

            If e.KeyCode = Keys.W And Max.Onfloor = True Then
                Max.Speed.Y = -Max.Startspeed.Y



            End If
        End If






    End Sub

    Private Sub MainForm_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.D Then
            Max.Speed.X = 0

        End If
    End Sub



    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call resetLevel()
        LevelNumber = 1
        Timer1.Start()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call SpawnPowerUps()

        Dim index As Integer
        Call Movesprite(Max)

        For index = 0 To numSpawnBadGuys
            Call Movesprite(BadGuys(index))
        Next index
        TimerCounter += 1
        numSpawnBadGuys = TimerCounter / 130
        If numSpawnBadGuys > NumBadguys Then
            numSpawnBadGuys = NumBadguys
        End If
        Call checkKillMax()



        Call AnimateMax()
        Call animateBadGuys()
        Call ScreenDraw()
        Call ReviveMax()
        Call checkKillBadguy()
        Call CheckMilk()
        Call checkYouWin()
        Call CheckYouLoose()
        Call CheckInvinsibility()
        Call VisualizeInvincibility()
        Call slowBadGuydown()
        Call SpeedUp()
        Call ResetSpeed()
        Call BadguysJump()
        Call badguysReverse()
    End Sub
    Public Sub DrawScreenSet()
        imageOffScreen = Backdrop.Picture.Clone
        picDrawOnScreen.Left = Backdrop.Position.X
        picDrawOnScreen.Top = Backdrop.Position.Y
        picDrawOnScreen.Width = Backdrop.Width
        picDrawOnScreen.Height = Backdrop.Height
    End Sub
    Public Sub ScreenDraw()
        Dim index As Integer
        g = picDrawOnScreen.CreateGraphics
        offg = Graphics.FromImage(imageOffScreen)
        Call BackgroundDraw()

        Call DrawSprite(Max)

        If Slow.state = ALIVE And SlowSpawn = True Then
            Call DrawSprite(Slow)
        End If

        For index = 0 To numSpawnBadGuys
            Call DrawSprite(BadGuys(index))

        Next index
        If Milk.state = ALIVE Then
            Call DrawSprite(Milk)
        End If
        If Invincibility.state = ALIVE And InvincibilitySpawn = True Then
            Call DrawSprite(Invincibility)
        End If
        If fastspawn = True Then
            Call DrawSprite(fast)
        End If
        If SlowDownSpawn = True Then
            Call DrawSprite(SlowDown)
        End If
        g.DrawImage(imageOffScreen, 0, 0)
        g.Dispose()
        offg.Dispose()

    End Sub
    Public Sub checkYouWin()
        If NumBadguysKilled > NumBadguys Then
            Timer1.Stop()
            'NumBadguys += 1
            Winform.ShowDialog()
            If Quit = True Then
                Me.Close()

            End If

            Call resetLevel()
            Timer1.Start()
        End If
    End Sub
    Public Sub CheckYouLoose()
        If Lives = 0 Then
            Timer1.Stop()
            Form1.ShowDialog()
            If Quit = True Then
                Me.Close()
            End If
            Call resetLevel()
            Call Timer1.Start()
        End If
    End Sub
    Public Sub resetLevel()
        
        Call LoadSprite(Max, "/Pics/Pics/galacticat.png", 15, 5, 17, 200, 200)
        NumBadguys = badguynumber

        For index = 0 To NumBadguys
            If index Mod 2 = 0 Then
                Call LoadSprite(BadGuys(index), "/Pics/Pics/fangs.png", 10, 4, 0, 50, 50)
            Else
                Call LoadSprite(BadGuys(index), "/Pics/Pics/fangs.png", 10, -4, 0, 550, 50)
            End If
        Next index
        Call LoadSprite(Milk, "/pics/pics/milk.png", 1, 0, 0, 310, 278)
        Call LoadBackground()
        Call DrawScreenSet()
        Call SetFloors()
        Quit = False
        Score = 0
        Lives = 3
        NumBadguysKilled = 0
        Max.Speed.X = 0
        Max.Startspeed.X = 5
        Max.TimeInvincible = 0
        My.Computer.Audio.Play(IO.Path.GetDirectoryName(Application.ExecutablePath) & "\sounds\Meglovania.wav", AudioPlayMode.BackgroundLoop)
        TimerCounter = 0

    End Sub
    Public Sub SpawnPowerUps()
        Dim randomNum As Integer
        randomNum = Int((100 * Rnd()) + 1)
        If randomNum = 50 Then
            Call LoadSprite(Invincibility, "/pics/pics/Invincible.png", 1, 0, 0, 200, 20)
            InvincibilitySpawn = True
        End If

        If randomNum = 70 Then
            Call LoadSprite(Invincibility, "/pics/pics/Invincible.png", 1, 0, 0, 200, 20)
            InvincibilitySpawn = True
        End If
        If randomNum = 2 Then
            Call LoadSprite(Slow, "/pics/pics/clock.png", 1, 0, 0, 400, 250)
            SlowSpawn = True
        End If
        If randomNum = 100 Then
            Call LoadSprite(fast, "/Pics/Pics/coffee2.png", 1, 0, 0, 100, 250)
            fastspawn = True
        End If
        If randomNum = 100 Then
            Call LoadSprite(SlowDown, "/pics/pics/Water.png", 1, 0, 0, 450, 250)
            SlowDownSpawn = True
        End If
        'changes ... 

    End Sub
End Class
