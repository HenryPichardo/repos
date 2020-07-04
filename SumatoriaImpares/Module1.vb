Module Module1

    Sub Main()
        Console.WriteLine("*********=====>>>  Suma Numeros Impares  <<<======**************")
        Console.WriteLine("*********=====>>>  Del 1 al 300  <<<======**************")

        Console.WriteLine("")

        Console.WriteLine("*=>Presione cualquier tecla para continuar...<=*")
        Console.ReadKey()
        Dim ni As Integer = 0
        Dim suma As Integer = 0
        Dim totalImpares As Integer = 0
        While ni <= 298
            Console.WriteLine(ni)
            ni = ni + 1
            suma = suma + ni
        End While
        totalImpares = (300 / 2)
        Console.WriteLine("Total de numeros impares = " & totalImpares)
        Console.WriteLine("Sumatoria = " & suma)
        Console.ReadKey()
    End Sub

End Module
