Imports System   
Module Module1   
    Sub Main()   
        Dim An_array() As Integer = {1, 2, 3, 4, 5}   
        Dim i As Integer
        For Each i In An_array   
            Console.WriteLine(" Value of i is {0}", i)   
        Next   
        Console.WriteLine("Press any key to exit...")   
        Console.ReadLine()   
    End Sub   
End Module