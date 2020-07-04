Module Module1
    Sub Main()
        Dim Persona(4) As String

        Console.Write("Digite el primer nombre: ")
        Persona(0) = Console.ReadLine()

        Console.Write("Digite el segundo nombre : ")
        Persona(1) = Console.ReadLine()

        Console.Write("Digite el tercer nombre : ")
        Persona(2) = Console.ReadLine()

        Console.Write("Digite el cuarto nombre : ")
        Persona(3) = Console.ReadLine()

        Console.Write("Digite el quinto nombre : ")
        Persona(4) = Console.ReadLine()

        Console.WriteLine("                            Los nombres son  :  ")
        Console.WriteLine("               *******************************************************   ")
        Console.WriteLine("   ")

        For index = 0 To 4
            Console.WriteLine(Persona(index))
        Next
        Console.ReadKey()

    End Sub

End Module
