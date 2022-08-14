Public Class frmNumerosCrescentes


    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim n1 As Double
        Dim n2 As Double
        Dim n3 As Double

        n1 = CDbl(txtNumero1.Text)
        n2 = CDbl(txtNumero2.Text)
        n3 = CDbl(txtNumero3.Text)

        If n1 < n2 And n1 < n3 And n2 < n3 Then
            MsgBox("A ordem dos números é: " & n1 & " , " & n2 & " , " & n3)
        ElseIf n1 < n2 And n1 < n3 And n3 < n2 Then
            MsgBox("A ordem dos números é: " & n1 & " , " & n3 & " , " & n2)

        ElseIf n2 < n1 And n2 < n3 And n1 < n3 Then
            MsgBox("A ordem dos números é: " & n2 & " , " & n1 & " , " & n3)
        ElseIf n2 < n1 And n2 < n3 And n3 < n1 Then
            MsgBox("A ordem dos números é: " & n2 & " , " & n3 & " , " & n1)

        ElseIf n3 < n1 And n3 < n2 And n2 < n1 Then
            MsgBox("A ordem dos números é: " & n3 & " , " & n2 & " , " & n1)
        ElseIf n3 < n1 And n3 < n2 And n1 < n2 Then
            MsgBox("A ordem dos números é: " & n3 & " , " & n1 & " , " & n2)



        End If

    End Sub

End Class
