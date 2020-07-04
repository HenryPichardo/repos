Module Module1

    Sub Main()
        'mostramos el encabezado del programa
        Console.WriteLine("****Este programa calcula comisiones de ventas*******")
        Console.WriteLine("")

        'solicitar la cantidad de empleados

        Console.WriteLine("****Introduzca la cantidad de empleados*******")
        Dim cantEmpleados As Integer = Console.ReadLine()

        'crear la matriz para capturar los datos
        Dim comisionesVentas(cantEmpleados - 1, 4) As String
        For fila = 0 To cantEmpleados - 1
            Console.WriteLine("Nombre:")
            comisionesVentas(fila, 0) = Console.ReadLine()
            Console.WriteLine("Monto de la venta:")
            comisionesVentas(fila, 1) = Console.ReadLine()
            Console.WriteLine("Sueldo del empleado:")
            comisionesVentas(fila, 2) = Console.ReadLine()
        Next
        'recorrer la matriz para calcular los calculos de comision para cada empleado
        For fila = 0 To cantEmpleados - 1
            Dim comision As Decimal = 0
            Dim montoVenta As Decimal = comisionesVentas(fila, 1)
            Dim totalDevengado As Decimal
            If montoVenta >= 50000 And montoVenta <= 100000 Then
                comision = montoVenta * 0.05

            ElseIf montoVenta >= 100001 And montoVenta <= 150000 Then
                comision = montoVenta * 0.1

            ElseIf montoVenta >= 150001 And montoVenta <= 300000 Then
                comision = montoVenta * 0.15

            ElseIf montoVenta > 300000 Then
                comision = montoVenta * 0.2
            End If
            'ahora guardaremos la comision

            comisionesVentas(fila, 3) = comision
            totalDevengado = comision + comisionesVentas(fila, 2)
            comisionesVentas(fila, 4) = totalDevengado

        Next

        'mostrar el nombre monto y comision
        For fila = 0 To cantEmpleados - 1
            Console.WriteLine("Empleado: {0}     Monto Venta: {1}     Sueldo: {2}     Comision: {3} Total devengado: {4}",
                              comisionesVentas(fila, 0),
            comisionesVentas(fila, 1),
            comisionesVentas(fila, 2),
            comisionesVentas(fila, 3),
            comisionesVentas(fila, 4))
        Next
        Console.ReadKey()

    End Sub

End Module
