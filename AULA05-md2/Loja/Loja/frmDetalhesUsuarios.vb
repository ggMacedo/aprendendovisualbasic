﻿Imports System.Data.SqlClient

Public Class frmDetalhesUsuarios

    Private con As New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")


    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class