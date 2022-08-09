Imports System

Module Module1
    Sub Main()
        Dim s1,s2 as String
        s1="Hello World"
        Console.WriteLine("Before Replacement")
        Console.WriteLine(s1)
        s2=s1.Replace("Hello","Bye")
        Console.WriteLine("After Replacement")
        Console.WriteLine(s2)
    End Sub
End Module