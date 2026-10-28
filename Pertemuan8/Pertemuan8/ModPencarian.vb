Option Strict On

Module ModPencarian
    Public Function AmankanTeksFilter(teks As String) As String
        Dim hasil As String = teks
        hasil = hasil.Replace("'", "''")
        hasil = hasil.Replace("[", "[[]")
        hasil = hasil.Replace("*", "[*]")
        hasil = hasil.Replace("%", "[%]")
        Return hasil
    End Function
End Module

