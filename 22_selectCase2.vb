Module Module1 
    Sub Main() 
         Console.Write("Enter your name: ") 
         Dim name As String = Console.ReadLine() 
         Select Case name 
             Case "Rayyan" 
                Console.WriteLine("Hello Rayyan") 
             Case "Ram" 
                Console.WriteLine("Ram") 
             Case "Rohit" 
                Console.WriteLine("Hello Rohit") 
             Case "Mohit" 
                Console.WriteLine("Hello Mohit") 
             Case Else 
                Console.WriteLine("unknown name") 
         End Select 
     End Sub 
End Module 