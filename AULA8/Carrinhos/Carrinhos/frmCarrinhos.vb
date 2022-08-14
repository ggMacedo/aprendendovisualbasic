Public Class frmCarrinhos
    Dim base As Double
    Dim adicional As Double
    Dim total As Double
    Dim banco As Double
    Dim abs As Double
    Dim air As Double
    Dim nenhum As Double
    Dim simples As Double
    Dim caixa As Double

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
        If cmbMarca.SelectedIndex >= 0 Then

            If cmbMarca.SelectedIndex = 0 Then
                cmbModelo.Items.Clear()
                cmbModelo.Items.Add("italia")
                cmbModelo.Items.Add("california")
                cmbModelo.Items.Add("f12")

            ElseIf cmbMarca.SelectedIndex = 1 Then
                cmbModelo.Items.Clear()
                cmbModelo.Items.Add("aventador")
                cmbModelo.Items.Add("urus")
                cmbModelo.Items.Add("veneno")

            ElseIf cmbMarca.SelectedIndex = 2 Then
                cmbModelo.Items.Clear()
                cmbModelo.Items.Add("650S")
                cmbModelo.Items.Add("f1")
                cmbModelo.Items.Add("p1")

            End If

        End If
    End Sub

    Private Sub cmbCor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCor.SelectedIndexChanged

        pcbCarro.Image = New Bitmap(Application.StartupPath & "\Carros\" & cmbModelo.Text & cmbCor.Text & ".jpg")

    End Sub

    Private Sub cmbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModelo.SelectedIndexChanged
       
        If cmbMarca.SelectedIndex = 0 Then

            If cmbModelo.SelectedIndex = 0 Then
                base = 10000
                txtBase.Text = nenhum
                txtTotal.Text = base.ToString("R$ ###,###.00") + adicional + banco + abs + air + nenhum
                txtBase.Text = base.ToString("R$ ###,###.00")
          

            ElseIf cmbModelo.SelectedIndex = 1 Then
                base = 20000
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            ElseIf cmbModelo.SelectedIndex = 2 Then
                base = 30000
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            End If

        ElseIf cmbMarca.SelectedIndex = 1 Then

            If cmbModelo.SelectedIndex = 0 Then
                base = 40
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            ElseIf cmbModelo.SelectedIndex = 1 Then
                base = 700
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            ElseIf cmbModelo.SelectedIndex = 2 Then
                base = 2
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            End If

        ElseIf cmbMarca.SelectedIndex = 2 Then

            If cmbModelo.SelectedIndex = 0 Then
                base = 4000000
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            ElseIf cmbModelo.SelectedIndex = 1 Then
                base = 2000000
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            ElseIf cmbModelo.SelectedIndex = 2 Then
                base = 8000000
                txtBase.Text = 0
                txtTotal.Text = base + adicional + banco + abs + air + nenhum
                txtBase.Text = base

            End If
            
        End If

        If cmbCor.SelectedIndex = 0 Then
            pcbCarro.Image = New Bitmap(Application.StartupPath & "\Carros\" & cmbModelo.Text & cmbCor.Text & ".jpg")

        ElseIf cmbCor.SelectedIndex = 1 Then
            pcbCarro.Image = New Bitmap(Application.StartupPath & "\Carros\" & cmbModelo.Text & cmbCor.Text & ".jpg")

        ElseIf cmbCor.SelectedIndex = 2 Then
            pcbCarro.Image = New Bitmap(Application.StartupPath & "\Carros\" & cmbModelo.Text & cmbCor.Text & ".jpg")
        End If



    End Sub

    Private Sub nupPortas_ValueChanged(sender As Object, e As EventArgs) Handles nupPortas.ValueChanged

        If nupPortas.Value = 2 Then
            adicional = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = base + adicional + banco + abs + air + nenhum + simples + caixa

        ElseIf nupPortas.Value = 4 Then
            adicional = 6000
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtBase.Text = base
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa
        End If

    End Sub

    Private Sub chkBancos_CheckedChanged(sender As Object, e As EventArgs) Handles chkBancos.CheckedChanged

        If chkBancos.Checked Then
            txtBase.Text = base
            banco = 1500
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa

        Else

            banco = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = base + adicional + banco + abs + air + nenhum + simples + caixa

        End If
    End Sub

    Private Sub chkAbs_CheckedChanged(sender As Object, e As EventArgs) Handles chkAbs.CheckedChanged
        If chkAbs.Checked Then
            txtBase.Text = base
            abs = 2000
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa

        Else

            abs = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = base + adicional + banco + abs + air + nenhum + simples + caixa

        End If
    End Sub

    Private Sub chkAirBaq_CheckedChanged(sender As Object, e As EventArgs) Handles chkAirBaq.CheckedChanged

        If chkAirBaq.Checked Then
            txtBase.Text = base
            air = 3000
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa

        Else

            air = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = base + adicional + banco + abs + air + nenhum + simples + caixa

        End If
    End Sub

    Private Sub rdbNenhum_CheckedChanged(sender As Object, e As EventArgs) Handles rdbNenhum.CheckedChanged

        If rdbNenhum.Checked Then
            txtBase.Text = base
            nenhum = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa

        End If

    End Sub

    Private Sub rdbSimples_CheckedChanged(sender As Object, e As EventArgs) Handles rdbSimples.CheckedChanged
        If rdbSimples.Checked Then
            txtBase.Text = base
            simples = 500
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa

        Else
            simples = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = base + adicional + banco + abs + air + nenhum + simples + caixa
        End If
    End Sub

    Private Sub rdbCaixa_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCaixa.CheckedChanged
        If rdbCaixa.Checked Then
            txtBase.Text = base
            caixa = 1500
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = txtBase.Text + adicional + banco + abs + air + nenhum + simples + caixa

        Else
            caixa = 0
            txtAdicional.Text = adicional + banco + abs + air + nenhum + simples + caixa
            txtTotal.Text = base + adicional + banco + abs + air + nenhum + simples + caixa
        End If
    End Sub
End Class
