Public Class frmSOMA

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim Numpri As Integer
        Dim Numseg As Integer
        Dim total As Integer

        Numpri = CInt(txtNumpri.Text)
        Numseg = CInt(txtNumseg.Text)
        total = Numpri + Numseg

        MsgBox("O total da soma é: " & total)

    End Sub
End Class
