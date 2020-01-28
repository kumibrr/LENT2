Module Module1
    Const PRESENT_PARTIES As Integer = 3
    Const TOTAL_VOTES As Integer = 6100
    Const SEATS_AVAILABLE As Integer = 5

    Structure Party
        Dim partyName As String
        Dim votes As Integer
        Dim seats As Integer
        Dim percentage As Decimal
    End Structure



    Function CalculatePercentageAndDiscard(party() As Party)
        Dim discaredParties As Integer
        For index = 0 To party.Length - 1
            party(index).percentage = CInt(party(index).votes * 100 / TOTAL_VOTES)

            If party(index).percentage < 3 Then
                party(index).votes = 0
                discaredParties = discaredParties + 1
            End If
        Next

        Return discaredParties
    End Function

    Sub ConstructTable(party() As Party, discaredParties As Integer)

        For index = 0 To party.Length - (1 + discaredParties)

        Next

    End Sub


    Sub Main()
        Dim parties(PRESENT_PARTIES) As Party
        Dim discaredParties As Integer

        parties(0).partyName = "Partido A"
        parties(0).votes = 2000
        parties(1).partyName = "Partido B"
        parties(1).votes = 3000
        parties(2).partyName = "Partido C"
        parties(2).votes = 1000
        parties(3).partyName = "Partido D"
        parties(3).votes = 100

        discaredParties = CalculatePercentageAndDiscard(parties)

    End Sub

End Module
