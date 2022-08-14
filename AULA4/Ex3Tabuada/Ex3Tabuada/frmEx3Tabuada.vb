Public Class frmEx3Tabuada

    Private Sub btnTabuada_Click(sender As Object, e As EventArgs) Handles btnTabuada.Click
        Dim i As Integer
        Dim r As Integer
        Dim t As String
        Dim n As Integer

        n = CInt(txtNumero.Text)

        For i = 1 To 10
            r = i * n
            t += (i & " X " & n & " = " & r & vbCrLf)
        Next
        MsgBox(t)
    End Sub
End Class
