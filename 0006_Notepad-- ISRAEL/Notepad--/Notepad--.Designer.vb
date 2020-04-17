<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notepad__
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
        Me.mnuOptions = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOpenFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.StyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnBackgroundColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTextColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnNewSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtNewSize = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cboSize = New System.Windows.Forms.ToolStripComboBox()
        Me.btnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtMain = New System.Windows.Forms.TextBox()
        Me.mnuOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuOptions
        '
        Me.mnuOptions.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.mnuOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.StyleToolStripMenuItem, Me.EditToolStripMenuItem, Me.SizeToolStripMenuItem, Me.btnAbout})
        Me.mnuOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuOptions.Size = New System.Drawing.Size(1067, 42)
        Me.mnuOptions.TabIndex = 0
        Me.mnuOptions.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewFile, Me.btnOpenFile, Me.ToolStripSeparator1, Me.btnSave, Me.btnSaveAs, Me.ToolStripSeparator2, Me.btnClose})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(115, 38)
        Me.FileToolStripMenuItem.Text = "Archivo"
        '
        'btnNewFile
        '
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(359, 44)
        Me.btnNewFile.Text = "Nuevo"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(359, 44)
        Me.btnOpenFile.Text = "Abrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(356, 6)
        '
        'btnSave
        '
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(359, 44)
        Me.btnSave.Text = "Guardar"
        '
        'btnSaveAs
        '
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(359, 44)
        Me.btnSaveAs.Text = "Guardar como"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(356, 6)
        '
        'btnClose
        '
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(359, 44)
        Me.btnClose.Text = "Salir"
        '
        'StyleToolStripMenuItem
        '
        Me.StyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFont, Me.btnBackgroundColor, Me.btnTextColor})
        Me.StyleToolStripMenuItem.Name = "StyleToolStripMenuItem"
        Me.StyleToolStripMenuItem.Size = New System.Drawing.Size(91, 38)
        Me.StyleToolStripMenuItem.Text = "Estilo"
        '
        'btnFont
        '
        Me.btnFont.Name = "btnFont"
        Me.btnFont.Size = New System.Drawing.Size(359, 44)
        Me.btnFont.Text = "Fuente ..."
        '
        'btnBackgroundColor
        '
        Me.btnBackgroundColor.Name = "btnBackgroundColor"
        Me.btnBackgroundColor.Size = New System.Drawing.Size(359, 44)
        Me.btnBackgroundColor.Text = "Color Fondo ..."
        '
        'btnTextColor
        '
        Me.btnTextColor.Name = "btnTextColor"
        Me.btnTextColor.Size = New System.Drawing.Size(359, 44)
        Me.btnTextColor.Text = "Color Texto ..."
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCut, Me.btnCopy, Me.btnPaste})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(95, 38)
        Me.EditToolStripMenuItem.Text = "Editar"
        '
        'btnCut
        '
        Me.btnCut.Name = "btnCut"
        Me.btnCut.Size = New System.Drawing.Size(359, 44)
        Me.btnCut.Text = "Cortar"
        '
        'btnCopy
        '
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(359, 44)
        Me.btnCopy.Text = "Copiar"
        '
        'btnPaste
        '
        Me.btnPaste.Name = "btnPaste"
        Me.btnPaste.Size = New System.Drawing.Size(359, 44)
        Me.btnPaste.Text = "Pegar"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNewSize, Me.txtNewSize, Me.ToolStripSeparator3, Me.cboSize})
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(118, 38)
        Me.SizeToolStripMenuItem.Text = "Tamaño"
        '
        'btnNewSize
        '
        Me.btnNewSize.Name = "btnNewSize"
        Me.btnNewSize.Size = New System.Drawing.Size(359, 44)
        Me.btnNewSize.Text = "Nuevo Tamaño"
        '
        'txtNewSize
        '
        Me.txtNewSize.AcceptsReturn = True
        Me.txtNewSize.Enabled = False
        Me.txtNewSize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNewSize.Name = "txtNewSize"
        Me.txtNewSize.Size = New System.Drawing.Size(100, 39)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(356, 6)
        '
        'cboSize
        '
        Me.cboSize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 40)
        '
        'btnAbout
        '
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(154, 38)
        Me.btnAbout.Text = "Acerca de..."
        '
        'txtMain
        '
        Me.txtMain.Location = New System.Drawing.Point(16, 54)
        Me.txtMain.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.Size = New System.Drawing.Size(1033, 502)
        Me.txtMain.TabIndex = 1
        Me.txtMain.Visible = False
        '
        'Notepad__
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 562)
        Me.Controls.Add(Me.mnuOptions)
        Me.Controls.Add(Me.txtMain)
        Me.MainMenuStrip = Me.mnuOptions
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Notepad__"
        Me.Text = "Notepad__"
        Me.mnuOptions.ResumeLayout(False)
        Me.mnuOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuOptions As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StyleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAbout As ToolStripMenuItem
    Friend WithEvents btnNewFile As ToolStripMenuItem
    Friend WithEvents btnOpenFile As ToolStripMenuItem
    Friend WithEvents btnFont As ToolStripMenuItem
    Friend WithEvents btnBackgroundColor As ToolStripMenuItem
    Friend WithEvents btnTextColor As ToolStripMenuItem
    Friend WithEvents btnCut As ToolStripMenuItem
    Friend WithEvents btnCopy As ToolStripMenuItem
    Friend WithEvents btnPaste As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents btnSave As ToolStripMenuItem
    Friend WithEvents btnSaveAs As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnClose As ToolStripMenuItem
    Friend WithEvents txtNewSize As ToolStripTextBox
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents cboSize As ToolStripComboBox
    Friend WithEvents txtMain As TextBox
    Friend WithEvents btnNewSize As ToolStripMenuItem
End Class
