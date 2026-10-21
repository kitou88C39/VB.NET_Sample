Class ClassName
    Shared Sub Main()
        Dim strInputData As Integer
        intHour = System.DateTime.Now.Hour
        If intHour < 12 Then
            System.Console.WriteLine("午前")
        Else
            System.Console.WriteLine("午後")
        End If
        System.Console.ReadKey()
    End Sub
End Class
