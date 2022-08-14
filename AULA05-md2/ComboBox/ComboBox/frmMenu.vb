Public Class frmMenu
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmGridClientes.MdiParent = Me
        frmGridClientes.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        frmCombo.MdiParent = Me
        frmCombo.Show()
    End Sub
End Class