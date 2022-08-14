Imports System.Data.SqlClient

Public Class frmCombo
    Private con As New SqlConnection("Initial Catalog=Loja;server=L3CORE502\mssql2017;UID=sa;PWD=etec")
    Private dtb As New DataTable()

    Private Sub frmCombo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim adp As New SqlDataAdapter("Select * from Clientes", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
        cmbClientes.DataSource = dtb
        cmbClientes.DisplayMember = "nome"
        cmbClientes.ValueMember = "codigo"
    End Sub

    Private Sub btnNome_Click(sender As Object, e As EventArgs) Handles btnNome.Click
        MsgBox(cmbClientes.Text)
    End Sub

    Private Sub btnCodigo_Click(sender As Object, e As EventArgs) Handles btnCodigo.Click
        MsgBox(cmbClientes.SelectedValue)
    End Sub

    Private Sub btnEndereco_Click(sender As Object, e As EventArgs) Handles btnEndereco.Click
        MsgBox(dtb.Rows(cmbClientes.SelectedIndex).Item("endereco"))
    End Sub

End Class
