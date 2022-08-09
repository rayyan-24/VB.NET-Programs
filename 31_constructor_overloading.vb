Imports System   
Module Const_Over   
    Class Details   
        Public name As String   
        Public course As String   
        ' Define Default Constructor   
        Public Sub New()   
            name = "Prince"   
            course = "Coputer Science"   
            Console.WriteLine(" Uses of Overloading Constructor")   
        End Sub   
        ' Create a parametrized constructor   
        Public Sub New(ByVal a As String, ByVal b As String)   
            name = a   
            course = b   
        End Sub   
    End Class   
    Sub Main()   
        ' Called default constructor   
        Dim det As Details = New Details()   
        ' Called the parametrized constructor    
        Dim det1 As Details = New Details("Peter", "Knowledge of Data Mining")   
        Console.WriteLine(" Your Details are: Name : {0} and Course : {1}", det.name, det.course)   
        Console.WriteLine(" Your Overloaded Details are: Name : {0} and Course :{1}", det1.name, det1.course)   
        Console.WriteLine(" Press any key to exit...")   
        Console.ReadKey()   
    End Sub   
End Module