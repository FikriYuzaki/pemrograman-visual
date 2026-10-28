Public Class Form1

    Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jumlahTiket As Integer
        Dim isMember As Boolean

        If Not Integer.TryParse(txtJumlahTiket.Text, jumlahTiket) Then
            MessageBox.Show("Masukkan jumlah tiket dalam bentuk angka")
            txtJumlahTiket.Focus()
            Return
        End If

        If jumlahTiket <= 0 Then
            MessageBox.Show("Jumlah tiket harus lebih dari 0")
            txtJumlahTiket.Focus()
            Return
        End If

        isMember = chkMember.Checked

        Dim subtotal As Decimal
        Dim diskonPersen As Decimal
        Dim nilaiDiskon As Decimal
        Dim totalBayar As Decimal

        subtotal = ModTiket.HitungSubtotal(jumlahTiket)
        diskonPersen = ModTiket.HitungDiskonPersen(jumlahTiket, isMember)
        nilaiDiskon = ModTiket.HitungNilaiDiskon(subtotal, diskonPersen)
        totalBayar = ModTiket.HitungTotalBayar(subtotal, nilaiDiskon)

        txtSubtotal.Text = subtotal.ToString("N0")
        txtPersenDiskon.Text = (diskonPersen * 100).ToString("0") & "%"
        txtNilaiDiskon.Text = nilaiDiskon.ToString("N0")
        txtTotalBayar.Text = totalBayar.ToString("N0")
    End Sub

    Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtJumlahTiket.Clear()
        chkMember.Checked = False
        txtSubtotal.Clear()
        txtPersenDiskon.Clear()
        txtNilaiDiskon.Clear()
        txtTotalBayar.Clear()
    End Sub

    Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

End Class

