Imports System
Module Module1 
    Sub Main()  
        Console.Write("Enter your name: ") 
        Dim name As String = Console.ReadLine() 
        Select Case name
             Case "Johnny"  
                Console.WriteLine("Hello Johnny") 
             Case "Kanav"  
                Console.WriteLine("Kanav") 
             Case "Rohit"  
                Console.WriteLine("Hello Rohit") 
             Case "Prasuk"  
                Console.WriteLine("Hello Prasuk") 
             Case Else 
                Console.WriteLine("unknown name") 
        End Select 
     End Sub 
 End Module 