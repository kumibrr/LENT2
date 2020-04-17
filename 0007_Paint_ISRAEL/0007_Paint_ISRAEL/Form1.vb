Public Class Form1
    Dim colorDialogForm = New ColorDialog
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim paintingAreaForm As New paintingAreaForm
        paintingAreaForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPencilColor_Click(sender As Object, e As EventArgs) Handles btnPencilColor.Click
        colorDialogForm.ShowDialog()
    End Sub


End Class
