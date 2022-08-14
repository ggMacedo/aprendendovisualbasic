Imports System.Data.SqlClient

Public Class frmCadastro

    Private con As New SqlConnection("Initial catalog=ExAlunos;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Private dtb As New DataTable

    Private Sub frmCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AtualizarGrid()

    End Sub

    Private Sub AtualizarGrid()

        con.Open()
        Dim adp As New SqlDataAdapter("SELECT * FROM Alunos", con)
        dtb.Clear()
        adp.Fill(dtb)
        gridCadastro.DataSource = dtb
        con.Close()

    End Sub

    Private Sub gridCadastro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCadastro.CellContentClick

        If dtb.Rows.Count > 0 Then

            frmInserirr.txtCodigo.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("codigo")
            frmInserirr.txtNome.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("nome")
            frmInserirr.txtIdade.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("idade")
            frmInserirr.txtEstado.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("estado")

        Else
            MsgBox("Adicione algum dado!")
        End If
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click

        frmInserirr.txtCodigo.Text = ""
        frmInserirr.txtNome.Text = ""
        frmInserirr.txtIdade.Text = ""
        frmInserirr.txtEstado.Text = ""

        frmInserirr.ShowDialog()

        If frmInserirr.DialogResult = DialogResult.OK Then
            con.Open()

            Dim cmd As New SqlCommand("INSERT INTO Alunos VALUES ('" & frmInserirr.txtNome.Text & "','" & frmInserirr.txtIdade.Text & "','" & frmInserirr.txtEstado.Text & "');", con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizarGrid()

        End If
    End Sub



    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        frmInserirr.txtCodigo.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("codigo")
        frmInserirr.txtNome.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("nome")
        frmInserirr.txtIdade.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("idade")
        frmInserirr.txtEstado.Text = dtb.Rows(gridCadastro.CurrentRow.Index).Item("estado")

        frmInserirr.ShowDialog()

        If frmInserirr.DialogResult = DialogResult.OK Then
            con.Open()

            Dim cmd As New SqlCommand("UPDATE Alunos SET nome = '" & frmInserirr.txtNome.Text & "', 
                                                              idade = '" & frmInserirr.txtIdade.Text & "', 
                                                              estado = '" & frmInserirr.txtEstado.Text & "' 
                                                              WHERE codigo = '" & dtb.Rows(gridCadastro.CurrentRow.Index).Item("codigo") & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizarGrid()
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Alunos WHERE codigo = '" & dtb.Rows(gridCadastro.CurrentRow.Index).Item("codigo") & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizarGrid()
        End If

    End Sub
End Class
