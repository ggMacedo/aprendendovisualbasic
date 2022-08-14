Public Class frmTiraLetra

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim p As String = txtPalavra.Text
        Dim l As String = txtLetra.Text
        Dim k As String
        Dim i As Integer
        Dim resp As String
        Dim t As Integer

        t = p.Length
        t = t - 1

        For i = 0 To t

            k = p.Substring(i, 1)

            If k <> l Then
                resp += p.Substring(i, 1)
            End If

        Next

        MsgBox(resp)
    End Sub
End Class
