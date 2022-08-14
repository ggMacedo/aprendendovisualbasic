Imports System.Data.SqlClient

Public Class frmGridClientes

    Private con As New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Private dtb As New DataTable()

    Private Sub frmGridClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaGrid()
        grid.DataSource = dtb
    End Sub

    Private Sub AtualizaGrid()
        con.Open()
        Dim adp As New SqlDataAdapter("Select codigo AS [Código], nome AS [Nome], endereco AS [Endereço] from Clientes", con)
        dtb.Clear()
        adp.Fill(dtb)
        con.Close()
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        frmDetalhesClientes.txtCodigo.Text = "(novo)"
        frmDetalhesClientes.txtNome.Text = ""
        frmDetalhesClientes.txtEndereco.Text = ""
        frmDetalhesClientes.ShowDialog()

        If (frmDetalhesClientes.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("INSERT INTO Clientes VALUES ('" & _
                                      frmDetalhesClientes.txtNome.Text & "', '" & _
                                      frmDetalhesClientes.txtEndereco.Text & "')", con)
            cmd.ExecuteNonQuery()
            Dim adp As New SqlDataAdapter("SELECT MAX(codigo) FROM Clientes", con)
            Dim dtbCod As New DataTable
            adp.Fill(dtbCod)
            For i As Integer = 0 To frmDetalhesClientes.dtbTelefones.Rows.Count - 1
                Dim cmdTel As New SqlCommand("INSERT INTO Telefones VALUES (" & _
                                             dtbCod.Rows(0).Item(0) & ", '" & _
                                             frmDetalhesClientes.dtbTelefones.Rows(i).Item("Número") & "', '" & _
                                             frmDetalhesClientes.dtbTelefones.Rows(i).Item("Tipo") & "')", con)
                cmdTel.ExecuteNonQuery()
            Next
            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmDetalhesClientes.txtCodigo.Text = dtb.Rows(grid.CurrentRow.Index).Item("Código")
        frmDetalhesClientes.txtNome.Text = dtb.Rows(grid.CurrentRow.Index).Item("Nome")
        frmDetalhesClientes.txtEndereco.Text = dtb.Rows(grid.CurrentRow.Index).Item("Endereço")
        frmDetalhesClientes.ShowDialog()

        If (frmDetalhesClientes.DialogResult = Windows.Forms.DialogResult.OK) Then
            con.Open()
            Dim cmd As New SqlCommand("UPDATE Clientes SET nome = '" & _
                                      frmDetalhesClientes.txtNome.Text & "', endereco = '" & _
                                      frmDetalhesClientes.txtEndereco.Text & _
                                      "' WHERE codigo = " & frmDetalhesClientes.txtCodigo.Text, con)
            cmd.ExecuteNonQuery()
            Dim cmdTelExc As New SqlCommand("DELETE FROM Telefones WHERE codCliente = " & frmDetalhesClientes.txtCodigo.Text, con)
            cmdTelExc.ExecuteNonQuery()
            For i As Integer = 0 To frmDetalhesClientes.dtbTelefones.Rows.Count - 1
                Dim cmdTel As New SqlCommand("INSERT INTO Telefones VALUES (" & _
                                             frmDetalhesClientes.txtCodigo.Text & ", '" & _
                                             frmDetalhesClientes.dtbTelefones.Rows(i).Item("Número") & "', '" & _
                                             frmDetalhesClientes.dtbTelefones.Rows(i).Item("Tipo") & "')", con)
                cmdTel.ExecuteNonQuery()
            Next

            con.Close()
            AtualizaGrid()
        End If
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Clientes " & _
                                      "WHERE codigo = " & dtb.Rows(grid.CurrentRow.Index).Item("Código"), con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizaGrid()

        End If
    End Sub
End Class