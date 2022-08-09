Imports System   
Module Module1   
    Sub Main()   
        Dim An_array() As Integer = {1, 2, 3, 4, 5}   
        Dim i As Integer
        For Each i In An_array   
            Console.WriteLine("{0}", i)   
        Next     
    End Sub   
End Module