Imports System
Module Module1
Function area(len As integer,bre As Integer) As Integer
    Console.WriteLine("Area = {0}",len*bre)
    return len*bre
End Function
Function area(radius As integer) As Integer
    Console.WriteLine("Area = {0}",3.14*radius*radius)
    return 3.14*radius*radius
End Function
    Sub Main()
    Dim x as Integer
        x=area(2,43)
        Console.WriteLine("x={0}",x)
        x=area(7)
        Console.WriteLine("x={0}",x)
    End Sub
End Module