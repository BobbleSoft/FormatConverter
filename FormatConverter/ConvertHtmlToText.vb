Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Net

Public Class ConvertHtmlToText
    Implements IConvert

    Public Function Convert(ByVal sHtmlCode As String) As String Implements IConvert.Convert
        ' Remove new lines since they are not visible in HTML
        sHtmlCode = sHtmlCode.Replace("\n", " ")

        ' Changes tabs to a series of spaces.
        sHtmlCode = sHtmlCode.Replace("\t", "   ")

        ' Remove multiple white spaces from HTML
        sHtmlCode = Regex.Replace(sHtmlCode, "\\s+", "  ")

        ' Remove HEAD tag
        sHtmlCode = Regex.Replace(sHtmlCode, "<head.*?</head>", "", RegexOptions.IgnoreCase Or RegexOptions.Singleline)

        ' Remove any JavaScript
        sHtmlCode = Regex.Replace(sHtmlCode, "<script.*?</script>", "", RegexOptions.IgnoreCase Or RegexOptions.Singleline)

        ' Replace special characters like &, <, >, " etc.
        'Dim sbHTML As StringBuilder = New StringBuilder(sHtmlCode)
        'Dim OldWords() As String = {"&nbsp;", "&amp;", "&quot;", "&lt;", "&gt;", "&reg;", "&copy;", "&bull;", "&trade;"}
        'Dim NewWords() As String = {" ", "&", """", "<", ">", "Â®", "Â©", "â€¢", "â„¢"}
        'For i As Integer = 0 To i < OldWords.Length
        '    sbHTML.Replace(OldWords(i), NewWords(i))
        'Next i
        sHtmlCode = WebUtility.HtmlDecode(sHtmlCode)

        ' Check if there are line breaks (<br>) or paragraph (<p>)
        sHtmlCode.Replace("<br>", "\n<br>")
        sHtmlCode.Replace("<br ", "\n<br ")
        sHtmlCode.Replace("<p ", "\n<p ")

        ' Finally, remove all HTML tags and return plain text
        Convert = Regex.Replace(sHtmlCode.ToString(), "<[^>]*>", "")
    End Function

End Class
