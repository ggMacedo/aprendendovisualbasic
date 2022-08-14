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
            Dim cmd As New SqlCommand("INSERT INTO Produto VALUES ('" &
                                      frmDetalhesProdutos.txtNome.Text & "', '" &
                                      frmDetalhesProdutos.txtQuantidade.Text & "', '" &
                                      frmDetalhesProdutos.txtPreco.Text & "')", con)
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
            Dim cmd As New SqlCommand("UPDATE Produto SET nome = '" &
                                      frmDetalhesProdutos.txtNome.Text &
                                      "', quantidade = '" & frmDetalhesProdutos.txtQuantidade.Text &
                                      "', preco = '" & frmDetalhesProdutos.txtPreco.Text &
                                      "' WHERE codigo = " & frmDetalhesProdutos.txtCodigo.Text, con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Produto " &
                                      "WHERE codigo = " & dtb.Rows(gridProdutos.CurrentRow.Index).Item("Código"), con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub
End Class