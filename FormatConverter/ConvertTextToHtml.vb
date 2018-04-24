Imports System.Text
Imports System.Net

Public Class ConvertTextToHtml
    Implements IConvert

    Public Function Convert(ByVal sSource As String) As String Implements IConvert.Convert
        Dim sText As String

        ' Convert the special characters to HTML equivalents
        sText = WebUtility.HtmlEncode(sSource)

        Convert = sText
    End Function

End Class
