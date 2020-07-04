Module Module1

    Sub Main()
        'Dim contador As Integer = 0

        'While contador <= 10

        '    contador = contador + 2

        '    Console.WriteLine("contador" & (contador))

        'End While

        'Console.ReadKey()

        'Dim i As Integer

        'Console.WriteLine("Introduzca un valor")
        'i = Convert.ToInt32(Console.ReadLine())
        'If i > 1 Then
        '    Console.WriteLine("la variable i es mayor que 1")
        'ElseIf i < 1 Then
        '    Console.WriteLine("la variable i es menor que 1")

        'End If
        'Console.ReadKey()

        'Dim valor1 As String = "Este es el valor 1"
        'Dim valor2 As Integer = 5
        'Dim valor3 As String = valor1

        'Console.WriteLine(valor1)
        'Console.WriteLine(valor2)
        'Console.WriteLine(valor3)



        'Muestra un mensaje en la pantalla pidiendo informacion al usuario

        'Console.WriteLine("Ingrese una frase o su nombre")
        'Dim inputTexto As String = Console.ReadLine()







        'Muestra un menu para que el usuario seleccione una opcion


        'Console.WriteLine(" (1) -Mostrar nombre en mayusculas")
        'Console.WriteLine(" (2) -Mostrar nombre en minusculas")
        'Console.WriteLine(" (3) -Mostrar largo del nombre")
        'Console.WriteLine("Ingrese una opcion")

        'Dim opcion As Integer = Console.ReadLine() 

        'If (opcion= 1) Then
        '    Console.WriteLine(inputTexto.ToUpper())
        '    Console.WriteLine("" + "" + "el nombre esta en mayusculas")

        'ElseIf (opcion = 2) Then
        '    Console.WriteLine(inputTexto.ToLower())
        '    Console.WriteLine("el nombre esta en minusculas")

        'ElseIf (opcion = 3) Then
        '    Console.WriteLine("su nombre tiene ")
        '    Console.WriteLine(inputTexto.Length)
        '    Console.WriteLine("caracteres")
        'End If

        'Console.WriteLine()
        'Console.WriteLine("Presione una tecla para finalizar")
        'Console.ReadKey()



        'Dim valor As Integer
        'Console.WriteLine("Inserte un valor")
        'valor = Console.ReadLine()
        'If (valor > 10) Then
        '    Console.WriteLine("el numero ingresado es mayor que 10")

        'Else
        '    Console.WriteLine("el numero ingresado es menor que 10")

        'End If

        'Dim diaSemana As Integer

        'Console.WriteLine("Los dias de la semana")
        'Console.WriteLine("")
        'Console.WriteLine("Introduzca un numero del 1 al 7")
        'diaSemana = Console.ReadLine()

        'Select Case diaSemana
        '    Case 1
        '        Console.WriteLine("lunes")
        '    Case 2
        '        Console.WriteLine("martes")
        '    Case 3
        '        Console.WriteLine("miercoles")
        '    Case 4
        '        Console.WriteLine("jueves")
        '    Case 5
        '        Console.WriteLine("viernes")
        '    Case 6
        '        Console.WriteLine("sabado")
        '    Case 7
        '        Console.WriteLine("domingo")

        '    Case Else
        '        Console.WriteLine("Opcion incorrecta")
        'End Select
        'Console.ReadKey()

        Dim i As Integer
        For i = 0 To 10 Step 1
            'i se incrementa en 10
            Console.WriteLine(i)
        Next
        Console.ReadKey()

        'Dim nombres() As String = {"Manuel", "Maria", "Pedro", "Luisa", "Josefa", "Wilkin"}
        'Dim auxNombre As String
        'For Each auxNombre In nombres
        '    Console.WriteLine(auxNombre)
        'Next
        'Console.ReadKey()

        'Dim contador As Integer
        '
        '
        'While (contador <= 10) = True
        '
        '    contador = contador + 2
        '
        '    Console.WriteLine("contador :" & (contador))
        'End While
        '
        '
        'Console.ReadKey()
        '
        'Dim paises(2, 3) As String

        'paises(0, 0) = "RD"
        'paises(1, 2) = "Cuba"
        'paises(2, 3) = "USA"
        'paises(0, 1) = "Mexico"


        'Dim x As Integer
        'Dim z As Integer

        'For x = 0 To 2
        '    For z = 0 To 3
        '        Console.WriteLine("pais : " & paises(x, z))
        '    Next
        'Next

        'Console.ReadKey()


    End Sub

End Module
