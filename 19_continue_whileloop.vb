 
Imports System   
Module Continue_While   
    Sub Main()   
        'Declaration and initialization of variable i   
        Dim i As Integer = 10   
   
        'Define the While Loop Condition   
        While i < 20
            If i = 14 Then   
                Console.WriteLine(" Skipped number is {0}", i)   
                i += 1 ' skip the define iteration   
                Continue while
                ' exit while
            End If   
            Console.WriteLine(" Value of i is {0}", i)   
            i += 1 ' Update the variable i by 1   
        End While   
        Console.WriteLine(" Press any key to exit...")   
        Console.ReadKey()   
    End Sub   
End Module   