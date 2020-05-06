Module Module1
    Dim primos As New Serie_Primos(0, 1)

    Sub calculos()
        Dim serie = primos.calcularPrimos()

        For Each item In serie
            Console.WriteLine(item)
        Next
    End Sub


End Module
