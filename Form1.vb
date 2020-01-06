Public Class Center
    Inherits Form



    Sub Minutes_Click(sender As Object, e As EventArgs) Handles Min1.Click, Min3.Click, Min10.Click
        Dim beeping As Boolean = SingleTimer.SelectedTimer.beeping
        Dim countdown As Boolean = SingleTimer.SelectedTimer.countdown

        If Not beeping And Not countdown Then
            SingleTimer.SelectedTimer.StartButton.Enabled = True
            SingleTimer.SelectedTimer.StartButton.ForeColor = Color.Lime
            SingleTimer.SelectedTimer.ClearButton.Enabled = True
            SingleTimer.SelectedTimer.ClearButton.ForeColor = Color.Black
            SingleTimer.SelectedTimer.MinutesCounter.ForeColor = Color.RoyalBlue
            SingleTimer.SelectedTimer.ColonLabel.ForeColor = Color.RoyalBlue
            SingleTimer.SelectedTimer.SecondsCounter.ForeColor = Color.RoyalBlue
            SingleTimer.AddMinutesToSelected(sender.Tag)
        End If
    End Sub


    Sub Seconds_Click(sender As Object, e As EventArgs) Handles Sec1.Click, Sec3.Click, Sec10.Click
        Dim beeping As Boolean = SingleTimer.SelectedTimer.beeping
        Dim countdown As Boolean = SingleTimer.SelectedTimer.countdown

        If Not beeping And Not countdown Then
            SingleTimer.SelectedTimer.StartButton.Enabled = True
            SingleTimer.SelectedTimer.StartButton.ForeColor = Color.Lime
            SingleTimer.SelectedTimer.ClearButton.Enabled = True
            SingleTimer.SelectedTimer.ClearButton.ForeColor = Color.Black
            SingleTimer.SelectedTimer.MinutesCounter.ForeColor = Color.RoyalBlue
            SingleTimer.SelectedTimer.ColonLabel.ForeColor = Color.RoyalBlue
            SingleTimer.SelectedTimer.SecondsCounter.ForeColor = Color.RoyalBlue
            SingleTimer.AddSecondsToSelected(sender.Tag)
        End If
    End Sub


    Private Sub Center_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserControl11.Title = "Back Left"
        UserControl12.Title = "Back Right"
        UserControl13.Title = "Front Left"
        UserControl14.Title = "Front Right"

        UserControl11.TitleLabel.Text = UserControl11.Title
        UserControl12.TitleLabel.Text = UserControl12.Title
        UserControl13.TitleLabel.Text = UserControl13.Title
        UserControl14.TitleLabel.Text = UserControl14.Title

        UserControl11.selectMe()

    End Sub


End Class
