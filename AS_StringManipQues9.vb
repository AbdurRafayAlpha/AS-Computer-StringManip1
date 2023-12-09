Module Program
    Sub Main()

        'Given strings a and b, return a single string with a and b separated by a space "<a> <b>", except swap the first 2 chars of each string.
        ' "happy" "people"
        ' peppy haople

        Dim stra, strb, str1, str2 As String
        Dim first_two_char, second_two_char As String
        Dim x, y As Integer
        Console.Write("enter a string: ")
        stra = Console.ReadLine()

        Console.Write("enter second string. ")
        strb = Console.ReadLine()

        first_two_char = Left(stra, 2)
        x = Len(stra) - InStr(stra, first_two_char)

        str1 = Left(strb, 2) & Right(stra, x - 1)

        second_two_char = Left(strb, 2)
        y = Len(strb) - InStr(strb, second_two_char)

        str2 = Left(stra, 2) & Right(strb, y - 1)

        Console.WriteLine(str1 & " " & str2)





    End Sub
End Module
