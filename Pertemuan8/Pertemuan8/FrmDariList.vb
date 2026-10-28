Option Strict On

Public Class FrmDariList
    Private daftarMahasiswa As List(Of Mahasiswa)

    Private Sub FrmDariList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        daftarMahasiswa = New List(Of Mahasiswa)
        daftarMahasiswa.Add(New Mahasiswa("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D))
        daftarMahasiswa.Add(New Mahasiswa("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D))
        daftarMahasiswa.Add(New Mahasiswa("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D))
        daftarMahasiswa.Add(New Mahasiswa("241712007", "Dimas Siregar", "Teknik Komputer", 2024, 2.95D))

        cboJurusan.Items.AddRange(New String() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})

        bsMahasiswa.DataSource = daftarMahasiswa
        dgvMahasiswa.DataSource = bsMahasiswa
        PerbaruiJumlah()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim valid As Boolean = True

        errInput.Clear()

        If Not ValidasiNim(txtNim.Text.Trim()) Then
            errInput.SetError(txtNim, "NIM harus terdiri dari 9 digit angka.")
            valid = False
        Else
            For Each mhs As Mahasiswa In daftarMahasiswa
                If mhs.Nim = txtNim.Text.Trim() Then
                    errInput.SetError(txtNim, "NIM sudah terdaftar.")
                    valid = False
                    Exit For
                End If
            Next
        End If

        If Not ValidasiNama(txtNama.Text.Trim()) Then
            errInput.SetError(txtNama, "Nama wajib diisi.")
            valid = False
        End If

        If Not ValidasiJurusan(If(cboJurusan.SelectedItem IsNot Nothing, cboJurusan.SelectedItem.ToString(), "")) Then
            errInput.SetError(cboJurusan, "Jurusan wajib dipilih.")
            valid = False
        End If

        Dim angkatan As Integer
        If Not ValidasiAngkatan(txtAngkatan.Text.Trim(), angkatan) Then
            errInput.SetError(txtAngkatan, "Angkatan harus antara 2015 dan " & Date.Now.Year.ToString() & ".")
            valid = False
        End If

        Dim ipk As Decimal
        If Not ValidasiIpk(txtIpk.Text.Trim(), ipk) Then
            errInput.SetError(txtIpk, "IPK harus antara 0 dan 4.")
            valid = False
        End If

        If Not valid Then Return

        Dim mhsBaru As New Mahasiswa(
            txtNim.Text.Trim(),
            txtNama.Text.Trim(),
            cboJurusan.SelectedItem.ToString(),
            angkatan,
            ipk
        )

        bsMahasiswa.Add(mhsBaru)
        PerbaruiJumlah()
        BersihkanInput()
    End Sub

    Private Sub PerbaruiJumlah()
        lblJumlah.Text = "Jumlah data: " & daftarMahasiswa.Count.ToString()
    End Sub

    Private Sub BersihkanInput()
        txtNim.Clear()
        txtNama.Clear()
        cboJurusan.SelectedIndex = -1
        txtAngkatan.Clear()
        txtIpk.Clear()
        errInput.Clear()
        txtNim.Focus()
    End Sub
End Class

