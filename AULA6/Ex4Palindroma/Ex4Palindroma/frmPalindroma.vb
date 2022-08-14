Public Class frmPalindroma

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim p As String = txtPalavra.Text
        Dim i As Integer
        Dim t As Integer
        Dim g As String

        t = p.Length
        t = t - 1

        For i = t To 0 Step -1
            g += (p.Substring(i, 1))
        Next

        If p = g Then
            MsgBox("Palíndroma")
        Else
            MsgBox("Não é Palíndroma")
        End If

    End Sub
End Class
