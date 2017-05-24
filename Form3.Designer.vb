<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Editor2 = New FastColoredTextBoxNS.FastColoredTextBox()
        CType(Me.Editor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Editor2
        '
        Me.Editor2.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.Editor2.AutoScrollMinSize = New System.Drawing.Size(27, 14)
        Me.Editor2.BackBrush = Nothing
        Me.Editor2.CharHeight = 14
        Me.Editor2.CharWidth = 8
        Me.Editor2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Editor2.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Editor2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Editor2.Font = New System.Drawing.Font("Courier New", 9.75!)
        Me.Editor2.IsReplaceMode = False
        Me.Editor2.Location = New System.Drawing.Point(0, 0)
        Me.Editor2.Name = "Editor2"
        Me.Editor2.Paddings = New System.Windows.Forms.Padding(0)
        Me.Editor2.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Editor2.ServiceColors = CType(resources.GetObject("Editor2.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.Editor2.Size = New System.Drawing.Size(557, 371)
        Me.Editor2.TabIndex = 0
        Me.Editor2.Zoom = 100
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 371)
        Me.Controls.Add(Me.Editor2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "View Code"
        CType(Me.Editor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Editor2 As FastColoredTextBoxNS.FastColoredTextBox
End Class
