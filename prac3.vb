Imports System

Module Module1
Class distance
    ' Declaration of Data Members
    Private feet As Integer
    Private inch As Double
    ' Default Constructor
    Public Sub New()
        feet=0
        inch=0.0
    End Sub
    ' Parameterized Constructor
    Public Sub New(f As Integer,i as Double)
        feet=f
        inch=i
    End Sub
    ' Sub Procedure
    Public Sub show()
        Console.WriteLine("Feet={0}",feet)
        Console.WriteLine("Inch={0}",inch)
    End Sub
    ' Member Functions
    Public Function getFeet() As Integer
        return feet
    End Function
    Public Function getInch() As Double
        return inch
    End Function
    ' Destructor
    Protected Overrides Sub Finalize()
        Console.WriteLine("Object Destroyed")
    End Sub
End Class
    Sub Main()
        ' Calling Parameterized Constructor
        Dim d1 As distance=New Distance(1,2.31)
        ' Calling Default Constructor
        Dim d2 As distance=New Distance()
        ' Calling Member Functions
        d1.show()
        d2.show()
        Console.WriteLine("feet={0} inch={1}",d1.getFeet(),d1.getInch())
    End Sub
End Module