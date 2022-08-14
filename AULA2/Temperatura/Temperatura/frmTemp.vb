Public Class frmTemp

    Private Sub btnConverter_Click(sender As Object, e As EventArgs) Handles btnConverter.Click
        Dim n1 As Double
        Dim f As Double
        Dim k As Double

        n1 = CDbl(txtTempC.Text)
        
        f = (n1 * 1.8) + 32
        k = n1 + 273

        txtTempF.Text = f
        txtTempK.Text = k

    End Sub
End Class
