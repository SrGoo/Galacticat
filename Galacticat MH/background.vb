Module background
    Structure floor
        Dim top As Integer
        Dim bottom As Integer
        Dim left As Integer
        Dim right As Integer
    End Structure
    Structure background
        Dim Picture As Bitmap
        Dim Position As Point
        Dim Width As Integer
        Dim Height As Integer

    End Structure

    Public Backdrop As background
    Public g As Graphics
    Public offg As Graphics
    Public imageOffScreen As Image
    Public numfloors As Integer = 7
    Public floors(numfloors) As floor


    Public Sub LoadBackground()
        Backdrop.Position.X = 0
        Backdrop.Position.Y = 0
        Backdrop.Picture = New Bitmap(IO.Path.GetDirectoryName(Application.ExecutablePath) & "/Pics/Pics/bckgrnd.bmp")
        Backdrop.Width = Backdrop.Picture.Width
        Backdrop.Height = Backdrop.Picture.Height

    End Sub
    Public Sub BackgroundDraw()
        offg.DrawImage(Backdrop.Picture, 0, 0)

    End Sub

    Public Sub SetFloors()
        floors(0).top = 415
        floors(0).bottom = 441
        floors(0).left = -50
        floors(0).right = 688

        floors(1).top = 318
        floors(1).bottom = 335
        floors(1).left = 0
        floors(1).right = 245

        floors(2).top = 318
        floors(2).bottom = 335
        floors(2).left = 406
        floors(2).right = 638

        floors(3).top = 217
        floors(3).bottom = 232
        floors(3).left = 0
        floors(3).right = 101

        floors(4).top = 217
        floors(4).bottom = 232
        floors(4).left = 552
        floors(4).right = 638

        floors(5).top = 202
        floors(5).bottom = 220
        floors(5).left = 166
        floors(5).right = 482

        floors(6).top = 93
        floors(6).bottom = 111
        floors(6).left = 0
        floors(6).right = 270

        floors(7).top = 93
        floors(7).bottom = 111
        floors(7).left = 380
        floors(7).right = 638
    End Sub

End Module
