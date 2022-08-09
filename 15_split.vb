Imports System
Module Module1 
    Sub Main() 
        Dim myarray() As String 
        Dim var22 As String 
        Dim x As Integer 
        var22 = "Welcome, to, My Application" 
        myarray = Split(var22, ", ") 
        For x = LBound(myarray) To UBound(myarray) 
             Console.WriteLine(myarray(x)) 
         Next 
         Console.ReadKey() 
    End Sub 
End Module 