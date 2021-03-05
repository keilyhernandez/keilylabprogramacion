Shared Sub Main(args As String())
    Dim I As Integer = 0
    Dim K As Integer = 0
    Dim CAN As Integer = 0
    Dim AUX As Integer = 0
    Dim linea As String
    Console.Write("CUANTOS ELEMENTOS MÁX=12:")
    linea = Console.ReadLine()
    CAN = Integer.Parse(linea)
    Dim VEC(0 To CAN + 1 - 1) As Integer
    ' INGRESO
    For I = 1 To CAN
        Console.Write("POSICIÓN {0} ==>", I)
        linea = Console.ReadLine()
        VEC(I) = Integer.Parse(linea)

    Next
    ' PROCESO
    For I = 1 To CAN - 1
        For K = I + 1 To CAN
            If (VEC(I) < VEC(K)) Then

                AUX = VEC(K)
                VEC(K) = VEC(I)
                VEC(I) = AUX

            End If

        Next
    Next
    Console.WriteLine()
    ' SALIDA
    Console.WriteLine("ARREGLO ORDENADO DESCENDENTE")
    For I = 1 To CAN
        Console.WriteLine(VEC(I))

    Next
    Console.Write("Pulse una Tecla:")
    Console.ReadLine()

End Sub