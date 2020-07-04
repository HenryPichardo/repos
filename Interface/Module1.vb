Public Interface ISerializable
    Function Guardar() As Boolean
End Interface
Public Class Control
    Dim miDatos As Integer
    Public Property Datos() As Integer
        Get
            Return miDatos
        End Get
        Set(ByVal value As Integer)
            miDatos = value

        End Set
    End Property

End Class
Public Class miControl
    Inherits Control
    Implements ISerializable
    Public Sub New()
        Datos = 20
    End Sub
    Function Guardar() As Boolean Implements ISerializable.Guardar
        Console.WriteLine("Grabando-{0}", Datos)
        Return True
    End Function
End Class
Module Module1

    Sub Main()
        Dim obj As New miControl

        Console.WriteLine("********Interface********")
        Console.WriteLine("=========================")
        obj.Guardar()
        Console.WriteLine("La validacion {0} fue correta", obj.Datos)

        Console.ReadKey()
    End Sub

End Module
