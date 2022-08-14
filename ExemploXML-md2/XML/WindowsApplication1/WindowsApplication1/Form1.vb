Imports System.Xml

Public Class Form1

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Try
            Dim writer As New XmlTextWriter("C:\Danilo\cadastro.xml", Nothing)
            writer.WriteStartDocument()

            writer.WriteStartElement("cadastro")

            writer.WriteElementString("nome", txtNome.Text)
            writer.WriteElementString("idade", txtIdade.Text)

            writer.WriteEndElement()

            writer.Close()
            MsgBox("Arquivo XML gerado com sucesso.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLer_Click(sender As Object, e As EventArgs) Handles btnLer.Click
        Dim reader As XmlTextReader = New XmlTextReader("C:\Danilo\cadastro.xml")
        Dim elementos As ArrayList = New ArrayList

        Do While (reader.Read())
            Select Case reader.NodeType
                Case XmlNodeType.Element
                    elementos.Add(reader.Name)
                Case XmlNodeType.Text
                    elementos.Add(reader.Value)
            End Select
        Loop

        Dim num As String
        For Each num In elementos
            ListBox1.Items.Add(num)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dtb As New DataTable("Cadastro")
        Dim colNome As DataColumn = New DataColumn("Nome", GetType(String))
        Dim colIdade As DataColumn = New DataColumn("Idade", GetType(Integer))

        dtb.Columns.Add(colNome)
        dtb.Columns.Add(colIdade)

        Dim linha As DataRow
        linha = dtb.NewRow()
        linha.Item("Nome") = txtNome.Text
        linha.Item("Idade") = CInt(txtIdade.Text)
        dtb.Rows.Add(linha)

        Dim ds As New DataSet
        ds.Tables.Add(dtb)
        ds.WriteXml("C:\Danilo\cadastroDS.xml")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet

        ds.ReadXml("C:\Danilo\cadastroDS.xml")

        Dim dtb As New DataTable
        dtb = ds.Tables(0)

        DataGridView1.DataSource = dtb
    End Sub
End Class
