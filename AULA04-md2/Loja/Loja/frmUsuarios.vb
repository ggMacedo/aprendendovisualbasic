Imports System.Data.SqlClient

Public Class frmUsuarios

    Private con As New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Private dtb As New DataTable()

    Private Sub frmGridUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        gridUsuarios.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select codigo AS [Código], nome AS [Nome], usuario AS [Usuário], senha AS [Senha] from usuarios", con)
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
            Dim cmd As New SqlCommand("INSERT INTO usuarios VALUES 
                                    ('" & frmDetalhesUsuarios.txtNome.Text & "', 
                                      '" & frmDetalhesUsuarios.txtUsuario.Text & "', 
                                      '" & frmDetalhesUsuarios.txtSenha.Text & "')", con)
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
        frmDetalhesUsuarios.ShowDialog()

        If (frmDetalhesUsuarios.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("UPDATE usuarios SET nome = '" & frmDetalhesUsuarios.txtNome.Text &
                                      "', usuario = '" & frmDetalhesUsuarios.txtUsuario.Text &
                                      "', senha = '" & frmDetalhesUsuarios.txtSenha.Text &
                                      "' WHERE codigo = " & frmDetalhesUsuarios.txtCodigo.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM usuarios " &
                                      "WHERE codigo = " & dtb.Rows(gridUsuarios.CurrentRow.Index).Item("Código"), con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub

End Class