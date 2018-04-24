Imports System.Text

Public Class ConvertTextToText
    Implements IConvert

    Public Function Convert(ByVal sSource As String) As String Implements IConvert.Convert
        Dim sb As New StringBuilder

        sb.Append("Output as Text")

        Convert = sb.ToString()
    End Function

End Class
