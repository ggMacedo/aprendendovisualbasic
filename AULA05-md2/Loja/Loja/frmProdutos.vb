Imports System.Data.SqlClient

Public Class frmProdutos

    Private con As New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Private dtb As New DataTable()

    Private Sub frmGridClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        gridProdutos.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select codigo AS [Código], nome AS [Nome], quantidade AS [Quantidade], preco AS [Preço] from Produto", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        frmDetalhesProdutos.txtCodigo.Text = "(novo)"
        frmDetalhesProdutos.txtNome.Text = ""
        frmDetalhesProdutos.txtQuantidade.Text = ""
        frmDetalhesProdutos.txtPreco.Text = ""
        frmDetalhesProdutos.ShowDialog()

        If (frmDetalhesProdutos.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Produto VALUES (@nome, @quantidade, @preco)", con)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 30).Value = frmDetalhesProdutos.txtNome.Text
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = frmDetalhesProdutos.txtQuantidade.Text
            cmd.Parameters.Add("@preco", SqlDbType.Decimal, 10.2).Value = frmDetalhesProdutos.txtPreco.Text
            cmd.ExecuteNonQuery()

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmDetalhesProdutos.txtCodigo.Text = dtb.Rows(gridProdutos.CurrentRow.Index).Item("Código")
        frmDetalhesProdutos.txtNome.Text = dtb.Rows(gridProdutos.CurrentRow.Index).Item("Nome")
        frmDetalhesProdutos.txtQuantidade.Text = dtb.Rows(gridProdutos.CurrentRow.Index).Item("Quantidade")
        frmDetalhesProdutos.txtPreco.Text = dtb.Rows(gridProdutos.CurrentRow.Index).Item("Preço")

        frmDetalhesProdutos.ShowDialog()

        If (frmDetalhesProdutos.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Produto SET nome = @nome, quantidade = @quantidade, preco = @preco WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 30).Value = frmDetalhesProdutos.txtNome.Text
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = frmDetalhesProdutos.txtQuantidade.Text
            cmd.Parameters.Add("@preco", SqlDbType.Decimal, 10.2).Value = frmDetalhesProdutos.txtPreco.Text.Replace(",", ".")
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = frmDetalhesProdutos.txtCodigo.Text
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Produto WHERE codigo = @codigo", con)
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = dtb.Rows(gridProdutos.CurrentRow.Index).Item("Código")
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub
End Class