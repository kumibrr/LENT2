Module Module1

    Sub Main()
        Dim random As New Random()

        Dim ticket(5) As Integer
        Dim index As Integer = 0
        Dim ticketDone As Boolean = False
        Randomize()

        Do While index < 6

            ticket(index) = Int((Rnd() * 49) + 1)


            Dim isAlready As Boolean = False
            Dim index2 As Integer
            For index2 = 0 To index - 1
                If ticket(index) = ticket(index2) Then
                    isAlready = True
                End If
                index2 = +1
            Next

            If isAlready = False Then
                index += 1
            End If

        Loop
        Console.WriteLine(ticket(0).ToString)
        Console.WriteLine(ticket(1).ToString)
        Console.WriteLine(ticket(2).ToString)
        Console.WriteLine(ticket(3).ToString)
        Console.WriteLine(ticket(4).ToString)
        Console.WriteLine(ticket(5).ToString)
        Console.ReadLine()
    End Sub

End Module
