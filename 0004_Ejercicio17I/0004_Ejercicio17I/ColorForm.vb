Public Class ColorForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAmarillo.Click
        lblColorArea.BackColor = ColorForm.Yellow
        lblColor.ForeColor = ColorForm.Yellow
    End Sub

    Private Sub btnRojo_Click(sender As Object, e As EventArgs) Handles btnRojo.Click
        lblColorArea.BackColor = ColorForm.Red
        lblColor.ForeColor = ColorForm.Red
    End Sub

    Private Sub btnCyan_Click(sender As Object, e As EventArgs) Handles btnCyan.Click
        lblColorArea.BackColor = ColorForm.Cyan
        lblColor.ForeColor = ColorForm.Cyan
    End Sub

    Private Sub btnVerde_Click(sender As Object, e As EventArgs) Handles btnVerde.Click
        lblColorArea.BackColor = ColorForm.Green
        lblColor.ForeColor = ColorForm.Green
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
