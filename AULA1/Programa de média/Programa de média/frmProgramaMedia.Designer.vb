<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProgramaMedia
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
        Me.lblNota1 = New System.Windows.Forms.Label()
        Me.lblNota2 = New System.Windows.Forms.Label()
        Me.lblNota3 = New System.Windows.Forms.Label()
        Me.lblNota4 = New System.Windows.Forms.Label()
        Me.txtNota4 = New System.Windows.Forms.TextBox()
        Me.txtNota3 = New System.Windows.Forms.TextBox()
        Me.txtNota2 = New System.Windows.Forms.TextBox()
        Me.txtNota1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(76, 288)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(100, 35)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "Enviar notas"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'lblNota1
        '
        Me.lblNota1.AutoSize = True
        Me.lblNota1.Location = New System.Drawing.Point(73, 37)
        Me.lblNota1.Name = "lblNota1"
        Me.lblNota1.Size = New System.Drawing.Size(109, 13)
        Me.lblNota1.TabIndex = 1
        Me.lblNota1.Text = "Digite a primeira nota:"
        '
        'lblNota2
        '
        Me.lblNota2.AutoSize = True
        Me.lblNota2.Location = New System.Drawing.Point(73, 89)
        Me.lblNota2.Name = "lblNota2"
        Me.lblNota2.Size = New System.Drawing.Size(114, 13)
        Me.lblNota2.TabIndex = 2
        Me.lblNota2.Text = "Digite a segunda nota:"
        '
        'lblNota3
        '
        Me.lblNota3.AutoSize = True
        Me.lblNota3.Location = New System.Drawing.Point(74, 157)
        Me.lblNota3.Name = "lblNota3"
        Me.lblNota3.Size = New System.Drawing.Size(108, 13)
        Me.lblNota3.TabIndex = 3
        Me.lblNota3.Text = "Digite a terceira nota:"
        '
        'lblNota4
        '
        Me.lblNota4.AutoSize = True
        Me.lblNota4.Location = New System.Drawing.Point(73, 221)
        Me.lblNota4.Name = "lblNota4"
        Me.lblNota4.Size = New System.Drawing.Size(103, 13)
        Me.lblNota4.TabIndex = 4
        Me.lblNota4.Text = "Digite a quarta nota:"
        '
        'txtNota4
        '
        Me.txtNota4.Location = New System.Drawing.Point(76, 237)
        Me.txtNota4.Name = "txtNota4"
        Me.txtNota4.Size = New System.Drawing.Size(100, 20)
        Me.txtNota4.TabIndex = 5
        '
        'txtNota3
        '
        Me.txtNota3.Location = New System.Drawing.Point(76, 173)
        Me.txtNota3.Name = "txtNota3"
        Me.txtNota3.Size = New System.Drawing.Size(100, 20)
        Me.txtNota3.TabIndex = 6
        '
        'txtNota2
        '
        Me.txtNota2.Location = New System.Drawing.Point(76, 105)
        Me.txtNota2.Name = "txtNota2"
        Me.txtNota2.Size = New System.Drawing.Size(100, 20)
        Me.txtNota2.TabIndex = 7
        '
        'txtNota1
        '
        Me.txtNota1.Location = New System.Drawing.Point(76, 53)
        Me.txtNota1.Name = "txtNota1"
        Me.txtNota1.Size = New System.Drawing.Size(100, 20)
        Me.txtNota1.TabIndex = 8
        '
        'frmProgramaMedia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(279, 335)
        Me.Controls.Add(Me.txtNota1)
        Me.Controls.Add(Me.txtNota2)
        Me.Controls.Add(Me.txtNota3)
        Me.Controls.Add(Me.txtNota4)
        Me.Controls.Add(Me.lblNota4)
        Me.Controls.Add(Me.lblNota3)
        Me.Controls.Add(Me.lblNota2)
        Me.Controls.Add(Me.lblNota1)
        Me.Controls.Add(Me.btnEnviar)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "frmProgramaMedia"
        Me.Text = "Média de notas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents lblNota1 As System.Windows.Forms.Label
    Friend WithEvents lblNota2 As System.Windows.Forms.Label
    Friend WithEvents lblNota3 As System.Windows.Forms.Label
    Friend WithEvents lblNota4 As System.Windows.Forms.Label
    Friend WithEvents txtNota4 As System.Windows.Forms.TextBox
    Friend WithEvents txtNota3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNota2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNota1 As System.Windows.Forms.TextBox

End Class
