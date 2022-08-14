Public Class frmEx1Tabuada

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim i As Integer
        Dim r As Integer

        For i = 1 To 10
            r = i * 5
            MsgBox(i & " X 5 = " & r)

        Next



    End Sub
End Class
