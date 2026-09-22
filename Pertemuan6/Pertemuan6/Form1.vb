Imports System.Security.Cryptography.X509Certificates

Public Class Form1
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        dgvMahasiswa.AutoGenerateColumns = True
        dgvMahasiswa.DataSource = ModQuery.TampilkanData()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If ModQuery.TambahData(
            txtNim.Text,
            txtNama.Text,
            txtJurusan.Text
        ) Then
            MessageBox.Show("Data berhasil disimpan")
        End If
        txtJurusan.Clear()
        txtNama.Clear()
        txtNim.Clear()
    End Sub


    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


End Class
