Option Strict On

Public Class FrmCariList
    Private daftarSemua As List(Of Mahasiswa)

    Private Sub FrmCariList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daftarSemua = BuatDaftarMahasiswa()
        bsMahasiswa.DataSource = daftarSemua
        dgvMahasiswa.DataSource = bsMahasiswa
        PerbaruiJumlah()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim kata As String = txtCari.Text.Trim()
        If kata.Length = 0 Then
            bsMahasiswa.DataSource = daftarSemua
        Else
            Dim hasil As New List(Of Mahasiswa)
            For Each mhs As Mahasiswa In daftarSemua
                If mhs.Nama.IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0 OrElse
                   mhs.Nim.IndexOf(kata, StringComparison.OrdinalIgnoreCase) >= 0 Then
                    hasil.Add(mhs)
                End If
            Next
            bsMahasiswa.DataSource = hasil
        End If
        dgvMahasiswa.DataSource = bsMahasiswa
        PerbaruiJumlah()
    End Sub

    Private Sub PerbaruiJumlah()
        lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString() & " dari " & daftarSemua.Count.ToString()
    End Sub
End Class

