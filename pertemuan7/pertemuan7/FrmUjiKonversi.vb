Option Strict On

Public Class FrmUjiKonversi

    ' CInt langsung tanpa Try: jika input berupa huruf seperti "abc", program akan crash
    ' karena terjadi InvalidCastException. Ini sengaja tidak ditangani untuk demonstrasi.
    Private Sub btnCInt_Click(sender As Object, e As EventArgs) Handles btnCInt.Click
        Dim angka As Integer = CInt(txtInput.Text)
        lblHasil.Text = "CInt berhasil: " & angka.ToString()
    End Sub

    ' Fungsi Val membaca karakter angka dari awal teks saja.
    ' Fungsi ini tidak menimbulkan exception, tapi hasilnya bisa tidak terduga,
    ' misalnya "12abc" berubah jadi 12 dan input kosong menghasilkan 0.
    Private Sub btnVal_Click(sender As Object, e As EventArgs) Handles btnVal.Click
        Dim angka As Double = Val(txtInput.Text)
        lblHasil.Text = "Val menghasilkan: " & angka.ToString()
    End Sub

    ' Integer.TryParse mengembalikan True jika parsing berhasil dan False jika gagal.
    ' Cara ini aman karena tidak akan memunculkan exception jika input tidak valid.
    Private Sub btnTryParse_Click(sender As Object, e As EventArgs) Handles btnTryParse.Click
        Dim angka As Integer
        If Integer.TryParse(txtInput.Text, angka) Then
            lblHasil.Text = "Valid. Nilai angka = " & angka.ToString()
        Else
            lblHasil.Text = "Bukan bilangan bulat yang valid. Tidak ada exception."
        End If
    End Sub

    ' Integer.Parse dijalankan di dalam blok Try.
    ' Kesalahan ditangkap oleh Catch sehingga program tidak berhenti tiba-tiba.
    Private Sub btnTryCatch_Click(sender As Object, e As EventArgs) Handles btnTryCatch.Click
        Try
            Dim angka As Integer = Integer.Parse(txtInput.Text)
            lblHasil.Text = "Berhasil dikonversi: " & angka.ToString()
        Catch ex As Exception
            lblHasil.Text = "Konversi gagal, program tetap berjalan."
            MessageBox.Show("Input harus bilangan bulat, misalnya 25." & vbCrLf &
                            "Detail: " & ex.Message, "Input Tidak Valid",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    ' Menangani exception secara bertingkat dari yang paling spesifik
    ' sampai ke Catch Exception umum di posisi paling bawah.
    Private Sub btnCatchBertingkat_Click(sender As Object, e As EventArgs) Handles btnCatchBertingkat.Click
        Try
            Dim angka As Integer = Integer.Parse(txtInput.Text)
            Dim hasil As Integer = 1000 \ angka
            lblHasil.Text = "1000 \ " & angka.ToString() & " = " & hasil.ToString()
        Catch ex As FormatException
            lblHasil.Text = "Format salah: input bukan bilangan bulat."
        Catch ex As OverflowException
            lblHasil.Text = "Angka terlalu besar untuk tipe Integer."
        Catch ex As DivideByZeroException
            lblHasil.Text = "Pembagian dengan nol tidak diperbolehkan."
        Catch ex As Exception
            lblHasil.Text = "Error lain: " & ex.Message
        End Try
    End Sub

End Class

