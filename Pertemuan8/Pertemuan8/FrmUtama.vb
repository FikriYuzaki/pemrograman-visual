Option Strict On

Public Class FrmUtama
    Private Sub btnDariArray_Click(sender As Object, e As EventArgs) Handles btnDariArray.Click
        Using frm As New FrmDariArray()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnDariList_Click(sender As Object, e As EventArgs) Handles btnDariList.Click
        Using frm As New FrmDariList()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnDataTable_Click(sender As Object, e As EventArgs) Handles btnDataTable.Click
        Using frm As New FrmDataTable()
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub btnCariList_Click(sender As Object, e As EventArgs) Handles btnCariList.Click
        Using frm As New FrmCariList()
            frm.ShowDialog()
        End Using
    End Sub
End Class

