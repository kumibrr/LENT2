<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class colorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblColorArea = New System.Windows.Forms.Label()
        Me.btnAmarillo = New System.Windows.Forms.Button()
        Me.btnRojo = New System.Windows.Forms.Button()
        Me.btnCyan = New System.Windows.Forms.Button()
        Me.btnVerde = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblColor.ForeColor = System.Drawing.Color.Red
        Me.lblColor.Location = New System.Drawing.Point(230, 26)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(60, 30)
        Me.lblColor.TabIndex = 0
        Me.lblColor.Text = "Color"
        Me.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColorArea
        '
        Me.lblColorArea.BackColor = System.Drawing.Color.Red
        Me.lblColorArea.Location = New System.Drawing.Point(119, 83)
        Me.lblColorArea.Name = "lblColorArea"
        Me.lblColorArea.Size = New System.Drawing.Size(300, 100)
        Me.lblColorArea.TabIndex = 1
        '
        'btnAmarillo
        '
        Me.btnAmarillo.Location = New System.Drawing.Point(33, 226)
        Me.btnAmarillo.Name = "btnAmarillo"
        Me.btnAmarillo.Size = New System.Drawing.Size(75, 23)
        Me.btnAmarillo.TabIndex = 2
        Me.btnAmarillo.Text = "Amarillo"
        Me.btnAmarillo.UseVisualStyleBackColor = True
        '
        'btnRojo
        '
        Me.btnRojo.Location = New System.Drawing.Point(154, 226)
        Me.btnRojo.Name = "btnRojo"
        Me.btnRojo.Size = New System.Drawing.Size(75, 23)
        Me.btnRojo.TabIndex = 3
        Me.btnRojo.Text = "Rojo"
        Me.btnRojo.UseVisualStyleBackColor = True
        '
        'btnCyan
        '
        Me.btnCyan.Location = New System.Drawing.Point(282, 226)
        Me.btnCyan.Name = "btnCyan"
        Me.btnCyan.Size = New System.Drawing.Size(75, 23)
        Me.btnCyan.TabIndex = 4
        Me.btnCyan.Text = "Cyan"
        Me.btnCyan.UseVisualStyleBackColor = True
        '
        'btnVerde
        '
        Me.btnVerde.Location = New System.Drawing.Point(410, 226)
        Me.btnVerde.Name = "btnVerde"
        Me.btnVerde.Size = New System.Drawing.Size(75, 23)
        Me.btnVerde.TabIndex = 5
        Me.btnVerde.Text = "Verde"
        Me.btnVerde.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(215, 278)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'colorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(532, 325)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnVerde)
        Me.Controls.Add(Me.btnCyan)
        Me.Controls.Add(Me.btnRojo)
        Me.Controls.Add(Me.btnAmarillo)
        Me.Controls.Add(Me.lblColorArea)
        Me.Controls.Add(Me.lblColor)
        Me.Name = "colorForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblColor As Label
    Friend WithEvents lblColorArea As Label
    Friend WithEvents btnAmarillo As Button
    Friend WithEvents btnRojo As Button
    Friend WithEvents btnCyan As Button
    Friend WithEvents btnVerde As Button
    Friend WithEvents btnClose As Button
End Class
