Imports System
Imports System.Threading

Module Program
    Sub Main()
        ' Find the character that appears most number of times in an entered string and output it.
        Dim str1 As String
        Dim chr, chr2, most_repeated As Char
        Dim count, i, k, count2 As Integer

        ' INITIALIZATION
        str1 = ""
        chr = ""
        most_repeated = ""
        i = 0
        k = 0
        count2 = 0
        count = 0
        ' INPUT

        Console.Write("enter a string: ")
        str1 = Console.ReadLine()

        ' PROCESS

        For i = 1 To Len(str1)
            chr = Mid(str1, i, 1)
            For k = 1 To Len(str1)
                chr2 = Mid(str1, k, 1)
                If chr2 = chr Then
                    count += 1
                End If
            Next

            If count > count2 Then
                count2 = count
                most_repeated = chr
            End If
            count = 0
        Next


        ' OUTPUT
        Console.WriteLine("The most repeated character in the entered string is " & most_repeated)

        Console.ReadKey()
    End Sub
End Module
