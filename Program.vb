Imports System
Imports System.Collections

Module Program
    Dim brr() As Integer
    Public n As UInteger = 0
    Dim sn As UInteger
    Sub Main()
        Dim obj As Object

        Console.WriteLine("         Welcome!，幹付我錢，打這個很麻煩。")
        Console.WriteLine("SYSTEM POWERED BY TORTOISE")
start:

        Console.Write("Please Enter The Number That You Desire(It Has To Be A Natrual Number): ")
        Try
            obj = Console.ReadLine()
            n = obj
            If (n <> obj) Then
                Throw New TypeAccessException("Type Float or Double Detected!")
            End If
        Catch ex As Exception
            Console.WriteLine("Screw You! Enter A Natural Number Goddammit")
            Console.WriteLine("Error Message: ")
            Console.WriteLine(ex.Message)
            'Return
            GoTo start
        End Try
        Console.Write("S(n): ")
        Dim a As Integer
        Try
            obj = Console.ReadLine()
            sn = obj
            If (sn <> obj) Then
                Throw New TypeAccessException("Type Float or Double Detected!")
            End If
            a = sn - 1
        Catch ex As Exception
            Console.WriteLine("Screw You! Enter A Natural Number Goddammit")
            Console.WriteLine("Error Message: ")
            Console.WriteLine(ex.Message)
            'Return
            GoTo start
        End Try
        Dim millis As Double = DateTimeOffset.UtcNow.UtcTicks / 10000000
        ReDim brr(a - 1)
        Dim temp(n - 2) As Integer
        For i As Integer = 0 To n - 2
            temp(i) = i + 1
        Next
        If Swap(temp, a) Then
            Console.WriteLine("True")
        End If
        Console.WriteLine(String.Format("Processed With {0:#0.000000} Second(s) Elapsed", DateTimeOffset.UtcNow.UtcTicks / 10000000 - millis))
        GoTo start
    End Sub
    Function Swap(arr() As Integer, a As Integer) As Boolean
        For i As Integer = 0 To arr.Length - 1
            If a = 0 Then Exit For
            Dim temp(arr.Length - 2) As Integer
            brr(n - 1 - arr.Length) = arr(i)
            Dim k As Integer = 0
            For j As Integer = 0 To arr.Length - 1
                If (j <> i) Then
                    temp(k) = arr(j)
                    k += 1
                End If
            Next
            If Swap(temp, a - 1) Then Return True
        Next
        If a <> 0 Then Return False
        For j As Integer = 0 To brr.Length - 1
            Console.Write("{0} ", brr(j))
        Next
        Console.WriteLine()
        Return Check()
    End Function
    Function Check() As Boolean
        Dim onoff As Boolean = True
        Dim sequence As New List(Of Integer) From {0, n}
        Console.Write("Check: 0 ")
        For i As Integer = 0 To brr.Length - 1
            If sequence.Contains(Math.Abs(brr(i) * 2 - n)) Then Continue For
            For j As UInteger = 0 To sequence.Count - 1
                'Dim d As UInteger = i - sequence(j)
                If sequence.Contains(math.Abs (sequence(j) * 2 - brr(i))) Then
                    onoff = False
                    Exit For
                End If
            Next
            If onoff = True Then
                sequence.Add(brr(i))
                Console.Write(brr(i))
                Console.Write(" ")
            End If
            onoff = True
        Next
        Console.Write(n)
        Console.WriteLine(String.Format(" With Total {0} Numbers In This Sequence", sequence.Count - 1))
        Return sequence.Count - 1 = sn
    End Function
End Module
