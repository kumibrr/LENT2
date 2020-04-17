Public Class paintingAreaForm
    Dim area As Graphics = Me.CreateGraphics
    Dim myPen As Pen
    Dim myErrasePen As Pen



    Private Sub paintingAreaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pencilCursor As New System.IO.MemoryStream(My.Resources.Pencil_Normal_select)
        Me.Cursor = New Cursor(pencilCursor)
    End Sub

    Private Sub paintingAreaForm_Click(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        myPen = New Pen(Color.Black, Width = 1)
        myErrasePen = New Pen(Color.White, Width = 1)

        If MouseButtons.HasFlag(MouseButtons.Left) Then
            area.DrawRectangle(myPen, e.X, e.Y, 1, 1)
        ElseIf MouseButtons.HasFlag(MouseButtons.Right) Then
            Dim eraserCursor As New System.IO.MemoryStream(My.Resources.Eraser)
            Me.Cursor = New Cursor(eraserCursor)
            area.DrawRectangle(myErrasePen, e.X, e.Y, 1, 1)
        Else
            Dim pencilCursor As New System.IO.MemoryStream(My.Resources.Pencil_Normal_select)
            Me.Cursor = New Cursor(pencilCursor)
        End If


    End Sub


End Class