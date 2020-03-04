Public Class mainMenuForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ColorForm.ShowDialog()
    End Sub

    Private Sub btnComp_Click(sender As Object, e As EventArgs) Handles btnComp.Click
        specsSelector.ShowDialog()
    End Sub
End Class