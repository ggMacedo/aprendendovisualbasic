Public Class frmForNum

    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim msg As String = ""
        Dim n1 As Integer = CInt(txtPNum.Text)
        Dim n2 As Integer = CInt(txtSNum.Text)
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
