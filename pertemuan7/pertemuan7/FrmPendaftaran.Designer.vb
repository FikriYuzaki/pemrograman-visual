<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPendaftaran
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
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
        btnSimpan = New Button()
        btnBersihkan = New Button()
        lblDaftar = New Label()
        lstMahasiswa = New ListBox()
        btnEkspor = New Button()
        lblStatus = New Label()
        errInput = New ErrorProvider(components)
        CType(errInput, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.Location = New Point(25, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(281, 32)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Pendaftaran Mahasiswa"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Font = New Font("Segoe UI", 9.5F)
        lblNim.Location = New Point(25, 55)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(40, 21)
        lblNim.TabIndex = 1
        lblNim.Text = "NIM"
        ' 
        ' txtNim
        ' 
        txtNim.Font = New Font("Segoe UI", 9.5F)
        txtNim.Location = New Point(25, 75)
        txtNim.MaxLength = 9
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(280, 29)
        txtNim.TabIndex = 2
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.5F)
        lblNama.Location = New Point(25, 110)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(52, 21)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Font = New Font("Segoe UI", 9.5F)
        txtNama.Location = New Point(25, 130)
        txtNama.MaxLength = 100
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(280, 29)
        txtNama.TabIndex = 4
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Font = New Font("Segoe UI", 9.5F)
        lblJurusan.Location = New Point(25, 165)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(64, 21)
        lblJurusan.TabIndex = 5
        lblJurusan.Text = "Jurusan"
        ' 
        ' cboJurusan
        ' 
        cboJurusan.DropDownStyle = ComboBoxStyle.DropDownList
        cboJurusan.Font = New Font("Segoe UI", 9.5F)
        cboJurusan.FormattingEnabled = True
        cboJurusan.Items.AddRange(New Object() {"Teknik Informatika", "Sistem Informasi", "Manajemen Informatika", "Teknik Komputer"})
        cboJurusan.Location = New Point(25, 185)
        cboJurusan.Name = "cboJurusan"
        cboJurusan.Size = New Size(280, 29)
        cboJurusan.TabIndex = 6
        ' 
        ' lblAngkatan
        ' 
        lblAngkatan.AutoSize = True
        lblAngkatan.Font = New Font("Segoe UI", 9.5F)
        lblAngkatan.Location = New Point(25, 220)
        lblAngkatan.Name = "lblAngkatan"
        lblAngkatan.Size = New Size(76, 21)
        lblAngkatan.TabIndex = 7
        lblAngkatan.Text = "Angkatan"
        ' 
        ' txtAngkatan
        ' 
        txtAngkatan.Font = New Font("Segoe UI", 9.5F)
        txtAngkatan.Location = New Point(25, 240)
        txtAngkatan.MaxLength = 4
        txtAngkatan.Name = "txtAngkatan"
        txtAngkatan.Size = New Size(280, 29)
        txtAngkatan.TabIndex = 8
        ' 
        ' lblIpk
        ' 
        lblIpk.AutoSize = True
        lblIpk.Font = New Font("Segoe UI", 9.5F)
        lblIpk.Location = New Point(25, 275)
        lblIpk.Name = "lblIpk"
        lblIpk.Size = New Size(33, 21)
        lblIpk.TabIndex = 9
        lblIpk.Text = "IPK"
        ' 
        ' txtIpk
        ' 
        txtIpk.Font = New Font("Segoe UI", 9.5F)
        txtIpk.Location = New Point(25, 295)
        txtIpk.MaxLength = 4
        txtIpk.Name = "txtIpk"
        txtIpk.Size = New Size(280, 29)
        txtIpk.TabIndex = 10
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Font = New Font("Segoe UI", 9.5F)
        btnSimpan.Location = New Point(25, 340)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(135, 36)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.CausesValidation = False
        btnBersihkan.Font = New Font("Segoe UI", 9.5F)
        btnBersihkan.Location = New Point(170, 340)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(135, 36)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = True
        ' 
        ' lblDaftar
        ' 
        lblDaftar.AutoSize = True
        lblDaftar.Font = New Font("Segoe UI", 9.5F)
        lblDaftar.Location = New Point(345, 55)
        lblDaftar.Name = "lblDaftar"
        lblDaftar.Size = New Size(116, 21)
        lblDaftar.TabIndex = 13
        lblDaftar.Text = "Data tersimpan"
        ' 
        ' lstMahasiswa
        ' 
        lstMahasiswa.Font = New Font("Segoe UI", 9.5F)
        lstMahasiswa.FormattingEnabled = True
        lstMahasiswa.HorizontalScrollbar = True
        lstMahasiswa.IntegralHeight = False
        lstMahasiswa.ItemHeight = 21
        lstMahasiswa.Location = New Point(345, 75)
        lstMahasiswa.Name = "lstMahasiswa"
        lstMahasiswa.Size = New Size(410, 249)
        lstMahasiswa.TabIndex = 14
        ' 
        ' btnEkspor
        ' 
        btnEkspor.CausesValidation = False
        btnEkspor.Font = New Font("Segoe UI", 9.5F)
        btnEkspor.Location = New Point(345, 340)
        btnEkspor.Name = "btnEkspor"
        btnEkspor.Size = New Size(410, 36)
        btnEkspor.TabIndex = 15
        btnEkspor.Text = "Ekspor ke CSV"
        btnEkspor.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.BorderStyle = BorderStyle.Fixed3D
        lblStatus.Font = New Font("Segoe UI", 9.5F)
        lblStatus.Location = New Point(0, 435)
        lblStatus.Name = "lblStatus"
        lblStatus.Padding = New Padding(10, 0, 0, 0)
        lblStatus.Size = New Size(780, 35)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Siap."
        lblStatus.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' errInput
        ' 
        errInput.ContainerControl = Me
        ' 
        ' FrmPendaftaran
        ' 
        AcceptButton = btnSimpan
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(780, 470)
        Controls.Add(lblStatus)
        Controls.Add(btnEkspor)
        Controls.Add(lstMahasiswa)
        Controls.Add(lblDaftar)
        Controls.Add(btnBersihkan)
        Controls.Add(btnSimpan)
        Controls.Add(txtIpk)
        Controls.Add(lblIpk)
        Controls.Add(txtAngkatan)
        Controls.Add(lblAngkatan)
        Controls.Add(cboJurusan)
        Controls.Add(lblJurusan)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(txtNim)
        Controls.Add(lblNim)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmPendaftaran"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pendaftaran Mahasiswa"
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
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents lblDaftar As Label
    Friend WithEvents lstMahasiswa As ListBox
    Friend WithEvents btnEkspor As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents errInput As ErrorProvider

End Class

