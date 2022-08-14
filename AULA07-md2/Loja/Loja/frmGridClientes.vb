Imports System.Data.SqlClient

Public Class frmGridClientes

    Private con As SqlConnection = Biblioteca.Conexao()
    Private dtb As New DataTable()

    Private Sub frmGridClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        grid.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select codigo AS [Código], nome AS [Nome], endereco AS [Endereço] from Cliente", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        frmDetalhesClientes.txtCodigo.Text = "(novo)"
        frmDetalhesClientes.txtNome.Text = ""
        frmDetalhesClientes.txtEndereco.Text = ""
        frmDetalhesClientes.ShowDialog()

        If (frmDetalhesClientes.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Cliente VALUES (@nome, @endereco)", con)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = frmDetalhesClientes.txtNome.Text
            cmd.Parameters.Add("@endereco", SqlDbType.VarChar, 50).Value = frmDetalhesClientes.txtEndereco.Text
            cmd.ExecuteNonQuery()
            Dim adp As New SqlDataAdapter("SELECT MAX(codigo) FROM Cliente", con)
            Dim dtbCod As New DataTable
            adp.Fill(dtbCod)

            For i As Integer = 0 To frmDetalhesClientes.dtbTelefones.Rows.Count - 1
                Dim cmdTel As New SqlCommand("INSERT INTO Telefones VALUES (@codCliente, @numero, @tipo)", con)
                cmdTel.Parameters.Add("@codCliente", SqlDbType.Int).Value = dtbCod.Rows(0).Item(0)
                cmdTel.Parameters.Add("@numero", SqlDbType.VarChar, 15).Value = frmDetalhesClientes.dtbTelefones.Rows(i).Item("Número")
                cmdTel.Parameters.Add("@tipo", SqlDbType.VarChar, 20).Value = frmDetalhesClientes.dtbTelefones.Rows(i).Item("Tipo")
                cmdTel.ExecuteNonQuery()
            Next
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmDetalhesClientes.txtCodigo.Text = dtb.Rows(grid.CurrentRow.Index).Item("Código")
        frmDetalhesClientes.txtNome.Text = dtb.Rows(grid.CurrentRow.Index).Item("Nome")
        frmDetalhesClientes.txtEndereco.Text = dtb.Rows(grid.CurrentRow.Index).Item("Endereço")
        frmDetalhesClientes.ShowDialog()

        If (frmDetalhesClientes.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Cliente SET nome = @nome, endereco = @endereco WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = frmDetalhesClientes.txtNome.Text
            cmd.Parameters.Add("@endereco", SqlDbType.VarChar, 50).Value = frmDetalhesClientes.txtEndereco.Text
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = frmDetalhesClientes.txtCodigo.Text
            cmd.ExecuteNonQuery()

            Dim cmdTelExc As New SqlCommand("DELETE FROM Telefones WHERE codCliente = @codigo", con)
            cmdTelExc.Parameters.Add("@codigo", SqlDbType.Int).Value = frmDetalhesClientes.txtCodigo.Text
            cmdTelExc.ExecuteNonQuery()
            For i As Integer = 0 To frmDetalhesClientes.dtbTelefones.Rows.Count - 1
                Dim cmdTel As New SqlCommand("INSERT INTO Telefones VALUES (@codCliente, @numero, @tipo)", con)
                cmdTel.Parameters.Add("@codCliente", SqlDbType.Int).Value = frmDetalhesClientes.txtCodigo.Text
                cmdTel.Parameters.Add("@numero", SqlDbType.VarChar, 15).Value = frmDetalhesClientes.dtbTelefones.Rows(i).Item("Número")
                cmdTel.Parameters.Add("@tipo", SqlDbType.VarChar, 20).Value = frmDetalhesClientes.dtbTelefones.Rows(i).Item("Tipo")
                cmdTel.ExecuteNonQuery()
            Next

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Cliente WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = dtb.Rows(grid.CurrentRow.Index).Item("Código")
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub
End Class