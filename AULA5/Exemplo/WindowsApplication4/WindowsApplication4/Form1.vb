Public Class Form1

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim nome As String = txtNome.Text
        'Substring - pedaço de uma String
        MsgBox(nome.Substring(4, 2))

        'Length - tamanho do texto - Integer
        MsgBox(nome.Length)
    End Sub
End Class
