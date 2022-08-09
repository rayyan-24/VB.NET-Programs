Imports System   
Module Default_Const   
    Class Tutor   
        Public name As String   
        Public topic As String   
        ' Create a default constructor   
        Public Sub New()   
            name = "vb.net"   
            topic = "VB.NET Tutorial"   
        End Sub   
    End Class   
    Sub Main()   
        ' The constructor will automatically call when the instance of the class is created   
        Dim tutor1 As Tutor = New Tutor()                                 ' Create an object as a tutor   
        Console.WriteLine(" Your Site Name is : {0}", tutor1.name)   
        Console.WriteLine(" Your Topic Name is : {0}", tutor1.topic)   
        Console.WriteLine(" Press any key to exit...")   
        Console.ReadKey()   
    End Sub   
End Module