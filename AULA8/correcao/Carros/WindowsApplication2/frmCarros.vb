Public Class frmCarros
    Private precob As Double
    Private precoa As Double
    Private precot As Double

    Private Sub frmCarros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMarca.Items.Add("Fiat")
        cmbMarca.Items.Add("GM")
        cmbMarca.Items.Add("Volkswagen")

        cmbCor.Items.Add("Branco")
        cmbCor.Items.Add("Preto")
        cmbCor.Items.Add("Prata")
    End Sub

    Private Sub cmbMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMarca.SelectedIndexChanged
        cmbModelo.Items.Clear()
        If cmbMarca.Text = "Fiat" Then
            cmbModelo.Items.Add("Uno")
            cmbModelo.Items.Add("Mobi")
            cmbModelo.Items.Add("Bravo")
        ElseIf cmbMarca.Text = "GM" Then
            cmbModelo.Items.Add("Cobalt")
            cmbModelo.Items.Add("Cruze")
            cmbModelo.Items.Add("Jay")
        ElseIf cmbMarca.Text = "Volkswagen" Then
            cmbModelo.Items.Add("Amarok")
            cmbModelo.Items.Add("Jetta")
            cmbModelo.Items.Add("Space")
        End If
    End Sub

    Private Sub cmbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModelo.SelectedIndexChanged, cmbCor.SelectedIndexChanged
        If cmbModelo.SelectedIndex > -1 And cmbCor.SelectedIndex > -1 Then
            pctCarro.Image = New Bitmap(Application.StartupPath + "\Carros\" + cmbModelo.Text + cmbCor.Text + ".jpg")
        End If
        precoBase()
    End Sub

    Private Sub precoBase()
        If cmbModelo.Text = "Uno" Then
            precob = 25000
        ElseIf cmbModelo.Text = "Mobi" Then
            precob = 20000
        ElseIf cmbModelo.Text = "Bravo" Then
            precob = 40000
        ElseIf cmbModelo.Text = "Cobalt" Then
            precob = 50000
        ElseIf cmbModelo.Text = "Cruze" Then
            precob = 70000
        ElseIf cmbModelo.Text = "Jay" Then
            precob = 55000
        ElseIf cmbModelo.Text = "Amarok" Then
            precob = 80000
        ElseIf cmbModelo.Text = "Jetta" Then
            precob = 65000
        ElseIf cmbModelo.Text = "Space" Then
            precob = 60000
        End If

        txtBase.Text = precob.ToString("R$ ###,###.00")
        precot = precoa + precob
        txtTotal.Text = precot.ToString("R$ ###,###.00")
    End Sub

    Private Sub CalculaAdicionais()
        precoa = 0
        If numPortas.Value = 4 Then
            precoa += 5000
        End If

        If chkBanco.Checked Then
            precoa += 1500
        End If

        If chkAbs.Checked Then
            precoa += 2000
        End If

        If chkAirBag.Checked Then
            precoa += 3000
        End If

        If radSimples.Checked Then
            precoa += 500
        ElseIf radCaixa.Checked Then
            precoa += 1500
        End If

        txtAdicional.Text = precoa.ToString("R$ ###,###.00")
        precot = precoa + precob
        txtTotal.Text = precot.ToString("R$ ###,###.00")
    End Sub

    Private Sub numPortas_ValueChanged(sender As Object, e As EventArgs) Handles numPortas.ValueChanged
        CalculaAdicionais()
    End Sub

    Private Sub chkBanco_CheckedChanged(sender As Object, e As EventArgs) Handles chkBanco.CheckedChanged
        CalculaAdicionais()
    End Sub

    Private Sub chkAbs_CheckedChanged(sender As Object, e As EventArgs) Handles chkAbs.CheckedChanged
        CalculaAdicionais()
    End Sub

    Private Sub chkAirBag_CheckedChanged(sender As Object, e As EventArgs) Handles chkAirBag.CheckedChanged
        CalculaAdicionais()
    End Sub

    Private Sub radNenhum_CheckedChanged(sender As Object, e As EventArgs) Handles radNenhum.CheckedChanged
        CalculaAdicionais()
    End Sub

    Private Sub radSimples_CheckedChanged(sender As Object, e As EventArgs) Handles radSimples.CheckedChanged
        CalculaAdicionais()
    End Sub

    Private Sub radCaixa_CheckedChanged(sender As Object, e As EventArgs) Handles radCaixa.CheckedChanged
        CalculaAdicionais()
    End Sub

End Class
