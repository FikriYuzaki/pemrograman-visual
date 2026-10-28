<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCariList
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
        lblCari = New Label()
        txtCari = New TextBox()
        dgvMahasiswa = New DataGridView()
        lblJumlah = New Label()
        bsMahasiswa = New BindingSource(components)
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()

        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.Location = New Point(20, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Text = "Mencari di List(Of Mahasiswa)"

        lblCari.AutoSize = True
        lblCari.Font = New Font("Segoe UI", 10.0F)
        lblCari.Location = New Point(20, 60)
        lblCari.Name = "lblCari"
        lblCari.Text = "Cari nama/NIM:"

        txtCari.Font = New Font("Segoe UI", 10.0F)
        txtCari.Location = New Point(160, 57)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(300, 30)

        dgvMahasiswa.AllowUserToAddRows = False
        dgvMahasiswa.AllowUserToDeleteRows = False
        dgvMahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(20, 100)
        dgvMahasiswa.MultiSelect = False
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.ReadOnly = True
        dgvMahasiswa.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMahasiswa.Size = New Size(680, 280)

        lblJumlah.AutoSize = True
        lblJumlah.Font = New Font("Segoe UI", 10.0F)
        lblJumlah.Location = New Point(20, 390)
        lblJumlah.Name = "lblJumlah"
        lblJumlah.Text = "Jumlah data: 0"

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 430)
        Controls.Add(lblJudul)
        Controls.Add(lblCari)
        Controls.Add(txtCari)
        Controls.Add(dgvMahasiswa)
        Controls.Add(lblJumlah)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmCariList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pencarian dengan Perulangan"
        CType(dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(bsMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblCari As Label
    Friend WithEvents txtCari As TextBox
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblJumlah As Label
    Friend WithEvents bsMahasiswa As BindingSource
End Class

