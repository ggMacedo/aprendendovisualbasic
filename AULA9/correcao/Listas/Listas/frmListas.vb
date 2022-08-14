Public Class frmListas

    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        list1.Items.Add(txtNome.Text)
    End Sub

    Private Sub EnviaValor(listaOrigem As ListBox, listaDestino As ListBox)
        If listaOrigem.SelectedIndex > -1 Then
            listaDestino.Items.Add(listaOrigem.Text)
            listaOrigem.Items.RemoveAt(listaOrigem.SelectedIndex)
        Else
            MsgBox("Selecione um item!")
        End If
    End Sub

    Private Sub btn1p2_Click(sender As Object, e As EventArgs) Handles btn1p2.Click
        EnviaValor(list1, list2)
    End Sub

    Private Sub btn2p1_Click(sender As Object, e As EventArgs) Handles btn2p1.Click
        EnviaValor(list2, list1)
    End Sub

    Private Sub btn1p3_Click(sender As Object, e As EventArgs) Handles btn1p3.Click
        EnviaValor(list1, list3)
    End Sub

    Private Sub btn2p3_Click(sender As Object, e As EventArgs) Handles btn2p3.Click
        EnviaValor(list2, list3)
    End Sub

    Private Sub btn3p2_Click(sender As Object, e As EventArgs) Handles btn3p2.Click
        EnviaValor(list3, list2)
    End Sub

    Private Sub btn3p1_Click(sender As Object, e As EventArgs) Handles btn3p1.Click
        EnviaValor(list3, list1)
    End Sub
End Class
