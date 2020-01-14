Public Class Form
    ' sender = target
    ' e = objeto evento
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub runButton_Click(sender As Object, e As EventArgs) Handles runButton.Click
        imageLeprechaun.Visible = False
    End Sub

    Private Sub mainControlPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainControlPanel.Paint

    End Sub

    Private Sub endButton_Click(sender As Object, e As EventArgs) Handles endButton.Click
        End
    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles labelFirstNum.Click

    End Sub
End Class
