Module Module1

    Sub Main()

        'mostramos el encabezado del programa

        Console.WriteLine("****SISTEMA DE FACTURACION DE PRODUCTOS*******")

        'solicitar la cantidad de productos

        Console.WriteLine("****   Cuantos Productos se van a facturar?   *******")
        Dim cantProductos As Integer = Console.ReadLine()

        'crear la matriz para capturar los datos
        Dim ventas(cantProductos - 1, 5) As String
        For fila = 0 To cantProductos - 1
            Console.WriteLine("Escriba el Nombre del producto #" & (fila + 1))
            ventas(fila, 0) = Console.ReadLine()
            Console.WriteLine("Cantidad:")
            ventas(fila, 1) = Console.ReadLine()
            Console.WriteLine("Precio:")
            ventas(fila, 2) = Console.ReadLine()
            

            Console.WriteLine("*******     Elija una opcion")
            Console.WriteLine(" ")
            Console.WriteLine("******* Continuar presione la tecla(c)")
            Console.WriteLine(" ")
            Console.WriteLine("******* Terminar presione la tecla(t)")

            Dim opcion As ConsoleKeyInfo = Console.ReadKey()
            Console.WriteLine()
            If opcion.Key = ConsoleKey.C Then

            ElseIf (opcion.Key = ConsoleKey.T) Then
                Exit For
            Else
                Console.WriteLine("Debe elegir C o T")
            End If



        Next



        'recorrer la matriz para calcular los  subTotales
        For fila = 0 To cantProductos - 1
            Dim cantidad As Decimal = ventas(fila, 1)
            Dim precio As Decimal = ventas(fila, 2)
            Dim subTotal As Decimal
            Dim total As decimal
            Dim descuento As Double = 0

            subTotal = cantidad * precio
            total = subTotal - descuento



            'ahora guardaremos el subtotal y el total

            ventas(fila, 3) = subTotal
            ventas(fila, 5) = total
            If subTotal>=5000 And subTotal<=10000 Then
                descuento = subTotal * 0.05
                
                ElseIf subTotal>=10001 And subTotal<=15000 Then
                descuento = subTotal * 0.10

                ElseIf subTotal>1500 Then
                descuento = subTotal * 0.15

                End If

                ventas(fila,4) = descuento
        Next
        'declaro el total general
        Dim totalGeneral As Double = 0
        'declaro productos facturados
        Dim prodFacturados As Integer = 0

        'mostrar el nombre precio y subtotal y el total general

        For fila = 0 To cantProductos - 1
            prodFacturados = prodFacturados + ventas(fila, 1)
            totalGeneral = totalGeneral + ventas(fila, 5)
            Console.WriteLine("Producto: {0}     Cantidad: {1}     Precio: {2}     subtotal: {3}      Descuento: {4}     Total: {5}",
            ventas(fila, 0),
            ventas(fila, 1),
            ventas(fila, 2),
            ventas(fila, 3),
            ventas(fila, 4),
            ventas(fila, 5))
            Console.WriteLine("")
        Next
        Console.WriteLine("Total de productos facturados = " & prodFacturados)
        Console.WriteLine("Total General = RD$" & totalGeneral)
        Console.ReadKey()

    End Sub

End Module
