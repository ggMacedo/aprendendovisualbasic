Public Class frmEx2Tabuada

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim i As Integer
        Dim r As Integer
        Dim t As String

        For i = 1 To 10
            r = i * 5
            t += (i & " X 5 = " & r & vbCrLf)
        Next
        MsgBox(t)
    End Sub
End Class
