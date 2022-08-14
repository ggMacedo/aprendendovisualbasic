Public Class frmTrocaLetraa

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim p As String = txtPalavra.Text
        Dim l1 As String = txtLetra1.Text
        Dim l2 As String = txtLetra2.Text
        Dim k As String
        Dim i As Integer
        Dim resp As String
        Dim t As Integer

        t = p.Length
        t = t - 1

        For i = 0 To t

            k = p.Substring(i, 1)

            If k = l1 And k <> l2 Then
                resp += l2
            Else
                resp += k
            End If

        Next

        MsgBox(resp)
    End Sub
End Class
