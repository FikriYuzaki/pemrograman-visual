<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblJudul = New Label()
        lblHargaInfo = New Label()
        grpInput = New GroupBox()
        chkMember = New CheckBox()
        txtJumlahTiket = New TextBox()
        lblJumlahTiket = New Label()
        btnHitung = New Button()
        btnReset = New Button()
        btnKeluar = New Button()
        grpOutput = New GroupBox()
        txtTotalBayar = New TextBox()
        lblTotalBayar = New Label()
        txtNilaiDiskon = New TextBox()
        lblNilaiDiskon = New Label()
        txtPersenDiskon = New TextBox()
        lblPersenDiskon = New Label()
        txtSubtotal = New TextBox()
        lblSubtotal = New Label()
        grpInput.SuspendLayout()
        grpOutput.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblJudul.Location = New Point(20, 15)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(480, 28)
        lblJudul.TabIndex = 0
        lblJudul.Text = "APLIKASI PEMESANAN TIKET BIOSKOP"
        lblJudul.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHargaInfo
        ' 
        lblHargaInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, 0)
        lblHargaInfo.ForeColor = Color.DimGray
        lblHargaInfo.Location = New Point(20, 45)
        lblHargaInfo.Name = "lblHargaInfo"
        lblHargaInfo.Size = New Size(480, 20)
        lblHargaInfo.TabIndex = 1
        lblHargaInfo.Text = "Harga Tiket: Rp 50.000 / tiket"
        lblHargaInfo.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grpInput
        ' 
        grpInput.Controls.Add(chkMember)
        grpInput.Controls.Add(txtJumlahTiket)
        grpInput.Controls.Add(lblJumlahTiket)
        grpInput.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        grpInput.Location = New Point(25, 75)
        grpInput.Name = "grpInput"
        grpInput.Size = New Size(470, 105)
        grpInput.TabIndex = 2
        grpInput.TabStop = False
        grpInput.Text = "Data Pemesanan"
        ' 
        ' chkMember
        ' 
        chkMember.AutoSize = True
        chkMember.Location = New Point(140, 64)
        chkMember.Name = "chkMember"
        chkMember.Size = New Size(160, 19)
        chkMember.TabIndex = 2
        chkMember.Text = "Pelanggan adalah Member"
        chkMember.UseVisualStyleBackColor = True
        ' 
        ' txtJumlahTiket
        ' 
        txtJumlahTiket.Location = New Point(140, 28)
        txtJumlahTiket.Name = "txtJumlahTiket"
        txtJumlahTiket.Size = New Size(130, 23)
        txtJumlahTiket.TabIndex = 1
        ' 
        ' lblJumlahTiket
        ' 
        lblJumlahTiket.AutoSize = True
        lblJumlahTiket.Location = New Point(20, 31)
        lblJumlahTiket.Name = "lblJumlahTiket"
        lblJumlahTiket.Size = New Size(77, 15)
        lblJumlahTiket.TabIndex = 0
        lblJumlahTiket.Text = "Jumlah Tiket:"
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        btnHitung.Location = New Point(75, 195)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(110, 35)
        btnHitung.TabIndex = 3
        btnHitung.Text = "Hitung Total"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(205, 195)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(110, 35)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset Form"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(335, 195)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(110, 35)
        btnKeluar.TabIndex = 5
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' grpOutput
        ' 
        grpOutput.Controls.Add(txtTotalBayar)
        grpOutput.Controls.Add(lblTotalBayar)
        grpOutput.Controls.Add(txtNilaiDiskon)
        grpOutput.Controls.Add(lblNilaiDiskon)
        grpOutput.Controls.Add(txtPersenDiskon)
        grpOutput.Controls.Add(lblPersenDiskon)
        grpOutput.Controls.Add(txtSubtotal)
        grpOutput.Controls.Add(lblSubtotal)
        grpOutput.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, 0)
        grpOutput.Location = New Point(25, 245)
        grpOutput.Name = "grpOutput"
        grpOutput.Size = New Size(470, 190)
        grpOutput.TabIndex = 6
        grpOutput.TabStop = False
        grpOutput.Text = "Rincian Pembayaran"
        ' 
        ' txtTotalBayar
        ' 
        txtTotalBayar.BackColor = SystemColors.Window
        txtTotalBayar.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0)
        txtTotalBayar.Location = New Point(170, 142)
        txtTotalBayar.Name = "txtTotalBayar"
        txtTotalBayar.ReadOnly = True
        txtTotalBayar.Size = New Size(260, 25)
        txtTotalBayar.TabIndex = 7
        ' 
        ' lblTotalBayar
        ' 
        lblTotalBayar.AutoSize = True
        lblTotalBayar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, 0)
        lblTotalBayar.Location = New Point(20, 147)
        lblTotalBayar.Name = "lblTotalBayar"
        lblTotalBayar.Size = New Size(101, 15)
        lblTotalBayar.TabIndex = 6
        lblTotalBayar.Text = "Total Bayar (Rp):"
        ' 
        ' txtNilaiDiskon
        ' 
        txtNilaiDiskon.BackColor = SystemColors.Window
        txtNilaiDiskon.Location = New Point(170, 104)
        txtNilaiDiskon.Name = "txtNilaiDiskon"
        txtNilaiDiskon.ReadOnly = True
        txtNilaiDiskon.Size = New Size(260, 23)
        txtNilaiDiskon.TabIndex = 5
        ' 
        ' lblNilaiDiskon
        ' 
        lblNilaiDiskon.AutoSize = True
        lblNilaiDiskon.Location = New Point(20, 107)
        lblNilaiDiskon.Name = "lblNilaiDiskon"
        lblNilaiDiskon.Size = New Size(100, 15)
        lblNilaiDiskon.TabIndex = 4
        lblNilaiDiskon.Text = "Nilai Diskon (Rp):"
        ' 
        ' txtPersenDiskon
        ' 
        txtPersenDiskon.BackColor = SystemColors.Window
        txtPersenDiskon.Location = New Point(170, 66)
        txtPersenDiskon.Name = "txtPersenDiskon"
        txtPersenDiskon.ReadOnly = True
        txtPersenDiskon.Size = New Size(260, 23)
        txtPersenDiskon.TabIndex = 3
        ' 
        ' lblPersenDiskon
        ' 
        lblPersenDiskon.AutoSize = True
        lblPersenDiskon.Location = New Point(20, 69)
        lblPersenDiskon.Name = "lblPersenDiskon"
        lblPersenDiskon.Size = New Size(106, 15)
        lblPersenDiskon.TabIndex = 2
        lblPersenDiskon.Text = "Persentase Diskon:"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.BackColor = SystemColors.Window
        txtSubtotal.Location = New Point(170, 28)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.ReadOnly = True
        txtSubtotal.Size = New Size(260, 23)
        txtSubtotal.TabIndex = 1
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(20, 31)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(81, 15)
        lblSubtotal.TabIndex = 0
        lblSubtotal.Text = "Subtotal (Rp):"
        ' 
        ' Form1
        ' 
        AcceptButton = btnHitung
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnKeluar
        ClientSize = New Size(520, 460)
        Controls.Add(grpOutput)
        Controls.Add(btnKeluar)
        Controls.Add(btnReset)
        Controls.Add(btnHitung)
        Controls.Add(grpInput)
        Controls.Add(lblHargaInfo)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pemesanan Tiket Bioskop"
        grpInput.ResumeLayout(False)
        grpInput.PerformLayout()
        grpOutput.ResumeLayout(False)
        grpOutput.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblHargaInfo As Label
    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblJumlahTiket As Label
    Friend WithEvents txtJumlahTiket As TextBox
    Friend WithEvents chkMember As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents grpOutput As GroupBox
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents lblPersenDiskon As Label
    Friend WithEvents txtPersenDiskon As TextBox
    Friend WithEvents lblNilaiDiskon As Label
    Friend WithEvents txtNilaiDiskon As TextBox
    Friend WithEvents lblTotalBayar As Label
    Friend WithEvents txtTotalBayar As TextBox
End Class

