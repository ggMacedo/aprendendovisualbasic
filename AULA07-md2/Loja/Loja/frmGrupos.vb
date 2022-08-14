Imports System.Data.SqlClient

Public Class frmGrupos

    Private con As SqlConnection = Biblioteca.Conexao()
    Private dtb As New DataTable()

    Private Sub frmGridUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        gridGrupos.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select codigo AS [Código], nome AS [Nome] from grupoUsuarios", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        frmDetalhesGrupo.txtCodigo.Text = "(novo)"
        frmDetalhesGrupo.txtNome.Text = ""
        frmDetalhesGrupo.ShowDialog()

        If (frmDetalhesGrupo.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO grupoUsuarios VALUES (@nome, @clienteConsulta, @clienteInsere, @clienteAltera, @clienteExclui, 
                                                                        @produtoConsulta, @produtoInsere, @produtoAltera, @produtoExclui,
                                                                        @vendedoresConsulta, @vendedoresInsere, @vendedoresAltera, @vendedoresExclui,
                                                                        @vendasConsulta, @vendasInsere, @vendasAltera, @vendasExclui)", con)

            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = frmDetalhesGrupo.txtNome.Text

            cmd.Parameters.Add("@clienteConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaCliente.Checked
            cmd.Parameters.Add("@clienteInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereCliente.Checked
            cmd.Parameters.Add("@clienteAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraCliente.Checked
            cmd.Parameters.Add("@clienteExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiCliente.Checked

            cmd.Parameters.Add("@produtoConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaProduto.Checked
            cmd.Parameters.Add("@produtoInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereProduto.Checked
            cmd.Parameters.Add("@produtoAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraProduto.Checked
            cmd.Parameters.Add("@produtoExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiProduto.Checked

            cmd.Parameters.Add("@vendedoresConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaVendedor.Checked
            cmd.Parameters.Add("@vendedoresInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereVendedor.Checked
            cmd.Parameters.Add("@vendedoresAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraVendedor.Checked
            cmd.Parameters.Add("@vendedoresExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiVendedor.Checked

            cmd.Parameters.Add("@vendasConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaVendas.Checked
            cmd.Parameters.Add("@vendasInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereVendas.Checked
            cmd.Parameters.Add("@vendasAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraVendas.Checked
            cmd.Parameters.Add("@vendasExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiVendas.Checked

            cmd.ExecuteNonQuery()

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmDetalhesGrupo.txtCodigo.Text = dtb.Rows(gridGrupos.CurrentRow.Index).Item("Código")
        frmDetalhesGrupo.txtNome.Text = dtb.Rows(gridGrupos.CurrentRow.Index).Item("Nome")
        frmDetalhesGrupo.ShowDialog()

        If (frmDetalhesGrupo.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()

            Dim cmd As New SqlCommand("UPDATE grupoUsuarios SET nome = @nome, 
            clienteConsulta = @clienteConsulta, clienteInsere = @clienteInsere, clienteAltera = @clienteAltera, clienteExclui = @clienteExclui
            produtoConsulta = @produtoConsulta, produtoInsere = @produtoInsere, produtoAltera = @produtoAltera, produtoExclui = @produtoExclui,
            vendedoresConsulta = @vendedoresConsulta, vendedoresInsere = @vendedoresInsere, vendedoresAltera = @vendedoresAltera, vendedoresExclui = @vendedoresExclui,
            vendasConsulta = @vendasConsulta, vendasInsere = @vendasInsere, vendasAltera = @vendasAltera, vendasExclui = @vendasExclui
            WHERE codigo = @codigo", con)

            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = frmDetalhesGrupo.txtNome.Text

            cmd.Parameters.Add("@clienteConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaCliente.Checked
            cmd.Parameters.Add("@clienteInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereCliente.Checked
            cmd.Parameters.Add("@clienteAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraCliente.Checked
            cmd.Parameters.Add("@clienteExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiCliente.Checked

            cmd.Parameters.Add("@produtoConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaProduto.Checked
            cmd.Parameters.Add("@produtoInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereProduto.Checked
            cmd.Parameters.Add("@produtoAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraProduto.Checked
            cmd.Parameters.Add("@produtoExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiProduto.Checked

            cmd.Parameters.Add("@vendedoresConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaVendedor.Checked
            cmd.Parameters.Add("@vendedoresInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereVendedor.Checked
            cmd.Parameters.Add("@vendedoresAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraVendedor.Checked
            cmd.Parameters.Add("@vendedoresExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiVendedor.Checked

            cmd.Parameters.Add("@vendasConsulta", SqlDbType.Bit).Value = frmDetalhesGrupo.cbConsultaVendas.Checked
            cmd.Parameters.Add("@vendasInsere", SqlDbType.Bit).Value = frmDetalhesGrupo.cbInsereVendas.Checked
            cmd.Parameters.Add("@vendasAltera", SqlDbType.Bit).Value = frmDetalhesGrupo.cbAlteraVendas.Checked
            cmd.Parameters.Add("@vendasExclui", SqlDbType.Bit).Value = frmDetalhesGrupo.cbExcluiVendas.Checked
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM grupoUsuarios WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = dtb.Rows(gridGrupos.CurrentRow.Index).Item("Código")
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub

End Class