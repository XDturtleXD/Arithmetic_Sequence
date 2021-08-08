Imports System
Imports System.Collections

Module Program2
    'Dim brr() As Integer
    Public n As UInteger = 0
    Dim sn As UInteger
    Public res() As Integer
    Sub Main()
        Dim obj As Object

        Console.WriteLine("         Welcome!")
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
        Try
            obj = Console.ReadLine()
            sn = obj
            If (sn <> obj) Then
                Throw New TypeAccessException("Type Float or Double Detected!")
            End If
            'sn -= 1
        Catch ex As Exception
            Console.WriteLine("Screw You! Enter A Natural Number Goddammit")
            Console.WriteLine("Error Message: ")
            Console.WriteLine(ex.Message)
            Return
            GoTo start
        End Try
        Dim millis As Double = DateTimeOffset.UtcNow.UtcTicks / 10000000
        Dim temp(n - 2) As Integer
        For i As Integer = 0 To n - 2
            temp(i) = i + 1
        Next
        ReDim res(sn - 2)
        Create(temp, sn - 1)
        'ReDim brr(1)

        'Dim temp(n - 2) As Integer
        'For i As Integer = 0 To n - 2
        'temp(i) = i + 1
        'Next
        'If Swap(temp, a) Then
        'Console.WriteLine("True")
        'End If
        Console.WriteLine(String.Format("Processed With {0:#0.000000} Second(s) Elapsed", DateTimeOffset.UtcNow.UtcTicks / 10000000 - millis))
        GoTo start
    End Sub
    'Function Swap(arr() As Integer, a As Integer) As Boolean
    '    For i As Integer = 0 To arr.Length - 1
    '        If a = 0 Then Exit For
    '        Dim temp(arr.Length - 2) As Integer
    '        brr(n - 1 - arr.Length) = arr(i)
    '        Dim k As Integer = 0
    '        For j As Integer = 0 To arr.Length - 1
    '            If (j <> i) Then
    '                temp(k) = arr(j)
    '                k += 1
    '            End If
    '        Next
    '        If Swap(temp, a - 1) Then Return True
    '    Next
    '    If a <> 0 Then Return False
    '    For j As Integer = 0 To brr.Length - 1
    '        Console.Write("{0} ", brr(j))
    '    Next
    '    Console.WriteLine()
    '    Return 1 'Check()
    'End Function
    Function Check(brr() As Integer) As Integer
        Dim onoff As Boolean = True
        Dim sequence As New List(Of Integer) From {0, n}
        'Console.Write("Check: 0 ")
        For Each i As Integer In brr
            If sequence.Contains(i * 2 - n) Then Return 0
            For Each j In sequence
                'Dim d As UInteger = i - sequence(j)
                If sequence.Contains(j * 2 - i) Then
                    onoff = False
                    Exit For
                End If
            Next
            If onoff = True Then
                sequence.Add(i)
                'Console.Write(i)
                'Console.Write(" ")
            Else
                Return 0
            End If
            onoff = True
        Next

        sequence.Sort()
        For Each i As Integer In sequence
            Console.Write(i.ToString() + " ")
        Next
        Console.WriteLine(String.Format(" With Total {0} Numbers In This Sequence", sequence.Count - 1))
        Return sequence.Count - 1
    End Function

    Function Create(arr() As Integer, num As Integer, Optional layer As Integer = 0) As Boolean

        Dim l As Integer = arr.Length
        If num = 0 Then
            'Dim txt = ""
            'For Each i In res
            '    txt += i.ToString() + " "
            'Next
            'MsgBox(txt)
            If Check(res) = sn Then
                Console.WriteLine("True")
                Return True
            Else
                Return False
            End If
        End If

        num -= 1
        'ReDim res(num)

        For i As Integer = 0 To l - num - 1
            res(layer) = arr(i)
            Dim temp(l - 2 - i) As Integer
            For j As Integer = i + 1 To l - 1
                temp(j - i - 1) = arr(j)
            Next
            'Dim txt = ""
            'For Each j In temp
            '    txt += j.ToString() + " "
            'Next
            'MsgBox("tmp: " + txt)
            If Create(temp, num, layer + 1) = True Then Return True
        Next
        Return False

    End Function
End Module
