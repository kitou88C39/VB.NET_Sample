Class ClientClass
    Shared Sub Main()
        Dim objClass As ServiceClass = New ServiceClass()
        objClass.PropertyName = "プロパティ"
        System.Console.WriteLine(objClass.PropertyName)
        System.Console.ReadKey()
    End Sub
End Class
