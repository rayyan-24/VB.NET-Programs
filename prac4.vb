Imports System
Module Module1
    Structure Distance
        Public feet As Integer
        Public inch As Double
        Public Function add(a As Integer,b As Integer) As Integer
            a=a+1
            b=b+1
            return 1
        End Function
    End Structure
    Sub Main()
        Dim s1 as Distance
        Dim x,y As Integer
        x=10
        y=20
        s1.feet=10
        s1.inch=1.25
        Console.WriteLine("{0}",s1.feet)
        Console.WriteLine("{0}",s1.inch)
        Console.WriteLine("{0} {1}",x,y)
        s1.add(x,y)
        Console.WriteLine("{0} {1}",x,y)
    End Sub
End Module