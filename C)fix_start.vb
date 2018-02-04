Module Module1

    Sub Main()
        Dim Word As String = " "
        Dim RemWord As String = " "
        Dim Letter1 As String = " "

        Console.WriteLine("enter word : ")
        Word = Console.ReadLine
        RemWord = Mid(Word, 2, Len(Word) - 1)
        Letter1 = Left(Word, 1)
        RemWord = RemWord.Replace(Letter1, "*")
        Console.WriteLine(Letter1 & RemWord)
        Console.ReadKey()

    End Sub

End Module
