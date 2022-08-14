Public Class frmMenuInicial
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        frmGridClientes.ShowDialog()
    End Sub

    Private Sub btnVendedores_Click(sender As Object, e As EventArgs) Handles btnVendedores.Click
        frmGridVendedores.ShowDialog()
    End Sub

    Private Sub btnProdutos_Click(sender As Object, e As EventArgs) Handles btnProdutos.Click
        frmProdutos.ShowDialog()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub frmMenuInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class