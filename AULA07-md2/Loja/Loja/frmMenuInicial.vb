Imports System.Data.SqlClient
Public Class frmMenuInicial
    Private con As SqlConnection = Biblioteca.Conexao()
    Public dtbGrupo As New DataTable()
    Public valores

    Private Sub frmMenuInicial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        frmLogin.ShowDialog()
        If frmLogin.DialogResult = Windows.Forms.DialogResult.OK Then
            tsslStatus.Text = DadosUsuario.usuario & " - " & DadosUsuario.grupo
        Else
            End
        End If

        con.Open()
        Dim adp2 As New SqlDataAdapter("Select * from grupoUsuarios WHERE codigo = @codGrupo", con)
        adp2.SelectCommand.Parameters.Add("@codGrupo", SqlDbType.Int).Value = DadosUsuario.codigoGrupo
        dtbGrupo.Clear()
        adp2.Fill(dtbGrupo)
        con.Close()

        Dim codigoGrupo As String = dtbGrupo.Rows(0)("codigo").ToString()
        Dim clienteConsulta As String = dtbGrupo.Rows(0)("clienteConsulta").ToString()
        Dim clienteInsere As String = dtbGrupo.Rows(0)("clienteInsere").ToString()
        Dim clienteAltera As String = dtbGrupo.Rows(0)("clienteAltera").ToString()
        Dim clienteExclui As String = dtbGrupo.Rows(0)("clienteExclui").ToString()
        Dim produtoConsulta As String = dtbGrupo.Rows(0)("produtoConsulta").ToString()
        Dim produtoInsere As String = dtbGrupo.Rows(0)("produtoInsere").ToString()
        Dim produtoAltera As String = dtbGrupo.Rows(0)("produtoAltera").ToString()
        Dim produtoExclui As String = dtbGrupo.Rows(0)("produtoExclui").ToString()
        Dim vendedoresConsulta As String = dtbGrupo.Rows(0)("vendedoresConsulta").ToString()
        Dim vendedoresInsere As String = dtbGrupo.Rows(0)("vendedoresInsere").ToString()
        Dim vendedoresAltera As String = dtbGrupo.Rows(0)("vendedoresAltera").ToString()
        Dim vendedoresExclui As String = dtbGrupo.Rows(0)("vendedoresExclui").ToString()
        Dim vendasConsulta As String = dtbGrupo.Rows(0)("vendasConsulta").ToString()
        Dim vendasInsere As String = dtbGrupo.Rows(0)("vendasInsere").ToString()
        Dim vendasAltera As String = dtbGrupo.Rows(0)("vendasAltera").ToString()
        Dim vendasExclui As String = dtbGrupo.Rows(0)("vendasExclui").ToString()


        If DadosUsuario.grupo = "Gerente" Or DadosUsuario.grupo = "Administrador" Or DadosUsuario.grupo = "Funcionário" Then

            If clienteConsulta = "True" Then
                Me.ClientesToolStripMenuItem.Enabled = True

                If clienteInsere = "True" Then
                    frmGridClientes.btnInserir.Enabled = True

                Else

                    frmGridClientes.btnInserir.Enabled = False

                End If

                If clienteAltera = "True" Then
                    frmGridClientes.btnAlterar.Enabled = True

                Else

                    frmGridClientes.btnAlterar.Enabled = False

                End If

                If clienteExclui = "True" Then
                    frmGridClientes.btnExcluir.Enabled = True

                Else

                    frmGridClientes.btnExcluir.Enabled = False

                End If

            Else

                Me.ClientesToolStripMenuItem.Enabled = False

            End If

            If produtoConsulta = "True" Then

                Me.ProdutosToolStripMenuItem.Enabled = True

                If produtoInsere = "True" Then
                    frmProdutos.btnInserir.Enabled = True

                Else

                    frmProdutos.btnInserir.Enabled = False

                End If

                If produtoAltera = "True" Then
                    frmProdutos.btnAlterar.Enabled = True

                Else

                    frmProdutos.btnAlterar.Enabled = False

                End If

                If produtoExclui = "True" Then
                    frmProdutos.btnExcluir.Enabled = True

                Else

                    frmProdutos.btnExcluir.Enabled = False

                End If

            Else

                Me.ProdutosToolStripMenuItem.Enabled = False

            End If


            If vendedoresConsulta = "True" Then
                Me.VendedoresToolStripMenuItem.Enabled = True

                If vendedoresInsere = "True" Then
                    frmGridVendedores.btnInserir.Enabled = True

                Else

                    frmGridVendedores.btnInserir.Enabled = False

                End If

                If vendedoresAltera = "True" Then
                    frmGridVendedores.btnAlterar.Enabled = True

                Else

                    frmGridVendedores.btnAlterar.Enabled = False

                End If

                If vendedoresExclui = "True" Then
                    frmGridVendedores.btnExcluir.Enabled = True

                Else

                    frmGridVendedores.btnExcluir.Enabled = False

                End If

            Else

                Me.VendedoresToolStripMenuItem.Enabled = False

            End If


            If vendasConsulta = "True" Then
                Me.VendasToolStripMenuItem.Enabled = True

                If vendasInsere = "True" Then
                    frmVendas.btnInserir.Enabled = True

                Else

                    frmVendas.btnInserir.Enabled = False

                End If

                If vendasAltera = "True" Then
                    frmVendas.btnAlterar.Enabled = True

                Else

                    frmVendas.btnAlterar.Enabled = False

                End If

                If vendasExclui = "True" Then
                    frmVendas.btnExcluir.Enabled = True

                Else

                    frmVendas.btnExcluir.Enabled = False

                End If

            Else

                Me.VendasToolStripMenuItem.Enabled = False

            End If

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

    Private Sub GruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem.Click
        frmGrupos.MdiParent = Me
        frmGrupos.Show()
    End Sub

End Class