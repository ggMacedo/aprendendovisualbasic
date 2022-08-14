<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhesGrupo
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
        Me.lblPermissoes = New System.Windows.Forms.Label()
        Me.gbVendedores = New System.Windows.Forms.GroupBox()
        Me.cbExcluiVendedor = New System.Windows.Forms.CheckBox()
        Me.cbAlteraVendedor = New System.Windows.Forms.CheckBox()
        Me.cbInsereVendedor = New System.Windows.Forms.CheckBox()
        Me.cbConsultaVendedor = New System.Windows.Forms.CheckBox()
        Me.gbVendas = New System.Windows.Forms.GroupBox()
        Me.cbExcluiVendas = New System.Windows.Forms.CheckBox()
        Me.cbAlteraVendas = New System.Windows.Forms.CheckBox()
        Me.cbInsereVendas = New System.Windows.Forms.CheckBox()
        Me.cbConsultaVendas = New System.Windows.Forms.CheckBox()
        Me.gbProduto = New System.Windows.Forms.GroupBox()
        Me.cbAlteraProduto = New System.Windows.Forms.CheckBox()
        Me.cbExcluiProduto = New System.Windows.Forms.CheckBox()
        Me.cbInsereProduto = New System.Windows.Forms.CheckBox()
        Me.cbConsultaProduto = New System.Windows.Forms.CheckBox()
        Me.gbClientes = New System.Windows.Forms.GroupBox()
        Me.cbExcluiCliente = New System.Windows.Forms.CheckBox()
        Me.cbAlteraCliente = New System.Windows.Forms.CheckBox()
        Me.cbInsereCliente = New System.Windows.Forms.CheckBox()
        Me.cbConsultaCliente = New System.Windows.Forms.CheckBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.gbVendedores.SuspendLayout()
        Me.gbVendas.SuspendLayout()
        Me.gbProduto.SuspendLayout()
        Me.gbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPermissoes
        '
        Me.lblPermissoes.AutoSize = True
        Me.lblPermissoes.Location = New System.Drawing.Point(12, 78)
        Me.lblPermissoes.Name = "lblPermissoes"
        Me.lblPermissoes.Size = New System.Drawing.Size(115, 13)
        Me.lblPermissoes.TabIndex = 17
        Me.lblPermissoes.Text = "Permissões de usuário:"
        '
        'gbVendedores
        '
        Me.gbVendedores.Controls.Add(Me.cbExcluiVendedor)
        Me.gbVendedores.Controls.Add(Me.cbAlteraVendedor)
        Me.gbVendedores.Controls.Add(Me.cbInsereVendedor)
        Me.gbVendedores.Controls.Add(Me.cbConsultaVendedor)
        Me.gbVendedores.Location = New System.Drawing.Point(12, 174)
        Me.gbVendedores.Name = "gbVendedores"
        Me.gbVendedores.Size = New System.Drawing.Size(209, 75)
        Me.gbVendedores.TabIndex = 15
        Me.gbVendedores.TabStop = False
        Me.gbVendedores.Text = "Vendedores"
        '
        'cbExcluiVendedor
        '
        Me.cbExcluiVendedor.AutoSize = True
        Me.cbExcluiVendedor.Location = New System.Drawing.Point(93, 43)
        Me.cbExcluiVendedor.Name = "cbExcluiVendedor"
        Me.cbExcluiVendedor.Size = New System.Drawing.Size(54, 17)
        Me.cbExcluiVendedor.TabIndex = 3
        Me.cbExcluiVendedor.Text = "Exclui"
        Me.cbExcluiVendedor.UseVisualStyleBackColor = True
        '
        'cbAlteraVendedor
        '
        Me.cbAlteraVendedor.AutoSize = True
        Me.cbAlteraVendedor.Location = New System.Drawing.Point(94, 20)
        Me.cbAlteraVendedor.Name = "cbAlteraVendedor"
        Me.cbAlteraVendedor.Size = New System.Drawing.Size(53, 17)
        Me.cbAlteraVendedor.TabIndex = 2
        Me.cbAlteraVendedor.Text = "Altera"
        Me.cbAlteraVendedor.UseVisualStyleBackColor = True
        '
        'cbInsereVendedor
        '
        Me.cbInsereVendedor.AutoSize = True
        Me.cbInsereVendedor.Location = New System.Drawing.Point(6, 43)
        Me.cbInsereVendedor.Name = "cbInsereVendedor"
        Me.cbInsereVendedor.Size = New System.Drawing.Size(55, 17)
        Me.cbInsereVendedor.TabIndex = 1
        Me.cbInsereVendedor.Text = "Insere"
        Me.cbInsereVendedor.UseVisualStyleBackColor = True
        '
        'cbConsultaVendedor
        '
        Me.cbConsultaVendedor.AutoSize = True
        Me.cbConsultaVendedor.Location = New System.Drawing.Point(7, 20)
        Me.cbConsultaVendedor.Name = "cbConsultaVendedor"
        Me.cbConsultaVendedor.Size = New System.Drawing.Size(67, 17)
        Me.cbConsultaVendedor.TabIndex = 0
        Me.cbConsultaVendedor.Text = "Consulta"
        Me.cbConsultaVendedor.UseVisualStyleBackColor = True
        '
        'gbVendas
        '
        Me.gbVendas.Controls.Add(Me.cbExcluiVendas)
        Me.gbVendas.Controls.Add(Me.cbAlteraVendas)
        Me.gbVendas.Controls.Add(Me.cbInsereVendas)
        Me.gbVendas.Controls.Add(Me.cbConsultaVendas)
        Me.gbVendas.Location = New System.Drawing.Point(227, 174)
        Me.gbVendas.Name = "gbVendas"
        Me.gbVendas.Size = New System.Drawing.Size(209, 75)
        Me.gbVendas.TabIndex = 13
        Me.gbVendas.TabStop = False
        Me.gbVendas.Text = "Vendas"
        '
        'cbExcluiVendas
        '
        Me.cbExcluiVendas.AutoSize = True
        Me.cbExcluiVendas.Location = New System.Drawing.Point(102, 43)
        Me.cbExcluiVendas.Name = "cbExcluiVendas"
        Me.cbExcluiVendas.Size = New System.Drawing.Size(54, 17)
        Me.cbExcluiVendas.TabIndex = 3
        Me.cbExcluiVendas.Text = "Exclui"
        Me.cbExcluiVendas.UseVisualStyleBackColor = True
        '
        'cbAlteraVendas
        '
        Me.cbAlteraVendas.AutoSize = True
        Me.cbAlteraVendas.Location = New System.Drawing.Point(102, 20)
        Me.cbAlteraVendas.Name = "cbAlteraVendas"
        Me.cbAlteraVendas.Size = New System.Drawing.Size(53, 17)
        Me.cbAlteraVendas.TabIndex = 2
        Me.cbAlteraVendas.Text = "Altera"
        Me.cbAlteraVendas.UseVisualStyleBackColor = True
        '
        'cbInsereVendas
        '
        Me.cbInsereVendas.AutoSize = True
        Me.cbInsereVendas.Location = New System.Drawing.Point(7, 43)
        Me.cbInsereVendas.Name = "cbInsereVendas"
        Me.cbInsereVendas.Size = New System.Drawing.Size(55, 17)
        Me.cbInsereVendas.TabIndex = 1
        Me.cbInsereVendas.Text = "Insere"
        Me.cbInsereVendas.UseVisualStyleBackColor = True
        '
        'cbConsultaVendas
        '
        Me.cbConsultaVendas.AutoSize = True
        Me.cbConsultaVendas.Location = New System.Drawing.Point(7, 20)
        Me.cbConsultaVendas.Name = "cbConsultaVendas"
        Me.cbConsultaVendas.Size = New System.Drawing.Size(67, 17)
        Me.cbConsultaVendas.TabIndex = 0
        Me.cbConsultaVendas.Text = "Consulta"
        Me.cbConsultaVendas.UseVisualStyleBackColor = True
        '
        'gbProduto
        '
        Me.gbProduto.Controls.Add(Me.cbAlteraProduto)
        Me.gbProduto.Controls.Add(Me.cbExcluiProduto)
        Me.gbProduto.Controls.Add(Me.cbInsereProduto)
        Me.gbProduto.Controls.Add(Me.cbConsultaProduto)
        Me.gbProduto.Location = New System.Drawing.Point(227, 94)
        Me.gbProduto.Name = "gbProduto"
        Me.gbProduto.Size = New System.Drawing.Size(209, 74)
        Me.gbProduto.TabIndex = 14
        Me.gbProduto.TabStop = False
        Me.gbProduto.Text = "Produto"
        '
        'cbAlteraProduto
        '
        Me.cbAlteraProduto.AutoSize = True
        Me.cbAlteraProduto.Location = New System.Drawing.Point(102, 20)
        Me.cbAlteraProduto.Name = "cbAlteraProduto"
        Me.cbAlteraProduto.Size = New System.Drawing.Size(53, 17)
        Me.cbAlteraProduto.TabIndex = 3
        Me.cbAlteraProduto.Text = "Altera"
        Me.cbAlteraProduto.UseVisualStyleBackColor = True
        '
        'cbExcluiProduto
        '
        Me.cbExcluiProduto.AutoSize = True
        Me.cbExcluiProduto.Location = New System.Drawing.Point(102, 44)
        Me.cbExcluiProduto.Name = "cbExcluiProduto"
        Me.cbExcluiProduto.Size = New System.Drawing.Size(54, 17)
        Me.cbExcluiProduto.TabIndex = 2
        Me.cbExcluiProduto.Text = "Exclui"
        Me.cbExcluiProduto.UseVisualStyleBackColor = True
        '
        'cbInsereProduto
        '
        Me.cbInsereProduto.AutoSize = True
        Me.cbInsereProduto.Location = New System.Drawing.Point(7, 43)
        Me.cbInsereProduto.Name = "cbInsereProduto"
        Me.cbInsereProduto.Size = New System.Drawing.Size(55, 17)
        Me.cbInsereProduto.TabIndex = 1
        Me.cbInsereProduto.Text = "Insere"
        Me.cbInsereProduto.UseVisualStyleBackColor = True
        '
        'cbConsultaProduto
        '
        Me.cbConsultaProduto.AutoSize = True
        Me.cbConsultaProduto.Location = New System.Drawing.Point(7, 20)
        Me.cbConsultaProduto.Name = "cbConsultaProduto"
        Me.cbConsultaProduto.Size = New System.Drawing.Size(67, 17)
        Me.cbConsultaProduto.TabIndex = 0
        Me.cbConsultaProduto.Text = "Consulta"
        Me.cbConsultaProduto.UseVisualStyleBackColor = True
        '
        'gbClientes
        '
        Me.gbClientes.Controls.Add(Me.cbExcluiCliente)
        Me.gbClientes.Controls.Add(Me.cbAlteraCliente)
        Me.gbClientes.Controls.Add(Me.cbInsereCliente)
        Me.gbClientes.Controls.Add(Me.cbConsultaCliente)
        Me.gbClientes.Location = New System.Drawing.Point(12, 94)
        Me.gbClientes.Name = "gbClientes"
        Me.gbClientes.Size = New System.Drawing.Size(209, 74)
        Me.gbClientes.TabIndex = 16
        Me.gbClientes.TabStop = False
        Me.gbClientes.Text = "Clientes"
        '
        'cbExcluiCliente
        '
        Me.cbExcluiCliente.AutoSize = True
        Me.cbExcluiCliente.Location = New System.Drawing.Point(94, 44)
        Me.cbExcluiCliente.Name = "cbExcluiCliente"
        Me.cbExcluiCliente.Size = New System.Drawing.Size(54, 17)
        Me.cbExcluiCliente.TabIndex = 3
        Me.cbExcluiCliente.Text = "Exclui"
        Me.cbExcluiCliente.UseVisualStyleBackColor = True
        '
        'cbAlteraCliente
        '
        Me.cbAlteraCliente.AutoSize = True
        Me.cbAlteraCliente.Location = New System.Drawing.Point(94, 20)
        Me.cbAlteraCliente.Name = "cbAlteraCliente"
        Me.cbAlteraCliente.Size = New System.Drawing.Size(53, 17)
        Me.cbAlteraCliente.TabIndex = 2
        Me.cbAlteraCliente.Text = "Altera"
        Me.cbAlteraCliente.UseVisualStyleBackColor = True
        '
        'cbInsereCliente
        '
        Me.cbInsereCliente.AutoSize = True
        Me.cbInsereCliente.Location = New System.Drawing.Point(7, 44)
        Me.cbInsereCliente.Name = "cbInsereCliente"
        Me.cbInsereCliente.Size = New System.Drawing.Size(55, 17)
        Me.cbInsereCliente.TabIndex = 1
        Me.cbInsereCliente.Text = "Insere"
        Me.cbInsereCliente.UseVisualStyleBackColor = True
        '
        'cbConsultaCliente
        '
        Me.cbConsultaCliente.AutoSize = True
        Me.cbConsultaCliente.Location = New System.Drawing.Point(7, 20)
        Me.cbConsultaCliente.Name = "cbConsultaCliente"
        Me.cbConsultaCliente.Size = New System.Drawing.Size(67, 17)
        Me.cbConsultaCliente.TabIndex = 0
        Me.cbConsultaCliente.Text = "Consulta"
        Me.cbConsultaCliente.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(227, 255)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(210, 23)
        Me.btnCancelar.TabIndex = 19
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 255)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(209, 23)
        Me.btnOk.TabIndex = 18
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(121, 43)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 20
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 43)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 21
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(122, 23)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 22
        Me.lblNome.Text = "Nome:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(9, 23)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 23
        Me.lblCodigo.Text = "Código:"
        '
        'frmDetalhesGrupo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 297)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblPermissoes)
        Me.Controls.Add(Me.gbVendedores)
        Me.Controls.Add(Me.gbVendas)
        Me.Controls.Add(Me.gbProduto)
        Me.Controls.Add(Me.gbClientes)
        Me.Name = "frmDetalhesGrupo"
        Me.Text = "frmDetalhesGrupo"
        Me.gbVendedores.ResumeLayout(False)
        Me.gbVendedores.PerformLayout()
        Me.gbVendas.ResumeLayout(False)
        Me.gbVendas.PerformLayout()
        Me.gbProduto.ResumeLayout(False)
        Me.gbProduto.PerformLayout()
        Me.gbClientes.ResumeLayout(False)
        Me.gbClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPermissoes As Label
    Friend WithEvents gbVendedores As GroupBox
    Friend WithEvents cbExcluiVendedor As CheckBox
    Friend WithEvents cbAlteraVendedor As CheckBox
    Friend WithEvents cbInsereVendedor As CheckBox
    Friend WithEvents cbConsultaVendedor As CheckBox
    Friend WithEvents gbVendas As GroupBox
    Friend WithEvents cbExcluiVendas As CheckBox
    Friend WithEvents cbAlteraVendas As CheckBox
    Friend WithEvents cbInsereVendas As CheckBox
    Friend WithEvents cbConsultaVendas As CheckBox
    Friend WithEvents gbProduto As GroupBox
    Friend WithEvents cbAlteraProduto As CheckBox
    Friend WithEvents cbExcluiProduto As CheckBox
    Friend WithEvents cbInsereProduto As CheckBox
    Friend WithEvents cbConsultaProduto As CheckBox
    Friend WithEvents gbClientes As GroupBox
    Friend WithEvents cbExcluiCliente As CheckBox
    Friend WithEvents cbAlteraCliente As CheckBox
    Friend WithEvents cbInsereCliente As CheckBox
    Friend WithEvents cbConsultaCliente As CheckBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblNome As Label
    Friend WithEvents lblCodigo As Label
End Class
