<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarros
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
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtAdicional = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblAdicional = New System.Windows.Forms.Label()
        Me.lblBase = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.radCaixa = New System.Windows.Forms.RadioButton()
        Me.radSimples = New System.Windows.Forms.RadioButton()
        Me.radNenhum = New System.Windows.Forms.RadioButton()
        Me.chkAirBag = New System.Windows.Forms.CheckBox()
        Me.chkAbs = New System.Windows.Forms.CheckBox()
        Me.chkBanco = New System.Windows.Forms.CheckBox()
        Me.numPortas = New System.Windows.Forms.NumericUpDown()
        Me.lblNumPortas = New System.Windows.Forms.Label()
        Me.pctCarro = New System.Windows.Forms.PictureBox()
        Me.cmbCor = New System.Windows.Forms.ComboBox()
        Me.lblCor = New System.Windows.Forms.Label()
        Me.cmbModelo = New System.Windows.Forms.ComboBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.cmbMarca = New System.Windows.Forms.ComboBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.groupBox1.SuspendLayout()
        CType(Me.numPortas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCarro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(323, 246)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(148, 20)
        Me.txtTotal.TabIndex = 37
        '
        'txtAdicional
        '
        Me.txtAdicional.Enabled = False
        Me.txtAdicional.Location = New System.Drawing.Point(323, 222)
        Me.txtAdicional.Name = "txtAdicional"
        Me.txtAdicional.Size = New System.Drawing.Size(148, 20)
        Me.txtAdicional.TabIndex = 36
        '
        'txtBase
        '
        Me.txtBase.Enabled = False
        Me.txtBase.Location = New System.Drawing.Point(323, 195)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(148, 20)
        Me.txtBase.TabIndex = 35
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(264, 246)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 34
        Me.lblTotal.Text = "Total:"
        '
        'lblAdicional
        '
        Me.lblAdicional.AutoSize = True
        Me.lblAdicional.Location = New System.Drawing.Point(261, 222)
        Me.lblAdicional.Name = "lblAdicional"
        Me.lblAdicional.Size = New System.Drawing.Size(53, 13)
        Me.lblAdicional.TabIndex = 33
        Me.lblAdicional.Text = "Adicional:"
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Location = New System.Drawing.Point(261, 198)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(34, 13)
        Me.lblBase.TabIndex = 32
        Me.lblBase.Text = "Base:"
        '
        'groupBox1
        '
        Me.groupBox1.Controls.Add(Me.radCaixa)
        Me.groupBox1.Controls.Add(Me.radSimples)
        Me.groupBox1.Controls.Add(Me.radNenhum)
        Me.groupBox1.Location = New System.Drawing.Point(9, 270)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(200, 100)
        Me.groupBox1.TabIndex = 31
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Som"
        '
        'radCaixa
        '
        Me.radCaixa.AutoSize = True
        Me.radCaixa.Location = New System.Drawing.Point(7, 66)
        Me.radCaixa.Name = "radCaixa"
        Me.radCaixa.Size = New System.Drawing.Size(161, 17)
        Me.radCaixa.TabIndex = 2
        Me.radCaixa.TabStop = True
        Me.radCaixa.Text = "Caixa Selada (+R$ 1.500,00)"
        Me.radCaixa.UseVisualStyleBackColor = True
        '
        'radSimples
        '
        Me.radSimples.AutoSize = True
        Me.radSimples.Location = New System.Drawing.Point(7, 43)
        Me.radSimples.Name = "radSimples"
        Me.radSimples.Size = New System.Drawing.Size(126, 17)
        Me.radSimples.TabIndex = 1
        Me.radSimples.TabStop = True
        Me.radSimples.Text = "Simples (+R$ 500,00)"
        Me.radSimples.UseVisualStyleBackColor = True
        '
        'radNenhum
        '
        Me.radNenhum.AutoSize = True
        Me.radNenhum.Location = New System.Drawing.Point(7, 20)
        Me.radNenhum.Name = "radNenhum"
        Me.radNenhum.Size = New System.Drawing.Size(65, 17)
        Me.radNenhum.TabIndex = 0
        Me.radNenhum.TabStop = True
        Me.radNenhum.Text = "Nenhum"
        Me.radNenhum.UseVisualStyleBackColor = True
        '
        'chkAirBag
        '
        Me.chkAirBag.AutoSize = True
        Me.chkAirBag.Location = New System.Drawing.Point(12, 246)
        Me.chkAirBag.Name = "chkAirBag"
        Me.chkAirBag.Size = New System.Drawing.Size(134, 17)
        Me.chkAirBag.TabIndex = 30
        Me.chkAirBag.Text = "Air Bag (+R$ 3.000,00)"
        Me.chkAirBag.UseVisualStyleBackColor = True
        '
        'chkAbs
        '
        Me.chkAbs.AutoSize = True
        Me.chkAbs.Location = New System.Drawing.Point(12, 222)
        Me.chkAbs.Name = "chkAbs"
        Me.chkAbs.Size = New System.Drawing.Size(118, 17)
        Me.chkAbs.TabIndex = 29
        Me.chkAbs.Text = "Abs (+R$ 2.000,00)"
        Me.chkAbs.UseVisualStyleBackColor = True
        '
        'chkBanco
        '
        Me.chkBanco.AutoSize = True
        Me.chkBanco.Location = New System.Drawing.Point(12, 198)
        Me.chkBanco.Name = "chkBanco"
        Me.chkBanco.Size = New System.Drawing.Size(177, 17)
        Me.chkBanco.TabIndex = 28
        Me.chkBanco.Text = "Banco de Couro (+R$ 1.500,00)"
        Me.chkBanco.UseVisualStyleBackColor = True
        '
        'numPortas
        '
        Me.numPortas.Increment = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numPortas.Location = New System.Drawing.Point(12, 161)
        Me.numPortas.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.numPortas.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.numPortas.Name = "numPortas"
        Me.numPortas.Size = New System.Drawing.Size(62, 20)
        Me.numPortas.TabIndex = 27
        Me.numPortas.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'lblNumPortas
        '
        Me.lblNumPortas.AutoSize = True
        Me.lblNumPortas.Location = New System.Drawing.Point(12, 145)
        Me.lblNumPortas.Name = "lblNumPortas"
        Me.lblNumPortas.Size = New System.Drawing.Size(54, 13)
        Me.lblNumPortas.TabIndex = 26
        Me.lblNumPortas.Text = "Nº portas:"
        '
        'pctCarro
        '
        Me.pctCarro.Location = New System.Drawing.Point(261, 27)
        Me.pctCarro.Name = "pctCarro"
        Me.pctCarro.Size = New System.Drawing.Size(210, 111)
        Me.pctCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctCarro.TabIndex = 25
        Me.pctCarro.TabStop = False
        '
        'cmbCor
        '
        Me.cmbCor.FormattingEnabled = True
        Me.cmbCor.Location = New System.Drawing.Point(12, 117)
        Me.cmbCor.Name = "cmbCor"
        Me.cmbCor.Size = New System.Drawing.Size(243, 21)
        Me.cmbCor.TabIndex = 24
        '
        'lblCor
        '
        Me.lblCor.AutoSize = True
        Me.lblCor.Location = New System.Drawing.Point(9, 101)
        Me.lblCor.Name = "lblCor"
        Me.lblCor.Size = New System.Drawing.Size(26, 13)
        Me.lblCor.TabIndex = 23
        Me.lblCor.Text = "Cor:"
        '
        'cmbModelo
        '
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.Location = New System.Drawing.Point(12, 72)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(243, 21)
        Me.cmbModelo.TabIndex = 22
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(9, 56)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(45, 13)
        Me.lblModelo.TabIndex = 21
        Me.lblModelo.Text = "Modelo:"
        '
        'cmbMarca
        '
        Me.cmbMarca.FormattingEnabled = True
        Me.cmbMarca.Location = New System.Drawing.Point(12, 27)
        Me.cmbMarca.Name = "cmbMarca"
        Me.cmbMarca.Size = New System.Drawing.Size(243, 21)
        Me.cmbMarca.TabIndex = 20
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(9, 10)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 13)
        Me.lblMarca.TabIndex = 19
        Me.lblMarca.Text = "Marca:"
        '
        'frmCarros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 390)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtAdicional)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblAdicional)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.chkAirBag)
        Me.Controls.Add(Me.chkAbs)
        Me.Controls.Add(Me.chkBanco)
        Me.Controls.Add(Me.numPortas)
        Me.Controls.Add(Me.lblNumPortas)
        Me.Controls.Add(Me.pctCarro)
        Me.Controls.Add(Me.cmbCor)
        Me.Controls.Add(Me.lblCor)
        Me.Controls.Add(Me.cmbModelo)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.cmbMarca)
        Me.Controls.Add(Me.lblMarca)
        Me.Name = "frmCarros"
        Me.Text = "Carros"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.numPortas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCarro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtTotal As System.Windows.Forms.TextBox
    Private WithEvents txtAdicional As System.Windows.Forms.TextBox
    Private WithEvents txtBase As System.Windows.Forms.TextBox
    Private WithEvents lblTotal As System.Windows.Forms.Label
    Private WithEvents lblAdicional As System.Windows.Forms.Label
    Private WithEvents lblBase As System.Windows.Forms.Label
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents radCaixa As System.Windows.Forms.RadioButton
    Private WithEvents radSimples As System.Windows.Forms.RadioButton
    Private WithEvents radNenhum As System.Windows.Forms.RadioButton
    Private WithEvents chkAirBag As System.Windows.Forms.CheckBox
    Private WithEvents chkAbs As System.Windows.Forms.CheckBox
    Private WithEvents chkBanco As System.Windows.Forms.CheckBox
    Private WithEvents numPortas As System.Windows.Forms.NumericUpDown
    Private WithEvents lblNumPortas As System.Windows.Forms.Label
    Private WithEvents pctCarro As System.Windows.Forms.PictureBox
    Private WithEvents cmbCor As System.Windows.Forms.ComboBox
    Private WithEvents lblCor As System.Windows.Forms.Label
    Private WithEvents cmbModelo As System.Windows.Forms.ComboBox
    Private WithEvents lblModelo As System.Windows.Forms.Label
    Private WithEvents cmbMarca As System.Windows.Forms.ComboBox
    Private WithEvents lblMarca As System.Windows.Forms.Label

End Class
