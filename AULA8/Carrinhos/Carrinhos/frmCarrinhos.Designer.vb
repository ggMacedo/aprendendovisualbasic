<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarrinhos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.cmbCor = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.nupPortas = New System.Windows.Forms.NumericUpDown()
        Me.lblPortas = New System.Windows.Forms.Label()
        Me.chkBancos = New System.Windows.Forms.CheckBox()
        Me.chkAbs = New System.Windows.Forms.CheckBox()
        Me.chkAirBaq = New System.Windows.Forms.CheckBox()
        Me.grpSom = New System.Windows.Forms.GroupBox()
        Me.rdbCaixa = New System.Windows.Forms.RadioButton()
        Me.rdbSimples = New System.Windows.Forms.RadioButton()
        Me.rdbNenhum = New System.Windows.Forms.RadioButton()
        Me.pcbCarro = New System.Windows.Forms.PictureBox()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblAdicional = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAdicional = New System.Windows.Forms.TextBox()
        CType(Me.nupPortas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSom.SuspendLayout()
        CType(Me.pcbCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Items.AddRange(New Object() {"Ferrari", "Lamborghini", "McLaren"})
        Me.cmbMarca.Location = New System.Drawing.Point(12, 24)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(121, 21)
        Me.cmbMarca.TabIndex = 1
        '
        'cmbModelo
        '
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(12, 83)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(121, 21)
        Me.cmbModelo.TabIndex = 2
        '
        'cmbCor
        '
        Me.cmbCor.FormattingEnabled = True
        Me.cmbCor.Items.AddRange(New Object() {"Branca", "Prata", "Vermelha"})
        Me.cmbCor.Location = New System.Drawing.Point(12, 145)
        Me.cmbCor.Name = "cmbCor"
        Me.cmbCor.Size = New System.Drawing.Size(121, 21)
        Me.cmbCor.TabIndex = 3
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(12, 9)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 13)
        Me.lblMarca.TabIndex = 3
        Me.lblMarca.Text = "Marca:"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(13, 67)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(45, 13)
        Me.lblModelo.TabIndex = 4
        Me.lblModelo.Text = "Modelo:"
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Location = New System.Drawing.Point(13, 129)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(26, 13)
        Me.lblCor.TabIndex = 5
        Me.lblCor.Text = "Cor:"
        '
        'nupPortas
        '
        Me.nupPortas.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nupPortas.Location = New System.Drawing.Point(12, 193)
        Me.nupPortas.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nupPortas.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.nupPortas.Name = "nupPortas"
        Me.nupPortas.Size = New System.Drawing.Size(121, 20)
        Me.nupPortas.TabIndex = 4
        Me.nupPortas.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblPortas
        '
        Me.lblPortas.AutoSize = True
        Me.lblPortas.Location = New System.Drawing.Point(9, 177)
        Me.lblPortas.Name = "lblPortas"
        Me.lblPortas.Size = New System.Drawing.Size(55, 13)
        Me.lblPortas.TabIndex = 7
        Me.lblPortas.Text = "N° Portas:"
        '
        'chkBancos
        '
        Me.chkBancos.AutoSize = True
        Me.chkBancos.Location = New System.Drawing.Point(12, 229)
        Me.chkBancos.Name = "chkBancos"
        Me.chkBancos.Size = New System.Drawing.Size(178, 17)
        Me.chkBancos.TabIndex = 5
        Me.chkBancos.Text = "Bancos de couro(+R$ 1.500,00)"
        Me.chkBancos.UseVisualStyleBackColor = True
        '
        'chkAbs
        '
        Me.chkAbs.AutoSize = True
        Me.chkAbs.Location = New System.Drawing.Point(12, 250)
        Me.chkAbs.Name = "chkAbs"
        Me.chkAbs.Size = New System.Drawing.Size(112, 17)
        Me.chkAbs.TabIndex = 6
        Me.chkAbs.Text = "Abs(+R$2.000,00)"
        Me.chkAbs.UseVisualStyleBackColor = True
        '
        'chkAirBaq
        '
        Me.chkAirBaq.AutoSize = True
        Me.chkAirBaq.Location = New System.Drawing.Point(12, 273)
        Me.chkAirBaq.Name = "chkAirBaq"
        Me.chkAirBaq.Size = New System.Drawing.Size(128, 17)
        Me.chkAirBaq.TabIndex = 7
        Me.chkAirBaq.Text = "Air Bag(+R$3.000,00)"
        Me.chkAirBaq.UseVisualStyleBackColor = True
        '
        'grpSom
        '
        Me.grpSom.Controls.Add(Me.rdbCaixa)
        Me.grpSom.Controls.Add(Me.rdbSimples)
        Me.grpSom.Controls.Add(Me.rdbNenhum)
        Me.grpSom.Location = New System.Drawing.Point(12, 305)
        Me.grpSom.Name = "grpSom"
        Me.grpSom.Size = New System.Drawing.Size(200, 100)
        Me.grpSom.TabIndex = 8
        Me.grpSom.TabStop = False
        Me.grpSom.Text = "Som"
        '
        'rdbCaixa
        '
        Me.rdbCaixa.AutoSize = True
        Me.rdbCaixa.Location = New System.Drawing.Point(6, 77)
        Me.rdbCaixa.Name = "rdbCaixa"
        Me.rdbCaixa.Size = New System.Drawing.Size(155, 17)
        Me.rdbCaixa.TabIndex = 10
        Me.rdbCaixa.TabStop = True
        Me.rdbCaixa.Text = "Caixa Selada(+R$1.500,00)"
        Me.rdbCaixa.UseVisualStyleBackColor = True
        '
        'rdbSimples
        '
        Me.rdbSimples.AutoSize = True
        Me.rdbSimples.Location = New System.Drawing.Point(6, 54)
        Me.rdbSimples.Name = "rdbSimples"
        Me.rdbSimples.Size = New System.Drawing.Size(120, 17)
        Me.rdbSimples.TabIndex = 9
        Me.rdbSimples.TabStop = True
        Me.rdbSimples.Text = "Simples(+R$500,00)"
        Me.rdbSimples.UseVisualStyleBackColor = True
        '
        'rdbNenhum
        '
        Me.rdbNenhum.AutoSize = True
        Me.rdbNenhum.Location = New System.Drawing.Point(3, 31)
        Me.rdbNenhum.Name = "rdbNenhum"
        Me.rdbNenhum.Size = New System.Drawing.Size(65, 17)
        Me.rdbNenhum.TabIndex = 8
        Me.rdbNenhum.TabStop = True
        Me.rdbNenhum.Text = "Nenhum"
        Me.rdbNenhum.UseVisualStyleBackColor = True
        '
        'pcbCarro
        '
        Me.pcbCarro.Location = New System.Drawing.Point(204, 24)
        Me.pcbCarro.Name = "pcbCarro"
        Me.pcbCarro.Size = New System.Drawing.Size(271, 142)
        Me.pcbCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbCarro.TabIndex = 12
        Me.pcbCarro.TabStop = False
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(267, 209)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(34, 13)
        Me.lblBase.TabIndex = 13
        Me.lblBase.Text = "Base:"
        '
        'lblAdicional
        '
        Me.lblAdicional.AutoSize = True
        Me.lblAdicional.Location = New System.Drawing.Point(267, 257)
        Me.lblAdicional.Name = "lblAdicional"
        Me.lblAdicional.Size = New System.Drawing.Size(53, 13)
        Me.lblAdicional.TabIndex = 14
        Me.lblAdicional.Text = "Adicional:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(267, 305)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 15
        Me.lblTotal.Text = "Total:"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(326, 209)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.ReadOnly = True
        Me.txtBase.Size = New System.Drawing.Size(100, 20)
        Me.txtBase.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(326, 305)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 11
        '
        'txtAdicional
        '
        Me.txtAdicional.Location = New System.Drawing.Point(326, 257)
        Me.txtAdicional.Name = "txtAdicional"
        Me.txtAdicional.ReadOnly = True
        Me.txtAdicional.Size = New System.Drawing.Size(100, 20)
        Me.txtAdicional.TabIndex = 10
        '
        'frmCarrinhos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 434)
        Me.Controls.Add(Me.txtAdicional)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblAdicional)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.pcbCarro)
        Me.Controls.Add(Me.grpSom)
        Me.Controls.Add(Me.chkAirBaq)
        Me.Controls.Add(Me.chkAbs)
        Me.Controls.Add(Me.chkBancos)
        Me.Controls.Add(Me.lblPortas)
        Me.Controls.Add(Me.nupPortas)
        Me.Controls.Add(Me.lblCor)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.cmbCor)
        Me.Controls.Add(Me.cmbModelo)
        Me.Controls.Add(Me.cmbMarca)
        Me.Name = "frmCarrinhos"
        Me.Text = "Carrinhos"
        CType(Me.nupPortas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSom.ResumeLayout(False)
        Me.grpSom.PerformLayout()
        CType(Me.pcbCarro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Friend WithEvents cmbModelo As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCor As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblCor As System.Windows.Forms.Label
    Friend WithEvents nupPortas As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblPortas As System.Windows.Forms.Label
    Friend WithEvents chkBancos As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbs As System.Windows.Forms.CheckBox
    Friend WithEvents chkAirBaq As System.Windows.Forms.CheckBox
    Friend WithEvents grpSom As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCaixa As System.Windows.Forms.RadioButton
    Friend WithEvents rdbSimples As System.Windows.Forms.RadioButton
    Friend WithEvents rdbNenhum As System.Windows.Forms.RadioButton
    Friend WithEvents pcbCarro As System.Windows.Forms.PictureBox
    Friend WithEvents lblBase As System.Windows.Forms.Label
    Friend WithEvents lblAdicional As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtBase As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtAdicional As System.Windows.Forms.TextBox

End Class
