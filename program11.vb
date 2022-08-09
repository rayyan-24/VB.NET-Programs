Module Module1  
    Sub Main()
        Dim x As Integer = 5    
        Dim y As Integer 
        y = x
        Console.WriteLine(" y = x gives y = {0}", y) 
        y += x
        Console.WriteLine(" y += x gives y = {0}", y) 
        y -= x 
        Console.WriteLine(" y -= x gives y = {0}", y)  
        y *= x
        Console.WriteLine(" y *= x gives y = {0}", y)  
        Console.ReadLine()  
    End Sub 
End Module 