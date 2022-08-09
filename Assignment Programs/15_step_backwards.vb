Imports System

Module Module1
    Sub Main()
    Dim n1,n2 as Integer

    Console.WriteLine("Enter Upper Limit")
    n2=Console.Readline()
    Console.WriteLine("Enter Lower Limit")
    n1=Console.Readline()
        for i as Integer=n2 to n1 Step -1
            Console.WriteLine(i)
        Next
    End Sub
End Module