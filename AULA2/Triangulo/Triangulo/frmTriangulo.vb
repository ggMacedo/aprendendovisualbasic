Public Class frmTriangulo

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim la As Double
        Dim lc As Double
        Dim lb As Double

        la = CDbl(txtA.Text)
        lc = CDbl(txtC.Text)



        lb = Math.Sqrt((lc ^ 2) - (la ^ 2))

        MsgBox("O lado B mede: " & lb)

    End Sub
End Class
