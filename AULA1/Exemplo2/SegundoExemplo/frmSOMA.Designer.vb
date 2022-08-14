<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSOMA
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
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtNumpri = New System.Windows.Forms.TextBox()
        Me.lblNumpri = New System.Windows.Forms.Label()
        Me.lblNumseg = New System.Windows.Forms.Label()
        Me.txtNumseg = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(91, 165)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(111, 23)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtNumpri
        '
        Me.txtNumpri.Location = New System.Drawing.Point(82, 50)
        Me.txtNumpri.Name = "txtNumpri"
        Me.txtNumpri.Size = New System.Drawing.Size(120, 20)
        Me.txtNumpri.TabIndex = 1
        '
        'lblNumpri
        '
        Me.lblNumpri.AutoSize = True
        Me.lblNumpri.Location = New System.Drawing.Point(79, 34)
        Me.lblNumpri.Name = "lblNumpri"
        Me.lblNumpri.Size = New System.Drawing.Size(123, 13)
        Me.lblNumpri.TabIndex = 2
        Me.lblNumpri.Text = "Digite o primeiro número:"
        '
        'lblNumseg
        '
        Me.lblNumseg.AutoSize = True
        Me.lblNumseg.Location = New System.Drawing.Point(88, 90)
        Me.lblNumseg.Name = "lblNumseg"
        Me.lblNumseg.Size = New System.Drawing.Size(128, 13)
        Me.lblNumseg.TabIndex = 3
        Me.lblNumseg.Text = "Digite o segundo número:"
        '
        'txtNumseg
        '
        Me.txtNumseg.Location = New System.Drawing.Point(82, 120)
        Me.txtNumseg.Name = "txtNumseg"
        Me.txtNumseg.Size = New System.Drawing.Size(120, 20)
        Me.txtNumseg.TabIndex = 4
        '
        'frmSOMA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(284, 219)
        Me.Controls.Add(Me.txtNumseg)
        Me.Controls.Add(Me.lblNumseg)
        Me.Controls.Add(Me.lblNumpri)
        Me.Controls.Add(Me.txtNumpri)
        Me.Controls.Add(Me.btnEnviar)
        Me.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Name = "frmSOMA"
        Me.Text = "Programa de Soma"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txtNumpri As System.Windows.Forms.TextBox
    Friend WithEvents lblNumpri As System.Windows.Forms.Label
    Friend WithEvents lblNumseg As System.Windows.Forms.Label
    Friend WithEvents txtNumseg As System.Windows.Forms.TextBox

End Class
