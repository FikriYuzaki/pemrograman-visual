Option Strict On

Public Class FrmUtama

    ' Membuka form contoh konversi input
    Private Sub btnUjiKonversi_Click(sender As Object, e As EventArgs) Handles btnUjiKonversi.Click
        Dim frm As New FrmUjiKonversi()
        frm.ShowDialog()
    End Sub

    ' Membuka form studi kasus pendaftaran mahasiswa
    Private Sub btnPendaftaran_Click(sender As Object, e As EventArgs) Handles btnPendaftaran.Click
        Dim frm As New FrmPendaftaran()
        frm.ShowDialog()
    End Sub

End Class

