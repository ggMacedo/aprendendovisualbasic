<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalhesVendedores
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
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblPercentual = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.txtPercentual = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(10, 10)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(39, 15)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código:"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(10, 55)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 15)
        Me.lblNome.TabIndex = 1
        Me.lblNome.Text = "Nome:"
        '
        'lblPercentual
        '
        Me.lblPercentual.AutoSize = True
        Me.lblPercentual.Location = New System.Drawing.Point(10, 100)
        Me.lblPercentual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPercentual.Name = "lblPercentual"
        Me.lblPercentual.Size = New System.Drawing.Size(53, 15)
        Me.lblPercentual.TabIndex = 2
        Me.lblPercentual.Text = "Percentual:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(12, 29)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(128, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 74)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(128, 20)
        Me.txtNome.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(77, 149)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(62, 27)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(10, 149)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(62, 27)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'txtPercentual
        '
        Me.txtPercentual.Location = New System.Drawing.Point(12, 119)
        Me.txtPercentual.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtPercentual.Name = "txtPercentual"
        Me.txtPercentual.Size = New System.Drawing.Size(128, 20)
        Me.txtPercentual.TabIndex = 2
        '
        'frmDetalhesVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(157, 186)
        Me.Controls.Add(Me.txtPercentual)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblPercentual)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frmDetalhesVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDetalhesVendedores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblNome As Label
    Friend WithEvents lblPercentual As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnOk As Button
    Friend WithEvents txtPercentual As TextBox
End Class
