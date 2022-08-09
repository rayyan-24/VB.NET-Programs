Module Module1 
    Sub Main() 
         Dim name As String 
         name = "Rayyan" 
         Select Case name 
             Case "Johnny" 
                Console.WriteLine("Hello John") 
             Case "Rayyan" 
                Console.WriteLine("Hello Rayyan") 
             Case "Louis" 
                Console.WriteLine("Hello Alice") 
             Case "Joe" 
                Console.WriteLine("Hello Joel") 
             Case Else 
                Console.WriteLine("unknown name") 
         End Select 
         Console.WriteLine("VB.NET is easy!") 
     End Sub 
 End Module 