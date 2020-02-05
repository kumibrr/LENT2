Module Module1
    'Model definition
    Const PRESENT_PARTIES As Integer = 3
    Const SEATS_AVAILABLE As Integer = 5

    Structure Party
        Dim partyName As String
        Dim votes As Integer
        Dim seats As Integer
        Dim percentage As Integer
    End Structure

    Dim parties(PRESENT_PARTIES) As Party
    Dim partiesTable(,)
    Dim discaredParties As Integer = 0
    Dim totalVotes As Integer = 0

    'Subroutines and functions

    Function CalculatePercentageAndDiscard(party() As Party)

        For i = 0 To parties.Length - 1
            totalVotes += parties(i).votes
        Next

        For i = 0 To party.Length - 1
            party(i).percentage = CInt(party(i).votes * 100 / totalVotes)
            If party(i).percentage < 3 Then
                discaredParties = discaredParties + 1
            End If
        Next
        Return discaredParties
    End Function

    Sub drawTable()
        ReDim partiesTable((parties.Length - (1 + discaredParties)), SEATS_AVAILABLE - 1)
        For i = 0 To parties.Length - (1 + discaredParties)

            For j = 0 To SEATS_AVAILABLE - 1

                partiesTable(i, j) = parties(i).votes / (j + 1)

            Next

        Next

    End Sub

    Sub distributeSeats()
        Dim seatsOccupied As Integer = 0
        Dim highestValuei As Integer
        Dim highestValuej As Integer

        While seatsOccupied < SEATS_AVAILABLE
            For i = 0 To (partiesTable.GetLength(0) - 1)

                For j = 0 To (partiesTable.GetLength(1) - 1)
                    If partiesTable(i, j) > partiesTable(highestValuei, highestValuej) Then
                        highestValuei = i
                        highestValuej = j
                    End If
                Next

            Next

            seatsOccupied += 1
            parties(highestValuei).seats += 1
            partiesTable(highestValuei, highestValuej) = 0
            highestValuei = 0
            highestValuej = 0
        End While

    End Sub

    Function readData()
        parties(0).partyName = "Partido A"
        parties(0).votes = 2000
        parties(1).partyName = "Partido B"
        parties(1).votes = 3000
        parties(2).partyName = "Partido C"
        parties(2).votes = 1000
        parties(3).partyName = "Partido D"
        parties(3).votes = 100

        Return parties
    End Function

    Sub writeToConsole()
        For i = 0 To parties.Length - 1
            Console.WriteLine("Partido: {0}. Porcentaje de votos: {1}. Votos: {2}. Escaños asignados: {3}", parties(i).partyName, parties(i).percentage, parties(i).votes, parties(i).seats)
            Console.WriteLine("")
        Next
        Console.ReadLine()
    End Sub

    'Main subroutine

    Sub Main()
        Dim parties() As Party = readData()
        discaredParties = CalculatePercentageAndDiscard(parties)
        drawTable()
        distributeSeats()
        writeToConsole()
    End Sub

End Module
