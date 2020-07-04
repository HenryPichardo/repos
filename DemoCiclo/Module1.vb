Module Module1

    Sub Main()
        Console.WriteLine("Cuenta hasta el numero que diga el usuario")
        Console.WriteLine()
        Console.WriteLine("Introduzca el numero")
        Dim nf As Integer = Console.ReadLine()
        Dim ni As Integer = 1

        Console.WriteLine("Resultado con while")
        While ni <= nf
            Console.WriteLine(ni)
            ni = ni + 1
        End While
        Console.WriteLine()
        Console.ReadKey()


        Console.WriteLine("Resultado con do while")
        Do While ni <= nf
            Console.WriteLine(ni)
            ni = ni + 1
        Loop
        Do

        Loop
        Console.WriteLine(ni)
        Console.WriteLine()




    End Sub

End Module
