<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        btnTampil = New Button()
        txtPanjang = New TextBox()
        txtLebar = New TextBox()
        lblPanjang = New Label()
        lblLebar = New Label()
        lsbArray = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(364, 236)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(94, 29)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(350, 88)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(125, 27)
        txtPanjang.TabIndex = 1
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(350, 180)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(125, 27)
        txtLebar.TabIndex = 2
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(379, 55)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(68, 20)
        lblPanjang.TabIndex = 3
        lblPanjang.Text = "Panjang :"
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(379, 157)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(53, 20)
        lblLebar.TabIndex = 4
        lblLebar.Text = "Lebar :"
        ' 
        ' lsbArray
        ' 
        lsbArray.FormattingEnabled = True
        lsbArray.Location = New Point(337, 302)
        lsbArray.Name = "lsbArray"
        lsbArray.Size = New Size(150, 124)
        lsbArray.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lsbArray)
        Controls.Add(lblLebar)
        Controls.Add(lblPanjang)
        Controls.Add(txtLebar)
        Controls.Add(txtPanjang)
        Controls.Add(btnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents lblPanjang As Label
    Friend WithEvents lblLebar As Label
    Friend WithEvents lsbArray As ListBox

End Class
