Public Class MainForm

    Private Const vbQuote As String = """"

    Private Sub ManageConversion()
        Dim converter As IConvert

        btnGo.Enabled = False
        pnlSrc.Enabled = False
        pnlTgt.Enabled = False
        btnSrcLoad.Enabled = False
        btnTgtSave.Enabled = False
        txtSrc.Enabled = False

        If rbSrcHtml.Checked Then
            If rbTgtHtml.Checked Then
                converter = New ConvertHtmlToHtml()
            ElseIf rbTgtRtf.Checked Then
                converter = New ConvertHtmlToRtf()
            Else
                converter = New ConvertHtmlToText()
            End If
        ElseIf rbSrcRtf.Checked Then
            If rbTgtHtml.Checked Then
                converter = New ConvertRtfToHtml()
            ElseIf rbTgtRtf.Checked Then
                converter = New ConvertRtfToRtf()
            Else
                converter = New ConvertRtfToText()
            End If
        Else    ' rbSrcText.Checked Then
            If rbTgtHtml.Checked Then
                converter = New ConvertTextToHtml()
            ElseIf rbTgtRtf.Checked Then
                converter = New ConvertTextToRtf()
            Else
                converter = New ConvertTextToText()
            End If
        End If

        txtTgt.Text = converter.Convert(txtSrc.Text)

        btnGo.Enabled = True
        pnlSrc.Enabled = True
        pnlTgt.Enabled = True
        btnSrcLoad.Enabled = True
        btnTgtSave.Enabled = True
        txtSrc.Enabled = True

    End Sub

    Private Sub LoadFromFile()
        Dim sFilter As String
        Dim sFilename As String

        LoadFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)

        If rbSrcHtml.Checked Then
            sFilter = "HTML Files (*.htm;*.html)|*.html;*.htm"
        ElseIf rbSrcRtf.Checked Then
            sFilter = "RTF Files (*.rtf)|*.rtf"
        Else    ' rbSrcText.Checked
            sFilter = "Text Files (*.txt)|*.txt"
        End If
        LoadFileDialog.Filter = sFilter & "|All Files(*.*)|"
        LoadFileDialog.FilterIndex = 1

        If (LoadFileDialog.ShowDialog() = DialogResult.OK) Then
            sFilename = LoadFileDialog.FileName
            txtSrc.Text = ReadFile(sFilename)
        End If
    End Sub

    Private Function ReadFile(ByVal sFilename As String) As String

        Try
            ReadFile = System.IO.File.ReadAllText(sFilename)
        Catch ex As Exception
            ErrorMsg("Could not read the file" + vbNewLine + sFilename, ex)
            ReadFile = vbNullString
        End Try

    End Function

    Private Sub ErrorMsg(ByVal sMsg As String, Optional ByRef ex As Exception = Nothing)

        If Not IsNothing(ex) Then
            sMsg = sMsg + vbNewLine + vbNewLine + ex.ToString
        End If

        MessageBox.Show(sMsg, Application.ProductName + " -- Error!")
    End Sub

    Private Sub SaveOutputToFile()
        Dim sFilter As String
        Dim sFilename As String

        SaveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)

        If rbSrcHtml.Checked Then
            sFilter = "HTML Files (*.htm;*.html)|*.html;*.htm"
        ElseIf rbSrcRtf.Checked Then
            sFilter = "RTF Files (*.rtf)|*.rtf"
        Else    ' rbSrcText.Checked
            sFilter = "Text Files (*.txt)|*.txt"
        End If
        SaveFileDialog.Filter = sFilter & "|All Files(*.*)|"
        SaveFileDialog.FilterIndex = 1

        If (SaveFileDialog.ShowDialog() = DialogResult.OK) Then
            sFilename = SaveFileDialog.FileName
            If SaveFile(sFilename, txtSrc.Text) Then
                MessageBox.Show("The file was saved.", Application.ProductName, MessageBoxButtons.OK)
            End If
        End If

    End Sub

    Private Function SaveFile(sFilename As String, ByRef sText As String) As Boolean
        Dim oWriter As System.IO.StreamWriter = Nothing

        Try
            oWriter = New System.IO.StreamWriter(sFilename)
            oWriter.Write(sText)
            SaveFile = True
        Catch ex As Exception
            ErrorMsg("Failed to write the file" + vbNewLine + sFilename, ex)
            SaveFile = False
        Finally
            If Not IsNothing(oWriter) Then
                oWriter.Close()
            End If
        End Try
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        Dim myForm As New AboutBox
        myForm.ShowDialog()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        ManageConversion()
    End Sub

    Private Sub btnSrcLoad_Click(sender As Object, e As EventArgs) Handles btnSrcLoad.Click
        LoadFromFile()
    End Sub

    Private Sub txtTgt_TextChanged(sender As Object, e As EventArgs) Handles txtTgt.TextChanged
        btnTgtSave.Enabled = Len(txtTgt.Text) > 0
    End Sub

    Private Sub btnTgtSave_Click(sender As Object, e As EventArgs) Handles btnTgtSave.Click
        SaveOutputToFile()
    End Sub

    Private Sub txtSrc_TextChanged(sender As Object, e As EventArgs) Handles txtSrc.TextChanged
        txtTgt.Text = vbNullString
        btnGo.Enabled = Len(txtSrc.Text) > 0
    End Sub
End Class
