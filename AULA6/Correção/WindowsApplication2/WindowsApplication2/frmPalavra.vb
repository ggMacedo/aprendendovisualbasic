Public Class frmPalavra

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim msg As String = ""
        'msg = msg & txtPalavra.Text.Substring(5, 1)
        'msg = msg & txtPalavra.Text.Substring(4, 1)
        'msg = msg & txtPalavra.Text.Substring(3, 1)
        'msg = msg & txtPalavra.Text.Substring(2, 1)
        'msg = msg & txtPalavra.Text.Substring(1, 1)
        'msg = msg & txtPalavra.Text.Substring(0, 1)
        Dim n As Integer = txtPalavra.Text.Length - 1
        For i As Integer = n To 0 Step -1
            msg = msg & txtPalavra.Text.Substring(i, 1)
        Next
        If msg.ToLower = txtPalavra.Text.ToLower Then
            MsgBox("Palíndromo!")
        Else
            MsgBox("Não Palíndromo!")
        End If
    End Sub
End Class
