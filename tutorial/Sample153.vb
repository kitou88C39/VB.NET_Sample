Class ClientClass
    Shared Sub Main()
        Dim objClass As ServiceClass = New ServiceClass()
        objClass.SuperMethod()
        objClass.SubMethod()
        System.Console.ReadKey()
    End Sub
End Class
