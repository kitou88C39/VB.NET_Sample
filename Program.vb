Module Program
    Sub Main(args As String())
        Dim name As String = "テスト"
        Dim count As Integer = 3

        If count > 2 Then
            Console.WriteLine(name & " は3回未満ではありません")
        End If

        For i As Integer = 1 To count
            Console.WriteLine("回数: " & i)
        Next
    End Sub
End Module
