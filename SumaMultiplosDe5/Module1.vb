Module Module1

    Sub Main()
        Console.WriteLine("*********=====>>> Suma Multiplos de 5 <<<======**************")
        Console.WriteLine("*********=====>>>Del 1 al 100<<<======**************")

        Console.WriteLine("")

        Console.WriteLine("*=>Presione cualquier tecla para continuar...<=*")
        Console.ReadKey()
        Dim ni As Integer = 0
        Dim suma As Integer = 0

        While ni <= 95
            ni = ni + 5
            suma = suma + ni
            Console.WriteLine(ni)
        End While
        Console.WriteLine("Sumatoria = " & suma)
        Console.ReadKey()
    End Sub

End Module
