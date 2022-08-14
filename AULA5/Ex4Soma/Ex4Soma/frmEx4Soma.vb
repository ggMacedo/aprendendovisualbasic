Public Class frmEx4Soma

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim nu As String = txtNumero.Text
        Dim t As Integer
        Dim so As Integer

        t = nu.Length
        t = t - 1

        For i As Integer = 0 To t
            so += (nu.Substring(i, 1))
        Next
        MsgBox(so)

    End Sub
End Class
