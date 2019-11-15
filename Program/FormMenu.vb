Public Class FormMenu

    Private Sub KELUARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KELUARToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FormMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DATAOBATToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAOBATToolStripMenuItem.Click
        FormDataObat.Show()
        Me.Hide()
    End Sub

    Private Sub PENJUALANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENJUALANToolStripMenuItem.Click
        FormPenjualan.Show()
        Me.Hide()
    End Sub
End Class