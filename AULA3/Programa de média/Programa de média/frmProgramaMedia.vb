Public Class frmProgramaMedia

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim Nota1 As Integer
        Dim Nota2 As Integer
        Dim Nota3 As Integer
        Dim Nota4 As Integer
        Dim soma As Integer
        Dim total As Integer

        Nota1 = CInt(txtNota1.Text)
        Nota2 = CInt(txtNota2.Text)
        Nota3 = CInt(txtNota3.Text)
        Nota4 = CInt(txtNota4.Text)

        soma = Nota1 + Nota2 + Nota3 + Nota4
        total = soma / 4

        MsgBox("A média foi de: " & total)

        If total >= 9 Then
            MsgBox("MB")
        ElseIf total >= 7 Then
            MsgBox("B")
        ElseIf total >= 5 Then
            MsgBox("R")
        Else
            MsgBox("I")

        End If

    End Sub
End Class
