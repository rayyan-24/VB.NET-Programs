Imports System
Module Module1 
    Sub Main() 
        Dim var_w As Integer = 11 
        Dim var_x As Integer = 5 
        Dim var_q As Integer = 2 
        Dim var_y As Integer 
        Dim var_z As Single   
        var_y = var_w + var_z 
        Console.WriteLine(" Result of 11 + 5 is {0} ", var_y)   
        var_y = var_w - var_x 
        Console.WriteLine(" Result of 11 - 5 is {0} ", var_y)   
        var_y = var_w * var_x 
        Console.WriteLine(" Result of 11 * 5 is {0} ", var_y)   
        var_z = var_w / var_x 
        Console.WriteLine(" Result of 11 / 5 is {0}", var_z)   
        var_y = var_w \ var_x 
        Console.WriteLine(" Result of 11 \ 5 is {0}", var_y)   
        var_y = var_w Mod var_x 
        Console.WriteLine(" Result of 11 MOD 5 is {0}", var_y)   
        var_y = var_x ^ var_x 
        Console.WriteLine(" Result of 5 ^ 5 is {0}", var_y) 
        Console.ReadLine()
    End Sub 
        End Module