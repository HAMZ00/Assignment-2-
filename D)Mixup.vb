Module Module1

    Sub Main()
        Dim Word1 As String = " "
        Dim Word2 As String = " "
        Dim Word1New As String = " "
        Dim Word2New As String = " "
        Console.WriteLine("enter word 1: ")
        Word1 = Console.ReadLine
        Console.WriteLine("enter word 2: ")
        Word2 = Console.ReadLine
        Word1New = Left(Word2, 2) & Mid(Word1, 3, Len(Word1) - 2)
        Word2New = Left(Word1, 2) & Mid(Word2, 3, Len(Word2) - 2)
        Console.WriteLine(Word1New & " " & Word2New)

        Console.ReadKey()

    End Sub

End Module
