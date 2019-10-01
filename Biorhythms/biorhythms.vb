Public Class frmBiorhythms

    Dim Coeff As Integer
    Dim Status As String
    Dim Days As Integer
    Dim D1 As Date
    Dim D2 As Date

    Private Sub Physical_CheckedChanged(sender As Object, e As EventArgs) Handles Physical.CheckedChanged
        Coeff = 23
        Status = "phisical"
    End Sub

    Private Sub Emotional_CheckedChanged(sender As Object, e As EventArgs) Handles Emotional.CheckedChanged
        Coeff = 28
        Status = "emotional"
    End Sub

    Private Sub Intellectual_CheckedChanged(sender As Object, e As EventArgs) Handles Intellectual.CheckedChanged
        Coeff = 33
        Status = "intellectual"
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        D1 = BirthDay.Text
        D2 = Today
        Days = DateDiff(DateInterval.Day, D1, D2)
        MsgBox("The percent of your " & Status & " state is " & Format(Math.Sin(360 * Days / Coeff), "00%"), 0, "Dr.Oz says...")
    End Sub
End Class
