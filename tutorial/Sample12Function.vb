Class ClassName
    Shared Sub Main()
        System.Console.WriteLine(FunctionMethod(2,3))
        System.Console.ReadKey()
End Sub

Shared Function FunctionMethod(intNum1 As Integer, intNum2 As Integer) As Integer
        Return intNum1 * intNum2
    End Function
End Class
