Public Class Form1

    Private Sub btnAbrir_Click(sender As Object, e As EventArgs) Handles btnAbrir.Click
        Form2.ShowDialog()
        If Form2.DialogResult = Windows.Forms.DialogResult.OK Then
            Label1.Text = Form2.TextBox1.Text
        Else
            MsgBox("cancelou")
        End If

    End Sub
End Class
