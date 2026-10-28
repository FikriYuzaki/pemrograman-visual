Option Strict On

Public Class FrmDataTable
    Private dtMahasiswa As DataTable
    Private jumlahTotal As Integer

    Private Sub FrmDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtMahasiswa = New DataTable("Mahasiswa")
        dtMahasiswa.Columns.Add("Nim", GetType(String))
        dtMahasiswa.Columns.Add("Nama", GetType(String))
        dtMahasiswa.Columns.Add("Jurusan", GetType(String))
        dtMahasiswa.Columns.Add("Angkatan", GetType(Integer))
        dtMahasiswa.Columns.Add("Ipk", GetType(Decimal))

        dtMahasiswa.Rows.Add("231712001", "Andi Pratama", "Teknik Informatika", 2023, 3.45D)
        dtMahasiswa.Rows.Add("231712002", "Sari Wulandari", "Sistem Informasi", 2023, 3.8D)
        dtMahasiswa.Rows.Add("221712015", "Budi Santoso", "Teknik Informatika", 2022, 3.12D)
        dtMahasiswa.Rows.Add("241712007", "Dimas Siregar", "Teknik Komputer", 2024, 2.95D)
        dtMahasiswa.Rows.Add("221712020", "Rina Marpaung", "Manajemen Informatika", 2022, 3.5D)
        dtMahasiswa.Rows.Add("241712011", "Putri Lubis", "Sistem Informasi", 2024, 3.91D)
        dtMahasiswa.Rows.Add("231712019", "Fajar Nasution", "Teknik Informatika", 2023, 3.28D)
        dtMahasiswa.Rows.Add("221712031", "Maya Sari Hasibuan", "Teknik Komputer", 2022, 3.55D)

        jumlahTotal = dtMahasiswa.Rows.Count
        bsMahasiswa.DataSource = dtMahasiswa
        dgvMahasiswa.DataSource = bsMahasiswa
        PerbaruiJumlah()
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        Dim kata As String = txtCari.Text.Trim()
        If kata.Length = 0 Then
            bsMahasiswa.RemoveFilter()
        Else
            Dim aman As String = AmankanTeksFilter(kata)
            bsMahasiswa.Filter = "Nama LIKE '%" & aman & "%' OR Nim LIKE '%" & aman & "%'"
        End If
        PerbaruiJumlah()
    End Sub

    Private Sub btnRapikan_Click(sender As Object, e As EventArgs) Handles btnRapikan.Click
        If dgvMahasiswa.Columns.Contains("Nim") Then
            dgvMahasiswa.Columns("Nim").HeaderText = "NIM"
        End If
        If dgvMahasiswa.Columns.Contains("Ipk") Then
            dgvMahasiswa.Columns("Ipk").HeaderText = "IPK"
            dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Format = "N2"
            dgvMahasiswa.Columns("Ipk").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If dgvMahasiswa.Columns.Contains("Angkatan") Then
            dgvMahasiswa.Columns("Angkatan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
        If dgvMahasiswa.Columns.Contains("Nama") Then
            dgvMahasiswa.Columns("Nama").FillWeight = 150
        End If
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub PerbaruiJumlah()
        lblJumlah.Text = "Jumlah data: " & bsMahasiswa.Count.ToString() & " dari " & jumlahTotal.ToString()
    End Sub
End Class

