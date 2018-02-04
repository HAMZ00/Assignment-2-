Module Module1

    Sub Main()
        Dim Str As String = " "
        Dim StrLen As Integer = 0
        Dim NewStr1 As String = " "
        Dim NewStr2 As String = " "

        Console.WriteLine("enter string: ")
        Str = Console.ReadLine

        If Len(Str) Mod 2 = 0 Then
            NewStr1 = Mid(Str, 1, Len(Str) / 2)
            NewStr2 = Mid(Str, (Len(Str) / 2) + 1)
        Else
            NewStr1 = Mid(Str, 1, (Len(Str) / 2) + 0.5)
            NewStr2 = Mid(Str, ((Len(Str) / 2) + 0.5) + 1)
        End If
        Console.WriteLine(Left(NewStr1, 1) & Left(NewStr2, 1) & Right(NewStr1, 1) & Right(NewStr2, 1))
        Console.ReadKey()

    End Sub

End Module
