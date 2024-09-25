Public Class Form1
    Private Sub btncheck_Click(sender As Object, e As EventArgs) Handles btncheck.Click
        Dim number As Integer = txtnumber.Text
        If number = 0 Then
            MessageBox.Show("Zero")
        ElseIf number > 0 Then
            MessageBox.Show("Positive")
        ElseIf number < 0 Then
            MessageBox.Show("Negative")
        End If

    End Sub
End Class
