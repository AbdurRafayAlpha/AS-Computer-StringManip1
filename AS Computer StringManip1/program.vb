Imports System

Module Program
    Sub Main(args As String())
        'Find if the input string has all the alphabets (case neutral).
        Dim str1 As String
        Dim str2 As String
        Dim chr As Char
        Dim locate As Integer
        Dim wordcount As Integer
        str1 = ""
        str2 = "abcdefghijklmnopqrstuvwxyz"
        locate = 0
        chr = ""
        wordcount = 0

        Console.Write("Enter a string: ")
        str1 = Console.ReadLine()
        str1 = LCase(str1)

        For i = 1 To Len(str2)
            chr = Mid(str2, i, 1)
            locate = InStr(str1, chr)
            If locate > 0 Then
                wordcount += 1
            End If
        Next

        If wordcount = 26 Then
            Console.WriteLine("yes the string has all the alphabets")

        Else
            Console.WriteLine("no the string does not have all the alphabets")

        End If

        Console.ReadKey()

    End Sub
End Module
