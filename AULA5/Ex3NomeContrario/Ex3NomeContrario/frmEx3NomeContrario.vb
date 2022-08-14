Public Class frmEx3NomeContrario

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim nome As String = txtNome.Text
        Dim t As Integer
        Dim g As String

        t = nome.Length
        t = t - 1

        For i As Integer = t To 0 Step -1
            g += (nome.Substring(i, 1))
        Next
        MsgBox(g)

    End Sub
End Class
