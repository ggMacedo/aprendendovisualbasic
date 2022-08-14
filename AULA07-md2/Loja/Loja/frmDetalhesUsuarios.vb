Imports System.Data.SqlClient

Public Class frmDetalhesUsuarios


    Private con As SqlConnection = Biblioteca.Conexao()
    Public dtbGrupo As New DataTable()

    Private Sub frmDetalhesUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()
        Dim adp2 As New SqlDataAdapter("Select * from grupoUsuarios", con)
        dtbGrupo.Clear()
        adp2.Fill(dtbGrupo)
        con.Close()

        cmbGrupo.DataSource = dtbGrupo
        cmbGrupo.DisplayMember = "nome"
        cmbGrupo.ValueMember = "codigo"


    End Sub


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class