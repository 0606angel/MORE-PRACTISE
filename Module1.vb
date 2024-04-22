Module Module1
    Private name As String = "Junior"
    Private age As Integer = 23

    Sub Main()
        Console.WriteLine(name)
        Console.WriteLine(age)
        Console.ReadLine()
        Console.WriteLine("how old are you " & age)
        Console.WriteLine("my name is " & name)
        Console.ReadLine()
        variables()
        Console.ReadLine()
        conditions()
        Console.ReadLine()
        loops()
        Console.ReadLine()
        conditional_statements()
        Console.ReadLine()

    End Sub

    Private Sub variables()
        Dim name As String = "CeCe"
        Dim age As Integer = 45
        Dim salary As Integer = 89600

        Console.WriteLine("What Is Your name? " & name)
        Console.WriteLine("How Old Are You? " & age)
        Console.WriteLine("how much do they pay you " & salary)


    End Sub

    Private Sub conditions()


        Console.WriteLine("Enter the name of the university ")
        Dim university As String = Console.ReadLine()
        Console.WriteLine("Enter your name ")
        Dim student_name As String = Console.ReadLine()
        Console.WriteLine("Enter your student number")
        Dim student_num As Integer = Console.ReadLine()
        If university = "UJ" Then
            Console.WriteLine("you have entered the correct institution")
        End If
        If student_name = "Mbuelo Maranda" Then
            Console.WriteLine("follow the last step")
        End If
        If student_num = 223068270 Then
            Console.WriteLine("welcome Mbuelo Maranda, you are registred as a uj student")
        End If
        Console.ReadLine()

    End Sub

    Private Sub loops()
        Dim thoughts As Integer

        For thoughts = 1 To 10
            Console.WriteLine("I AM TIRED, I WANT TO REST......")
        Next
        Console.ReadLine()
    End Sub

    Private Sub conditional_statements()

        Console.WriteLine("which faculty are you in? ")
        Dim faculty As String = Console.ReadLine
        If faculty = "faculty of science" Then
            Console.WriteLine("Nice One")
            Console.ReadLine()
        End If


        Console.WriteLine("which course are you doing? ")
        Dim course As String = Console.ReadLine()
        If course = "computer sciences" Then
            Console.WriteLine("SUICIDE!!!!!!")
            Console.ReadLine()
        End If

        Console.WriteLine("are you in the main stream or extended course?")
        Dim choice As String = Console.ReadLine()
        If choice = "extended course" Then
            Console.WriteLine("not so bad....")
            Console.ReadLine()
        End If

        Console.WriteLine("How many modules do you have in a semester?")
        Dim modules As Integer = Console.ReadLine()
        If modules < 4 Then
            Console.WriteLine("then you can manage")
            Console.ReadLine()
        End If
        Console.ReadLine()






    End Sub







End Module
