<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuInicial
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
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVendedores = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.White
        Me.btnClientes.Location = New System.Drawing.Point(10, 33)
        Me.btnClientes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(73, 27)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnVendedores
        '
        Me.btnVendedores.BackColor = System.Drawing.Color.White
        Me.btnVendedores.Location = New System.Drawing.Point(10, 67)
        Me.btnVendedores.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Size = New System.Drawing.Size(73, 27)
        Me.btnVendedores.TabIndex = 2
        Me.btnVendedores.Text = "Vendedores"
        Me.btnVendedores.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.White
        Me.btnUsuarios.Location = New System.Drawing.Point(134, 67)
        Me.btnUsuarios.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(73, 27)
        Me.btnUsuarios.TabIndex = 4
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnProdutos
        '
        Me.btnProdutos.BackColor = System.Drawing.Color.White
        Me.btnProdutos.Location = New System.Drawing.Point(134, 33)
        Me.btnProdutos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Size = New System.Drawing.Size(73, 27)
        Me.btnProdutos.TabIndex = 3
        Me.btnProdutos.Text = "Produtos"
        Me.btnProdutos.UseVisualStyleBackColor = False
        '
        'frmMenuInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(228, 112)
        Me.Controls.Add(Me.btnProdutos)
        Me.Controls.Add(Me.btnUsuarios)
        Me.Controls.Add(Me.btnVendedores)
        Me.Controls.Add(Me.btnClientes)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmMenuInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuInicial"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVendedores As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnProdutos As Button
End Class
