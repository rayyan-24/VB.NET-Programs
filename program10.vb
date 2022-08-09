Module Module1 
    Sub Main() 
        Dim x As Integer = 11 
        Dim y As Integer = 5 
        If (x = y) Then 
            Console.WriteLine("11=5 is True") 
        Else 
            Console.WriteLine(" 11=5 is False") 
        End If 
        If (x < y) Then 
            Console.WriteLine(" 11<5 is True") 
        Else 
            Console.WriteLine(" 11<5 is False") 
        End If
        If (x > y) Then 
            Console.WriteLine(" 11>5 is True") 
        Else 
            Console.WriteLine(" 11>5 is False") 
        End If     
        x = 3 
        y = 7 
        If (x <= y) Then 
            Console.WriteLine(" 3<=7 is True") 
        End If 
        If (y >= x) Then 
            Console.WriteLine(" 7>=3 is True") 
        End If
    End Sub 
End Module