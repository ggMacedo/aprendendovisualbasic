Imports System.Data.SqlClient

Public Class frmVendas

    Private con As SqlConnection = Biblioteca.Conexao()
    Private dtb As New DataTable()

    Private Sub frmGridClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        gridVendas.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select Vendas.codigo AS [Código], Vendas.dataa AS [Data], Cliente.nome AS [Cliente], Vendedores.nome AS [Vendedores] from Vendas
                                        INNER JOIN Cliente on Cliente.codigo = Vendas.codCliente
                                        INNER JOIN Vendedores on Vendedores.codigo = Vendas.codVendedor", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        frmDetalhesVendas.txtCodigo.Text = "(novo)"
        frmDetalhesVendas.cmbCliente.Text = ""
        frmDetalhesVendas.cmbVendedor.Text = ""
        frmDetalhesVendas.txtTtotal.Text = ""
        frmDetalhesVendas.ShowDialog()

        If (frmDetalhesVendas.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Vendas VALUES (@codCliente, @codVendedor, @dataa)", con)
            cmd.Parameters.Add("@codCliente", SqlDbType.Int).Value = frmDetalhesVendas.codigoC
            cmd.Parameters.Add("@codVendedor", SqlDbType.Int).Value = frmDetalhesVendas.codigoV
            cmd.Parameters.Add("@dataa", SqlDbType.Date).Value = frmDetalhesVendas.dtpData.Text
            cmd.ExecuteNonQuery()

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmDetalhesVendas.txtCodigo.Text = dtb.Rows(gridVendas.CurrentRow.Index).Item("Código")
        frmDetalhesVendas.dtpData.Text = dtb.Rows(gridVendas.CurrentRow.Index).Item("Data")
        frmDetalhesVendas.cmbCliente.Text = dtb.Rows(gridVendas.CurrentRow.Index).Item("Cliente")
        frmDetalhesVendas.cmbVendedor.Text = dtb.Rows(gridVendas.CurrentRow.Index).Item("Vendedor")
        frmDetalhesVendas.txtTtotal.Text = dtb.Rows(gridVendas.CurrentRow.Index).Item("Total")

        frmDetalhesVendas.ShowDialog()

        If (frmDetalhesVendas.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Cliente SET nome = '" &
                                      frmDetalhesClientes.txtNome.Text & "', endereco = '" &
                                      frmDetalhesClientes.txtEndereco.Text &
                                      "' WHERE codigo = " & frmDetalhesClientes.txtCodigo.Text, con)
            cmd.ExecuteNonQuery()
            Dim cmdTelExc As New SqlCommand("DELETE FROM Telefones WHERE codCliente = " & frmDetalhesClientes.txtCodigo.Text, con)
            cmdTelExc.ExecuteNonQuery()
            For i As Integer = 0 To frmDetalhesClientes.dtbTelefones.Rows.Count - 1
                Dim cmdTel As New SqlCommand("INSERT INTO Telefones VALUES (" &
                                             frmDetalhesClientes.txtCodigo.Text & ", '" &
                                             frmDetalhesClientes.dtbTelefones.Rows(i).Item("Número") & "', '" &
                                             frmDetalhesClientes.dtbTelefones.Rows(i).Item("Tipo") & "')", con)
                cmdTel.ExecuteNonQuery()
            Next

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Cliente " &
                                      "WHERE codigo = " & dtb.Rows(gridVendas.CurrentRow.Index).Item("Código"), con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub
End Class