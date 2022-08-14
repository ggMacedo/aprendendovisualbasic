Public Class frmEx1_3Nomes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim nome1 As String = txtNome1.Text
        Dim nome2 As String = txtNome2.Text
        Dim nome3 As String = txtNome3.Text
        Dim t1 As Integer
        Dim t2 As Integer
        Dim t3 As Integer

        t1 = nome1.Length / 2
        t2 = nome2.Length / 2
        t3 = nome3.Length / 2

        MsgBox(nome1.Substring(0, t1) & " " & nome2.Substring(0, t2) & " " & nome3.Substring(0, t3))

    End Sub
End Class
