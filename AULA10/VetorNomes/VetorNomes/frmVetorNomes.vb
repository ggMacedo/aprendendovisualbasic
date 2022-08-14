Public Class frmVetorNomes
    Private nomes() As String
    Dim i As Integer
    Dim p As Integer

    Private Sub frmVetorNomes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ReDim nomes(9)

    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click

        If txtNome.Text = vbNullString Then
            MsgBox("Digite um nome na caixa de texto.")

        ElseIf i >= 0 And i <= 9 Then
            nomes(i) = txtNome.Text
            p = i
            i = i + 1

        ElseIf i > 9 Then
            MsgBox("Máximo de cadastros possível atingido.")

        End If

    End Sub

    Private Sub btnAvancar_Click(sender As Object, e As EventArgs) Handles btnAvancar.Click

        If p = 10 Then
            p = p - 1

        End If

        If p >= 0 And p < i - 1 Then
            p = p + 1
            txtNome.Text = nomes(p)

        End If

    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click

        If p > 0 And p <= 9 Then
            p = p - 1
            txtNome.Text = nomes(p)

        End If

    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click

        If p > 0 And p <= 9 Then
            p = 0
            txtNome.Text = nomes(p)

        End If

    End Sub

    Private Sub btnFinal_Click(sender As Object, e As EventArgs) Handles btnFinal.Click

        If p >= 0 And p < i - 1 Then
            p = i - 1
            txtNome.Text = nomes(p)

        End If

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        If txtNome.Text = vbNullString Then
            MsgBox("Digite um nome na caixa de texto.")

        Else
            nomes(p) = txtNome.Text

        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        If txtNome.Text = vbNullString Then
            MsgBox("Digite um nome na caixa de texto.")

        End If

        For j = p + 1 To i - 1 Step 1
            nomes(j - 1) = nomes(j)
        Next
        i = i - 1

        If i <= p Then
            p = i - 1

        End If

        If p >= 0 Then
            txtNome.Text = nomes(p)

        Else
            txtNome.Text = ""

        End If

    End Sub
End Class
