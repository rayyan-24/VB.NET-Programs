Imports System
Module Module1
    Sub Main() 
        Const PI = 3.14149 
        Dim radius, area As Single 
        Console.WriteLine("Enter Radius ")
        radius=Console.Readline()
        area = PI * radius * radius 
        Console.WriteLine("Area of circle of radius {0} is {1}",radius,area) 
    End Sub 
End Module 