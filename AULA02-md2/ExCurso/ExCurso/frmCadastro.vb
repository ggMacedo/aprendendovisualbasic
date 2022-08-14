Imports System.Data.SqlClient

Public Class frmCadastro

    Private con As New SqlConnection("Initial catalog=ExAlunos;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    Private dtb As New DataTable

    Private Sub frmCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AtualizarGrid()

    End Sub

    Private Sub AtualizarGrid()

        con.Open()
        Dim adp As New SqlDataAdapter("SELECT * FROM Curso", con)
        dtb.Clear()
        adp.Fill(dtb)
        gridCurso.DataSource = dtb
        con.Close()

    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click

        frmInserir.txtCodigo.Text = ""
        frmInserir.txtCurso.Text = ""

        frmInserir.ShowDialog()

        If frmInserir.DialogResult = DialogResult.OK Then
            con.Open()

            Dim cmd As New SqlCommand("INSERT INTO Curso VALUES ('" & frmInserir.txtCurso.Text & "');", con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizarGrid()

        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If dtb.Rows.Count > 0 Then

            frmInserir.txtCodigo.Text = dtb.Rows(gridCurso.CurrentRow.Index).Item("codigo")
            frmInserir.txtCurso.Text = dtb.Rows(gridCurso.CurrentRow.Index).Item("nome")

        Else
            MsgBox("Adicione algum dado!")
        End If

        frmInserir.ShowDialog()

        If frmInserir.DialogResult = DialogResult.OK Then
            con.Open()

            Dim cmd As New SqlCommand("UPDATE Curso SET nome = '" & frmInserir.txtCurso.Text & "' 
                                                              WHERE codigo = '" & dtb.Rows(gridCurso.CurrentRow.Index).Item("codigo") & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizarGrid()
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If MsgBox("Deseja realmente excluir?", MsgBoxStyle.YesNo, "Excluir") = MsgBoxResult.Yes Then
            con.Open()
            Dim cmd As New SqlCommand("DELETE FROM Curso " &
                                      "WHERE codigo = " & dtb.Rows(gridCurso.CurrentRow.Index).Item("codigo"), con)
            cmd.ExecuteNonQuery()
            con.Close()
            AtualizarGrid()
        End If
    End Sub
End Class