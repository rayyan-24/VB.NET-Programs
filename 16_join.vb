Imports System
Module Module1 
    Sub Main() 
        Dim students(0 To 2) As String  
        students(0) = "John"  
        students(1) = "Alice"  
        students(2) = "Antony"  
        Dim classmates As String  
        classmates = Join(students, ", ")  
        Console.WriteLine(classmates)  
        Console.ReadKey() 
    End Sub  
End Module 