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

        For index = 0 To parties.Length - 1
            totalVotes += parties(index).votes
        Next

        For index = 0 To party.Length - 1
            party(index).percentage = CInt(party(index).votes * 100 / totalVotes)
            If party(index).percentage < 3 Then
                party(index).votes = 0
                discaredParties = discaredParties + 1
            End If
        Next
        Return discaredParties
    End Function

    Sub fillTable()
        ReDim partiesTable((parties.Length - (1 + discaredParties)), SEATS_AVAILABLE - 1)
        For index = 0 To parties.Length - (1 + discaredParties)

            For index2 = 1 To SEATS_AVAILABLE

                partiesTable(index, index2 - 1) = parties(index).votes / index2

            Next

        Next

    End Sub

    Sub distributeSeats()
        Dim seatsOccupied As Integer = 0
        Dim highestValueIndex1 As Integer
        Dim highestValueIndex2 As Integer
        Dim index2Limit As Integer = (partiesTable.GetLength(1) - 1)
        Dim index1Limit As Integer = (partiesTable.GetLength(0) - 1)

        While seatsOccupied < SEATS_AVAILABLE
            For index = 0 To index1Limit

                For index2 = 0 To index2Limit
                    If partiesTable(index, index2) > partiesTable(highestValueIndex1, highestValueIndex2) Then
                        highestValueIndex1 = index
                        highestValueIndex2 = index2
                    End If

                Next
            Next
            seatsOccupied += 1
            parties(highestValueIndex1).seats += 1
            partiesTable(highestValueIndex1, highestValueIndex2) = 0
            highestValueIndex1 = 0
            highestValueIndex2 = 0

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
        For index = 0 To parties.Length - 1
            Console.WriteLine("Nombre: " + parties(index).partyName)
            Console.WriteLine("Porcentaje votos: " + parties(index).percentage.ToString)
            Console.WriteLine("Votos al partido: " + parties(index).votes.ToString)
            Console.WriteLine("Escanyos asignados: " + parties(index).seats.ToString)
        Next
        Console.ReadLine()
    End Sub

    'Main subroutine

    Sub Main()
        Dim parties() As Party = readData()
        discaredParties = CalculatePercentageAndDiscard(parties)
        fillTable()
        distributeSeats()
        writeToConsole()
    End Sub

End Module
