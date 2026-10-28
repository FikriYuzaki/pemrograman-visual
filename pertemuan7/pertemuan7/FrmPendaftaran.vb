Option Strict On

Imports System.ComponentModel
Imports System.IO

Public Class FrmPendaftaran

    ' Menyimpan NIM mahasiswa yang sudah terdaftar untuk mencegah data duplikat
    Private ReadOnly daftarNim As New List(Of String)

    ' Lokasi penyimpanan file CSV di folder Documents pengguna
    Private ReadOnly lokasiEkspor As String =
        Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                     "data-mahasiswa.csv")

    ' Memeriksa seluruh isian form pendaftaran. Mengembalikan True jika semua input valid.
    Private Function ValidasiInput() As Boolean
        errInput.Clear()
        Dim valid As Boolean = True

        ' Validasi Nama: tidak boleh kosong atau cuma spasi
        If Kosong(txtNama.Text) Then
            errInput.SetError(txtNama, "Nama wajib diisi.")
            valid = False
        End If

        ' Validasi Angkatan: harus angka antara tahun 2015 sampai tahun sekarang
        Dim angkatan As Integer
        If Not Integer.TryParse(txtAngkatan.Text, angkatan) OrElse
           angkatan < 2015 OrElse angkatan > Date.Today.Year Then
            errInput.SetError(txtAngkatan, "Angkatan harus angka 2015 s.d. tahun ini.")
            valid = False
        End If

        ' Validasi NIM: harus tepat 9 digit angka dan belum pernah terdaftar
        If Not SemuaDigit(txtNim.Text, 9) Then
            errInput.SetError(txtNim, "NIM harus 9 digit angka.")
            valid = False
        ElseIf daftarNim.Contains(txtNim.Text) Then
            errInput.SetError(txtNim, "NIM sudah terdaftar.")
            valid = False
        End If

        ' Validasi Jurusan: wajib memilih salah satu jurusan pada ComboBox
        If cboJurusan.SelectedIndex = -1 Then
            errInput.SetError(cboJurusan, "Pilih salah satu jurusan.")
            valid = False
        End If

        ' Validasi IPK: harus angka desimal antara 0.00 sampai 4.00
        Dim ipk As Decimal
        If Not CobaDesimal(txtIpk.Text, ipk) OrElse ipk < 0D OrElse ipk > 4D Then
            errInput.SetError(txtIpk, "IPK harus angka 0,00 s.d. 4,00.")
            valid = False
        End If

        Return valid
    End Function

    ' Menyimpan data mahasiswa baru setelah lolos semua tahap validasi
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah."
            Return
        End If

        ' Format nilai IPK menjadi 2 desimal
        Dim ipk As Decimal
        CobaDesimal(txtIpk.Text, ipk)

        ' Tambahkan data ke ListBox dan daftarkan NIM ke koleksi
        lstMahasiswa.Items.Add(txtNim.Text & " | " & txtNama.Text.Trim() & " | " &
                               cboJurusan.Text & " | " & txtAngkatan.Text & " | " & ipk.ToString("0.00"))
        daftarNim.Add(txtNim.Text)

        lblStatus.Text = "Data " & txtNama.Text.Trim() & " tersimpan."
        BersihkanForm()
    End Sub

    ' Validasi langsung saat kursor meninggalkan kotak input NIM
    Private Sub txtNim_Validating(sender As Object, e As CancelEventArgs) Handles txtNim.Validating
        If txtNim.Text = "" Then Return
        If SemuaDigit(txtNim.Text, 9) Then
            errInput.SetError(txtNim, "")
        Else
            errInput.SetError(txtNim, "NIM harus 9 digit angka.")
        End If
    End Sub

    ' Format satu kolom teks agar aman saat diekspor ke CSV (escape karakter khusus)
    Private Function EscapeCsv(teks As String) As String
        If teks.Contains(",") OrElse teks.Contains("""") OrElse teks.Contains(";") OrElse teks.Contains(vbCrLf) Then
            Return """" & teks.Replace("""", """""") & """"
        Else
            Return teks
        End If
    End Function

    ' Mengekspor seluruh data yang tersimpan di ListBox ke file CSV di folder Documents
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        If lstMahasiswa.Items.Count = 0 Then
            MessageBox.Show("Belum ada data mahasiswa untuk diekspor.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Menggunakan Using agar stream file tertutup otomatis setelah penulisan selesai
            Using penulis As New StreamWriter(lokasiEkspor, False)
                penulis.WriteLine("NIM,Nama,Jurusan,Angkatan,IPK")
                For Each item As Object In lstMahasiswa.Items
                    Dim baris As String = item.ToString()
                    Dim kolom() As String = baris.Split(New String() {" | "}, StringSplitOptions.None)
                    If kolom.Length = 5 Then
                        Dim barisCsv As String = String.Format("{0},{1},{2},{3},{4}",
                                                               EscapeCsv(kolom(0)),
                                                               EscapeCsv(kolom(1)),
                                                               EscapeCsv(kolom(2)),
                                                               EscapeCsv(kolom(3)),
                                                               EscapeCsv(kolom(4)))
                        penulis.WriteLine(barisCsv)
                    Else
                        penulis.WriteLine(baris.Replace(" | ", ","))
                    End If
                Next
            End Using

            lblStatus.Text = "Data diekspor ke " & lokasiEkspor
            MessageBox.Show("Data mahasiswa berhasil diekspor ke:" & vbCrLf & lokasiEkspor,
                            "Ekspor Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As IOException
            MessageBox.Show("File sedang dipakai program lain atau tidak bisa ditulis." &
                            vbCrLf & ex.Message, "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengekspor: " & ex.Message,
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Mengosongkan form input dan menghapus semua tanda error
    Private Sub BersihkanForm()
        txtNim.Clear()
        txtNama.Clear()
        txtAngkatan.Clear()
        txtIpk.Clear()
        cboJurusan.SelectedIndex = -1
        errInput.Clear()
        txtNim.Focus()
    End Sub

    ' Tombol bersihkan hanya mereset form isian tanpa menghapus data di ListBox
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        BersihkanForm()
        lblStatus.Text = "Form dibersihkan."
    End Sub

End Class

