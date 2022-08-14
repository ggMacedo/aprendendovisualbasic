Imports System.Data.SqlClient
Public Class frmDetalhesVendas

    Private con As New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Public dtbProdutos As New DataTable("Produtos")
    Private dtbCliente As New DataTable()
    Private dtbVendedor As New DataTable()
    Public codigoC As Integer
    Public codigoV As Integer

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmDetalhesVendas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtbProdutos = New DataTable("Produtos")
        Dim colProduto As New DataColumn("Produto", GetType(String))
        Dim colQuantidade As New DataColumn("Quantidade", GetType(String))
        Dim colPreco As New DataColumn("Preço", GetType(String))

        dtbProdutos.Columns.Add(colProduto)
        dtbProdutos.Columns.Add(colQuantidade)
        dtbProdutos.Columns.Add(colPreco)

        If (txtCodigo.Text <> "(novo)") Then
            con.Open()
            Dim adp As New SqlDataAdapter("SELECT nome AS [Produto], quantidade AS [Quantidade], preco AS [Preço] FROM Telefones WHERE codCliente = " & txtCodigo.Text, con)
            adp.Fill(dtbProdutos)
            con.Close()
        End If
        gridProdutos.DataSource = dtbProdutos

        con.Open()
        Dim adp2 As New SqlDataAdapter("Select * from Cliente", con)
        dtbCliente.Clear()
        adp2.Fill(dtbCliente)
        con.Close()
        cmbCliente.DataSource = dtbCliente
        cmbCliente.DisplayMember = "nome"
        cmbCliente.ValueMember = "codigo"



        con.Open()
        Dim adp1 As New SqlDataAdapter("Select * from Vendedores", con)
        dtbVendedor.Clear()
        adp1.Fill(dtbVendedor)
        con.Close()
        cmbVendedor.DataSource = dtbVendedor
        cmbVendedor.DisplayMember = "nome"
        cmbVendedor.ValueMember = "codigo"



    End Sub

    Private Sub btnMais_Click(sender As Object, e As EventArgs) Handles btnMais.Click
        frmDetalhesVendasProdutos.cmbProduto.Text = ""
        frmDetalhesVendasProdutos.txtQuantidade.Text = ""
        frmDetalhesVendasProdutos.txtPreco.Text = ""
        frmDetalhesVendasProdutos.txtTotal.Text = ""
        frmDetalhesVendasProdutos.ShowDialog()

        If frmDetalhesVendasProdutos.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim linha As DataRow
            linha = dtbProdutos.NewRow
            linha("Produto") = frmDetalhesVendasProdutos.cmbProduto.Text
            linha("Quantidade") = frmDetalhesVendasProdutos.txtQuantidade.Text
            linha("Preço") = frmDetalhesVendasProdutos.txtTotal.Text
            dtbProdutos.Rows.Add(linha)
            Dim a As Double = 0

            For i = 0 To dtbProdutos.Rows.Count - 1

                a += dtbProdutos.Rows(i).Item("Preço")

            Next

            txtTtotal.Text = a

        End If

    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        If dtbProdutos.Rows.Count > 0 Then
            If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
                dtbProdutos.Rows.RemoveAt(gridProdutos.CurrentRow.Index)
            End If
        End If
    End Sub

    Private Sub cmbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCliente.SelectedIndexChanged
        codigoC = dtbCliente.Rows(cmbCliente.SelectedIndex).Item("codigo")

    End Sub

    Private Sub cmbVendedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVendedor.SelectedIndexChanged
        codigoV = dtbVendedor.Rows(cmbVendedor.SelectedIndex).Item("codigo")

    End Sub
End Class