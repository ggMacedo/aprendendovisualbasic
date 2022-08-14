Public Class frmNomes
    Private Sub btnAdicionar_Click(sender As Object, e As EventArgs) Handles btnAdicionar.Click
        lbxLista1.Items.Add(txtNome.Text)

    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        If lbxLista1.SelectedIndex >= 0 Then
            lbxLista2.Items.Add(lbxLista1.Text)
            lbxLista1.Items.RemoveAt(lbxLista1.SelectedIndex)
        Else
            MsgBox("Não existe índice selecionado")

        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If lbxLista2.SelectedIndex >= 0 Then
            lbxLista1.Items.Add(lbxLista2.Text)
            lbxLista2.Items.RemoveAt(lbxLista2.SelectedIndex)
        Else
            MsgBox("Não existe índice selecionado")
        End If

    End Sub

    Private Sub btnProximoPlus_Click(sender As Object, e As EventArgs) Handles btnProximoPlus.Click
        If lbxLista1.SelectedIndex >= 0 Then
            lbxLista3.Items.Add(lbxLista1.Text)
            lbxLista1.Items.RemoveAt(lbxLista1.SelectedIndex)
        Else
            MsgBox("Não existe índice selecionado")
        End If

    End Sub

    Private Sub btnProximo2_Click(sender As Object, e As EventArgs) Handles btnProximo2.Click
        If lbxLista2.SelectedIndex >= 0 Then
            lbxLista3.Items.Add(lbxLista2.Text)
            lbxLista2.Items.RemoveAt(lbxLista2.SelectedIndex)
        Else
            MsgBox("Não existe índice selecionado")
        End If

    End Sub

    Private Sub btnAnterior2_Click(sender As Object, e As EventArgs) Handles btnAnterior2.Click
        If lbxLista3.SelectedIndex >= 0 Then
            lbxLista2.Items.Add(lbxLista3.Text)
            lbxLista3.Items.RemoveAt(lbxLista3.SelectedIndex)
        Else
            MsgBox("Não existe índice selecionado")
        End If

    End Sub

    Private Sub btnAnteriorPlus_Click(sender As Object, e As EventArgs) Handles btnAnteriorPlus.Click
        If lbxLista3.SelectedIndex >= 0 Then
            lbxLista1.Items.Add(lbxLista3.Text)
            lbxLista3.Items.RemoveAt(lbxLista3.SelectedIndex)
        Else
            MsgBox("Não existe índice selecionado")
        End If
    End Sub
End Class
