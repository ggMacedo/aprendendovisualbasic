Imports System.Data.SqlClient

Public Class frmUsuarios

    Private con As SqlConnection = Biblioteca.Conexao()
    Private dtb As New DataTable()

    Private Sub frmGridUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        gridUsuarios.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select usuarios.codigo AS [Código], usuarios.nome AS [Nome], usuario AS [Usuário], grupoUsuarios.nome AS [Grupo], senha AS [Senha] from usuarios INNER JOIN grupoUsuarios ON grupoUsuarios.codigo = usuarios.codGrupo", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        frmDetalhesUsuarios.txtCodigo.Text = "(novo)"
        frmDetalhesUsuarios.txtNome.Text = ""
        frmDetalhesUsuarios.txtUsuario.Text = ""
        frmDetalhesUsuarios.txtSenha.Text = ""
        frmDetalhesUsuarios.ShowDialog()

        If (frmDetalhesUsuarios.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO usuarios VALUES (@nome, @usuario, @senha, @codGrupo)", con)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = frmDetalhesUsuarios.txtNome.Text
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = frmDetalhesUsuarios.txtUsuario.Text
            cmd.Parameters.Add("@senha", SqlDbType.VarChar, 32).Value = Biblioteca.Criptografar(frmDetalhesUsuarios.txtSenha.Text.ToString)
            cmd.Parameters.Add("@codGrupo", SqlDbType.Int).Value = frmDetalhesUsuarios.cmbGrupo.SelectedValue
            cmd.ExecuteNonQuery()

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmDetalhesUsuarios.txtCodigo.Text = dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Código")
        frmDetalhesUsuarios.txtNome.Text = dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Nome")
        frmDetalhesUsuarios.txtUsuario.Text = dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Usuário")
        frmDetalhesUsuarios.txtSenha.Text = dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Senha")
        frmDetalhesUsuarios.cmbGrupo.Text = dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Grupo")
        frmDetalhesUsuarios.ShowDialog()

        If (frmDetalhesUsuarios.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("UPDATE usuarios SET nome = @nome, usuario = @usuario, senha = @senha, codGrupo = @codGrupo WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = frmDetalhesUsuarios.txtNome.Text
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = frmDetalhesUsuarios.txtUsuario.Text
            cmd.Parameters.Add("@senha", SqlDbType.VarChar, 32).Value = Biblioteca.Criptografar(frmDetalhesUsuarios.txtSenha.Text.ToString)
            cmd.Parameters.Add("@codGrupo", SqlDbType.Int).Value = frmDetalhesUsuarios.cmbGrupo.SelectedValue
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = frmDetalhesUsuarios.txtCodigo.Text
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM usuarios WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Código")
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub

End Class