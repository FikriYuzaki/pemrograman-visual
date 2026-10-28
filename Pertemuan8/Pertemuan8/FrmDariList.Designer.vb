<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariList
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
        components = New System.ComponentModel.Container()
        lblJudul = New Label()
        lblNim = New Label()
        txtNim = New TextBox()
        lblNama = New Label()
        txtNama = New TextBox()
        lblJurusan = New Label()
        cboJurusan = New ComboBox()
        lblAngkatan = New Label()
        txtAngkatan = New TextBox()
        lblIpk = New Label()
        txtIpk = New TextBox()
        btnTambah = New Button()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        errInput = New ErrorProvider(components)
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(errInput, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.Location = New Point(20, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "Binding List(Of Mahasiswa)"

        lblNim.AutoSize = True
        lblNim.Font = New Font("Segoe UI", 10.0F)
        lblNim.Location = New Point(20, 60)
        lblNim.Name = "lblNim"
        lblNim.Text = "NIM:"

        txtNim.Font = New Font("Segoe UI", 10.0F)
        txtNim.Location = New Point(110, 57)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(150, 30)

        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 10.0F)
        lblNama.Location = New Point(20, 95)
        lblNama.Name = "lblNama"
        lblNama.Text = "Nama:"

        txtNama.Font = New Font("Segoe UI", 10.0F)
        txtNama.Location = New Point(110, 92)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 30)

        lblJurusan.AutoSize = True
        lblJurusan.Font = New Font("Segoe UI", 10.0F)
        lblJurusan.Location = New Point(20, 130)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Text = "Jurusan:"

        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.Font = New Font("Segoe UI", 10.0F)
        cboJurusan.FormattingEnabled = True
        cboJurusan.Location = New Point(110, 127)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(250, 31)

        lblAngkatan.AutoSize = True
        lblAngkatan.Font = New Font("Segoe UI", 10.0F)
        lblAngkatan.Location = New Point(400, 60)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Text = "Angkatan:"

        txtAngkatan.Font = New Font("Segoe UI", 10.0F)
        txtAngkatan.Location = New Point(500, 57)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(100, 30)

        lblIpk.AutoSize = True
        lblIpk.Font = New Font("Segoe UI", 10.0F)
        lblIpk.Location = New Point(400, 95)
        lblIpk.Name = "lblIpk"
        lblIpk.Text = "IPK:"

        txtIpk.Font = New Font("Segoe UI", 10.0F)
        txtIpk.Location = New Point(500, 92)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(100, 30)

        btnTambah.Font = New Font("Segoe UI", 10.0F)
        btnTambah.Location = New Point(400, 127)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(200, 35)
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True

        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(20, 175)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(720, 240)

        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 10.0F)
        lblJumlah.Location = New Point(20, 425)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Text = "Jumlah data: 0"

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        AcceptButton = btnTambah
        ClientSize = New Size(760, 470)
        Controls.Add(lblJudul)
        Controls.Add(lblNim)
        Controls.Add(txtNim)
        Controls.Add(lblNama)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(cboJurusan)
        Controls.Add(lblAngkatan)
        Controls.Add(txtAngkatan)
        Controls.Add(lblIpk)
        Controls.Add(txtIpk)
        Controls.Add(btnTambah)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJumlah)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmDariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Binding List(Of Mahasiswa)"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(errInput, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblJurusan As Label
    Friend WithEvents cboJurusan As ComboBox
    Friend WithEvents lblAngkatan As Label
    Friend WithEvents txtAngkatan As TextBox
    Friend WithEvents lblIpk As Label
    Friend WithEvents txtIpk As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
    Friend WithEvents errInput As ErrorProvider
End Class

