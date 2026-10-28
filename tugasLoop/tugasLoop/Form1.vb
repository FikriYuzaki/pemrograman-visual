Public Class Form1

    ' Event Handler ketika tombol For...Next diklik
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' Bersihkan list terlebih dahulu agar tampilan bersih
        lstOutput.Items.Clear()

        ' Perulangan For...Next untuk menampilkan angka 1 sampai 10
        For i As Integer = 1 To 10
            lstOutput.Items.Add("Angka ke-" & i)
        Next
    End Sub

    ' Event Handler ketika tombol Do While...Loop diklik
    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        ' Bersihkan list terlebih dahulu agar tampilan bersih
        lstOutput.Items.Clear()

        ' Inisialisasi variabel counter
        Dim counter As Integer = 1

        ' Perulangan Do While...Loop selama counter <= 5
        Do While counter <= 5
            lstOutput.Items.Add("Nilai angka: " & counter)
            ' Memperbarui nilai counter agar tidak terjadi infinite loop
            counter += 1
        Loop
    End Sub

    ' Event Handler ketika tombol Bersihkan diklik
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Menghapus seluruh item dari ListBox
        lstOutput.Items.Clear()
    End Sub

End Class

