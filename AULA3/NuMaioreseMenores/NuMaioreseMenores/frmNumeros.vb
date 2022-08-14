Public Class frmNumeros
    

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim nu1 As Double
        Dim nu2 As Double
        Dim nu3 As Double
        Dim nu4 As Double

        nu1 = CDbl(txtN1.Text)
        nu2 = CDbl(txtN2.Text)
        nu3 = CDbl(txtN3.Text)
        nu4 = CDbl(txtN4.Text)

        If nu1 > nu2 And nu1 > nu3 And nu1 > nu4 Then
            MsgBox("O maior número é: " & nu1)

        ElseIf nu2 > nu1 And nu2 > nu3 And nu2 > nu4 Then
            MsgBox("O maior número é: " & nu2)

        ElseIf nu3 > nu1 And nu3 > nu2 And nu3 > nu4 Then
            MsgBox("O maior número é: " & nu3)

        ElseIf nu4 > nu1 And nu4 > nu2 And nu4 > nu3 Then
            MsgBox("O maior número é: " & nu4)

        End If

        If nu1 < nu2 And nu1 < nu3 And nu1 < nu4 Then
            MsgBox("O menor número é: " & nu1)

        ElseIf nu2 < nu1 And nu2 < nu3 And nu2 < nu4 Then
            MsgBox("O menor número é: " & nu2)

        ElseIf nu3 < nu1 And nu3 < nu2 And nu3 < nu4 Then
            MsgBox("O menor número é: " & nu3)

        ElseIf nu4 < nu1 And nu4 < nu2 And nu4 < nu3 Then
            MsgBox("O menor número é: " & nu4)

        End If
    End Sub
End Class
