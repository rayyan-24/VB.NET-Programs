Imports System

Module Module1
    Sub Main()
        Dim n1,n2 as Integer
        Console.WriteLine("Enter 1 Number: ")
        n1=Console.Readline()
        Console.WriteLine("Enter 2 Number: ")
        n2=Console.Readline()
        if(n1<n2)then
            Console.WriteLine("Number 1 is Less Than Number 2")            
        Else If(n1>n2)
            Console.WriteLine("Number 1 is Greater Than Number 2")            
        else
            Console.WriteLine("Equal")            
        End If
    End Sub
End Module