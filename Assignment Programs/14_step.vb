Imports System

Module Module1
    Sub Main()
    Dim n1,n2 as Integer

    Console.WriteLine("Enter Lower Limit")
    n1=Console.Readline()
    Console.WriteLine("Enter Upper Limit")
    n2=Console.Readline()
        for i as Integer=n1 to n2 Step 2
            Console.WriteLine(i)
        Next
    End Sub
End Module