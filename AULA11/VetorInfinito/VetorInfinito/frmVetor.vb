Public Class frmVetor
    Private nomes() As String
    Private i As Integer

    Private Sub frmVetor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim nomes(-1)
    End Sub

    Private Sub btnIncluir_Click(sender As Object, e As EventArgs) Handles btnIncluir.Click
        If txtNome.Text = vbNullString Then
            MsgBox("Digite um nome na caixa de texto.")
        Else
            ReDim Preserve nomes(nomes.Length)
            nomes(nomes.Length - 1) = txtNome.Text
            i = nomes.Length - 1
        End If

    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        If i > 0 Then
            i = i - 1
            txtNome.Text = nomes(i)
        End If
    End Sub

    Private Sub btnProximo_Click(sender As Object, e As EventArgs) Handles btnProximo.Click
        
        If i < nomes.Length - 1 Then
            i = i + 1
            txtNome.Text = nomes(i)

        End If
    End Sub

    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        If i > 0 Then
            i = 0
            txtNome.Text = nomes(i)

        End If
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        If i < nomes.Length - 1 Then
            i = nomes.Length - 1
            txtNome.Text = nomes(i)

        End If
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtNome.Text = vbNullString Then
            MsgBox("Digite um nome na caixa de texto.")
        Else
            nomes(i) = txtNome.Text
        End If

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If nomes.Length > 0 Then
            For j As Integer = i To nomes.Length - 2
                nomes(j) = nomes(j + 1)
            Next
            ReDim Preserve nomes(nomes.Length - 2)
            If i = nomes.Length Then
                i = i - 1
            End If
            If i >= 0 Then
                txtNome.Text = nomes(i)
            Else
                txtNome.Text = ""
            End If
        Else
            MsgBox("O vetor está vazio!")
        End If
    End Sub
End Class
