Class ServiceClass
    Public intNum1, intNum2 As Integer
    Shared Sub SybMethod()
        System.Console.WriteLine(intNum1 + intNum2)
End Sub

Public Function FunctionMethod()
        Return intNum1 * intNum2
    End Function
End Class
