Public Class frmCalculadora

    Dim Numero1 As Double
    Dim Numero2 As Double
    Dim total As Double

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click

        Numero1 = CDbl(txtN1.Text)
        Numero2 = CDbl(txtN2.Text)

        total = Numero1 + Numero2
        total = total.ToString("###,##0.00")
        MsgBox("A soma dos números é: " & total)

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Numero1 = CDbl(txtN1.Text)
        Numero2 = CDbl(txtN2.Text)

        total = Numero1 - Numero2
        total = total.ToString("###,##0.00")
        MsgBox("A subtração dos números é: " & total)
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Numero1 = CDbl(txtN1.Text)
        Numero2 = CDbl(txtN2.Text)

        total = Numero1 * Numero2
        total = total.ToString("###,##0.00")
        MsgBox("A multiplicação dos números é: " & total)
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Numero1 = CDbl(txtN1.Text)
        Numero2 = CDbl(txtN2.Text)

        total = Numero1 / Numero2
        total = total.ToString("###,##0.00")
        MsgBox("A divisão dos números é: " & total)
    End Sub
End Class
