Public Class frmContinentes

    Private Sub cmbContinente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbContinente.SelectedIndexChanged
        If cmbContinente.SelectedIndex >= 0 Then

            If cmbContinente.SelectedIndex = 0 Then
                cmbPaises.Items.Clear()
                cmbPaises.Items.Add("África do Sul")
                cmbPaises.Items.Add("Egito")
                cmbPaises.Items.Add("Moçambique")

            ElseIf cmbContinente.SelectedIndex = 1 Then
                cmbPaises.Items.Clear()
                cmbPaises.Items.Add("Japão")
                cmbPaises.Items.Add("China")
                cmbPaises.Items.Add("Coreia do Norte")

            ElseIf cmbContinente.SelectedIndex = 2 Then
                cmbPaises.Items.Clear()
                cmbPaises.Items.Add("Brasil")
                cmbPaises.Items.Add("Estados Unidos")
                cmbPaises.Items.Add("México")

            ElseIf cmbContinente.SelectedIndex = 3 Then
                cmbPaises.Items.Clear()
                cmbPaises.Items.Add("França")
                cmbPaises.Items.Add("Alemanha")
                cmbPaises.Items.Add("Inglaterra")

            ElseIf cmbContinente.SelectedIndex = 4 Then
                cmbPaises.Items.Clear()
                cmbPaises.Items.Add("Australia")
                cmbPaises.Items.Add("Fiji")
                cmbPaises.Items.Add("Palau")
            End If

        End If

    End Sub

    Private Sub cmbPaises_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaises.SelectedIndexChanged

        If cmbContinente.SelectedIndex = 0 Then
            If cmbPaises.SelectedIndex = 0 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Africa\africaSouth.jpg")

            ElseIf cmbPaises.SelectedIndex = 1 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Africa\egyto.jpg")

            ElseIf cmbPaises.SelectedIndex = 2 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Africa\mocambique.jpg")

            End If

        End If

        If cmbContinente.SelectedIndex = 1 Then
            If cmbPaises.SelectedIndex = 0 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Asia\japan.jpg")

            ElseIf cmbPaises.SelectedIndex = 1 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Asia\china.jpg")

            ElseIf cmbPaises.SelectedIndex = 2 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Asia\coreiaNorte.jpg")

            End If

        End If

        If cmbContinente.SelectedIndex = 2 Then
            If cmbPaises.SelectedIndex = 0 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\America\brazil.jpg")

            ElseIf cmbPaises.SelectedIndex = 1 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\America\eua.jpg")

            ElseIf cmbPaises.SelectedIndex = 2 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\America\mexico.jpg")

            End If

        End If

        If cmbContinente.SelectedIndex = 3 Then
            If cmbPaises.SelectedIndex = 0 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Europa\franca.jpg")

            ElseIf cmbPaises.SelectedIndex = 1 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Europa\alemanha.jpg")

            ElseIf cmbPaises.SelectedIndex = 2 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Europa\ingleter.jpg")

            End If

        End If

        If cmbContinente.SelectedIndex = 4 Then
            If cmbPaises.SelectedIndex = 0 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Oceania\australia.jpg")

            ElseIf cmbPaises.SelectedIndex = 1 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Oceania\Fiji.jpg")

            ElseIf cmbPaises.SelectedIndex = 2 Then
                pcbBandeira.Image = New Bitmap("C:\Users\gabri\OneDrive\Área de Trabalho\ETEC\Módulo 2\Desenvolvimento de Software 1\AULA7\Continentes\Imgens\Oceania\palau.jpg")

            End If

        End If

    End Sub

End Class
