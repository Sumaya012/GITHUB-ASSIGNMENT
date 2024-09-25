Public Class Form1
    Private Sub btncounttozero_Click(sender As Object, e As EventArgs) Handles btncounttozero.Click
        Dim numberEntered As Integer = txtnumberentered.Text
        While numberEntered
            MessageBox.Show("Number" & numberEntered)
            numberEntered = numberEntered - 1
        End While
    End Sub
End Class
