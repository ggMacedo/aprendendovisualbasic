Imports System.Data.SqlClient

Public Class frmDetalhesClientes

    Private con As New SqlConnection("Initial Catalog=Loja;server=L3CORE502\MSSQL2017;UID=sa;PWD=etec")
    Public dtbTelefones As New DataTable("Telefones")

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub frmDetalhesClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtbTelefones = New DataTable("Telefones")
        Dim colNumero As New DataColumn("Número", GetType(String))
        Dim colTipo As New DataColumn("Tipo", GetType(String))
        dtbTelefones.Columns.Add(colNumero)
        dtbTelefones.Columns.Add(colTipo)
        If (txtCodigo.Text <> "(novo)") Then
            con.Open()
            Dim adp As New SqlDataAdapter("SELECT numero AS [Número], tipo AS [Tipo] FROM Telefones WHERE codCliente = " & txtCodigo.Text, con)
            adp.Fill(dtbTelefones)
            con.Close()
        End If
        grid.DataSource = dtbTelefones
    End Sub

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        frmTelefone.txtNumero.Text = ""
        frmTelefone.txtTipo.Text = ""
        frmTelefone.ShowDialog()
        If frmTelefone.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim linha As DataRow
            linha = dtbTelefones.NewRow
            linha("Número") = frmTelefone.txtNumero.Text
            linha("Tipo") = frmTelefone.txtTipo.Text
            dtbTelefones.Rows.Add(linha)
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If dtbTelefones.Rows.Count > 0 Then
            If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
                dtbTelefones.Rows.RemoveAt(grid.CurrentRow.Index)
            End If
        End If
    End Sub
End Class