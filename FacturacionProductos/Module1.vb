Module Module1

    Sub Main()
        'mostramos el encabezado del programa

        Console.WriteLine("****SISTEMA DE FACTURACION DE PRODUCTOS*******")

        'solicitar la cantidad de productos

        Console.WriteLine("****   Cuantos Productos se van a facturar?   *******")
        Dim cantProductos As Integer = Console.ReadLine()

        'crear la matriz para capturar los datos
        Dim ProductosFacturados(cantProductos - 1, 5) As String
        For fila = 0 To cantProductos - 1
            Console.WriteLine("Escriba el Nombre del producto # " & (fila + 1))
            ProductosFacturados(fila, 0) = Console.ReadLine()
            Console.WriteLine("Cantidad:")
            ProductosFacturados(fila, 1) = Console.ReadLine()
            Console.WriteLine("Precio:")
            ProductosFacturados(fila, 2) = Console.ReadLine()


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
        'declaro el descuento y lo calculo tambien


        'recorrer la matriz para calcular los  subTotales
        For fila = 0 To cantProductos - 1
            Dim cantidad As Decimal = ProductosFacturados(fila, 1)
            Dim precio As Decimal = ProductosFacturados(fila, 2)
            Dim subTotal As Decimal
            Dim total As Decimal
            Dim descuento As Double = 0

            subTotal = cantidad * precio


            'ahora guardaremos el subtotal y el total

            ProductosFacturados(fila, 3) = subTotal
            ProductosFacturados(fila, 5) = total
            If subTotal >= 5000 And subTotal <= 10000 Then
                descuento = subTotal * 0.05

            ElseIf subTotal >= 10001 And subTotal <= 15000 Then
                descuento = subTotal * 0.1

            ElseIf subTotal > 1500 Then
                descuento = subTotal * 0.15

            End If

            total = subTotal - descuento
            ProductosFacturados(fila, 4) = descuento
        Next
        'declaro el total general
        Dim totalGeneral As Double = 0
        'declaro productos facturados
        Dim prodFacturados As Integer = 0
        Dim subtotalgen As Double = 0
        Dim totalDesc As Decimal = 0

        'mostrar el nombre precio y subtotal y el total general

        For fila = 0 To cantProductos - 1
            prodFacturados = prodFacturados + ProductosFacturados(fila, 1)
            totalGeneral = totalGeneral + ProductosFacturados(fila, 5)
            subtotalgen = subtotalgen + ProductosFacturados(fila, 3)
            totalDesc = totalDesc + ProductosFacturados(fila, 4)
            Console.WriteLine("Producto: {0}     Cantidad: {1}     Precio: {2}     subtotal: {3}      Descuento: {4}     Total: {5}",
            ProductosFacturados(fila, 0),
            ProductosFacturados(fila, 1),
            ProductosFacturados(fila, 2),
            ProductosFacturados(fila, 3),
            ProductosFacturados(fila, 4),
            ProductosFacturados(fila, 5))
            Console.WriteLine("")
        Next
        Console.WriteLine("Subtotal General = " & subtotalgen)
        Console.WriteLine("Total Descuento = RD$" & totalDesc)
        Console.WriteLine("Total de productos facturados = " & prodFacturados)
        Console.WriteLine("Total General = RD$" & totalGeneral)
        Console.ReadKey()
    End Sub

End Module
