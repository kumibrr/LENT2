Public Class MainForm
    Inherits Form

    Private lblFormTitle As Label
    Private txtFormtitle As TextBox
    Private lblFormTxtBox As Label
    Private txtFormTxtBox As TextBox
    Private lblButton1 As Label
    Private txtButton1 As TextBox
    Private lblButton2 As Label
    Private txtButton2 As TextBox
    Private lblButton3 As Label
    Private txtButton3 As TextBox
    Private btnModal As Button
    Private btnNotModal As Button
    Private btnExit As Button


    Public Sub New()
        MyBase.New()
        Me.Size = New Size(400, 300)

        lblFormTitle = New Label
        lblFormTitle.Text = "Window title"
        lblFormTitle.Location = New Point(15, 10)
        lblFormTitle.Size = New Size(100, 20)
        txtFormtitle = New TextBox
        txtFormtitle.Location = New Point(150, 8)
        txtFormtitle.Size = New Size(200, 20)

        lblFormTxtBox = New Label
        lblFormTxtBox.Text = "Text inside the window"
        lblFormTxtBox.Size = New Size(100, 40)
        lblFormTxtBox.Location = New Point(15, 40)

        txtFormTxtBox = New TextBox
        txtFormTxtBox.Size = New Size(132, 20)
        txtFormTxtBox.Location = New Point(120, 45)

        btnExit = New Button
        btnExit.Location = New Point(50, 50)

        Me.Controls.Add(lblFormTitle)
        Me.Controls.Add(txtFormtitle)
        Me.Controls.Add(lblFormTxtBox)
        Me.Controls.Add(txtFormTxtBox)
        Me.Controls.Add(btnExit)

        Me.ShowDialog()
        Me.ShowDialog()

    End Sub
End Class