Imports System

Module Module1
Class Student
    Public name As String
    Private id As Integer
    Sub setName()
        Console.WriteLine("Enter Name")
        name=Console.Readline()
    End Sub
    Sub setId()
        Console.WriteLine("Enter ID")
        id=Console.Readline()
    End Sub
    Sub showDet()
        Console.WriteLine("Name is {0}",name)
        Console.WriteLine("ID is {0}",id)
    End Sub
    Public Function getDet(nm As String,I As Integer) As Integer
        name=nm
        id=I
        return id
    End Function
End Class
    Sub Main()
        Dim s1 As Student=New Student()
        Dim x as Integer
        ' s1.setName()
        ' s1.setId()
        x=s1.getDet("Rayyan",6)
        s1.showDet()
        Console.WriteLine("{0}",x)
    End Sub
End Module