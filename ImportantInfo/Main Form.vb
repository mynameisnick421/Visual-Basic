Public Class frmOne
    Private Sub btnElect_Click(sender As Object, e As EventArgs) Handles btnElect.Click
        lblNameDis.Text = "Bob Lawbla"
        lblPhoneDis.Text = "641-777-7890"
    End Sub

    Private Sub btnPlumb_Click(sender As Object, e As EventArgs) Handles btnPlumb.Click
        lblNameDis.Text = "Bob Vila"
        lblPhoneDis.Text = "641-295-4567"
    End Sub

    Private Sub btnDoc_Click(sender As Object, e As EventArgs) Handles btnDoc.Click
        lblNameDis.Text = "Bob Ross"
        lblPhoneDis.Text = "641-295-6543"
    End Sub

    Private Sub btnHosp_Click(sender As Object, e As EventArgs) Handles btnHosp.Click
        lblNameDis.Text = "Bob Barker"
        lblPhoneDis.Text = "641-295-9393"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
