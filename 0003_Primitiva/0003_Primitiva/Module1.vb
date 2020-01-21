Module Module1

    Sub Main()
        'Model. This is an array to save the 6 integers
        Dim numbers(5) As Integer

        'Controller.
        'Generate 6 random numbers

        Dim index1 = 0
        Randomize()
        Do While index1 < 6
            numbers(index1) = Int(Rnd() * 49) + 1
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

        'For each to show in the numbers in the view.
        For Each numero As Integer In numbers
            Dim showNumber As String = numbers.ToString
            Console.WriteLine(showNumber)
        Next

        Console.ReadLine()


    End Sub


End Module
