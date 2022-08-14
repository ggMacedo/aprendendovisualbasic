Public Class frmExGrid1

    Dim dtbCliente As DataTable
    Dim linha1 As DataRow

    Private Sub frmExGrid1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtbCliente = New DataTable("Clientes")
        Dim colCodigo As DataColumn = New DataColumn("Codigo")
        colCodigo.DataType = System.Type.GetType("System.String")

        Dim colNome As DataColumn = New DataColumn("Nome")
        colNome.DataType = System.Type.GetType("System.String")

        Dim colEndereco As DataColumn = New DataColumn("Endereco")
        colEndereco.DataType = System.Type.GetType("System.String")

        Dim colCidade As DataColumn = New DataColumn("Cidade")
        colCidade.DataType = System.Type.GetType("System.String")

        Dim colUF As DataColumn = New DataColumn("UF")
        colUF.DataType = System.Type.GetType("System.String")

        Dim colIdade As DataColumn = New DataColumn("Idade")
        colIdade.DataType = System.Type.GetType("System.String")

        Dim colProfissao As DataColumn = New DataColumn("Profissao")
        colProfissao.DataType = System.Type.GetType("System.String")

        dtbCliente.Columns.Add(colCodigo)
        dtbCliente.Columns.Add(colNome)
        dtbCliente.Columns.Add(colEndereco)
        dtbCliente.Columns.Add(colCidade)
        dtbCliente.Columns.Add(colUF)
        dtbCliente.Columns.Add(colIdade)
        dtbCliente.Columns.Add(colProfissao)

        grid1.DataSource = dtbCliente

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click

        frmCaixaDialogo.ShowDialog()

        If frmCaixaDialogo.DialogResult = Windows.Forms.DialogResult.OK Then

            If frmCaixaDialogo.txtCodigo.Text = vbNullString Or frmCaixaDialogo.txtNome.Text = vbNullString Or frmCaixaDialogo.txtEndereco.Text = vbNullString Or frmCaixaDialogo.txtCidade.Text = vbNullString Or frmCaixaDialogo.txtUf.Text = vbNullString Or frmCaixaDialogo.txtIdade.Text = vbNullString Or frmCaixaDialogo.txtProfissao.Text = vbNullString Then

                MsgBox("Digite algo na caixa de texto!")
                frmCaixaDialogo.ShowDialog()

            Else

                linha1 = dtbCliente.NewRow()
                linha1.Item("Codigo") = frmCaixaDialogo.txtCodigo.Text
                linha1.Item("Nome") = frmCaixaDialogo.txtNome.Text
                linha1.Item("Endereco") = frmCaixaDialogo.txtEndereco.Text
                linha1.Item("Cidade") = frmCaixaDialogo.txtCidade.Text
                linha1.Item("UF") = frmCaixaDialogo.txtUf.Text
                linha1.Item("Idade") = frmCaixaDialogo.txtIdade.Text
                linha1.Item("Profissao") = frmCaixaDialogo.txtProfissao.Text

                dtbCliente.Rows.Add(linha1)

            End If

        ElseIf frmCaixaDialogo.DialogResult = Windows.Forms.DialogResult.Cancel Then

            MsgBox("Cancelou")

        End If

    End Sub

    Private Sub grid1_Click(sender As Object, e As EventArgs) Handles grid1.Click

        If dtbCliente.Rows.Count > 0 Then

            frmCaixaDialogo.txtCodigo.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("Codigo")
            frmCaixaDialogo.txtNome.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("Nome")
            frmCaixaDialogo.txtEndereco.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("Endereco")
            frmCaixaDialogo.txtCidade.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("Cidade")
            frmCaixaDialogo.txtUf.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("UF")
            frmCaixaDialogo.txtIdade.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("Idade")
            frmCaixaDialogo.txtProfissao.Text = dtbCliente.Rows(grid1.CurrentRow.Index).Item("Profissao")

        Else
            MsgBox("Adicione algum dado!")
        End If

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If dtbCliente.Rows.Count > 0 Then

            frmCaixaDialogo.ShowDialog()

            If frmCaixaDialogo.DialogResult = Windows.Forms.DialogResult.OK Then

                If frmCaixaDialogo.txtCodigo.Text = vbNullString Or frmCaixaDialogo.txtNome.Text = vbNullString Or frmCaixaDialogo.txtEndereco.Text = vbNullString Or frmCaixaDialogo.txtCidade.Text = vbNullString Or frmCaixaDialogo.txtUf.Text = vbNullString Or frmCaixaDialogo.txtIdade.Text = vbNullString Or frmCaixaDialogo.txtProfissao.Text = vbNullString Then

                    MsgBox("Digite algo na caixa de texto!")
                    frmCaixaDialogo.ShowDialog()

                Else

                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("Codigo") = frmCaixaDialogo.txtCodigo.Text
                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("Nome") = frmCaixaDialogo.txtNome.Text
                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("Endereco") = frmCaixaDialogo.txtEndereco.Text
                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("Cidade") = frmCaixaDialogo.txtCidade.Text
                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("UF") = frmCaixaDialogo.txtUf.Text
                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("Idade") = frmCaixaDialogo.txtIdade.Text
                    dtbCliente.Rows(grid1.CurrentRow.Index).Item("Profissao") = frmCaixaDialogo.txtProfissao.Text

                End If

            ElseIf frmCaixaDialogo.DialogResult = Windows.Forms.DialogResult.Cancel Then

                MsgBox("Cancelou")

            End If

        Else

            MsgBox("Insira algum dado!")

        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If dtbCliente.Rows.Count > 0 Then

            dtbCliente.Rows.RemoveAt(grid1.CurrentRow.Index)
        Else

            MsgBox("Não existe nenhum dado!")

        End If

    End Sub
End Class