Imports CodeConvert
Imports FastColoredTextBoxNS
Public Class Form1
    Public WholeExt, TempText
    Private Sub Delay(ByVal DelayInSeconds As Integer)
        Dim ts As TimeSpan
        Dim targetTime As DateTime = DateTime.Now.AddSeconds(DelayInSeconds)
        Do
            ts = targetTime.Subtract(DateTime.Now)
            Application.DoEvents() ' keep app responsive
            System.Threading.Thread.Sleep(50) ' reduce CPU usage
        Loop While ts.TotalSeconds > 0
    End Sub
    Private Sub NewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewProjectToolStripMenuItem.Click
        Editor1.Text = ""
    End Sub
    Private Sub ImportCodesFormTool()
        OpenFileDialog1.Filter = "C#,VB Net|*.vb;*.cs|All Files|*.*"
        OpenFileDialog1.Title = "Browse for Code"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            WholeExt = OpenFileDialog1.FileName
            Dim FileExtension = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
            If FileExtension = ".cs" Then
                VBNetToCToolStripMenuItem.Checked = False
                Editor1.Language = Language.CSharp
                CToVBNetToolStripMenuItem.Checked = True
                Label2.Text = "Language Change to C# Net"
                Editor1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Delay(3)
                Label2.Text = "Ready"
            End If
            If FileExtension = ".vb" Then
                VBNetToCToolStripMenuItem.Checked = True
                Editor1.Language = Language.VB
                CToVBNetToolStripMenuItem.Checked = False
                Label2.Text = "Language Change to VB Net"
                Editor1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                Delay(3)
                Label2.Text = "Ready"
            End If
        End If
    End Sub
    Private Sub VBNetToCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VBNetToCToolStripMenuItem.Click
        VBNetToCToolStripMenuItem.Checked = True
        Editor1.Language = Language.VB
        CToVBNetToolStripMenuItem.Checked = False
        Label2.Text = "Language Change to VB Net"
        Delay(3)
        Label2.Text = "Ready"
    End Sub

    Private Sub CToVBNetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToVBNetToolStripMenuItem.Click
        VBNetToCToolStripMenuItem.Checked = False
        CToVBNetToolStripMenuItem.Checked = True
        Editor1.Language = Language.CSharp
        Label2.Text = "Language Change to C# Net"
        Delay(3)
        Label2.Text = "Ready"
    End Sub
    Private Sub CodeConvertCheck()
        If VBNetToCToolStripMenuItem.Checked = True Then
            Form3.Editor2.Language = Language.CSharp
            If Not Editor1.Text = Nothing Then
                Try
                    TempText = ConversionLoader.ConvertVBToCSharp(Me.Editor1.Text)
                    Label2.Text = "Code Converted Successfully, Click View Icon to See Results"
                    Delay(4)
                    Label2.Text = "Ready"
                Catch ex2 As Exception
                    Label2.Text = "ERROR:" & ex2.Message
                    Delay(5)
                    Label2.Text = "Ready"
                End Try
            Else
                Label2.Text = "No Code To $safeprojectname$"
                Delay(3)
                Label2.Text = "Ready"
            End If
        End If
        If CToVBNetToolStripMenuItem.Checked = True Then
            If Not Editor1.Text = Nothing Then
                Try
                    TempText = ConversionLoader.ConvertCSharpToVB(Me.Editor1.Text)
                    Label2.Text = "Code Converted Successfully, Click View Icon to See Results"
                    Delay(4)
                    Label2.Text = "Ready"
                Catch ex2 As Exception
                    Label2.Text = "ERROR:" & ex2.Message
                    Delay(5)
                    Label2.Text = "Ready"
                End Try
            Else
                Label2.Text = "No Code To $safeprojectname$"
                Delay(3)
                Label2.Text = "Ready"
            End If
        End If
    End Sub
    Private Sub SaveProjectDialog()
        If Editor1.Text <> Nothing Then
            Dim FileExtension = System.IO.Path.GetExtension(WholeExt)
            Dim a = "temp"
            If FileExtension = ".cs" Then
                a = "VB Files|*.vb|All Files|*.*"
            ElseIf FileExtension = ".vb" Then
                a = "C# Files|*.cs|All Files|*.*"
            Else
                a = "All Files|*.*"
            End If
            SaveFileDialog1.Title = "Browse for Code Save Path"
            SaveFileDialog1.Filter = a
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                If VBNetToCToolStripMenuItem.Checked = True Then
                    Form3.Editor2.Language = Language.CSharp
                    If Not Editor1.Text = Nothing Then
                        Try
                            TempText = ConversionLoader.ConvertVBToCSharp(Me.Editor1.Text)
                            Label2.Text = "Code Converted Successfully, Click View Icon to See Results"
                            Delay(1)
                            Label2.Text = "Ready"
                        Catch ex2 As Exception
                            Label2.Text = "ERROR:" & ex2.Message
                            Delay(5)
                            Label2.Text = "Ready"
                        End Try
                    Else
                        Label2.Text = "No Code To $safeprojectname$"
                        Delay(3)
                        Label2.Text = "Ready"
                    End If
                End If
                If CToVBNetToolStripMenuItem.Checked = True Then
                    If Not Editor1.Text = Nothing Then
                        Try
                            TempText = ConversionLoader.ConvertCSharpToVB(Me.Editor1.Text)
                            Label2.Text = "Code Converted Successfully, Click View Icon to See Results"
                            Delay(1)
                            Label2.Text = "Ready"
                        Catch ex2 As Exception
                            Label2.Text = "ERROR:" & ex2.Message
                            Delay(5)
                            Label2.Text = "Ready"
                        End Try
                    Else
                        Label2.Text = "No Code To $safeprojectname$"
                        Delay(3)
                        Label2.Text = "Ready"
                    End If
                End If
                IO.File.WriteAllText(SaveFileDialog1.FileName, TempText)
                Label2.Text = "Code Saved : " + SaveFileDialog1.FileName
                Delay(5)
                Label2.Text = "Ready"
            End If
        Else
            Label2.Text = "No Code To $safeprojectname$"
            Delay(3)
            Label2.Text = "Ready"
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GenerateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateToolStripMenuItem.Click
        CodeConvertCheck()
    End Sub

    Private Sub ViewCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCodeToolStripMenuItem.Click
        Form3.Close()
        Form3.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Editor1.Text = ""
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        ImportCodesFormTool()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        CodeConvertCheck()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        SaveProjectDialog()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Form3.Close()
        Form3.Show()
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveProjectToolStripMenuItem.Click
        SaveProjectDialog()
    End Sub

    Private Sub VisitWebpageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitWebpageToolStripMenuItem.Click
        Process.Start("http://developerkp.capstricks.net/index.php/2017/05/23/convert/")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Form4.Close()
        Form4.ShowDialog()
    End Sub

    Private Sub OpenSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSourceToolStripMenuItem.Click
        Process.Start("https://github.com/KaustubhPatange/Net-Code-Converter")
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click, RefreshCodeToolStripMenuItem.Click
        Dim temp = Editor1.Text
        Editor1.Text = ""
        If CToVBNetToolStripMenuItem.Checked = True Then
            Editor1.Language = Language.CSharp
        End If
        If VBNetToCToolStripMenuItem.Checked = True Then
            Editor1.Language = Language.VB
        End If
        Editor1.Text = temp
    End Sub

    Private Sub LoadTemplateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadTemplateToolStripMenuItem.Click
        If VBNetToCToolStripMenuItem.Checked = True Then
            Editor1.Text = "Imports System" + Environment.NewLine + "Imports System.IO" + Environment.NewLine + "Public Class TestForm" + Environment.NewLine + Environment.NewLine + "End Class"
        End If
        If CToVBNetToolStripMenuItem.Checked = True Then
            Editor1.Text = "using system;" + Environment.NewLine + "using system.IO;" + Environment.NewLine + "public class TestForm" + Environment.NewLine + "{" + Environment.NewLine + Environment.NewLine + "}"

        End If
    End Sub

    Private Sub ImportCodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportCodeToolStripMenuItem.Click
        ImportCodesFormTool()
    End Sub
End Class
