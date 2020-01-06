<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TitleLabel = New System.Windows.Forms.RadioButton()
        Me.SecondsCounter = New CPS_613_Assignment.SecondsCounter()
        Me.MinutesCounter = New CPS_613_Assignment.MinutesCounter()
        Me.SuspendLayout()
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.LightGray
        Me.ClearButton.Location = New System.Drawing.Point(189, 124)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 51)
        Me.ClearButton.TabIndex = 0
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StartButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.ForeColor = System.Drawing.Color.LightGray
        Me.StartButton.Location = New System.Drawing.Point(23, 124)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(75, 51)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StopButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopButton.ForeColor = System.Drawing.Color.LightGray
        Me.StopButton.Location = New System.Drawing.Point(108, 124)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(75, 51)
        Me.StopButton.TabIndex = 2
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = False
        '
        'ColonLabel
        '
        Me.ColonLabel.AutoSize = True
        Me.ColonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColonLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ColonLabel.Location = New System.Drawing.Point(131, 55)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(37, 55)
        Me.ColonLabel.TabIndex = 3
        Me.ColonLabel.Text = ":"
        '
        'Timer
        '
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TitleLabel.Location = New System.Drawing.Point(23, 12)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(160, 29)
        Me.TitleLabel.TabIndex = 4
        Me.TitleLabel.Text = "RadioButton1"
        Me.TitleLabel.UseVisualStyleBackColor = True
        '
        'SecondsCounter
        '
        Me.SecondsCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsCounter.ForeColor = System.Drawing.Color.RoyalBlue
        Me.SecondsCounter.Location = New System.Drawing.Point(150, 62)
        Me.SecondsCounter.Name = "SecondsCounter"
        Me.SecondsCounter.Size = New System.Drawing.Size(70, 43)
        Me.SecondsCounter.TabIndex = 6
        Me.SecondsCounter.Tag = "0"
        Me.SecondsCounter.Text = "00"
        '
        'MinutesCounter
        '
        Me.MinutesCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesCounter.ForeColor = System.Drawing.Color.RoyalBlue
        Me.MinutesCounter.Location = New System.Drawing.Point(3, 62)
        Me.MinutesCounter.Name = "MinutesCounter"
        Me.MinutesCounter.Size = New System.Drawing.Size(141, 43)
        Me.MinutesCounter.TabIndex = 7
        Me.MinutesCounter.Tag = "0"
        Me.MinutesCounter.Text = "00"
        Me.MinutesCounter.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.Controls.Add(Me.SecondsCounter)
        Me.Controls.Add(Me.MinutesCounter)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(287, 187)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClearButton As Button
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ColonLabel As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents TitleLabel As RadioButton
    Friend WithEvents MinutesCounter As MinutesCounter
    Friend WithEvents SecondsCounter As SecondsCounter
End Class
