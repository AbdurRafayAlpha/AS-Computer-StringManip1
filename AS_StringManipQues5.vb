Imports System

Module Program
    Sub Main()
        ' Find the count of vowels in a string seperately
        Dim i, j, Acount, Ecount, Icount, Ocount, Ucount As Integer
        Dim chr, chr2 As Char
        Dim str, vowel As String
        i = 0
        Acount = 0
        Ecount = 0
        Icount = 0
        Ocount = 0
        Ucount = 0
        chr = ""
        Console.Write("Enter a string: ")
        str = Console.ReadLine()

        For i = 1 To Len(str)
            chr = Mid(str, i, 1)
            chr = LCase(chr)
            If chr = "a" Then Acount += 1
            If chr = "e" Then Ecount += 1
            If chr = "i" Then Icount += 1
            If chr = "o" Then Ocount += 1
            If chr = "u" Then Ucount += 1

        Next

        ' OUTPUT
        Console.WriteLine("Number of A are: " & Acount)
        Console.WriteLine("Number of E are: " & Ecount)
        Console.WriteLine("Number of I are: " & Icount)
        Console.WriteLine("Number of O are: " & Ocount)
        Console.WriteLine("Number of U are: " & Ucount)



    End Sub
End Module
