Public MustInherit Class Counter
    Inherits Label


    Protected maxvalue As Integer
    Protected value As Integer

    Function getValue()
        Return value
    End Function

    Function isMax()
        If maxvalue = value Then
            Return True
        Else
            Return False
        End If
    End Function

    Function isZero()
        If value = 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub reset()
        Me.setValue(0)
        Me.Text = "00"
    End Sub

    Sub setToMax()
        Me.setValue(maxvalue)
        Me.Text = maxvalue.ToString
    End Sub

    Sub setValue(newvalue As Integer)
        Me.value = newvalue

    End Sub

    Function getMax()
        Return maxvalue
    End Function

End Class

Public Class MinutesCounter
    Inherits Counter

    Shadows maxvalue As Integer = 99
    Shadows value = 0

    Dim secCounter As SecondsCounter


    Sub decrement()
        Me.value -= 1
        If Me.value < 10 Then
            Me.Text = "0" + Me.value.ToString
        Else
            Me.Text = Me.value.ToString
        End If

    End Sub

    Sub increaseBy(increment As Integer)
        Me.value += increment
    End Sub

    Sub setSecondsCounter(newcounter As SecondsCounter)
        Me.secCounter = newcounter
    End Sub
End Class

Public Class SecondsCounter
    Inherits Counter

    Shadows maxvalue As Integer = 59
    Shadows value = 0

    Dim minCounter As MinutesCounter

    Function getMinuteCounter()
        Return minCounter
    End Function

    Sub decrement()
        Dim minutes As Integer = minCounter.getValue()
        Dim minutesString As String = minutes.ToString
        Dim seconds As Integer = Me.getValue()
        Dim secondsString As String = seconds.ToString

        If minutes > 0 And seconds = 0 Then
            Me.minCounter.decrement()
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

        minCounter.Text = minutesString
        Me.Text = secondsString

        minCounter.setValue(minutes)
        Me.setValue(seconds)
    End Sub

    Sub increaseBy(increment As Integer)
        Me.value += increment
    End Sub

    Sub setMinutesCounter(newcounter As MinutesCounter)
        Me.minCounter = newcounter
    End Sub
End Class

