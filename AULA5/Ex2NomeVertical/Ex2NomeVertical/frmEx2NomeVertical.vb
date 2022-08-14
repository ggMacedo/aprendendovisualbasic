Public Class frmEx2NomeVertical

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim nome As String = txtNome.Text
        Dim t As Integer
        Dim g As String

        t = nome.Length
        t = t - 1

        For i As Integer = 0 To t
            g += (nome.Substring(i, 1) & vbCrLf)
        Next
        MsgBox(g)


    End Sub
End Class
