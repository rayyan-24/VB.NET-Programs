Imports System

Module Module1
    Sub Main()
        Dim n1,n2,n3 as Double
        Console.WriteLine("Enter 1 Number: ")
        n1=Console.Readline()
        Console.WriteLine("Enter 2 Number: ")
        n2=Console.Readline()
        n3=n1*n2
        Console.WriteLine("{0} * {1}={2}",n1,n2,n3)
        n3=n1/n2
        Console.WriteLine("{0} / {1}={2}",n1,n2,n3)
    End Sub
End Module