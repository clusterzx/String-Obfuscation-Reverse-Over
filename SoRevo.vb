Imports System.Text
Namespace ClusterzTools
    Public Class SoRevo
        Public Function RevBack(tmpStr As String) As String
        tmpStr = Encoding.Default.GetString(Convert.FromBase64String(tmpStr))
        tmpStr = US(tmpStr)
        tmpStr = String.Join(String.Empty, tmpStr.Reverse.Select(Function(d) d.ToString).ToArray)
        Return tmpStr
    End Function
    Public Function RevForw(tmpStr As String) As String
        tmpStr = String.Join(String.Empty, tmpStr.Reverse.Select(Function(d) d.ToString).ToArray)
        tmpStr = OS(tmpStr)
        Dim data As Byte() = System.Text.Encoding.Default.GetBytes(tmpStr)
        tmpStr = Convert.ToBase64String(data)
        Return tmpStr
    End Function
    Public Function OS(ByVal sInput As String) As String
        Dim sTemp As String = ""
        Dim iLoop As Integer
        Dim iLen As Integer

        iLen = sInput.Length
        For iLoop = iLen To 1 Step -2
            sTemp += Microsoft.VisualBasic.Mid(sInput, iLoop, 1)
        Next
        For iLoop = iLen - 1 To 1 Step -2
            sTemp += Microsoft.VisualBasic.Mid(sInput, iLoop, 1)
        Next
        Return sTemp
    End Function
    Public Function US(ByVal sInput As String) As String
        Dim sTemp As String = ""
        Dim iLoop As Integer
        Dim iLen As Integer
        Dim iMiddle As Integer
        Dim iRemainder As Integer

        iLen = sInput.Length
        iRemainder = iLen Mod 2
        iMiddle = iLen \ 2

        For iLoop = iMiddle + iRemainder To 1 Step -1
            If iRemainder = 0 Then
                sTemp += Microsoft.VisualBasic.Mid(sInput, iLoop + iMiddle, 1)
            End If
            sTemp += Microsoft.VisualBasic.Mid(sInput, iLoop, 1)
            If iRemainder = 1 And iLoop <> 1 Then
                sTemp += Microsoft.VisualBasic.Mid(sInput, iLoop + iMiddle, 1)
            End If
        Next

        Return sTemp
    End Function
End Class
End Namespace
