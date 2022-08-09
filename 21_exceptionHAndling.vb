Imports System
Module Module1 
    Sub divisionFunction(ByVal n1 As Integer, ByVal n2 As Integer) 
        Dim answer As Integer 
        Try 
            answer = n1 \ n2 
        Catch ex As DivideByZeroException 
            Console.WriteLine("Exception: {0}", ex) 
        Finally 
            Console.WriteLine("Answer is: {0}", answer) 
        End Try 
    End Sub 
    Sub Main()
        Dim x,y as integer
        Console.WriteLine("Enter First Number")
        x=Console.Readline()
        Console.WriteLine("Enter Second Number")
        y=Console.Readline()
        divisionFunction(x, y) 
    End Sub 
End Module