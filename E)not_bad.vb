Module Module1

    Sub Main()
        Dim Str As String = " "
        Dim NotLoc As Integer = 0
        Dim BadLoc As Integer = 0
        Dim count As Integer = 0
        Dim a As Integer = 0
        Dim b As Integer = 0

        For count = 1 To Len(Str)
            If Mid(Str, count, 3) = "not" Then
                NotLoc = count
            ElseIf Mid(Str, count, 3) = "bad" Then
                BadLoc = count
            End If
        Next
        If BadLoc > NotLoc Then
            Console.WriteLine("So" & Str & "yields:" & Mid(Str, 1, NotLoc - 1) & "good" & Mid(Str, BadLoc + 3))
            Console.ReadKey()

        End If

    End Sub

End Module
