

Imports System.ComponentModel.DataAnnotations

Module AS_StringManipQues6
    Sub Main()
        ' INPUT an INT count of a number of donuts
        ' OUTPUT a string in the form "Number of donuts: <count>', where <count> is the number Input."
        'However, if the count is 10 or more, then use the word "many" instead of the actual count.


        ' DECLARATION
        Dim donut As String
        Dim count As Integer
        Dim x, y As Integer

        ' INITIALIZATION
        x = 0
        y = 0
        count = 0
        donut = ""

        'INPUT
        Console.Write("Enter number of donuts: ")
        donut = Console.ReadLine()

        ' PROCESS
        x = InStr(donut, ")")
        y = x - 7

        count = Mid(donut, 7, y)

        ' OUTPUT
        If count >= 10 Then
            Console.WriteLine("Number of donuts: many ")
        Else
            Console.WriteLine("Number of Donuts: " & count)
        End If

        Console.ReadKey()


    End Sub
End Module
