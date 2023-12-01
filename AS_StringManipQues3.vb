Module AS_StringManipQues3
    Sub Main()
        'Q. Count and output the NUMBER of an entered character in a string.
        'Also output separate counts for alphabets (cap & small together; case neutral),
        'digits and other characters in same entered string. 


        ' DECLARATION

        Dim str1 As String
        Dim Tcount, alphabet_count, special_count, digit_count As Integer
        Dim chr As Char
        ' INITIALIZATION

        str1 = ""
        Tcount = 0
        alphabet_count = 0
        digit_count = 0
        special_count = 0
        chr = ""

        ' INPUT

        Console.Write("Enter a sentence: ")
        str1 = Console.ReadLine()

        ' PROCESS

        Tcount = Len(str1)
        str1 = UCase(str1)

        For i = 1 To Tcount
            chr = Mid(str1, i, 1)

            If chr >= "A" And chr <= "Z" Then
                alphabet_count += 1

            ElseIf chr >= "0" And chr <= "9" Then
                digit_count += 1

            Else
                special_count += 1

            End If

        Next

        ' OUTPUT
        Console.WriteLine("number of characters in the string inculuding spaces are: " & Tcount)
        Console.WriteLine("number of alphabets in the string are: " & alphabet_count)
        Console.WriteLine("number of digits in the string are: " & digit_count)
        Console.WriteLine("number of special characters in the string inculuding spaces are: " & special_count)


        Console.ReadKey()

    End Sub
End Module
