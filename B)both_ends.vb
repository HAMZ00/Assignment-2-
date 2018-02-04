Module Module1

    Sub Main()
        Dim Text = " "

        Console.WriteLine("Enter word ")
        Text = Console.ReadLine

        If Len(Text) > 2 Then
            Console.WriteLine(Left(Text, 2) & Right(Text, 2))
        Else
            Console.WriteLine(" ")
        End If
        Console.ReadKey()

    End Sub

End Module
