<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCombo
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.btnCodigo = New System.Windows.Forms.Button()
        Me.btnNome = New System.Windows.Forms.Button()
        Me.btnEndereco = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(85, 23)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(239, 21)
        Me.cmbClientes.TabIndex = 0
        '
        'btnCodigo
        '
        Me.btnCodigo.Location = New System.Drawing.Point(85, 51)
        Me.btnCodigo.Name = "btnCodigo"
        Me.btnCodigo.Size = New System.Drawing.Size(75, 23)
        Me.btnCodigo.TabIndex = 1
        Me.btnCodigo.Text = "Código"
        Me.btnCodigo.UseVisualStyleBackColor = True
        '
        'btnNome
        '
        Me.btnNome.Location = New System.Drawing.Point(167, 51)
        Me.btnNome.Name = "btnNome"
        Me.btnNome.Size = New System.Drawing.Size(75, 23)
        Me.btnNome.TabIndex = 2
        Me.btnNome.Text = "Nome"
        Me.btnNome.UseVisualStyleBackColor = True
        '
        'btnEndereco
        '
        Me.btnEndereco.Location = New System.Drawing.Point(249, 51)
        Me.btnEndereco.Name = "btnEndereco"
        Me.btnEndereco.Size = New System.Drawing.Size(75, 23)
        Me.btnEndereco.TabIndex = 3
        Me.btnEndereco.Text = "Endereço"
        Me.btnEndereco.UseVisualStyleBackColor = True
        '
        'frmCombo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 183)
        Me.Controls.Add(Me.btnEndereco)
        Me.Controls.Add(Me.btnNome)
        Me.Controls.Add(Me.btnCodigo)
        Me.Controls.Add(Me.cmbClientes)
        Me.Name = "frmCombo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmbClientes As Windows.Forms.ComboBox
    Friend WithEvents btnCodigo As Button
    Friend WithEvents btnNome As Button
    Friend WithEvents btnEndereco As Button
End Class
