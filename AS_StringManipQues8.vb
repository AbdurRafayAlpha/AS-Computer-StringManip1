Imports System
Imports System.Threading.Channels

Module AS_StringManipQues8
    Sub Main()
        'Given a string s, return a string where all occurences of its first char have been changed to "*"
        ' except donot change the first char itself
        ' fast food
        Dim str1, str2, str3, str4 As String
        Dim chr1, chr2 As Char

        Console.Write("enter a word: ")
        str1 = Console.ReadLine()

        chr1 = Left(str1, 1)
        str4 = chr1

        For i = 1 To Len(str1)
            If i <> 1 Then
                chr2 = Mid(str1, i, 1)
                If chr2 = chr1 Then

                    str2 = "*"
                    str4 = str4 & str2
                Else
                    str3 = chr2
                    str4 = str4 & str3
                End If
            End If
            str3 = ""
        Next

        Console.WriteLine(str4)
    End Sub
End Module
