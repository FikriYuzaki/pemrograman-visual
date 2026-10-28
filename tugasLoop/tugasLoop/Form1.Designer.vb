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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnForNext = New System.Windows.Forms.Button()
        Me.btnDoWhile = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(20, 15)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(400, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "DEMONSTRASI PERULANGAN VB.NET"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnForNext
        '
        Me.btnForNext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnForNext.Location = New System.Drawing.Point(50, 60)
        Me.btnForNext.Name = "btnForNext"
        Me.btnForNext.Size = New System.Drawing.Size(150, 35)
        Me.btnForNext.TabIndex = 1
        Me.btnForNext.Text = "For...Next"
        Me.btnForNext.UseVisualStyleBackColor = True
        '
        'btnDoWhile
        '
        Me.btnDoWhile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnDoWhile.Location = New System.Drawing.Point(240, 60)
        Me.btnDoWhile.Name = "btnDoWhile"
        Me.btnDoWhile.Size = New System.Drawing.Size(150, 35)
        Me.btnDoWhile.TabIndex = 2
        Me.btnDoWhile.Text = "Do While...Loop"
        Me.btnDoWhile.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblOutput.Location = New System.Drawing.Point(50, 110)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(100, 15)
        Me.lblOutput.TabIndex = 3
        Me.lblOutput.Text = "Hasil Perulangan:"
        '
        'lstOutput
        '
        Me.lstOutput.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 17
        Me.lstOutput.Location = New System.Drawing.Point(50, 130)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(340, 191)
        Me.lstOutput.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(160, 335)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 35)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Bersihkan"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 390)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnDoWhile)
        Me.Controls.Add(Me.btnForNext)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Demonstrasi Perulangan VB.NET"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnForNext As System.Windows.Forms.Button
    Friend WithEvents btnDoWhile As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class

