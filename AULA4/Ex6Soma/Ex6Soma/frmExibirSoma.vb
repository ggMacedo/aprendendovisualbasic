Public Class frmExibirSoma

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim n1 As Integer = CInt(txtNu1.Text)
        Dim n2 As Integer = CInt(txtNu2.Text)
        Dim t As Integer
        Dim msg As String = ""

            For i As Integer = n1 To n2
            t += i
            msg += (i & "+")

            Next
       
        MsgBox(msg & " = " & t)

    End Sub
End Class
