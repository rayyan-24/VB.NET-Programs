Imports System

Module Module1
    Sub Main()
        Dim s1,s2,s3 as String
        Console.WriteLine("Enter String 1")
        s1=Console.Readline()
        Console.WriteLine("Enter String 2")
        s2=Console.Readline()
        s3=s1 & " " & s2
        Console.WriteLine("After Concatination")
        Console.WriteLine(s3)
    End Sub
End Module