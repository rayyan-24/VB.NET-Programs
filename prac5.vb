Imports System

Module Module1
Class parent
    Protected p_data As Integer
    ' Overridable is used to indicate that the procedure will be overrided by another procedure in derived class
    Overridable Public Sub show()
        Console.WriteLine("Parent Data={0}",p_data)
    End Sub
    Overridable Function area(radius As integer) As Integer
        Console.WriteLine("Area = {0}",3.14*radius*radius)
        return 3.14*radius*radius
    End Function
    Public Sub New(a As Integer)
        p_data=a
    End Sub

End Class

Class child
    Inherits parent
    Private c_data As Integer
    ' Overrides indicates that the procedure in base is being overrided by this procedure 
    Overrides Public Sub show()
    ' MyBase is used to access data members or functions of base class in derived class
        Console.WriteLine("Child Data={0} {1} ",c_data,MyBase.p_data)
        MyBase.show()
    End Sub
    Overrides Function area(radius As integer) As Integer
        Console.WriteLine("Area = {0}",3.14*radius*radius)
        return 3.14*radius*radius
    End Function
    Public Sub New(a As Integer,b As Integer)
        MyBase.New(b)
        c_data=a
    End Sub

End Class

    Sub Main()
        Dim p1 as parent=New parent(9)
        p1.show()        
        Dim c1 as child=New child(901,76) 
        c1.show()
        c1.area(7)
    End Sub
End Module