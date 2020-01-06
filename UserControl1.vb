Public Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    Public Title As String
    Public Shared SelectedTimer As SingleTimer
    Public beeping As Boolean = False 'for sounding the alarm, true if time runs out
    Dim AlarmBeeps As Integer   'number of beeps played by timer_tick
    Dim AlarmInterval As Integer 'intervals in milliseconds between each timer_tick
    Dim AlarmFrequency As Integer
    Public countdown As Boolean 'true if timer is counting down




    Shared Sub AddMinutesToSelected(extraMins As Integer)
        Dim minutes As Integer = SingleTimer.SelectedTimer.MinutesCounter.getValue()
        Dim seconds As Integer = SingleTimer.SelectedTimer.SecondsCounter.getValue()
        Dim maxMinutes As Integer = SingleTimer.SelectedTimer.MinutesCounter.getMax()
        Dim maxSeconds As Integer = SingleTimer.SelectedTimer.SecondsCounter.getMax()
        Dim minutesString As String = ""
        Dim secondsString As String = ""

        minutes = minutes + extraMins

        If minutes < 10 Then
            minutesString = "0" + minutes.ToString


        ElseIf minutes > 99 And seconds <= 59 Then
            minutes = 99
            seconds = 59
            secondsString = seconds.ToString
            minutesString = minutes.ToString


        Else
            minutesString = minutes.ToString
        End If

        If seconds < 10 Then
            secondsString = "0" + seconds.ToString
        Else
            secondsString = seconds.ToString
        End If

        SingleTimer.SelectedTimer.MinutesCounter.Text = minutesString
        SingleTimer.SelectedTimer.SecondsCounter.Text = secondsString

        SingleTimer.SelectedTimer.MinutesCounter.setValue(minutes)
        SingleTimer.SelectedTimer.SecondsCounter.setValue(seconds)
    End Sub


    Shared Sub AddSecondsToSelected(extraSecs As Integer)
        Dim minutes As Integer = SingleTimer.SelectedTimer.MinutesCounter.getValue()
        Dim maxMinutes As Integer = SingleTimer.SelectedTimer.MinutesCounter.getMax()
        Dim minutesString As String = minutes.ToString
        Dim seconds As Integer = SingleTimer.SelectedTimer.SecondsCounter.getValue()
        Dim maxSeconds As Integer = SingleTimer.SelectedTimer.SecondsCounter.getMax()
        Dim secondsString As String = seconds.ToString

        seconds = seconds + extraSecs

        If seconds < 10 Then
            secondsString = "0" + seconds.ToString

        ElseIf seconds >= 60 Then
            minutes = minutes + (seconds / 60)
            seconds = seconds Mod 60
            secondsString = "0" + seconds.ToString


            If minutes < 10 Then
                minutesString = "0" + minutes.ToString

            ElseIf minutes > 99 Or (minutes = 99 And seconds > 59) Then
                minutes = 99
                seconds = 59
                minutesString = minutes.ToString
                secondsString = seconds.ToString

            Else
                minutesString = minutes.ToString
            End If


        Else
            secondsString = seconds.ToString
        End If

        If minutes < 10 Then
            minutesString = "0" + minutes.ToString
        Else
            minutesString = minutes.ToString
        End If

        SingleTimer.SelectedTimer.MinutesCounter.Text = minutesString
        SingleTimer.SelectedTimer.SecondsCounter.Text = secondsString

        SingleTimer.SelectedTimer.MinutesCounter.setValue(minutes)
        SingleTimer.SelectedTimer.SecondsCounter.setValue(seconds)
    End Sub



    Sub selectMe()
        SelectedTimer = Me
        Me.TitleLabel.Checked = True
        newBackcolor(Color.DeepSkyBlue)

        If SelectedTimer Is Center.UserControl11 Then
            Center.UserControl12.deSelectMe()
            Center.UserControl13.deSelectMe()
            Center.UserControl14.deSelectMe()

        ElseIf SelectedTimer Is Center.UserControl12 Then
            Center.UserControl11.deSelectMe()
            Center.UserControl13.deSelectMe()
            Center.UserControl14.deSelectMe()

        ElseIf SelectedTimer Is Center.UserControl13 Then
            Center.UserControl11.deSelectMe()
            Center.UserControl12.deSelectMe()
            Center.UserControl14.deSelectMe()

        Else
            Center.UserControl11.deSelectMe()
            Center.UserControl12.deSelectMe()
            Center.UserControl13.deSelectMe()
        End If
    End Sub

    Sub deSelectMe()
        Me.TitleLabel.Checked = False
        newBackcolor(Color.LightBlue)
    End Sub

    'before minutes and seconds are entered
    'disables buttons For start,Stop,clear
    Sub DisableAllButtons()
        If countdown = False Then
            StartButton.Enabled = False
            StopButton.Enabled = False
            ClearButton.Enabled = False
        End If
    End Sub

    Sub New(AlarmBeeps As Integer, AlarmInterval As Integer, AlarmFrequency As Integer)

        InitializeComponent()
        initialize(AlarmBeeps, AlarmInterval, AlarmFrequency)
        DisableAllButtons()

    End Sub

    Sub initialize(AlarmBeeps As Integer, AlarmInterval As Integer, AlarmFrequency As Integer)
        countdown = False
        Me.AlarmBeeps = AlarmBeeps
        Me.AlarmInterval = AlarmInterval
        Me.AlarmFrequency = AlarmFrequency
    End Sub

    Sub newBackcolor(newcolor As Color)
        Me.BackColor = newcolor
    End Sub

    Sub newForecolor(newcolor As Color)
        Me.ForeColor = newcolor
    End Sub


    Sub SingleTimer_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.selectMe()

    End Sub




    Sub StartButton_Click1(sender As Object, e As EventArgs) Handles StartButton.Click
        Me.selectMe()
        StartButton.Enabled = False
        StopButton.Enabled = True
        StopButton.ForeColor = Color.Red
        countdown = True
        beeping = False
        Me.Timer.Interval = 1000
        Me.Timer.Start()
    End Sub

    Sub Timer_Tick1(sender As Object, e As EventArgs) Handles Timer.Tick

        If Me.beeping = True Then

            Dim i As Integer = 0

            While i < AlarmBeeps
                Console.Beep(AlarmFrequency, 500)
                i = i + 1
            End While


        Else
            Dim minutes As Integer = Me.MinutesCounter.getValue()
            Dim minutesString As String = minutes.ToString
            Dim seconds As Integer = Me.SecondsCounter.getValue()
            Dim secondsString As String = seconds.ToString

            If minutes > 0 And seconds = 0 Then
                minutes = minutes - 1
                seconds = 59

            Else
                seconds = seconds - 1
            End If



            If seconds < 10 Then
                secondsString = "0" + seconds.ToString

            Else
                secondsString = seconds.ToString
            End If

            If minutes < 10 Then
                minutesString = "0" + minutes.ToString
            Else
                minutesString = minutes.ToString
            End If

            Me.MinutesCounter.Text = minutesString
            Me.SecondsCounter.Text = secondsString

            Me.MinutesCounter.setValue(minutes)
            Me.SecondsCounter.setValue(seconds)

            If minutes = 0 And seconds = 0 Then
                beeping = True
                soundAlarm()
            End If
        End If
    End Sub

    Sub StartButton_EnabledChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Me.selectMe()
        countdown = False

        stopTiming()

        If beeping = True Then
            DisableAllButtons()
            beeping = False
            Me.Timer.Stop()
        End If



    End Sub

    Sub soundAlarm()
        ClearButton.Enabled = False
        StartButton.Enabled = False
        countdown = False

        Me.Timer.Interval = AlarmInterval
        Me.Timer.Start()

        stopTiming()
        Me.MinutesCounter.ForeColor = Color.Red
        Me.SecondsCounter.ForeColor = Color.Red
        Me.ColonLabel.ForeColor = Color.Red

    End Sub

    Sub stopTiming()
        countdown = False

        If beeping = True Then
            Me.MinutesCounter.ForeColor = Color.RoyalBlue
            Me.SecondsCounter.ForeColor = Color.RoyalBlue
            Me.ColonLabel.ForeColor = Color.RoyalBlue
            StartButton.Enabled = False
            StopButton.Enabled = True
            ClearButton.Enabled = False

        Else
            StartButton.Enabled = True
            StartButton.ForeColor = Color.Lime
            StopButton.Enabled = False
            Me.Timer.Stop()
        End If
    End Sub



    Private Sub ClearButton_Click_1(sender As Object, e As EventArgs) Handles ClearButton.Click
        Me.selectMe()
        Me.Timer.Stop()

        If countdown = True Then
            countdown = False
            stopTiming()
        End If

        SelectedTimer.MinutesCounter.reset()
        SelectedTimer.SecondsCounter.reset()
        DisableAllButtons()

    End Sub






    Private Sub SecondsCounter_Click1(sender As Object, e As EventArgs) Handles SecondsCounter.Click
        Me.selectMe()
    End Sub

    Private Sub MinutesCounter_Click1(sender As Object, e As EventArgs) Handles MinutesCounter.Click
        Me.selectMe()
    End Sub

    Private Sub ColonLabel_Click1(sender As Object, e As EventArgs) Handles ColonLabel.Click
        Me.selectMe()
    End Sub

    Private Sub TitleLabel_Click1(sender As Object, e As EventArgs) Handles TitleLabel.Click
        Me.selectMe()
    End Sub




    Private Sub SingleTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TitleLabel.Text = Me.Title
    End Sub



End Class