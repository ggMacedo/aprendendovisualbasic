Public Class frmContaInteira
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim nu As String = txtNumero.Text
        Dim i As Integer
        Dim t As Integer
        Dim cont1 As String = ""
        Dim cont2 As String = ""
        Dim sin As String = ""
        Dim dig As String = ""

        t = nu.Length - 1

        For i = 0 To t Step 1
            dig = nu.Substring(i, 1)

            If dig = "+" Or dig = "-" Or dig = "*" Or dig = "/" Then
                sin &= dig

            ElseIf sin = "" Then
                cont1 &= dig

            Else
                cont2 &= dig

            End If

        Next

        If sin = "+" Then
            MsgBox(CDbl(cont1) + CDbl(cont2))

        ElseIf sin = "-" Then
            MsgBox(CDbl(cont1) - CDbl(cont2))

        ElseIf sin = "*" Then
            MsgBox(CDbl(cont1) * CDbl(cont2))

        ElseIf sin = "/" Then
            MsgBox(CDbl(cont1) / CDbl(cont2))

        Else
            MsgBox("Digite um sinal válido:" & vbCrLf & "+ para soma" & vbCrLf & "- para subtração" & vbCrLf & "* para multiplicação" & vbCrLf & "/ para divisão")

        End If
    End Sub
End Class
