Public Class Serie_Numeros
    Private numeroInicio As Integer
    Private razon As Integer

    Public Function getNumeroInicio()
        Return numeroInicio
    End Function
    Public Function getRazon()
        Return razon
    End Function

    Public Sub setNumeroInicio(num As Integer)
        numeroInicio = num
    End Sub
    Public Sub setRazon(num As Integer)
        razon = num
    End Sub

    Public Sub New(i As Integer, r As Integer)
        MyBase.New()
        numeroInicio = i
        razon = r
    End Sub

    Public Function calcularDiezPrimeros()
        Dim serie(9) As Integer

        For i = 0 To 9 Step 1
            serie(i) = numeroInicio * razon * i

        Next

        Return serie
    End Function
End Class
