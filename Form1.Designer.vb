<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VBNetToCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CToVBNetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitWebpageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.Editor1 = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.Label1 = New System.Windows.Forms.ToolStrip()
        Me.Label2 = New System.Windows.Forms.ToolStripLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.Editor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Label1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConvertToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(710, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.ImportCodeToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.ViewCodeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.Add_document_icon__the_Noun_Project_27896__svg
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NewProjectToolStripMenuItem.Text = "&New Project"
        '
        'ImportCodeToolStripMenuItem
        '
        Me.ImportCodeToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources._20151201_565d8912b75e7
        Me.ImportCodeToolStripMenuItem.Name = "ImportCodeToolStripMenuItem"
        Me.ImportCodeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ImportCodeToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ImportCodeToolStripMenuItem.Text = "&Import Code"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.Save_icon
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.SaveProjectToolStripMenuItem.Text = "&Save Project"
        '
        'ViewCodeToolStripMenuItem
        '
        Me.ViewCodeToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.QuickView_icon
        Me.ViewCodeToolStripMenuItem.Name = "ViewCodeToolStripMenuItem"
        Me.ViewCodeToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ViewCodeToolStripMenuItem.Text = "View Code"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConvertToolStripMenuItem
        '
        Me.ConvertToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VBNetToCToolStripMenuItem, Me.CToVBNetToolStripMenuItem, Me.GenerateToolStripMenuItem})
        Me.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem"
        Me.ConvertToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ConvertToolStripMenuItem.Text = "&$safeprojectname$"
        '
        'VBNetToCToolStripMenuItem
        '
        Me.VBNetToCToolStripMenuItem.Checked = True
        Me.VBNetToCToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VBNetToCToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.prog_vbnet
        Me.VBNetToCToolStripMenuItem.Name = "VBNetToCToolStripMenuItem"
        Me.VBNetToCToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.VBNetToCToolStripMenuItem.Text = "VB.Net to C#"
        '
        'CToVBNetToolStripMenuItem
        '
        Me.CToVBNetToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.c_sharp1
        Me.CToVBNetToolStripMenuItem.Name = "CToVBNetToolStripMenuItem"
        Me.CToVBNetToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.CToVBNetToolStripMenuItem.Text = "C# to VB.Net"
        '
        'GenerateToolStripMenuItem
        '
        Me.GenerateToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.Generate_keys_icon
        Me.GenerateToolStripMenuItem.Name = "GenerateToolStripMenuItem"
        Me.GenerateToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.GenerateToolStripMenuItem.Text = "Generate"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitWebpageToolStripMenuItem, Me.AboutToolStripMenuItem, Me.OpenSourceToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'VisitWebpageToolStripMenuItem
        '
        Me.VisitWebpageToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources._14575
        Me.VisitWebpageToolStripMenuItem.Name = "VisitWebpageToolStripMenuItem"
        Me.VisitWebpageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VisitWebpageToolStripMenuItem.Text = "Visit Webpage"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.circle_with_i_1
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About "
        '
        'OpenSourceToolStripMenuItem
        '
        Me.OpenSourceToolStripMenuItem.Image = Global.$safeprojectname$.My.Resources.Resources.opensource_logo
        Me.OpenSourceToolStripMenuItem.Name = "OpenSourceToolStripMenuItem"
        Me.OpenSourceToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenSourceToolStripMenuItem.Text = "Open Source"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.Size = New System.Drawing.Size(710, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.$safeprojectname$.My.Resources.Resources.Add_document_icon__the_Noun_Project_27896__svg
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "New Project"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.$safeprojectname$.My.Resources.Resources._20151201_565d8912b75e7
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Import Code"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.$safeprojectname$.My.Resources.Resources.Save_icon
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Save Project"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = Global.$safeprojectname$.My.Resources.Resources.Generate_keys_icon
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Generate"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = Global.$safeprojectname$.My.Resources.Resources.QuickView_icon
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "View Code"
        '
        'Editor1
        '
        Me.Editor1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Editor1.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Editor1.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.Editor1.BackBrush = Nothing
        Me.Editor1.CharHeight = 14
        Me.Editor1.CharWidth = 8
        Me.Editor1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Editor1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Editor1.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Editor1.IsReplaceMode = False
        Me.Editor1.Location = New System.Drawing.Point(0, 52)
        Me.Editor1.Name = "Editor1"
        Me.Editor1.Paddings = New System.Windows.Forms.Padding(0)
        Me.Editor1.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Editor1.ServiceColors = CType(resources.GetObject("Editor1.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Editor1.Size = New System.Drawing.Size(710, 352)
        Me.Editor1.TabIndex = 2
        Me.Editor1.Zoom = 100
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label2})
        Me.Label1.Location = New System.Drawing.Point(0, 407)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ToolStrip2"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 22)
        Me.Label2.Text = "Ready"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 432)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Editor1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = ".Net Code Converter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.Editor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Label1.ResumeLayout(False)
        Me.Label1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConvertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VBNetToCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CToVBNetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisitWebpageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSourceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents GenerateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Editor1 As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents Label1 As ToolStrip
    Friend WithEvents Label2 As ToolStripLabel
    Friend WithEvents ViewCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
