Imports System.Data.SqlClient
Public Class frmDetalhesVendasProdutos

    Private con As New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Public dtbProdutos As New DataTable()

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmDetalhesVendasProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        Dim adp2 As New SqlDataAdapter("Select * from Produto", con)
        dtbProdutos.Clear()
        adp2.Fill(dtbProdutos)
        con.Close()
        cmbProduto.DataSource = dtbProdutos
        cmbProduto.DisplayMember = "nome"
        cmbProduto.ValueMember = "codigo"

        txtPreco.Text = dtbProdutos.Rows(cmbProduto.SelectedIndex)("preco").ToString

    End Sub

    Private Sub txtQuantidade_KeyUp(sender As Object, e As KeyEventArgs) Handles txtQuantidade.KeyUp
        Dim quantidade = txtQuantidade.Text
        Dim preco = txtPreco.Text

        If quantidade = vbNullString And preco = vbNullString Then
            txtTotal.Text = 0

        Else
            txtTotal.Text = preco * quantidade
        End If

    End Sub

    Private Sub cmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProduto.SelectedIndexChanged
        For i = 0 To cmbProduto.SelectedIndex
            txtPreco.Text = dtbProdutos.Rows(i)("preco").ToString
        Next
    End Sub


End Class