<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picDrawOnScreen = New System.Windows.Forms.PictureBox()
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.LivesText = New System.Windows.Forms.Label()
        CType(Me.picDrawOnScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'picDrawOnScreen
        '
        Me.picDrawOnScreen.Location = New System.Drawing.Point(424, 105)
        Me.picDrawOnScreen.Name = "picDrawOnScreen"
        Me.picDrawOnScreen.Size = New System.Drawing.Size(167, 124)
        Me.picDrawOnScreen.TabIndex = 2
        Me.picDrawOnScreen.TabStop = False
        '
        'ScoreText
        '
        Me.ScoreText.AutoSize = True
        Me.ScoreText.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.ForeColor = System.Drawing.Color.Cyan
        Me.ScoreText.Location = New System.Drawing.Point(659, 36)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(112, 37)
        Me.ScoreText.TabIndex = 3
        Me.ScoreText.Text = "Score: 0 "
        '
        'LivesText
        '
        Me.LivesText.AutoSize = True
        Me.LivesText.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LivesText.ForeColor = System.Drawing.Color.Cyan
        Me.LivesText.Location = New System.Drawing.Point(661, 105)
        Me.LivesText.Name = "LivesText"
        Me.LivesText.Size = New System.Drawing.Size(94, 36)
        Me.LivesText.TabIndex = 4
        Me.LivesText.Text = "Lives: 3"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.LivesText)
        Me.Controls.Add(Me.ScoreText)
        Me.Controls.Add(Me.picDrawOnScreen)
        Me.Name = "MainForm"
        Me.Text = "galacticat by matthew"
        CType(Me.picDrawOnScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents picDrawOnScreen As System.Windows.Forms.PictureBox
    Friend WithEvents ScoreText As System.Windows.Forms.Label
    Friend WithEvents LivesText As System.Windows.Forms.Label

End Class
