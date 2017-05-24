Imports FastColoredTextBoxNS
Imports CodeConvert
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Editor2.Cursor = Cursors.IBeam
        If Form1.VBNetToCToolStripMenuItem.Checked = True Then
            Editor2.Language = Language.CSharp
            Editor2.Text = Form1.TempText
        End If
        If Form1.CToVBNetToolStripMenuItem.Checked = True Then
            Editor2.Language = Language.VB
            Editor2.Text = Form1.TempText
        End If
    End Sub
End Class