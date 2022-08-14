<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhesVendas
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
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblVendedor = New System.Windows.Forms.Label()
        Me.lblProdutos = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTtotal = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.cmbVendedor = New System.Windows.Forms.ComboBox()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMais = New System.Windows.Forms.Button()
        Me.gridProdutos = New System.Windows.Forms.DataGridView()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        CType(Me.gridProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 339)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(269, 339)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 9)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 3
        Me.lblCodigo.Text = "Código:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(129, 9)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(33, 13)
        Me.lblData.TabIndex = 4
        Me.lblData.Text = "Data:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(12, 48)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(42, 13)
        Me.lblCliente.TabIndex = 5
        Me.lblCliente.Text = "Cliente:"
        '
        'lblVendedor
        '
        Me.lblVendedor.AutoSize = True
        Me.lblVendedor.Location = New System.Drawing.Point(12, 88)
        Me.lblVendedor.Name = "lblVendedor"
        Me.lblVendedor.Size = New System.Drawing.Size(56, 13)
        Me.lblVendedor.TabIndex = 6
        Me.lblVendedor.Text = "Vendedor:"
        '
        'lblProdutos
        '
        Me.lblProdutos.AutoSize = True
        Me.lblProdutos.Location = New System.Drawing.Point(12, 128)
        Me.lblProdutos.Name = "lblProdutos"
        Me.lblProdutos.Size = New System.Drawing.Size(52, 13)
        Me.lblProdutos.TabIndex = 7
        Me.lblProdutos.Text = "Produtos:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(12, 297)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 13)
        Me.lblTotal.TabIndex = 8
        Me.lblTotal.Text = "Total:"
        '
        'txtTtotal
        '
        Me.txtTtotal.Location = New System.Drawing.Point(12, 313)
        Me.txtTtotal.Name = "txtTtotal"
        Me.txtTtotal.Size = New System.Drawing.Size(332, 20)
        Me.txtTtotal.TabIndex = 9
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 25)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(12, 64)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(332, 21)
        Me.cmbCliente.TabIndex = 12
        '
        'cmbVendedor
        '
        Me.cmbVendedor.FormattingEnabled = True
        Me.cmbVendedor.Location = New System.Drawing.Point(12, 104)
        Me.cmbVendedor.Name = "cmbVendedor"
        Me.cmbVendedor.Size = New System.Drawing.Size(332, 21)
        Me.cmbVendedor.TabIndex = 13
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(317, 271)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(27, 23)
        Me.btnMenos.TabIndex = 14
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMais
        '
        Me.btnMais.Location = New System.Drawing.Point(317, 144)
        Me.btnMais.Name = "btnMais"
        Me.btnMais.Size = New System.Drawing.Size(27, 23)
        Me.btnMais.TabIndex = 15
        Me.btnMais.Text = "+"
        Me.btnMais.UseVisualStyleBackColor = True
        '
        'gridProdutos
        '
        Me.gridProdutos.AllowUserToAddRows = False
        Me.gridProdutos.AllowUserToDeleteRows = False
        Me.gridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProdutos.Location = New System.Drawing.Point(12, 144)
        Me.gridProdutos.Name = "gridProdutos"
        Me.gridProdutos.Size = New System.Drawing.Size(299, 150)
        Me.gridProdutos.TabIndex = 16
        '
        'dtpData
        '
        Me.dtpData.Location = New System.Drawing.Point(132, 25)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(212, 20)
        Me.dtpData.TabIndex = 17
        '
        'frmDetalhesVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 376)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.gridProdutos)
        Me.Controls.Add(Me.btnMais)
        Me.Controls.Add(Me.btnMenos)
        Me.Controls.Add(Me.cmbVendedor)
        Me.Controls.Add(Me.cmbCliente)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtTtotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblProdutos)
        Me.Controls.Add(Me.lblVendedor)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.lblData)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOk)
        Me.Name = "frmDetalhesVendas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalhes Vendas"
        CType(Me.gridProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblData As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblVendedor As Label
    Friend WithEvents lblProdutos As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTtotal As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents cmbCliente As ComboBox
    Friend WithEvents cmbVendedor As ComboBox
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMais As Button
    Friend WithEvents gridProdutos As DataGridView
    Friend WithEvents dtpData As DateTimePicker
End Class
