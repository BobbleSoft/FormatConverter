Imports System.Text

Public Class ConvertHtmlToRtf
    Implements IConvert

    Public Function Convert(ByVal sSource As String) As String Implements IConvert.Convert
        Dim sb As New StringBuilder

        sb.Append("Output as RTF")

        Convert = sb.ToString()
    End Function

End Class
