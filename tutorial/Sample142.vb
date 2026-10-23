Class ClassName
    Shared Sub Main()
        Dim objClass As ServiceClass = New ServiceClass()

        objClass.intNum1 = 2
        System.Console.WriteLine("整数1:" & objClass.intNum1)

        objClass.intNum2 = 3
        System.Console.WriteLine("整数2:" & objClass.intNum2)

        objClass.SubMethod()

        System.Console.WriteLine(objClass.FuncMethod())
        System.Console.ReadKey()
    End Sub
End Class
