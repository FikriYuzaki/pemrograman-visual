<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUjiKonversi
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
        lblPetunjuk = New Label()
        lblInput = New Label()
        txtInput = New TextBox()
        btnCInt = New Button()
        btnVal = New Button()
        btnTryParse = New Button()
        btnTryCatch = New Button()
        btnCatchBertingkat = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblJudul.Location = New Point(25, 18)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(230, 32)
        lblJudul.TabIndex = 0
        lblJudul.Text = "Uji Konversi Input"
        ' 
        ' lblPetunjuk
        ' 
        lblPetunjuk.Font = New Font("Segoe UI", 9F)
        lblPetunjuk.Location = New Point(25, 54)
        lblPetunjuk.Name = "lblPetunjuk"
        lblPetunjuk.Size = New Size(590, 35)
        lblPetunjuk.TabIndex = 1
        lblPetunjuk.Text = "Ketik sebuah nilai lalu coba setiap tombol. Coba: 25, abc, 12abc, 3,5, 99999999999, atau kosong."
        ' 
        ' lblInput
        ' 
        lblInput.AutoSize = True
        lblInput.Font = New Font("Segoe UI", 9.5F)
        lblInput.Location = New Point(25, 96)
        lblInput.Name = "lblInput"
        lblInput.Size = New Size(49, 21)
        lblInput.TabIndex = 2
        lblInput.Text = "Input:"
        ' 
        ' txtInput
        ' 
        txtInput.Font = New Font("Segoe UI", 9.5F)
        txtInput.Location = New Point(80, 93)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(220, 29)
        txtInput.TabIndex = 3
        ' 
        ' btnCInt
        ' 
        btnCInt.Font = New Font("Segoe UI", 9F)
        btnCInt.Location = New Point(25, 135)
        btnCInt.Name = "btnCInt"
        btnCInt.Size = New Size(185, 36)
        btnCInt.TabIndex = 4
        btnCInt.Text = "CInt (tanpa Try)"
        btnCInt.UseVisualStyleBackColor = True
        ' 
        ' btnVal
        ' 
        btnVal.Font = New Font("Segoe UI", 9F)
        btnVal.Location = New Point(228, 135)
        btnVal.Name = "btnVal"
        btnVal.Size = New Size(185, 36)
        btnVal.TabIndex = 5
        btnVal.Text = "Val"
        btnVal.UseVisualStyleBackColor = True
        ' 
        ' btnTryParse
        ' 
        btnTryParse.Font = New Font("Segoe UI", 9F)
        btnTryParse.Location = New Point(430, 135)
        btnTryParse.Name = "btnTryParse"
        btnTryParse.Size = New Size(185, 36)
        btnTryParse.TabIndex = 6
        btnTryParse.Text = "TryParse"
        btnTryParse.UseVisualStyleBackColor = True
        ' 
        ' btnTryCatch
        ' 
        btnTryCatch.Font = New Font("Segoe UI", 9F)
        btnTryCatch.Location = New Point(25, 182)
        btnTryCatch.Name = "btnTryCatch"
        btnTryCatch.Size = New Size(185, 36)
        btnTryCatch.TabIndex = 7
        btnTryCatch.Text = "Try...Catch"
        btnTryCatch.UseVisualStyleBackColor = True
        ' 
        ' btnCatchBertingkat
        ' 
        btnCatchBertingkat.Font = New Font("Segoe UI", 9F)
        btnCatchBertingkat.Location = New Point(228, 182)
        btnCatchBertingkat.Name = "btnCatchBertingkat"
        btnCatchBertingkat.Size = New Size(185, 36)
        btnCatchBertingkat.TabIndex = 8
        btnCatchBertingkat.Text = "Catch Bertingkat"
        btnCatchBertingkat.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.BorderStyle = BorderStyle.FixedSingle
        lblHasil.Font = New Font("Segoe UI", 9.5F)
        lblHasil.Location = New Point(25, 235)
        lblHasil.Name = "lblHasil"
        lblHasil.Padding = New Padding(8)
        lblHasil.Size = New Size(590, 80)
        lblHasil.TabIndex = 9
        lblHasil.Text = "Hasil akan tampil di sini."
        ' 
        ' FrmUjiKonversi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 340)
        Controls.Add(lblHasil)
        Controls.Add(btnCatchBertingkat)
        Controls.Add(btnTryCatch)
        Controls.Add(btnTryParse)
        Controls.Add(btnVal)
        Controls.Add(btnCInt)
        Controls.Add(txtInput)
        Controls.Add(lblInput)
        Controls.Add(lblPetunjuk)
        Controls.Add(lblJudul)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUjiKonversi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Uji Konversi Input"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents lblPetunjuk As Label
    Friend WithEvents lblInput As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCInt As Button
    Friend WithEvents btnVal As Button
    Friend WithEvents btnTryParse As Button
    Friend WithEvents btnTryCatch As Button
    Friend WithEvents btnCatchBertingkat As Button
    Friend WithEvents lblHasil As Label

End Class

