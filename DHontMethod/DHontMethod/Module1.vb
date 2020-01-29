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
    Dim discaredParties

    'Subroutines and functions

    Function CalculatePercentageAndDiscard(party() As Party)
        Dim discaredParties As Integer = 0
        Dim totalVotes As Integer = 0

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

    Sub FillTable()

        For index = 0 To parties.Length - (1 + discaredParties)

            For index2 = 1 To SEATS_AVAILABLE

                partiesTable(index, index2 - 1) = parties(index).votes / index2

            Next

        Next

    End Sub

    Function ReadData()
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

    'Main subroutine

    Sub Main()
        Dim parties() As Party = ReadData()
        discaredParties = CalculatePercentageAndDiscard(parties)
        ReDim partiesTable((parties.Length - (1 + discaredParties)), SEATS_AVAILABLE - 1)
        FillTable()
    End Sub

End Module
