<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx3NomeContrario
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(5, 32)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(41, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome :"
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(8, 84)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 2
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(8, 58)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 1
        '
        'frmEx3NomeContrario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(134, 126)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "frmEx3NomeContrario"
        Me.Text = "Nome ao Contrario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox

End Class
