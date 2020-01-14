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
        Me.labelSecondNum = New System.Windows.Forms.Label()
        Me.labelFirstNum = New System.Windows.Forms.Label()
        Me.labelThirdNum = New System.Windows.Forms.Label()
        Me.winPanel = New System.Windows.Forms.Panel()
        Me.imageLeprechaun = New System.Windows.Forms.PictureBox()
        Me.winLabel = New System.Windows.Forms.Label()
        Me.mainControlPanel.SuspendLayout()
        Me.winPanel.SuspendLayout()
        CType(Me.imageLeprechaun, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mainControlPanel.Controls.Add(Me.labelSecondNum)
        Me.mainControlPanel.Controls.Add(Me.labelFirstNum)
        Me.mainControlPanel.Controls.Add(Me.labelThirdNum)
        Me.mainControlPanel.Controls.Add(Me.runButton)
        Me.mainControlPanel.Controls.Add(Me.endButton)
        Me.mainControlPanel.Location = New System.Drawing.Point(12, 12)
        Me.mainControlPanel.Name = "mainControlPanel"
        Me.mainControlPanel.Size = New System.Drawing.Size(272, 53)
        Me.mainControlPanel.TabIndex = 2
        '
        'labelSecondNum
        '
        Me.labelSecondNum.AutoSize = True
        Me.labelSecondNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelSecondNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelSecondNum.Location = New System.Drawing.Point(172, 3)
        Me.labelSecondNum.Name = "labelSecondNum"
        Me.labelSecondNum.Size = New System.Drawing.Size(44, 48)
        Me.labelSecondNum.TabIndex = 3
        Me.labelSecondNum.Text = "1"
        '
        'labelFirstNum
        '
        Me.labelFirstNum.AutoSize = True
        Me.labelFirstNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelFirstNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelFirstNum.Location = New System.Drawing.Point(115, 3)
        Me.labelFirstNum.Name = "labelFirstNum"
        Me.labelFirstNum.Size = New System.Drawing.Size(44, 48)
        Me.labelFirstNum.TabIndex = 2
        Me.labelFirstNum.Text = "1"
        '
        'labelThirdNum
        '
        Me.labelThirdNum.AutoSize = True
        Me.labelThirdNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.labelThirdNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelThirdNum.Location = New System.Drawing.Point(227, 3)
        Me.labelThirdNum.Name = "labelThirdNum"
        Me.labelThirdNum.Size = New System.Drawing.Size(44, 48)
        Me.labelThirdNum.TabIndex = 0
        Me.labelThirdNum.Text = "1"
        '
        'winPanel
        '
        Me.winPanel.Controls.Add(Me.imageLeprechaun)
        Me.winPanel.Controls.Add(Me.winLabel)
        Me.winPanel.Location = New System.Drawing.Point(12, 71)
        Me.winPanel.Name = "winPanel"
        Me.winPanel.Size = New System.Drawing.Size(272, 142)
        Me.winPanel.TabIndex = 3
        Me.winPanel.Visible = False
        '
        'imageLeprechaun
        '
        Me.imageLeprechaun.Image = CType(resources.GetObject("imageLeprechaun.Image"), System.Drawing.Image)
        Me.imageLeprechaun.Location = New System.Drawing.Point(120, 3)
        Me.imageLeprechaun.Name = "imageLeprechaun"
        Me.imageLeprechaun.Size = New System.Drawing.Size(149, 136)
        Me.imageLeprechaun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imageLeprechaun.TabIndex = 1
        Me.imageLeprechaun.TabStop = False
        Me.imageLeprechaun.Visible = False
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
        Me.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        CType(Me.imageLeprechaun, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents runButton As Button
    Friend WithEvents endButton As Button
    Friend WithEvents mainControlPanel As Panel
    Friend WithEvents winPanel As Panel
    Friend WithEvents winLabel As Label
    Friend WithEvents labelThirdNum As Label
    Friend WithEvents imageLeprechaun As PictureBox
    Friend WithEvents labelSecondNum As Label
    Friend WithEvents labelFirstNum As Label
End Class
