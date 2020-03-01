Public Class frmOne
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnBirthday_Click(sender As Object, e As EventArgs) Handles btnBirthday.Click
        lblTitle.Text = "Birthday Cake"
        picSelection.Image = picBirthday.Image
    End Sub

    Private Sub btnWedding_Click(sender As Object, e As EventArgs) Handles btnWedding.Click
        lblTitle.Text = "Wedding Cake"
        picSelection.Image = picWedding.Image
    End Sub
End Class
