<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.runButton = New System.Windows.Forms.Button()
        Me.endButton = New System.Windows.Forms.Button()
        Me.mainControlPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.firstNumber = New System.Windows.Forms.Label()
        Me.winPanel = New System.Windows.Forms.Panel()
        Me.leprechaunImage = New System.Windows.Forms.PictureBox()
        Me.winLabel = New System.Windows.Forms.Label()
        Me.mainControlPanel.SuspendLayout()
        Me.winPanel.SuspendLayout()
        CType(Me.leprechaunImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'runButton
        '
        Me.runButton.Location = New System.Drawing.Point(0, 0)
        Me.runButton.Name = "runButton"
        Me.runButton.Size = New System.Drawing.Size(75, 23)
        Me.runButton.TabIndex = 0
        Me.runButton.Text = "Run"
        Me.runButton.UseVisualStyleBackColor = True
        '
        'endButton
        '
        Me.endButton.Location = New System.Drawing.Point(0, 30)
        Me.endButton.Name = "endButton"
        Me.endButton.Size = New System.Drawing.Size(75, 23)
        Me.endButton.TabIndex = 1
        Me.endButton.Text = "End"
        Me.endButton.UseVisualStyleBackColor = True
        '
        'mainControlPanel
        '
        Me.mainControlPanel.Controls.Add(Me.Label2)
        Me.mainControlPanel.Controls.Add(Me.Label1)
        Me.mainControlPanel.Controls.Add(Me.firstNumber)
        Me.mainControlPanel.Controls.Add(Me.runButton)
        Me.mainControlPanel.Controls.Add(Me.endButton)
        Me.mainControlPanel.Location = New System.Drawing.Point(12, 12)
        Me.mainControlPanel.Name = "mainControlPanel"
        Me.mainControlPanel.Size = New System.Drawing.Size(272, 53)
        Me.mainControlPanel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 48)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "1"
        '
        'firstNumber
        '
        Me.firstNumber.AutoSize = True
        Me.firstNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.firstNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumber.Location = New System.Drawing.Point(227, 3)
        Me.firstNumber.Name = "firstNumber"
        Me.firstNumber.Size = New System.Drawing.Size(44, 48)
        Me.firstNumber.TabIndex = 0
        Me.firstNumber.Text = "1"
        '
        'winPanel
        '
        Me.winPanel.Controls.Add(Me.leprechaunImage)
        Me.winPanel.Controls.Add(Me.winLabel)
        Me.winPanel.Location = New System.Drawing.Point(12, 71)
        Me.winPanel.Name = "winPanel"
        Me.winPanel.Size = New System.Drawing.Size(272, 142)
        Me.winPanel.TabIndex = 3
        Me.winPanel.Visible = False
        '
        'leprechaunImage
        '
        Me.leprechaunImage.Image = CType(resources.GetObject("leprechaunImage.Image"), System.Drawing.Image)
        Me.leprechaunImage.Location = New System.Drawing.Point(120, 3)
        Me.leprechaunImage.Name = "leprechaunImage"
        Me.leprechaunImage.Size = New System.Drawing.Size(149, 136)
        Me.leprechaunImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.leprechaunImage.TabIndex = 1
        Me.leprechaunImage.TabStop = False
        Me.leprechaunImage.Visible = False
        '
        'winLabel
        '
        Me.winLabel.AutoSize = True
        Me.winLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.winLabel.ForeColor = System.Drawing.Color.Purple
        Me.winLabel.Location = New System.Drawing.Point(3, 11)
        Me.winLabel.Name = "winLabel"
        Me.winLabel.Size = New System.Drawing.Size(111, 50)
        Me.winLabel.TabIndex = 0
        Me.winLabel.Text = "Siete" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "afortunado!"
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 225)
        Me.Controls.Add(Me.winPanel)
        Me.Controls.Add(Me.mainControlPanel)
        Me.Name = "Form"
        Me.Text = "Form1"
        Me.mainControlPanel.ResumeLayout(False)
        Me.mainControlPanel.PerformLayout()
        Me.winPanel.ResumeLayout(False)
        Me.winPanel.PerformLayout()
        CType(Me.leprechaunImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents runButton As Button
    Friend WithEvents endButton As Button
    Friend WithEvents mainControlPanel As Panel
    Friend WithEvents winPanel As Panel
    Friend WithEvents winLabel As Label
    Friend WithEvents firstNumber As Label
    Friend WithEvents leprechaunImage As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
