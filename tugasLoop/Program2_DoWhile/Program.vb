Imports System

Module Program
    Sub Main(args As String())
        ' Inisialisasi variabel counter
        Dim counter As Integer = 1

        ' Perulangan Do While...Loop selama counter <= 5
        Do While counter <= 5
            Console.WriteLine("Nilai angka: " & counter)
            ' Memperbarui nilai counter agar tidak terjadi infinite loop
            counter += 1
        Loop
    End Sub
End Module

