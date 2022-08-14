<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversor
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
        Me.lblReais = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.btnConverter = New System.Windows.Forms.Button()
        Me.lblDo = New System.Windows.Forms.Label()
        Me.txtDo = New System.Windows.Forms.TextBox()
        Me.lblLi = New System.Windows.Forms.Label()
        Me.txtLi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblReais
        '
        Me.lblReais.AutoSize = True
        Me.lblReais.Location = New System.Drawing.Point(15, 20)
        Me.lblReais.Name = "lblReais"
        Me.lblReais.Size = New System.Drawing.Size(68, 13)
        Me.lblReais.TabIndex = 0
        Me.lblReais.Tag = ""
        Me.lblReais.Text = "Valor em R$:"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(15, 52)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 1
        '
        'btnConverter
        '
        Me.btnConverter.Location = New System.Drawing.Point(15, 96)
        Me.btnConverter.Name = "btnConverter"
        Me.btnConverter.Size = New System.Drawing.Size(100, 23)
        Me.btnConverter.TabIndex = 2
        Me.btnConverter.Text = "Converta"
        Me.btnConverter.UseVisualStyleBackColor = True
        '
        'lblDo
        '
        Me.lblDo.AutoSize = True
        Me.lblDo.Location = New System.Drawing.Point(15, 139)
        Me.lblDo.Name = "lblDo"
        Me.lblDo.Size = New System.Drawing.Size(75, 13)
        Me.lblDo.TabIndex = 3
        Me.lblDo.Text = "Valor em US$:"
        '
        'txtDo
        '
        Me.txtDo.Location = New System.Drawing.Point(15, 164)
        Me.txtDo.Name = "txtDo"
        Me.txtDo.Size = New System.Drawing.Size(100, 20)
        Me.txtDo.TabIndex = 3
        '
        'lblLi
        '
        Me.lblLi.AutoSize = True
        Me.lblLi.Location = New System.Drawing.Point(15, 199)
        Me.lblLi.Name = "lblLi"
        Me.lblLi.Size = New System.Drawing.Size(66, 13)
        Me.lblLi.TabIndex = 5
        Me.lblLi.Text = "Valor em £$:"
        '
        'txtLi
        '
        Me.txtLi.Location = New System.Drawing.Point(15, 226)
        Me.txtLi.Name = "txtLi"
        Me.txtLi.Size = New System.Drawing.Size(100, 20)
        Me.txtLi.TabIndex = 4
        '
        'frmConversor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(198, 265)
        Me.Controls.Add(Me.txtLi)
        Me.Controls.Add(Me.lblLi)
        Me.Controls.Add(Me.txtDo)
        Me.Controls.Add(Me.lblDo)
        Me.Controls.Add(Me.btnConverter)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.lblReais)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Name = "frmConversor"
        Me.Text = "Conversor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReais As System.Windows.Forms.Label
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConverter As System.Windows.Forms.Button
    Friend WithEvents lblDo As System.Windows.Forms.Label
    Friend WithEvents txtDo As System.Windows.Forms.TextBox
    Friend WithEvents lblLi As System.Windows.Forms.Label
    Friend WithEvents txtLi As System.Windows.Forms.TextBox

End Class
