Public Class frmConversor

    Private Sub btnConverter_Click(sender As Object, e As EventArgs) Handles btnConverter.Click
        Dim n1 As Double
        Dim dolar As Double
        Dim libras As Double


        n1 = CDbl(txtValor1.Text)
        dolar = n1 / 3.24
        libras = n1 / 4.52

        txtDo.Text = dolar
        txtLi.Text = libras

    End Sub
    
End Class
