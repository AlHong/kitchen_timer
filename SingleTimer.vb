Public Class UserControl1

End Class

Public Class SingleTimer
    Inherits UserControl

    Dim beeping As Boolean
    Dim beeps As Integer
    Dim countdown As Boolean
    Dim frequency As Integer

    Sub addMinutes(extraMins As Integer)

    End Sub

    Sub AddMinutesToSelected(extraMins As Integer)

    End Sub

    Sub addSeconds(extraSecs As Integer)

    End Sub

    Sub AddSecondsToSelected(extraSecs As Integer)

    End Sub

    Sub ClearButton_Click(sender As Object, e As EventArgs)

    End Sub

    Sub ClearButton_EnabledChanged(sender As Object, e As EventArgs)

    End Sub

    Sub deSelectMe()

    End Sub

    Sub DisableAllButtons()

    End Sub

    Sub initialize()

    End Sub

    Sub newBackcolor(newcolor As Color)

    End Sub

    Sub newForecolor(newcolor As Color)

    End Sub

    Sub selectMe()

    End Sub

    Sub SetLook()

    End Sub

    Sub SingleTimer_Click(sender As Object, e As EventArgs)

    End Sub

    Sub soundAlarm()

    End Sub

    Sub StartButton_Click(sender As Object, e As EventArgs)

    End Sub

    Sub StartButton_EnabledChanged(sender As Object, e As EventArgs)

    End Sub

    Sub stopTiming()

    End Sub

    Sub Timer_Tick(sender As Object, e As EventArgs)

    End Sub
End Class

Public MustInherit Class Counter
    Inherits Label

    Dim maxvalue As Integer
    Dim value As Integer

    Sub isMax()

    End Sub

    Sub isZero()

    End Sub

    Sub reset()

    End Sub

    Sub setToMax()

    End Sub

    Sub setValue(newvalue As Integer)

    End Sub
End Class

Public Class MinutesCounter
    Inherits Counter

    Sub decrement()

    End Sub

    Sub increaseBy(increment As Integer)

    End Sub

    Sub setSecondsCounter(newcounter As SecondsCounter)

    End Sub
End Class

Public Class SecondsCounter
    Inherits Counter

    Sub decrement()

    End Sub

    Sub increaseBy(increment As Integer)

    End Sub

    Sub setMinutesCounter(newcounter As MinutesCounter)

    End Sub
End Class

