Public Class frmFor

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim msg As String = ""
        Dim n As Integer
        n = CInt(txtNumero.Text)
        For i As Integer = 1 To 10
            msg = msg & n & " x " & i & " = " & (n * i) & vbCrLf
        Next
        MsgBox(msg)
    End Sub
End Class
