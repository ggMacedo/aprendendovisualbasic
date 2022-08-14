Public Class frmGrid

    Private Sub btnPrencher_Click(sender As Object, e As EventArgs) Handles btnPrencher.Click
        Dim dtbCliente As DataTable
        dtbCliente = New DataTable("Clientes")

        Dim linha1, linha2, linha3 As DataRow

        Dim colCodigo As DataColumn = New DataColumn("Codigo")
        colCodigo.DataType = System.Type.GetType("System.String")

        Dim colNome As DataColumn = New DataColumn("Nome")
        colNome.DataType = System.Type.GetType("System.String")

        Dim colEndereco As DataColumn = New DataColumn("Endereco")
        colEndereco.DataType = System.Type.GetType("System.String")

        dtbCliente.Columns.Add(colCodigo)
        dtbCliente.Columns.Add(colNome)
        dtbCliente.Columns.Add(colEndereco)

        linha1 = dtbCliente.NewRow()
        linha1.Item("Codigo") = "1"
        linha1.Item("Nome") = "Danilo"
        linha1.Item("Endereco") = "Rua da Flores, 213"

        dtbCliente.Rows.Add(linha1)

        linha2 = dtbCliente.NewRow()
        linha2.Item("Codigo") = "2"
        linha2.Item("Nome") = "José"
        linha2.Item("Endereco") = "Rua das Figueiras, 111"

        dtbCliente.Rows.Add(linha2)

        linha3 = dtbCliente.NewRow()
        linha3.Item("Codigo") = "3"
        linha3.Item("Nome") = "Maria"
        linha3.Item("Endereco") = "Rua Um, 645"

        dtbCliente.Rows.Add(linha3)

        dgvGrid.DataSource = dtbCliente

    End Sub
End Class
