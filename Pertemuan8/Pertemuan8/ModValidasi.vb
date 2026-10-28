Option Strict On

Module ModValidasi
    Public Function ValidasiNim(nim As String) As Boolean
        If nim.Length <> 9 Then Return False
        For Each c As Char In nim
            If Not Char.IsDigit(c) Then Return False
        Next
        Return True
    End Function

    Public Function ValidasiNama(nama As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(nama)
    End Function

    Public Function ValidasiJurusan(jurusan As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(jurusan)
    End Function

    Public Function ValidasiAngkatan(teks As String, ByRef angkatan As Integer) As Boolean
        If Not Integer.TryParse(teks, angkatan) Then Return False
        If angkatan < 2015 OrElse angkatan > Date.Now.Year Then Return False
        Return True
    End Function

    Public Function ValidasiIpk(teks As String, ByRef ipk As Decimal) As Boolean
        If Not Decimal.TryParse(teks, ipk) Then Return False
        If ipk < 0D OrElse ipk > 4D Then Return False
        Return True
    End Function
End Module

