<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixaDialogo
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblUf = New System.Windows.Forms.Label()
        Me.lblIdade = New System.Windows.Forms.Label()
        Me.lblProfissao = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.txtIdade = New System.Windows.Forms.TextBox()
        Me.txtProfissao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(19, 270)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(159, 270)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(16, 16)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Código:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(16, 55)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(16, 94)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(56, 13)
        Me.lblEndereco.TabIndex = 4
        Me.lblEndereco.Text = "Endereço:"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(16, 133)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 5
        Me.lblCidade.Text = "Cidade:"
        '
        'lblUf
        '
        Me.lblUf.AutoSize = True
        Me.lblUf.Location = New System.Drawing.Point(131, 133)
        Me.lblUf.Name = "lblUf"
        Me.lblUf.Size = New System.Drawing.Size(24, 13)
        Me.lblUf.TabIndex = 6
        Me.lblUf.Text = "UF:"
        '
        'lblIdade
        '
        Me.lblIdade.AutoSize = True
        Me.lblIdade.Location = New System.Drawing.Point(15, 172)
        Me.lblIdade.Name = "lblIdade"
        Me.lblIdade.Size = New System.Drawing.Size(37, 13)
        Me.lblIdade.TabIndex = 7
        Me.lblIdade.Text = "Idade:"
        '
        'lblProfissao
        '
        Me.lblProfissao.AutoSize = True
        Me.lblProfissao.Location = New System.Drawing.Point(16, 211)
        Me.lblProfissao.Name = "lblProfissao"
        Me.lblProfissao.Size = New System.Drawing.Size(53, 13)
        Me.lblProfissao.TabIndex = 8
        Me.lblProfissao.Text = "Profissão:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(19, 32)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(215, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(18, 110)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(216, 20)
        Me.txtEndereco.TabIndex = 3
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(19, 71)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(215, 20)
        Me.txtNome.TabIndex = 2
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(18, 149)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCidade.TabIndex = 4
        '
        'txtUf
        '
        Me.txtUf.Location = New System.Drawing.Point(134, 149)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(100, 20)
        Me.txtUf.TabIndex = 5
        '
        'txtIdade
        '
        Me.txtIdade.Location = New System.Drawing.Point(19, 188)
        Me.txtIdade.Name = "txtIdade"
        Me.txtIdade.Size = New System.Drawing.Size(215, 20)
        Me.txtIdade.TabIndex = 6
        '
        'txtProfissao
        '
        Me.txtProfissao.Location = New System.Drawing.Point(19, 227)
        Me.txtProfissao.Name = "txtProfissao"
        Me.txtProfissao.Size = New System.Drawing.Size(215, 20)
        Me.txtProfissao.TabIndex = 7
        '
        'frmCaixaDialogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 315)
        Me.Controls.Add(Me.txtProfissao)
        Me.Controls.Add(Me.txtIdade)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblProfissao)
        Me.Controls.Add(Me.lblIdade)
        Me.Controls.Add(Me.lblUf)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmCaixaDialogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblCidade As Label
    Friend WithEvents lblUf As Label
    Friend WithEvents lblIdade As Label
    Friend WithEvents lblProfissao As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtUf As TextBox
    Friend WithEvents txtIdade As TextBox
    Friend WithEvents txtProfissao As TextBox
End Class
