Imports System.DateTime   
Module Module1  
    Sub Main()   
        ' Create DT as an instance of DateTime   
        Dim DT As DateTime = New DateTime()   
        Console.WriteLine("Default Date and Time is :{0}", DT)   
        Console.WriteLine()
        Console.WriteLine(" Different function of DateTime")   
        Dim DoB As DateTime = New Date(2021, 9, 20, 03, 22, 30)   
        '(year,month,day,hours,minutes,seconds)
        Console.WriteLine(" Day is : {0}", DoB.Day)   
        Console.WriteLine(" Month is : {0}", DoB.Month)   
        Console.WriteLine(" Year is : {0}", DoB.Year)   
        Console.WriteLine(" Hour is : {0}", DoB.Hour)   
        Console.WriteLine(" Minute is : {0}", DoB.Minute)   
        Console.WriteLine(" Second is : {0}", DoB.Second)   
        Console.WriteLine(" Millisecond is : {0}", DoB.Millisecond)   
        Console.WriteLine(" Day of Week is : {0}", DoB.DayOfWeek)   
        Console.WriteLine(" Day Of year is : {0}", DoB.DayOfYear)   
        Console.WriteLine(" Time of Day is : {0}", DoB.TimeOfDay)   
        Console.WriteLine(" Total Tick is : {0}" , DoB.Ticks)   

        ' To get the Max Value of DateTime   
        Dim MDT As DateTime = DateTime.MaxValue   
        Console.WriteLine(" Max value of Date and Time is {0}", MDT)   
   
        ' To get the Min Value of DateTime   
        Dim MinDT As DateTime = DateTime.MinValue   
        Console.WriteLine(" Min value of Date and Time is {0}", MinDT)   
   
        ' Create a DateTime from string   
        Dim DString As String = "20/09/2021 3:32:29 PM"   
        Console.WriteLine("Display Date and Time from string : {0}", DString)   
        Console.WriteLine(" Press any key to exit?")   
    End Sub   
End Module