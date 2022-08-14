<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculadora
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
        Me.lblN1 = New System.Windows.Forms.Label()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.btnSoma = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Location = New System.Drawing.Point(13, 13)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(85, 13)
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "Primeiro número:"
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Location = New System.Drawing.Point(13, 87)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(91, 13)
        Me.lblN2.TabIndex = 1
        Me.lblN2.Text = "Segundo número:"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(13, 49)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(100, 20)
        Me.txtN1.TabIndex = 1
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(13, 123)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(100, 20)
        Me.txtN2.TabIndex = 2
        '
        'btnSoma
        '
        Me.btnSoma.Location = New System.Drawing.Point(13, 182)
        Me.btnSoma.Name = "btnSoma"
        Me.btnSoma.Size = New System.Drawing.Size(91, 23)
        Me.btnSoma.TabIndex = 3
        Me.btnSoma.Text = "Soma"
        Me.btnSoma.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Location = New System.Drawing.Point(110, 182)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(98, 23)
        Me.btnSub.TabIndex = 4
        Me.btnSub.Text = "Subtração"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(110, 224)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(93, 23)
        Me.btnDiv.TabIndex = 6
        Me.btnDiv.Text = "Divisão"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(13, 224)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(91, 23)
        Me.btnMult.TabIndex = 5
        Me.btnMult.Text = "Multiplicação"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'frmCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(227, 262)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnSoma)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.lblN1)
        Me.Name = "frmCalculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblN1 As System.Windows.Forms.Label
    Friend WithEvents lblN2 As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSoma As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents btnMult As System.Windows.Forms.Button

End Class
