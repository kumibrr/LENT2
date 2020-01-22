Module Module1

    Sub Main()
        'Model. This is an array to save the 6 integers
        Dim numbers(5) As Integer

        'Controller.
        'Generate 6 random numbers

        Dim index1 As Integer = 0
        Randomize()
        Do While index1 < 6
            numbers(index1) = randomInt(1, 49)
            'Check if it is repeated
            Dim repeated As Boolean = False
            Dim index2 As Integer
            For index2 = 0 To index1 - 1
                If numbers(index1) = numbers(index2) Then
                    repeated = True
                    Exit For
                End If
            Next
            If repeated = False Then
                index1 += 1
            End If

        Loop

        'For-each to show the numbers in the view.
        For Each index As Integer In numbers
            Console.WriteLine(numbers)
        Next

        Console.ReadLine()
    End Sub

    Function randomInt(min As Integer, max As Integer) As Integer
        Return Int(Rnd() * max) + min
    End Function


End Module
