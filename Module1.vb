Module Module1

    Sub Main()
        ' Solicitar al usuario que ingrese tres números diferentes
        Console.Write("Ingresa el primer número entero: ")
        Dim num1 As Integer = Console.ReadLine()

        Console.Write("Ingresa el segundo número entero: ")
        Dim num2 As Integer = Console.ReadLine()

        Console.Write("Ingresa el tercer número entero: ")
        Dim num3 As Integer = Console.ReadLine()

        Dim mayor As Integer
        Dim medio As Integer
        Dim menor As Integer

        ' Encontrar el orden de los numeros
        If num1 <> num2 AndAlso num1 <> num3 AndAlso num2 <> num3 Then
            If num1 > num2 AndAlso num1 > num3 Then
                mayor = num1
                medio = Math.Max(num2, num3)
                menor = Math.Min(num2, num3)
            ElseIf num2 > num1 AndAlso num2 > num3 Then
                mayor = num2
                medio = Math.Max(num1, num3)
                menor = Math.Min(num1, num3)
            ElseIf num3 > num1 AndAlso num3 > num2 Then
                mayor = num3
                medio = Math.Max(num1, num2)
                menor = Math.Min(num1, num2)
            End If
        Else
            Console.WriteLine("Los numero deben ser diferentes")
            Console.WriteLine("Alumno: Francisco Salvador Moreno Garcia.    Carnet: MG1250012022")
            Console.Read()
            Stop
        End If

        ' Mostrar el resultado
        Console.WriteLine("El mayor es: " & mayor)
        Console.WriteLine("El medio es: " & medio)
        Console.WriteLine("El menor es: " & menor)
        Console.WriteLine()
        'autor
        Console.WriteLine("Alumno: Francisco Salvador Moreno Garcia.    Carnet: MG1250012022")
        Console.ReadLine()
    End Sub

End Module
