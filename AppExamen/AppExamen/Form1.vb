Public Class Form1

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim primos = New Examen.Serie_Primos(CInt(txtNumInicio.Text), 0)
        Dim cells() As Label = {lblCell1, lblCell2, lblCell3, lblCell4, lblCell5, lblCell6, lblCell7, lblCell8, lblCell9, lblCell10}


        Dim r = primos.calcularPrimos()

        Dim i As Integer
        For Each item In r
            cells(i).Text = item

            i += 1
        Next

    End Sub
End Class
