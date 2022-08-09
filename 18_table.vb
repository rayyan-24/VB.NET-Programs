Imports System   
Module Table   
    Sub Main()   
        'declaration of i and num variable   
        Dim i, num As Integer   
        Console.WriteLine(" Enter any number to print the table")   
        num = Console.ReadLine() ' accept a number from the user   
        Console.WriteLine(" Table of " & num)   
        'define for loop condition, it automatically initialize step to 1   
        For i = 1 To 10   
            Console.WriteLine(num & " * " & i & " = " & i * num)   
        Next   
        Console.ReadKey()   
    End Sub   
End Module