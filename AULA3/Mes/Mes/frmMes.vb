Public Class Form1

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim m As Integer

        m = CInt(txtMes.Text)

        If m = 1 Then
            MsgBox("Janeiro.")
        ElseIf m = 2 Then
            MsgBox("Fevereiro.")
        ElseIf m = 3 Then
            MsgBox("Março.")
        ElseIf m = 4 Then
            MsgBox("Abril.")
        ElseIf m = 5 Then
            MsgBox("Maio.")
        ElseIf m = 6 Then
            MsgBox("Junho.")
        ElseIf m = 7 Then
            MsgBox("Julho.")
        ElseIf m = 8 Then
            MsgBox("Agosto.")
        ElseIf m = 9 Then
            MsgBox("Setembro.")
        ElseIf m = 10 Then
            MsgBox("Outubro.")
        ElseIf m = 11 Then
            MsgBox("Novembro.")
        ElseIf m = 12 Then
            MsgBox("Dezembro.")
        Else
            MsgBox("Este mês não existe.")

        End If
    End Sub
End Class
