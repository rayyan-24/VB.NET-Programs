Imports System
Module Module1
Function add(ByVal n1 As Integer ,ByVal n2 As Integer) As Integer
    n1=n1+1
    n2=n2+1
    return n1
End Function
Sub Work(ByVal a As Integer,ByVal b As Integer)
    Console.WriteLine("{0} {1}",a,b)
End Sub
    Sub Main()
    Dim a,b,x As Integer
    a=5
    b=3
    x=add(a,b)
    Console.WriteLine(a)
    Console.WriteLine(b)
    Work(12,33)
    End Sub
End Module