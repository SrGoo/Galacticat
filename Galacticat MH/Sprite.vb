Module Sprite
    Structure sprite
        Dim Picture As Bitmap
        Dim cellWidth As Integer
        Dim cellheight As Integer
        Dim CellCount As Integer
        Dim StartPosition As Point
        Dim Position As Point
        Dim Speed As Point
        Dim Startspeed As Point
        Dim mRectangle As Rectangle
        Dim CellTop As Integer
        Dim FacingRight As Boolean
        Dim Onfloor As Boolean
        Dim index As Integer
        Dim radius As Integer
        Dim state As Integer
        Dim TimeFlip As Integer
        Dim TimeInvincible As Integer
        Dim Invincible As Boolean
        Dim timeslow As Integer
        Dim powerTimeSlower As Boolean
        Dim JumpCounter As Integer
        Dim ReverseTimer
    End Structure


    'HELLO WORLD
    Public fast As sprite
    Public SlowDown As sprite
    Public Slow As sprite
    Public Max As sprite
    Public Milk As sprite
    Public NumBadguys As Integer = badguynumber
    Public BadGuys(1000) As sprite
    Public Const gravity As Integer = 1
    Public ALIVE As Integer = 0
    Public DEAD As Integer = 1
    Public REVIVE As Integer = 2
    Public flip As Integer = 3
    Public Score As Integer
    Public Lives As Integer
    Public NumBadguysKilled As Integer
    Public Quit As Boolean
    Public LevelNumber As Integer
    Public Invincibility As sprite
    Public InvincibilitySpawn As Boolean
    Public ChangeCostume As Boolean
    Public SlowSpawn As Boolean
    Public fastspawn As Boolean
    Public SlowDownSpawn As Boolean

    Public Sub LoadSprite(ByRef Guy As sprite, ByVal picname As String, ByVal NumCells As Integer, ByVal XSpeed As Integer, ByVal YSpeed As Integer, ByVal Xpos As Integer, ByVal Ypos As Integer)
        Guy.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & picname)
        Guy.CellCount = NumCells
        Guy.cellWidth = Guy.Picture.Width
        Guy.cellheight = Guy.Picture.Height / Guy.CellCount
        Guy.StartPosition.X = 300
        Guy.StartPosition.Y = 300
        Guy.Position.X = Xpos
        Guy.Position.Y = Ypos
        Guy.Speed.X = XSpeed
        Guy.Speed.Y = YSpeed
        Guy.Startspeed.X = XSpeed
        Guy.Startspeed.Y = YSpeed
        Guy.mRectangle.Width = Guy.cellWidth
        Guy.mRectangle.Height = Guy.cellheight
        Guy.mRectangle.X = Guy.Position.X
        Guy.mRectangle.Y = Guy.Position.Y
        Guy.FacingRight = True
        Guy.radius = Guy.cellWidth / 2
        Guy.state = ALIVE


    End Sub

    Public Sub Movesprite(ByRef Guy As sprite)
        Guy.Speed.Y = GetVirticleSpeed(Guy)
        Guy.Position.Y += Guy.Speed.Y
        Guy.Position.X += Guy.Speed.X
        Guy.mRectangle.X = Guy.Position.X
        Guy.mRectangle.Y = Guy.Position.Y
        If Guy.Position.X > 638 + Guy.cellWidth Then
            Guy.Position.X = 0 - Guy.cellWidth
        ElseIf Guy.Position.X < 0 - Guy.cellWidth Then
            Guy.Position.X = 638
        End If
        If Guy.Position.Y > floors(1).bottom And Guy.Position.X = 638 + Guy.cellWidth And Guy.state = ALIVE Then
            Guy.Position.Y = 81 And Guy.Position.X = 0 - Guy.cellWidth
        ElseIf Guy.Position.Y > floors(1).bottom And Guy.Position.X = 0 - Guy.cellWidth And Guy.state = ALIVE Then
            Guy.Position.Y = 81 And Guy.Position.X = 637 - Guy.cellWidth

        End If
    End Sub
    Public Sub DrawSprite(ByRef Guy As sprite)
        offg.DrawImage(Guy.Picture, Guy.mRectangle, 0, Guy.CellTop, Guy.cellWidth, Guy.cellheight, System.Drawing.GraphicsUnit.Pixel)

    End Sub

    Public Sub AnimateMax()
        Max.CellTop += Max.cellheight
        If Max.state = ALIVE Or Max.invincible = True Then

            If Max.Speed.X > 0 And Max.Speed.Y = 0 And Max.Onfloor = True Then
                If Max.CellTop > Max.cellheight * 2 Then
                    Max.CellTop = 0
                End If

            ElseIf Max.Speed.X < 0 And Max.Speed.Y = 0 And Max.Onfloor = True Then
                If Max.CellTop > Max.cellheight * 5 Or Max.CellTop < Max.cellheight * 3 Then
                    Max.CellTop = Max.cellheight * 3
                End If
            ElseIf Max.Speed.X = 0 And Max.Speed.Y = 0 And Max.Onfloor = True Then
                If Max.FacingRight = True Then
                    Max.CellTop = Max.cellheight * 6
                Else
                    Max.CellTop = Max.cellheight * 7

                End If
            ElseIf Max.Onfloor = False Then
                If Max.FacingRight = True Then
                    Max.CellTop = Max.cellheight * 8
                Else
                    Max.CellTop = Max.cellheight * 9

                End If
            End If
        ElseIf Max.state = DEAD Then
            If Max.CellTop > Max.cellheight * 13 Then Max.CellTop = Max.cellheight * 12
        ElseIf Max.state = REVIVE Then
            Max.CellTop = Max.cellheight * 14

        End If
    End Sub
    Public Function GetVirticleSpeed(ByRef guy As sprite)
        Dim Index As Integer
        Dim NextVirticleStep As Integer
        NextVirticleStep = guy.Speed.Y + gravity
        If guy.state <> DEAD Then


            guy.Onfloor = False
            For Index = 0 To 7
                If guy.Position.X + guy.cellWidth > floors(Index).left And guy.Position.X < floors(Index).right Then
                    If NextVirticleStep > 0 Then
                        If guy.Position.Y + guy.cellheight <= floors(Index).top Then
                            If guy.Position.Y + guy.cellheight + NextVirticleStep > floors(Index).top Then
                                NextVirticleStep = floors(Index).top - (guy.Position.Y + guy.cellheight)
                                guy.Onfloor = True
                            End If
                        End If
                    End If
                    If NextVirticleStep <= 0 Then
                        If guy.Position.Y >= floors(Index).bottom Then
                            If guy.Position.Y + NextVirticleStep < floors(Index).bottom Then
                                NextVirticleStep = floors(Index).bottom - guy.Position.Y
                            End If
                        End If
                    End If
                End If
            Next Index
        End If
        Return NextVirticleStep

    End Function

    Public Sub animateBadGuys()
        Dim index As Integer
        For index = 0 To numSpawnBadGuys
            BadGuys(index).CellTop += BadGuys(index).cellheight
            If BadGuys(index).Speed.X > 0 And BadGuys(index).state = ALIVE Then
                If BadGuys(index).CellTop > BadGuys(index).cellheight Then
                    BadGuys(index).CellTop = 0
                End If
            ElseIf BadGuys(index).Speed.X < 0 And BadGuys(index).state = ALIVE Then
                If BadGuys(index).CellTop > BadGuys(index).cellheight * 3 Then
                    BadGuys(index).CellTop = BadGuys(index).cellheight * 2
                End If

            ElseIf BadGuys(index).state = flip Then
                If BadGuys(index).CellTop > BadGuys(index).cellheight * 9 Then
                    BadGuys(index).CellTop = BadGuys(index).cellheight * 8
                End If

            ElseIf BadGuys(index).state = DEAD Then
                If BadGuys(index).CellTop > BadGuys(index).cellheight * 7 Then
                    BadGuys(index).CellTop = BadGuys(index).cellheight * 4
                End If

            End If

        Next index
    End Sub
    Public numSpawnBadGuys As Integer
    Public TimerCounter As Integer

    Public Function collision(ByVal Guy1 As sprite, ByVal Guy2 As sprite)
        Dim a As Integer
        Dim b As Integer
        Dim c As Double
        a = Guy1.Position.X - Guy2.Position.X
        b = Guy1.Position.Y - Guy2.Position.Y
        c = Math.Sqrt(a * a + b * b)
        If c < Guy1.radius + Guy2.radius Then
            Return True
        End If
        Return False
    End Function
    Public Sub ReviveMax()
        If Max.state = DEAD And Max.Position.Y > Backdrop.Height Then
            Max.state = REVIVE
            Max.Speed.Y = 0
            Max.Position.Y = -50
            Max.Position.X = Backdrop.Width / 2


          









        End If

        If Max.Position.Y > 20 And Max.state = REVIVE Then
            Max.Speed.Y = 0
            Max.Position.Y = 20
        End If
    End Sub

    Public Sub checkKillBadguy()
        Dim index As Integer
        Dim MaxClone As sprite
        MaxClone = Max
        MaxClone.Position.Y -= 20
        For index = 0 To NumBadguys
            If collision(MaxClone, BadGuys(index)) And BadGuys(index).state = ALIVE And BadGuys(index).Onfloor = True Then
                BadGuys(index).state = flip
                BadGuys(index).Speed.Y = -5
                BadGuys(index).Speed.X = 0
                BadGuys(index).TimeFlip = 0
            End If
            If collision(Max, BadGuys(index)) And BadGuys(index).state = flip And Max.state = ALIVE Then
                BadGuys(index).state = DEAD
                BadGuys(index).Speed.X = Max.Speed.X * 5
                NumBadguysKilled += 1
                Score += 10
                MainForm.ScoreText.Text = "score: " + Score.ToString
            End If
            If BadGuys(index).state = DEAD And BadGuys(index).Position.Y > Backdrop.Height Then
                BadGuys(index).Speed.Y = 0
            End If
            If BadGuys(index).state = flip Then
                BadGuys(index).TimeFlip += 1
                If BadGuys(index).TimeFlip = 100 Then
                    BadGuys(index).TimeFlip = 0
                    BadGuys(index).state = ALIVE
                    BadGuys(index).Speed.X = BadGuys(index).Startspeed.X


                End If
            End If

        Next index

    End Sub

    Public Sub checkKillMax()


        For index = 0 To numSpawnBadGuys
            If collision(Max, BadGuys(index)) And Max.state = ALIVE And BadGuys(index).state = ALIVE And Max.Invincible = False Then

                Max.state = DEAD
                Max.Speed.Y = -20
                Max.Speed.X = 0
                Lives -= 1
                MainForm.LivesText.Text = "Lives: " + Lives.ToString
            End If
        Next index

    End Sub

    Public Sub CheckMilk()
        Dim index As Integer

        If collision(Milk, Max) And Max.state = ALIVE And Milk.state = ALIVE And Max.Speed.Y < 0 Then
            Max.Speed.Y = Milk.Position.Y + Milk.cellWidth - Max.Position.Y
            Milk.state = DEAD
            For index = 0 To numSpawnBadGuys
                If BadGuys(index).state = ALIVE Then


                    BadGuys(index).state = flip
                    BadGuys(index).Speed.X = 0
                End If
            Next index
        End If
    End Sub



    Public Sub CheckInvinsibility()
        If collision(Max, Invincibility) And Max.state = ALIVE Then
            Invincibility.state = DEAD
            Max.Invincible = True
            ChangeCostume = True
            InvincibilitySpawn = False
        End If

        If Max.invincible = True Then
            Max.TimeInvincible += 1
            If Max.TimeInvincible = 200 Then
                Max.TimeInvincible = 0


                Max.Invincible = False
                ChangeCostume = False
                Max.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/Pics/Pics/galacticat.png")

            End If

        End If
    End Sub

    Public Sub VisualizeInvincibility()

        If ChangeCostume = True Then
            Max.Picture = Image.FromFile(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/Pics/Pics/galacticat2.png")

        End If
    End Sub
    Public Sub slowBadGuydown()
        Dim index As Integer
        If collision(Max, Slow) And Max.state = ALIVE And Slow.state = ALIVE Then
            Slow.state = DEAD

            For index = 0 To numSpawnBadGuys
                If BadGuys(index).Speed.X > 0 Then


                    BadGuys(index).Speed.X = 1
                End If
                If BadGuys(index).Speed.X < 0 Then
                    BadGuys(index).Speed.X = -1
                End If
                Max.powerTimeSlower = True
                If Max.powerTimeSlower = True Then
                    BadGuys(index).timeslow += 1
                    If BadGuys(index).timeslow = 200 Then
                        BadGuys(index).Speed.X = BadGuys(index).Startspeed.X
                        BadGuys(index).timeslow = 0
                        Max.powerTimeSlower = False
                    End If
                End If
            Next

        End If
    End Sub

    Public Sub SpeedUp()
        If collision(Max, fast) And Max.state = ALIVE And fast.state = ALIVE Then
            fast.state = DEAD
            If Max.Startspeed.X < 10 Then
                Max.Startspeed.X *= 2
                fastspawn = False
            End If
        End If


    End Sub
    Public Sub ResetSpeed()
        If collision(Max, SlowDown) And Max.state = ALIVE And SlowDown.state = ALIVE Then
            SlowDown.state = DEAD
            Max.Startspeed.X = 5
            slowDownSpawn = False

        End If
    End Sub


    Public Sub BadguysJump()
        Dim index As Integer
        For index = 0 To NumBadguys
            BadGuys(index).JumpCounter += 1
            If BadGuys(index).JumpCounter = 200 Then
                BadGuys(index).Speed.Y = -10
                BadGuys(index).JumpCounter = 0
            End If



        Next
    End Sub


    Public Sub badguysReverse()
        Dim index As Integer
        For index = 0 To NumBadguys
            BadGuys(index).ReverseTimer += 1
            If BadGuys(index).ReverseTimer = 300 Then
                BadGuys(index).ReverseTimer = 0
                If BadGuys(index).Speed.X > 0 Then
                    BadGuys(index).Speed.X = -4
                Else
                    BadGuys(index).Speed.X = 4

                End If
            End If
        Next
    End Sub
End Module
