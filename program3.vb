Imports System

Public Class program3
    Public Shared Sub Main()
        Dim message As String 
        Console.Write("Enter message: ") 
        message = Console.ReadLine 
        Console.WriteLine() 
        Console.WriteLine("Your Message: {0}", message) 
        Console.ReadLine() 
    End Sub
End Class