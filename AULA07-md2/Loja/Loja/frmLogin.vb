Imports System.Data.SqlClient

Public Class frmLogin

    Private con As SqlConnection = Biblioteca.Conexao()
    Private dtb As New DataTable()

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        con.Open()
        Dim adp As New SqlDataAdapter("Select usuarios.codigo AS [codUsuario], usuarios.usuario AS [nomeUsuario], 
        usuarios.codGrupo, grupoUsuarios.codigo AS [codigoGrupo], grupoUsuarios.nome AS [nomeGrupo] 
        from usuarios INNER JOIN grupoUsuarios ON grupoUsuarios.codigo = usuarios.codGrupo 
        WHERE usuario = @usuario AND senha = @senha", con)
        adp.SelectCommand.Parameters.Add("@usuario", SqlDbType.VarChar, 50).Value = txtUsuario.Text
        adp.SelectCommand.Parameters.Add("@senha", SqlDbType.VarChar, 32).Value = Biblioteca.Criptografar(txtSenha.Text)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
        If dtb.Rows.Count > 0 Then
            DadosUsuario.usuario = dtb.Rows(0).Item("nomeUsuario")
            DadosUsuario.grupo = dtb.Rows(0).Item("nomeGrupo")
            DadosUsuario.codigoGrupo = dtb.Rows(0).Item("codigoGrupo")
            DialogResult = Windows.Forms.DialogResult.OK
        Else
            MsgBox("Usuário Inválido!")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class