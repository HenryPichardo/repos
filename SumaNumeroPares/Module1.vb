Module Module1

    Sub Main()
        Console.WriteLine("*********=====>>>SumaNumerosPares<<<======**************")
        Console.WriteLine("*********=====>>>Del 1 al 100<<<======**************")

        Console.WriteLine("")

        Console.WriteLine("*=>Presione cualquier tecla para continuar...<=*")
        Console.ReadKey()
        Dim ni As Integer = 0
        Dim suma As Integer = 0

        While ni <= 98
            ni = ni + 2
            suma = suma + ni
            Console.WriteLine(ni)
        End While
        Console.WriteLine("Sumatoria = " & suma)
        Console.ReadKey()
    End Sub

End Module
