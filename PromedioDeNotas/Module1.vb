Module Module1

    Sub Main()
        Console.WriteLine("*****_____Programa que calcula el promedio de notas____*****")
        Console.WriteLine("")
        Console.WriteLine("Cuantas notas vamos a calcular?....Inserte la cantidad de notas:")
        Dim a As Integer
        Dim cantnotas = Console.ReadLine()
        For a = 1 To cantnotas
            Console.WriteLine("Introduzca la nota " & a)
        Next
        Console.ReadKey()


    End Sub

End Module
