Module Module1

    Sub Main()
        Dim NoDonuts As Integer = 0


        Console.WriteLine("enter the number of donuts: ")
        NoDonuts = Console.ReadLine

        If NoDonuts > 10 Then
            Console.WriteLine("Number of donuts: " & "many")
        Else
            Console.WriteLine("Number of donuts: " & Val(NoDonuts))
        End If
        Console.ReadKey()

    End Sub

End Module
