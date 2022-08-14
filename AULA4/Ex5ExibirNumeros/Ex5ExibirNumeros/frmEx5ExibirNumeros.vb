Public Class frmEx5ExibirNumeros


    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim n1 As Integer = CInt (txtNu1.Text)
        Dim n2 As Integer = CInt(txtNu2.Text)
        Dim msg As String = ""

        If n1 < n2 Then
            For i As Integer = n1 To n2
                msg = msg & i & vbCrLf
            Next
        Else
            For i As Integer = n1 To n2 Step -1
                msg = msg & i & vbCrLf
            Next
        End If

        MsgBox(msg)


    End Sub
End Class
