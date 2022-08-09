Imports System   
Module Simple_Inherit   
    Public Class Vehicle   
        Public Sub speed()   
            Console.WriteLine(" 4 Wheeler cars are more luxurious than 2 Wheeler")   
        End Sub   
   
        Public Overridable Sub perform()   
            Console.WriteLine(" Both Vehicles are good, but in a narrow lane, two-wheeler are more comfortable than 4-Wheeler")   
        End Sub   
    End Class   
   
    Class Bike   
        Inherits Vehicle   
        Public Overrides Sub perform()   
            Console.WriteLine(" Two-wheeler are lesser weight as compared to 4 wheeler")   
        End Sub   
    End Class   
    Class Car   
        Inherits Vehicle   
        Public Overrides Sub perform()   
            Console.WriteLine(" It is 4 wheelar car")   
        End Sub   
    End Class   
   
    Sub Main()   
        Dim vehicle As Vehicle = New Vehicle()   
        Dim bike As Bike = New Bike()   
        Dim car As Car = New Car()   
        vehicle = bike   
        vehicle.perform()   
        vehicle = car   
        vehicle.perform()   
        Console.WriteLine(" Press any ley to exit...")   
        Console.ReadKey()   
    End Sub   
End Module 