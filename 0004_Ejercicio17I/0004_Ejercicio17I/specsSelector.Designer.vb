<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class specsSelector
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtPowerpc = New System.Windows.Forms.RadioButton()
        Me.rbtAmd = New System.Windows.Forms.RadioButton()
        Me.rbtIntel = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbtThirtytwoRam = New System.Windows.Forms.RadioButton()
        Me.rbtSixteenRam = New System.Windows.Forms.RadioButton()
        Me.rbtEightRam = New System.Windows.Forms.RadioButton()
        Me.rbtOneHdd = New System.Windows.Forms.GroupBox()
        Me.rbtSixHdd = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.rbtFivetwelveHdd = New System.Windows.Forms.RadioButton()
        Me.lblView = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.rbtOneHdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtPowerpc)
        Me.GroupBox1.Controls.Add(Me.rbtAmd)
        Me.GroupBox1.Controls.Add(Me.rbtIntel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Processador"
        '
        'rbtPowerpc
        '
        Me.rbtPowerpc.AutoSize = True
        Me.rbtPowerpc.Location = New System.Drawing.Point(6, 65)
        Me.rbtPowerpc.Name = "rbtPowerpc"
        Me.rbtPowerpc.Size = New System.Drawing.Size(133, 17)
        Me.rbtPowerpc.TabIndex = 2
        Me.rbtPowerpc.TabStop = True
        Me.rbtPowerpc.Text = "PowerPC e700 3.2Ghz"
        Me.rbtPowerpc.UseVisualStyleBackColor = True
        '
        'rbtAmd
        '
        Me.rbtAmd.AutoSize = True
        Me.rbtAmd.Location = New System.Drawing.Point(6, 42)
        Me.rbtAmd.Name = "rbtAmd"
        Me.rbtAmd.Size = New System.Drawing.Size(155, 17)
        Me.rbtAmd.TabIndex = 1
        Me.rbtAmd.TabStop = True
        Me.rbtAmd.Text = "AMD Ryzen 5 3500 4.3Ghz"
        Me.rbtAmd.UseVisualStyleBackColor = True
        '
        'rbtIntel
        '
        Me.rbtIntel.AutoSize = True
        Me.rbtIntel.Location = New System.Drawing.Point(6, 19)
        Me.rbtIntel.Name = "rbtIntel"
        Me.rbtIntel.Size = New System.Drawing.Size(127, 17)
        Me.rbtIntel.TabIndex = 0
        Me.rbtIntel.TabStop = True
        Me.rbtIntel.Text = "Intel i5 7500K 4.1Ghz"
        Me.rbtIntel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbtThirtytwoRam)
        Me.GroupBox2.Controls.Add(Me.rbtSixteenRam)
        Me.GroupBox2.Controls.Add(Me.rbtEightRam)
        Me.GroupBox2.Location = New System.Drawing.Point(262, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 121)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Memoria RAM"
        '
        'rbtThirtytwoRam
        '
        Me.rbtThirtytwoRam.AutoSize = True
        Me.rbtThirtytwoRam.Location = New System.Drawing.Point(6, 65)
        Me.rbtThirtytwoRam.Name = "rbtThirtytwoRam"
        Me.rbtThirtytwoRam.Size = New System.Drawing.Size(85, 17)
        Me.rbtThirtytwoRam.TabIndex = 2
        Me.rbtThirtytwoRam.TabStop = True
        Me.rbtThirtytwoRam.Text = "32GB DDR4"
        Me.rbtThirtytwoRam.UseVisualStyleBackColor = True
        '
        'rbtSixteenRam
        '
        Me.rbtSixteenRam.AutoSize = True
        Me.rbtSixteenRam.Location = New System.Drawing.Point(6, 42)
        Me.rbtSixteenRam.Name = "rbtSixteenRam"
        Me.rbtSixteenRam.Size = New System.Drawing.Size(85, 17)
        Me.rbtSixteenRam.TabIndex = 1
        Me.rbtSixteenRam.TabStop = True
        Me.rbtSixteenRam.Text = "16GB DDR4"
        Me.rbtSixteenRam.UseVisualStyleBackColor = True
        '
        'rbtEightRam
        '
        Me.rbtEightRam.AutoSize = True
        Me.rbtEightRam.Location = New System.Drawing.Point(6, 19)
        Me.rbtEightRam.Name = "rbtEightRam"
        Me.rbtEightRam.Size = New System.Drawing.Size(79, 17)
        Me.rbtEightRam.TabIndex = 0
        Me.rbtEightRam.TabStop = True
        Me.rbtEightRam.Text = "8GB DDR4"
        Me.rbtEightRam.UseVisualStyleBackColor = True
        '
        'rbtOneHdd
        '
        Me.rbtOneHdd.Controls.Add(Me.rbtSixHdd)
        Me.rbtOneHdd.Controls.Add(Me.RadioButton8)
        Me.rbtOneHdd.Controls.Add(Me.rbtFivetwelveHdd)
        Me.rbtOneHdd.Location = New System.Drawing.Point(517, 25)
        Me.rbtOneHdd.Name = "rbtOneHdd"
        Me.rbtOneHdd.Size = New System.Drawing.Size(200, 121)
        Me.rbtOneHdd.TabIndex = 2
        Me.rbtOneHdd.TabStop = False
        Me.rbtOneHdd.Text = "Almacenamiento"
        '
        'rbtSixHdd
        '
        Me.rbtSixHdd.AutoSize = True
        Me.rbtSixHdd.Location = New System.Drawing.Point(7, 68)
        Me.rbtSixHdd.Name = "rbtSixHdd"
        Me.rbtSixHdd.Size = New System.Drawing.Size(109, 17)
        Me.rbtSixHdd.TabIndex = 2
        Me.rbtSixHdd.TabStop = True
        Me.rbtSixHdd.Text = "6TB HDD SATA3"
        Me.rbtSixHdd.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Location = New System.Drawing.Point(7, 44)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton8.TabIndex = 1
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "1TB SSD SATA3"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'rbtFivetwelveHdd
        '
        Me.rbtFivetwelveHdd.AutoSize = True
        Me.rbtFivetwelveHdd.Location = New System.Drawing.Point(7, 20)
        Me.rbtFivetwelveHdd.Name = "rbtFivetwelveHdd"
        Me.rbtFivetwelveHdd.Size = New System.Drawing.Size(91, 17)
        Me.rbtFivetwelveHdd.TabIndex = 0
        Me.rbtFivetwelveHdd.TabStop = True
        Me.rbtFivetwelveHdd.Text = "512GB NVMe"
        Me.rbtFivetwelveHdd.UseVisualStyleBackColor = True
        '
        'lblView
        '
        Me.lblView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblView.Location = New System.Drawing.Point(12, 162)
        Me.lblView.Name = "lblView"
        Me.lblView.Size = New System.Drawing.Size(705, 65)
        Me.lblView.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(239, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Visualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 242)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'specsSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 277)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblView)
        Me.Controls.Add(Me.rbtOneHdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "specsSelector"
        Me.Text = "specsSelector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.rbtOneHdd.ResumeLayout(False)
        Me.rbtOneHdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtPowerpc As RadioButton
    Friend WithEvents rbtAmd As RadioButton
    Friend WithEvents rbtIntel As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbtThirtytwoRam As RadioButton
    Friend WithEvents rbtSixteenRam As RadioButton
    Friend WithEvents rbtEightRam As RadioButton
    Friend WithEvents rbtOneHdd As GroupBox
    Friend WithEvents rbtSixHdd As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents rbtFivetwelveHdd As RadioButton
    Friend WithEvents lblView As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
