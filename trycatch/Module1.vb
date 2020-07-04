Module Module1

    Sub Main()
        Dim a, b, c As Integer

        Try
            a = b / c

        Catch ex As Exception
            Console.WriteLine(" Resultado" & a)
        Finally
            Console.WriteLine("error")

        End Try
        Console.ReadKey()
    End Sub

End Module
