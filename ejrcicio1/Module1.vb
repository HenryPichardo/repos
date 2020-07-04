Module Module1

    Sub Main()
        Dim nombre, apellido As String
        Console.WriteLine("Por favor introduzca su nombre: ")
        nombre = Console.ReadLine()

        Console.WriteLine("Por favor introduzca su apellido: ")
        apellido = Console.ReadLine()

        Console.WriteLine(" ******************************** " & " BIENVENIDO " & " ******************************** ")

        Console.WriteLine("                             Hola " & nombre & " " & apellido)

        Console.ReadKey()


    End Sub

End Module
