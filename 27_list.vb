Imports System.Collections.Generic
Module Module1
    Sub Main()
        Dim l1 as List(of integer)=new list(of integer)(10)
        Dim i as integer
        l1.add(10)
        l1.add(20)
        l1.add(30)
        l1.add(40)
        l1.add(50)
        l1.add(60)
        for each i in l1
            Console.WriteLine("{0}",i)
        next i
        Dim l2 as List(of string)=new List(of string)(10)
        l2.Add("Welcome")   
        l2.Add("to")   
        l2.Add("JavaTpoint")   
        l2.Add("Site")
        for each j as string in l2
            Console.WriteLine("{0}",j)
        next j
        Console.WriteLine("{0}",l1.count)
        Console.WriteLine("{0}",l1.capacity)
    End Sub
End Module