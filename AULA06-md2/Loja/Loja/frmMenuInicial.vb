Public Class frmMenuInicial

    Private Sub frmMenuInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.ShowDialog()
        If frmLogin.DialogResult = Windows.Forms.DialogResult.OK Then
            tsslStatus.Text = DadosUsuario.usuario & " - " & DadosUsuario.grupo
        Else
            End
        End If

        If DadosUsuario.grupo <> "Administrador" Then
            UsuáriosToolStripMenuItem.Enabled = False
        End If
		
        If DadosUsuario.grupo = "Gerente" Then
            VendasToolStripMenuItem.Enabled = False
        End If
		
		 If DadosUsuario.grupo = "Funcionário" Then
			
            ClientesToolStripMenuItem.Enabled = False
			VendedoresToolStripMenuItem.Enabled = False
			ProdutosToolStripMenuItem.Enabled = False
			UsuáriosToolStripMenuItem.Enabled = False
        End If
		
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        frmGridClientes.MdiParent = Me
        frmGridClientes.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        frmGridVendedores.MdiParent = Me
        frmGridVendedores.Show()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        frmProdutos.MdiParent = Me
        frmProdutos.Show()
    End Sub

    Private Sub VendasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendasToolStripMenuItem.Click
        frmVendas.MdiParent = Me
        frmVendas.Show()
    End Sub

    Private Sub UsuáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuáriosToolStripMenuItem.Click
        frmUsuarios.MdiParent = Me
        frmUsuarios.Show()
    End Sub

End Class