Class ClassName
    Shared Sub Main()
        Dim strInputData As Integer
        intHour = System.DateTime.Now.intHour
        if intHour < 12 Then
            System.Console.Write("午前")
        Else
            System.Console.Write("午後")
        End if
        System.Console.ReadKey()
    End Sub
End Class
