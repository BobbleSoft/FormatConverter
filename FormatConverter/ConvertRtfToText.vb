Imports System.Text

Public Class ConvertRtfToText
    Implements IConvert

    Public Function Convert(ByVal sSource As String) As String Implements IConvert.Convert
        Dim sb As New StringBuilder

        sb.Append("Output as HTML")

        Convert = sb.ToString()
    End Function

End Class
