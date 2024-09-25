Public Class Form1
    Private Sub btnclicl_Click(sender As Object, e As EventArgs) Handles btnclick.Click
        Dim Name As String = txtname.Text
        Dim Age As String = txtage.Text
        Dim Favoritecolor As String = txtfavoritecolor.Text
        MessageBox.Show(Name & Age & Favoritecolor)
    End Sub
End Class
