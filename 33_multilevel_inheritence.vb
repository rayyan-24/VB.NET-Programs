Module Multi_inherit1   
    Public Class A   
        Public SName As String   
        Public Sub Display()   
            Console.WriteLine(" Name of Student : {0}", SName)   
        End Sub   
    End Class   
    Public Class B   
        Inherits A   
        Public place As String   
        Public Sub GetPlace()   
            Console.WriteLine(" Address : {0}", place)   
        End Sub   
    End Class   
   
    Public Class C   
        Inherits B   
        Public rollno As Integer   
        Public Sub GetRollno()   
            Console.WriteLine(" Student Roll no. {0}", rollno)   
        End Sub   
    End Class   
   
    Class Profile   
        Sub Main()   
            Dim c As C = New C()   
            c.SName = "Donald Trump"   
            c.place = "USA"   
            c.rollno = 102   
            c.Display()   
            c.GetPlace()   
            c.GetRollno()   
            Console.WriteLine(" Press any key to exit")   
            Console.ReadKey()   
        End Sub   
    End Class   
End Module   
