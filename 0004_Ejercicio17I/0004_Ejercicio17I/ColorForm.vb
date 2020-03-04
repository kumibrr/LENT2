Public Class colorForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAmarillo.Click
        lblColorArea.BackColor = Color.Yellow
        lblColor.ForeColor = Color.Yellow
    End Sub

    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        lblColorArea.BackColor = Color.Red
        lblColor.ForeColor = Color.Red
    End Sub

    Private Sub btnCyan_Click(sender As Object, e As EventArgs) Handles btnCyan.Click
        lblColorArea.BackColor = Color.Cyan
        lblColor.ForeColor = Color.Cyan
    End Sub

    Private Sub btnVerde_Click(sender As Object, e As EventArgs) Handles btnVerde.Click
        lblColorArea.BackColor = Color.Green
        lblColor.ForeColor = Color.Green
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub lblColor_Click(sender As Object, e As EventArgs) Handles lblColor.Click

    End Sub
End Class
