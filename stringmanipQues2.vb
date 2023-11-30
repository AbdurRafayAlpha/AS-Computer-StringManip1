Imports System

Module stringmanipQues2
    Sub Main()
        ' Q. Replace selected character with another in entered string.

        'Declaration
        Dim str1, str2 As String
        Dim to_replace, replace_with, chr As Char
        Dim i As Integer

        'Initialization

        str1 = ""
        str2 = ""
        to_replace = ""
        replace_with = ""
        i = 0
        chr = ""

        ' input

        Console.Write("Enter a string to edit: ")
        str1 = Console.ReadLine()

        Console.Write("Enter the letter to replace: ")
        to_replace = Console.ReadLine()

        Console.Write("Enter the letter to replace with: ")
        replace_with = Console.ReadLine()

        str1 = LCase(str1)
        to_replace = LCase(to_replace)
        replace_with = LCase(replace_with)

        ' Process

        For i = 1 To Len(str1)
            chr = Mid(str1, i, 1)
            If to_replace <> chr Then
                str2 = str2 & chr
            Else
                str2 = str2 & replace_with
            End If
        Next

        ' Output
        Console.WriteLine(str2)

        Console.ReadKey()


    End Sub
End Module
