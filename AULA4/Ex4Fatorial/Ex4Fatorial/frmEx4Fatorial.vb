Public Class frmEx4Fatorial

    Private Sub btnFatorial_Click(sender As Object, e As EventArgs) Handles btnFatorial.Click
        Dim i As Integer
        Dim r As Integer
        Dim t As Double
      
        i = CInt(txtNumero.Text)
        r = 1

        For t = i To 1 Step -1
            r *= t
        Next
        MsgBox(i & "! = " & r)
    End Sub
End Class
