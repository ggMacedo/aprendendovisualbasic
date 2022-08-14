Public Class frmConta

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim c As String = txtConta.Text
        Dim sinal As String = ""
        Dim n1 As String = ""
        Dim n2 As String = ""
        Dim result As Integer
        'For i As Integer = 0 To c.Length - 1
        '    If c.Substring(i, 1) = "+" Or c.Substring(i, 1) = "-" Or c.Substring(i, 1) = "*" Or c.Substring(i, 1) = "/" Then
        '        sinal = c.Substring(i, 1)
        '        n1 = c.Substring(0, i)
        '        n2 = c.Substring(i + 1, c.Length - (i + 1))
        '        Exit For
        '    End If
        'Next
        For i As Integer = 0 To c.Length - 1
            If c.Substring(i, 1) = "+" Or c.Substring(i, 1) = "-" Or c.Substring(i, 1) = "*" Or c.Substring(i, 1) = "/" Then
                sinal = c.Substring(i, 1)
            ElseIf sinal = "" Then
                n1 = n1 & c.Substring(i, 1)
            Else
                n2 = n2 & c.Substring(i, 1)
            End If
        Next
        If sinal = "+" Then
            result = CInt(n1) + CInt(n2)
        ElseIf sinal = "-" Then
            result = CInt(n1) - CInt(n2)
        ElseIf sinal = "*" Then
            result = CInt(n1) * CInt(n2)
        ElseIf sinal = "/" Then
            result = CInt(n1) / CInt(n2)
        End If
        MsgBox(result)
    End Sub
End Class
