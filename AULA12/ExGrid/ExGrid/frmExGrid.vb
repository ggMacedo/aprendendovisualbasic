Public Class frmExGrid
    Dim dtbCliente As DataTable
    Dim linha1 As DataRow
    Private Sub frmExGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtbCliente = New DataTable("Clientes")
        Dim colCodigo As DataColumn = New DataColumn("Codigo")
        colCodigo.DataType = System.Type.GetType("System.String")

        Dim colNome As DataColumn = New DataColumn("Nome")
        colNome.DataType = System.Type.GetType("System.String")

        Dim colEndereco As DataColumn = New DataColumn("Endereco")
        colEndereco.DataType = System.Type.GetType("System.String")

        dtbCliente.Columns.Add(colCodigo)
        dtbCliente.Columns.Add(colNome)
        dtbCliente.Columns.Add(colEndereco)
        gridClientes.DataSource = dtbCliente

    End Sub
    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        If txtCodigo.Text = vbNullString Or txtNome.Text = vbNullString Or txtEndereco.Text = vbNullString Then
            MsgBox("Digite algo na caixa de texto!")
        Else
            linha1 = dtbCliente.NewRow()
            linha1.Item("Codigo") = txtCodigo.Text
            linha1.Item("Nome") = txtNome.Text
            linha1.Item("Endereco") = txtEndereco.Text

            dtbCliente.Rows.Add(linha1)
        End If

    End Sub
    Private Sub gridClientes_Click(sender As Object, e As EventArgs) Handles gridClientes.Click

        txtCodigo.Text = dtbCliente.Rows(gridClientes.CurrentRow.Index).Item("Codigo")
        txtNome.Text = dtbCliente.Rows(gridClientes.CurrentRow.Index).Item("Nome")
        txtEndereco.Text = dtbCliente.Rows(gridClientes.CurrentRow.Index).Item("Endereco")

    End Sub


    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If txtCodigo.Text = vbNullString Or txtNome.Text = vbNullString Or txtEndereco.Text = vbNullString Then
            MsgBox("Digite algo na caixa de texto!")

        ElseIf dtbCliente.Rows.Count > 0 Then
            dtbCliente.Rows(gridClientes.CurrentRow.Index).Item("Codigo") = txtCodigo.Text
            dtbCliente.Rows(gridClientes.CurrentRow.Index).Item("Nome") = txtNome.Text
            dtbCliente.Rows(gridClientes.CurrentRow.Index).Item("Endereco") = txtEndereco.Text
        Else
            MsgBox("Insira algum dado!")
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If dtbCliente.Rows.Count > 0 Then
            dtbCliente.Rows.RemoveAt(gridClientes.CurrentRow.Index)
        Else
            MsgBox("Não existe nenhum dado!")
        End If

    End Sub
End Class
