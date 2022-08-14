Public Class frmImc

    Private Sub btnImc_Click(sender As Object, e As EventArgs) Handles btnImc.Click
        Dim n1 As Double
        Dim n2 As Double
        Dim imc As Double

        n1 = CDbl (txtPeso.Text)
        n2 = CDbl(txtAltura.Text)

        imc = (n1 / (n2 ^ 2))

        txtImc.Text = imc

        If imc < 18 Then
            MsgBox("Magreza")
        ElseIf imc <= 25 Then
            MsgBox("Saudável")
        ElseIf imc <= 30 Then
            MsgBox("Sobrepeso")
        ElseIf imc <= 35 Then
            MsgBox("Obesidade Nvl 1")
        ElseIf imc <= 40 Then
            MsgBox("Obesidade Nvl 2")
        ElseIf imc > 40 Then
            MsgBox("Obesidade Nvl 3")
        End If

    End Sub
End Class
