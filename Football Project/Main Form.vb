Public Class frmOne
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblFscoreDis.Text = 0
        tbxFgs.Text = ""
        tbxOpc.Text = ""
        tbxSafties.Text = ""
        tbxTds.Text = ""
        tbxTpc.Text = ""
    End Sub
End Class
