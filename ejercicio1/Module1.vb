Module Module1

    Sub Main()
        Console.WriteLine("Sumatoria de los numeros enteros pares del 1 al 100")
        Console.WriteLine()
        Dim num_ini As Integer = 1

        Dim suma As Integer
        Dim i As Integer
        Dim contador As Integer = 1
        Dim residuo As Integer

        Do While num_ini <= 100
            num_ini = num_ini + 1
            residuo = num_ini Mod 2

            If (residuo) = 0 Then

            End If
        Loop
        For i = 0 To 100 Step 2

            Console.WriteLine(i)
        Next
        Console.WriteLine("La sumatoria de los numeros enteros pares del 1 al 100 es = " & (suma))
        Console.ReadKey()




    End Sub

End Module
