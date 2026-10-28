<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
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
        btnDariArray = New Button()
        btnDariList = New Button()
        btnDataTable = New Button()
        btnCariList = New Button()
        SuspendLayout()

        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblJudul.Location = New Point(100, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(240, 32)
        lblJudul.Text = "Contoh Pertemuan 8"

        btnDariArray.Font = New Font("Segoe UI", 10.0F)
        btnDariArray.Location = New Point(60, 75)
        btnDariArray.Name = "btnDariArray"
        btnDariArray.Size = New Size(320, 40)
        btnDariArray.Text = "1. DataGridView dari Array"
        btnDariArray.UseVisualStyleBackColor = True

        btnDariList.Font = New Font("Segoe UI", 10.0F)
        btnDariList.Location = New Point(60, 125)
        btnDariList.Name = "btnDariList"
        btnDariList.Size = New Size(320, 40)
        btnDariList.Text = "2. Binding List(Of Mahasiswa)"
        btnDariList.UseVisualStyleBackColor = True

        btnDataTable.Font = New Font("Segoe UI", 10.0F)
        btnDataTable.Location = New Point(60, 175)
        btnDataTable.Name = "btnDataTable"
        btnDataTable.Size = New Size(320, 40)
        btnDataTable.Text = "3. DataTable, Rapikan Kolom dan Filter"
        btnDataTable.UseVisualStyleBackColor = True

        btnCariList.Font = New Font("Segoe UI", 10.0F)
        btnCariList.Location = New Point(60, 225)
        btnCariList.Name = "btnCariList"
        btnCariList.Size = New Size(320, 40)
        btnCariList.Text = "4. Pencarian dengan Perulangan"
        btnCariList.UseVisualStyleBackColor = True

        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(440, 300)
        Controls.Add(lblJudul)
        Controls.Add(btnDariArray)
        Controls.Add(btnDariList)
        Controls.Add(btnDataTable)
        Controls.Add(btnCariList)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "FrmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents btnDariArray As Button
    Friend WithEvents btnDariList As Button
    Friend WithEvents btnDataTable As Button
    Friend WithEvents btnCariList As Button
End Class

