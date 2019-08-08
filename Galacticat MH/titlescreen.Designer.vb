<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class titlescreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(titlescreen))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(73, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Galacticat"
        '
        'PlayButton
        '
        Me.PlayButton.BackColor = System.Drawing.Color.Black
        Me.PlayButton.Font = New System.Drawing.Font("Segoe Print", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayButton.ForeColor = System.Drawing.Color.Cyan
        Me.PlayButton.Location = New System.Drawing.Point(127, 167)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(81, 39)
        Me.PlayButton.TabIndex = 1
        Me.PlayButton.Text = "Play"
        Me.PlayButton.UseVisualStyleBackColor = False
        '
        'titlescreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(582, 416)
        Me.Controls.Add(Me.PlayButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "titlescreen"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PlayButton As System.Windows.Forms.Button
End Class
