Module Module1

    Sub Main()
        Dim A As Integer = 0
        Dim B As Integer = 0
        Dim C As Integer = 0

        Console.WriteLine("*********=====>>>  Factorial de un numero  <<<======**************")
        Console.WriteLine("")
        Console.WriteLine("*********=====>>>  INGRESE UN VALOR  <<<======**************")
        A = Convert.ToInt32(Console.ReadLine())
        B = 1
        For C = 1 To A
            B = B * C
        Next
        Console.WriteLine("")

        Console.WriteLine("El factorial es = " & B)
        Console.ReadKey()


    End Sub

End Module
