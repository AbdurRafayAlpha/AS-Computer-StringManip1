Imports System

Module Program
    Sub Main()

        'Given a word, if its length is at least 3, add "ing" to its end.
        ' Unless it already ends in "ing", in which case add 'ly' instead.
        ' if word length is less than three return it as it is

        Dim word, x, str1, str2 As String
        Dim count1, count2 As Integer

        word = ""
        x = ""
        str1 = ""
        str2 = ""
        count1 = 0
        count2 = 0

        
        Console.Write("enter a word: ")
        word = Console.ReadLine()

        If Len(word) >= 3 Then
            word = LCase(word)
            x = Right(word, 3)
            If x = "ing" Then
                str1 = word & "ly"
                count1 += 1
            Else
                str2 = word & "ing"
                count2 += 1
            End If


        End If

        If count1 > 0 Then Console.WriteLine(str1)
        If count2 > 0 Then Console.WriteLine(str2)
        If count1 < 1 And count2 < 1 Then Console.WriteLine(word)


    End Sub
End Module
