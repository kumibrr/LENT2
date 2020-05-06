Public Class Serie_Primos
    Inherits Serie_Numeros

    Sub New(i As Integer, r As Integer)
        MyBase.New(i, r)
    End Sub

    Function calcularPrimos()
        Dim num As Integer = getNumeroInicio()
        Dim response(9) As Integer

        For i = 0 To 9 Step 1

            If num Mod 2 = 0 Then
                num += 1
                response(i) = num
            Else
                response(i) = num
            End If
            num += 1

        Next
        Return response
    End Function


End Class
