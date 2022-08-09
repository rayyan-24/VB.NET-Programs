Module Module1 
    Sub Main() 
         Dim name As String 
         Console.WriteLine("Enter Name")
         name = Console.Readline()
         Select Case name 
             Case "Johnny" 
                Console.WriteLine("Hello Johnny") 
             Case "Rayyan" 
                Console.WriteLine("Hello Rayyan") 
             Case "Louis" 
                Console.WriteLine("Hello Louis") 
             Case "Joe" 
                Console.WriteLine("Hello Joe") 
             Case Else 
                Console.WriteLine("unknown name") 
         End Select 
     End Sub 
 End Module 