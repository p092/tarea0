Module Module1

    Sub Main()
        Console.WriteLine("Ingresa tu nombre")
        Dim nombre As String
        nombre = Console.ReadLine()

        Dim mensaje As String

        mensaje = "Bienvenido " + nombre

        Console.WriteLine(mensaje)

        Console.ReadKey()
    End Sub

End Module
