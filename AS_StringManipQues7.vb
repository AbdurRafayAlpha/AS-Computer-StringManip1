Imports System

Module Program
    Sub Main()
        'Input a string s, output a string made of the first 2 And the last 2 chars of the original string.

        Dim str1, str2, first_two, last_two As String

        Console.Write("Enter a string: ")
        str1 = Console.ReadLine()

        If Len(str1) > 2 Then
            first_two = Left(str1, 2)
            last_two = Right(str1, 2)

            str2 = first_two & last_two
            Console.WriteLine(str2)
        Else
            Console.WriteLine(str1)
        End If



    End Sub
End Module
