Imports System.IO

Public Class Notepad__

    Dim aboutForm As New about()
    Dim pathOfCurrentFile As String

    Private Function checkChangesInFile()
        Dim result As Boolean = True
        ''False = there are no changes.

        If pathOfCurrentFile = "" Or txtMain.Text = "" Then
            result = False
        Else
            Dim myCheckStream As New StreamReader(pathOfCurrentFile)

            If myCheckStream.ReadToEnd = txtMain.Text Then
                result = False
            End If

        End If

        Return result

    End Function

    Private Sub openFileDialog()
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        openFileDialog.Filter = "txt files (*.txt)|*.txt|All Files(*.*)|*.*"
        openFileDialog.FilterIndex = 1

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            pathOfCurrentFile = Path.GetFullPath(openFileDialog.FileName)
            Dim myStream As New StreamReader(openFileDialog.FileName)
            txtMain.Text = myStream.ReadToEnd()
            txtMain.Visible = True
            myStream.Close()
        End If
    End Sub

    Private Sub saveFileDialog()
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "txt Files (*.txt)|*.txt|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True
        saveFileDialog.FileName = "Texto1.txt"


        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            pathOfCurrentFile = Path.GetFullPath(saveFileDialog.FileName)
            Dim myStream As New StreamWriter(saveFileDialog.FileName)
            myStream.Write(txtMain.Text)
            myStream.Close()
        End If
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        aboutForm.ShowDialog()
    End Sub

    Private Sub btnNewFile_Click(sender As Object, e As EventArgs) Handles btnNewFile.Click
        txtMain.Visible = True
        If checkChangesInFile = True Then
            Dim message As String = "Hay cambios sin guardar. Si prosigues se perderán los cambios."
            Dim caption As String = "Sobreescritura."
            Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult

            result = MessageBox.Show(message, caption, buttons)
            If result = DialogResult.Yes Then
                txtMain.Text = ""
            End If
        End If
    End Sub

    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        If checkChangesInFile() = True Then
            Dim message As String = "Hay cambios sin guardar. ¿Desea abrir un nuevo archivo y perder los cambios?"
            Dim caption As String = "Sobreescritura."
            Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult

            result = MessageBox.Show(message, caption, buttons)
            If result = DialogResult.Yes Then
                openFileDialog()
            End If
        Else
            openFileDialog()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If File.Exists(pathOfCurrentFile) = False Then
            saveFileDialog()
        Else
            Dim myStream As New StreamWriter(pathOfCurrentFile)
            myStream.WriteLine(txtMain.Text)
            myStream.Close()
        End If
    End Sub

    Private Sub btnSaveAs_Click(sender As Object, e As EventArgs) Handles btnSaveAs.Click
        saveFileDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If checkChangesInFile() = True Then
            Dim message As String = "Hay cambios sin guardar. ¿Deseas cerrar sin guardar?."
            Dim caption As String = "Sobreescritura."
            Dim buttons As MessageBoxButtons = MessageBoxButtons.YesNo
            Dim result As DialogResult

            result = MessageBox.Show(message, caption, buttons)
            If result = DialogResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnFont_Click(sender As Object, e As EventArgs) Handles btnFont.Click
        Dim fontDialogForm As New FontDialog

        fontDialogForm.ShowColor = False
        fontDialogForm.MaxSize = txtMain.Font.Size
        fontDialogForm.MinSize = txtMain.Font.Size
        fontDialogForm.Font = txtMain.Font

        If fontDialogForm.ShowDialog <> DialogResult.Cancel Then
            txtMain.Font = fontDialogForm.Font
        End If
    End Sub

    Private Sub btnNewSize_Click(sender As Object, e As EventArgs) Handles btnNewSize.Click
        If cboSize.Items.Count < 3 Then
            txtNewSize.Enabled = True
        Else
            MessageBox.Show("Ha introducido demasiados valores >:(", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtNewSize_KeyPress_Enter(sender As Object, e As KeyPressEventArgs) Handles txtNewSize.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then

            If IsNumeric(txtNewSize.Text) = True Then

                If cboSize.Items.Contains(txtNewSize.Text) = False Then
                    cboSize.SelectedIndex = cboSize.Items.Add(txtNewSize.Text)

                    ''Applying new font to the main textbox.
                    Dim newFont = New Font(txtMain.Font.Name, Convert.ToInt32(txtNewSize.Text), txtMain.Font.Style, txtMain.Font.Unit)
                    txtMain.Font = newFont
                    txtNewSize.Text = ""
                    txtNewSize.Enabled = False
                Else
                    MessageBox.Show("El valor introducido ya existe", "Valor ya existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("El valor introducido no es válido", "Valor no válido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            e.Handled = True

        End If

    End Sub

    Private Sub cboSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSize.SelectedIndexChanged
        If IsNumeric(cboSize.SelectedItem) = True Then
            Dim newFont = New Font(txtMain.Font.Name, Convert.ToInt32(cboSize.SelectedItem), txtMain.Font.Style, txtMain.Font.Unit)
            txtMain.Font = newFont
        End If

    End Sub

    Private Sub btnBackgroundColor_Click(sender As Object, e As EventArgs) Handles btnBackgroundColor.Click
        Dim colorDialogForm As New ColorDialog
        colorDialogForm.Color = txtMain.BackColor

        If colorDialogForm.ShowDialog <> DialogResult.Cancel Then
            txtMain.BackColor = colorDialogForm.Color
        End If

    End Sub

    Private Sub btnTextColor_Click(sender As Object, e As EventArgs) Handles btnTextColor.Click
        Dim colorDialogForm As New ColorDialog
        colorDialogForm.Color = txtMain.ForeColor

        If colorDialogForm.ShowDialog <> DialogResult.Cancel Then
            txtMain.ForeColor = colorDialogForm.Color
        End If
    End Sub

    Private Sub btnCut_Click(sender As Object, e As EventArgs) Handles btnCut.Click
        txtMain.Cut()
    End Sub

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        txtMain.Copy()
    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs) Handles btnPaste.Click
        txtMain.Paste()
    End Sub
End Class