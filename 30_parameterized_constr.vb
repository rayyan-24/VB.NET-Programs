Imports System   
Module Para_Const   
    Class Tutor   
        Public name As String   
        Public topic As String   
        ' Create a parameterized constructor to pass parameter   
        Public Sub New(ByVal a As String, ByVal b As String)   
            name = a   
            topic = b   
            Console.WriteLine(" We are using a parameterized constructor to pass the parameter")   
        End Sub   
    End Class   
    Sub Main()   
        ' The constructor will automatically call when the instance of the class is created   
        Dim tutor As Tutor = New Tutor("VB.NET", "VB.NET Constructor")   
        Console.WriteLine(" Your Site Name is : {0}", tutor.name)   
        Console.WriteLine(" Your Topic Name is : {0}", tutor.topic)   
        Console.WriteLine(" Press any key to exit...")   
        Console.ReadKey()   
    End Sub   
End Module