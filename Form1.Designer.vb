<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Center
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
        Me.Sec1 = New System.Windows.Forms.Button()
        Me.Sec3 = New System.Windows.Forms.Button()
        Me.Sec10 = New System.Windows.Forms.Button()
        Me.Min1 = New System.Windows.Forms.Button()
        Me.Min3 = New System.Windows.Forms.Button()
        Me.Min10 = New System.Windows.Forms.Button()
        Me.UserControl14 = New CPS_613_Assignment.SingleTimer(4, 1000, 2400)
        Me.UserControl13 = New CPS_613_Assignment.SingleTimer(3, 1000, 1200)
        Me.UserControl12 = New CPS_613_Assignment.SingleTimer(2, 1000, 600)
        Me.UserControl11 = New CPS_613_Assignment.SingleTimer(1, 1000, 400)
        Me.SuspendLayout()
        '
        'Sec1
        '


        Me.Sec1.BackColor = System.Drawing.Color.SteelBlue
        Me.Sec1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sec1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sec1.Location = New System.Drawing.Point(27, 418)
        Me.Sec1.Name = "Sec1"
        Me.Sec1.Size = New System.Drawing.Size(171, 68)
        Me.Sec1.TabIndex = 0
        Me.Sec1.Tag = "1"
        Me.Sec1.Text = "1 Second"
        Me.Sec1.UseVisualStyleBackColor = False
        '
        'Sec3
        '
        Me.Sec3.BackColor = System.Drawing.Color.SteelBlue
        Me.Sec3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sec3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sec3.Location = New System.Drawing.Point(233, 418)
        Me.Sec3.Name = "Sec3"
        Me.Sec3.Size = New System.Drawing.Size(156, 68)
        Me.Sec3.TabIndex = 1
        Me.Sec3.Tag = "3"
        Me.Sec3.Text = "3 Seconds"
        Me.Sec3.UseVisualStyleBackColor = False
        '
        'Sec10
        '
        Me.Sec10.BackColor = System.Drawing.Color.SteelBlue
        Me.Sec10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sec10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sec10.Location = New System.Drawing.Point(426, 418)
        Me.Sec10.Name = "Sec10"
        Me.Sec10.Size = New System.Drawing.Size(152, 68)
        Me.Sec10.TabIndex = 2
        Me.Sec10.Tag = "10"
        Me.Sec10.Text = "10 Seconds"
        Me.Sec10.UseVisualStyleBackColor = False
        '
        'Min1
        '
        Me.Min1.BackColor = System.Drawing.Color.SteelBlue
        Me.Min1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Min1.Location = New System.Drawing.Point(27, 501)
        Me.Min1.Name = "Min1"
        Me.Min1.Size = New System.Drawing.Size(171, 65)
        Me.Min1.TabIndex = 3
        Me.Min1.Tag = "1"
        Me.Min1.Text = "1 Minute"
        Me.Min1.UseVisualStyleBackColor = False
        '
        'Min3
        '
        Me.Min3.BackColor = System.Drawing.Color.SteelBlue
        Me.Min3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Min3.Location = New System.Drawing.Point(233, 501)
        Me.Min3.Name = "Min3"
        Me.Min3.Size = New System.Drawing.Size(156, 65)
        Me.Min3.TabIndex = 4
        Me.Min3.Tag = "3"
        Me.Min3.Text = "3 Minutes"
        Me.Min3.UseVisualStyleBackColor = False
        '
        'Min10
        '
        Me.Min10.BackColor = System.Drawing.Color.SteelBlue
        Me.Min10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Min10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Min10.Location = New System.Drawing.Point(426, 501)
        Me.Min10.Name = "Min10"
        Me.Min10.Size = New System.Drawing.Size(152, 65)
        Me.Min10.TabIndex = 5
        Me.Min10.Tag = "10"
        Me.Min10.Text = "10 Minutes"
        Me.Min10.UseVisualStyleBackColor = False
        '
        'UserControl14
        '
        Me.UserControl14.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UserControl14.Location = New System.Drawing.Point(327, 216)
        Me.UserControl14.Name = "UserControl14"
        Me.UserControl14.Size = New System.Drawing.Size(287, 187)
        Me.UserControl14.TabIndex = 9
        '
        'UserControl13
        '
        Me.UserControl13.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UserControl13.Location = New System.Drawing.Point(12, 216)
        Me.UserControl13.Name = "UserControl13"
        Me.UserControl13.Size = New System.Drawing.Size(287, 187)
        Me.UserControl13.TabIndex = 8
        '
        'UserControl12
        '
        Me.UserControl12.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UserControl12.Location = New System.Drawing.Point(327, 11)
        Me.UserControl12.Name = "UserControl12"
        Me.UserControl12.Size = New System.Drawing.Size(287, 187)
        Me.UserControl12.TabIndex = 7
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.UserControl11.Location = New System.Drawing.Point(12, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(290, 186)
        Me.UserControl11.TabIndex = 6
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 578)
        Me.Controls.Add(Me.UserControl14)
        Me.Controls.Add(Me.UserControl13)
        Me.Controls.Add(Me.UserControl12)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Min10)
        Me.Controls.Add(Me.Min3)
        Me.Controls.Add(Me.Min1)
        Me.Controls.Add(Me.Sec10)
        Me.Controls.Add(Me.Sec3)
        Me.Controls.Add(Me.Sec1)
        Me.Name = "Center"
        Me.Text = "Allan Hong's Assignment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sec1 As Button
    Friend WithEvents Sec3 As Button
    Friend WithEvents Sec10 As Button
    Friend WithEvents Min1 As Button
    Friend WithEvents Min3 As Button
    Friend WithEvents Min10 As Button
    Friend WithEvents UserControl12 As CPS_613_Assignment.SingleTimer
    Friend WithEvents UserControl14 As CPS_613_Assignment.SingleTimer
    Friend WithEvents UserControl13 As CPS_613_Assignment.SingleTimer
    Friend WithEvents UserControl11 As CPS_613_Assignment.SingleTimer
End Class
