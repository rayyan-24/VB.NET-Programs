Imports System

Module Module1
    Sub Main()
        Dim s1,s2 as String
        s1="Hello"
        Console.WriteLine("Enter String")
        s2=Console.Readline()
        if(String.Compare(s1,s2)=0)then
            Console.WriteLine("Same")
        else
            Console.WriteLine("Not Same")
            
        End If
    End Sub
End Module