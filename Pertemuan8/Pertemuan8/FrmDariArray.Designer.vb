<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariArray
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblJudul = New Label()
        dgvMahasiswa = New DataGridView()
        btnTampilkan = New Button()
        btnKosongkan = New Button()
        lblJumlah = New Label()
        colNim = New DataGridViewTextBoxColumn()
        colNama = New DataGridViewTextBoxColumn()
        colJurusan = New DataGridViewTextBoxColumn()
        colAngkatan = New DataGridViewTextBoxColumn()
        colIpk = New DataGridViewTextBoxColumn()
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.Location = New Point(20, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "Data dari Array 2 Dimensi"

        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Columns.AddRange(New DataGridViewColumn() {colNim, colNama, colJurusan, colAngkatan, colIpk})
        dgvMahasiswa.Location = New Point(20, 55)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(680, 270)

        colNim.HeaderText = "NIM"
        colNim.Name = "colNim"
        colNim.ReadOnly = True

        colNama.HeaderText = "Nama"
        colNama.Name = "colNama"
        colNama.ReadOnly = True

        colJurusan.HeaderText = "Jurusan"
        colJurusan.Name = "colJurusan"
        colJurusan.ReadOnly = True

        colAngkatan.HeaderText = "Angkatan"
        colAngkatan.Name = "colAngkatan"
        colAngkatan.ReadOnly = True

        colIpk.HeaderText = "IPK"
        colIpk.Name = "colIpk"
        colIpk.ReadOnly = True

        btnTampilkan.Font = New Font("Segoe UI", 10.0F)
        btnTampilkan.Location = New Point(20, 340)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(120, 35)
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = True

        btnKosongkan.Font = New Font("Segoe UI", 10.0F)
        btnKosongkan.Location = New Point(150, 340)
        btnKosongkan.Name = "btnKosongkan"
        btnKosongkan.Size = New Size(120, 35)
        btnKosongkan.Text = "Kosongkan"
        btnKosongkan.UseVisualStyleBackColor = True

        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 10.0F)
        lblJumlah.Location = New Point(520, 347)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Text = "Jumlah data: 0"

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 400)
        Controls.Add(lblJudul)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTampilkan)
        Controls.Add(btnKosongkan)
        Controls.Add(lblJumlah)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariArray"
        StartPosition = FormStartPosition.CenterScreen
        Text = "DataGridView dari Array"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnKosongkan As Button
    Friend WithEvents lblJumlah As Label
    Friend WithEvents colNim As DataGridViewTextBoxColumn
    Friend WithEvents colNama As DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As DataGridViewTextBoxColumn
    Friend WithEvents colIpk As DataGridViewTextBoxColumn
End Class

