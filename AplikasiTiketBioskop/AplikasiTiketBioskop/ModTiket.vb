Module ModTiket

    Public Const HARGA_TIKET As Decimal = 50000D

    Function HitungSubtotal(jumlahTiket As Integer) As Decimal
        Return jumlahTiket * HARGA_TIKET
    End Function

    Function HitungDiskonPersen(jumlahTiket As Integer, isMember As Boolean) As Decimal
        If jumlahTiket < 5 Then
            Return 0D
        ElseIf jumlahTiket >= 5 AndAlso isMember Then
            Return 0.15D
        Else
            Return 0.1D
        End If
    End Function

    Function HitungNilaiDiskon(subtotal As Decimal, diskonPersen As Decimal) As Decimal
        Return subtotal * diskonPersen
    End Function

    Function HitungTotalBayar(subtotal As Decimal, nilaiDiskon As Decimal) As Decimal
        Return subtotal - nilaiDiskon
    End Function

End Module

