Public Class frmMain
    Private Sub LậpThẻMớiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpThẻMớiToolStripMenuItem.Click
        Dim frm As frmLapThe = New frmLapThe()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
