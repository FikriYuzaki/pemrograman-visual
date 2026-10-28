Option Strict On

Imports System.Globalization

' Kumpulan fungsi validasi yang bisa dipakai ulang oleh form mana pun
Public Module ModValidasi

    ' Memeriksa apakah teks kosong atau hanya berisi spasi
    Public Function Kosong(teks As String) As Boolean
        Return teks.Trim() = ""
    End Function

    ' Memeriksa apakah panjang teks tepat dan semua karakternya adalah digit 0-9
    Public Function SemuaDigit(teks As String, panjang As Integer) As Boolean
        If teks.Length <> panjang Then Return False
        For Each karakter As Char In teks
            If karakter < "0"c OrElse karakter > "9"c Then Return False
        Next
        Return True
    End Function

    ' Mengubah teks menjadi Decimal dengan aman.
    ' Koma dan titik sama-sama didukung agar tidak terpengaruh format regional Windows.
    Public Function CobaDesimal(teks As String, ByRef hasil As Decimal) As Boolean
        Dim teksTitik As String = teks.Trim().Replace(",", ".")
        Return Decimal.TryParse(teksTitik, NumberStyles.AllowDecimalPoint,
                                CultureInfo.InvariantCulture, hasil)
    End Function

End Module

