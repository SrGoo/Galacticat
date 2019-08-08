<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.YouLoose = New System.Windows.Forms.Label()
        Me.PlayAgain = New System.Windows.Forms.Button()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'YouLoose
        '
        Me.YouLoose.AutoSize = True
        Me.YouLoose.BackColor = System.Drawing.Color.Transparent
        Me.YouLoose.Font = New System.Drawing.Font("Segoe Print", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YouLoose.ForeColor = System.Drawing.Color.Cyan
        Me.YouLoose.Location = New System.Drawing.Point(90, 54)
        Me.YouLoose.Name = "YouLoose"
        Me.YouLoose.Size = New System.Drawing.Size(114, 43)
        Me.YouLoose.TabIndex = 0
        Me.YouLoose.Text = "You Loose"
        Me.YouLoose.UseCompatibleTextRendering = True
        '
        'PlayAgain
        '
        Me.PlayAgain.Location = New System.Drawing.Point(36, 128)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(75, 23)
        Me.PlayAgain.TabIndex = 1
        Me.PlayAgain.Text = "Play Again"
        Me.PlayAgain.UseVisualStyleBackColor = True
        '
        'QuitButton
        '
        Me.QuitButton.Location = New System.Drawing.Point(176, 128)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(75, 23)
        Me.QuitButton.TabIndex = 2
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(802, 490)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.YouLoose)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YouLoose As System.Windows.Forms.Label
    Friend WithEvents PlayAgain As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
End Class
