<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumeros
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
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.lblN2 = New System.Windows.Forms.Label()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.lblN3 = New System.Windows.Forms.Label()
        Me.txtN3 = New System.Windows.Forms.TextBox()
        Me.lblN4 = New System.Windows.Forms.Label()
        Me.txtN4 = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblN1
        '
        Me.lblN1.AutoSize = True
        Me.lblN1.Location = New System.Drawing.Point(13, 13)
        Me.lblN1.Name = "lblN1"
        Me.lblN1.Size = New System.Drawing.Size(56, 13)
        Me.lblN1.TabIndex = 0
        Me.lblN1.Text = "Número 1:"
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(12, 29)
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(100, 20)
        Me.txtN1.TabIndex = 1
        '
        'lblN2
        '
        Me.lblN2.AutoSize = True
        Me.lblN2.Location = New System.Drawing.Point(12, 69)
        Me.lblN2.Name = "lblN2"
        Me.lblN2.Size = New System.Drawing.Size(56, 13)
        Me.lblN2.TabIndex = 2
        Me.lblN2.Text = "Número 2:"
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(12, 85)
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(100, 20)
        Me.txtN2.TabIndex = 2
        '
        'lblN3
        '
        Me.lblN3.AutoSize = True
        Me.lblN3.Location = New System.Drawing.Point(12, 121)
        Me.lblN3.Name = "lblN3"
        Me.lblN3.Size = New System.Drawing.Size(56, 13)
        Me.lblN3.TabIndex = 4
        Me.lblN3.Text = "Número 3:"
        '
        'txtN3
        '
        Me.txtN3.Location = New System.Drawing.Point(12, 137)
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(100, 20)
        Me.txtN3.TabIndex = 3
        '
        'lblN4
        '
        Me.lblN4.AutoSize = True
        Me.lblN4.Location = New System.Drawing.Point(13, 177)
        Me.lblN4.Name = "lblN4"
        Me.lblN4.Size = New System.Drawing.Size(56, 13)
        Me.lblN4.TabIndex = 6
        Me.lblN4.Text = "Número 4:"
        '
        'txtN4
        '
        Me.txtN4.Location = New System.Drawing.Point(12, 193)
        Me.txtN4.Name = "txtN4"
        Me.txtN4.Size = New System.Drawing.Size(100, 20)
        Me.txtN4.TabIndex = 4
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(12, 229)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(103, 23)
        Me.btnExibir.TabIndex = 5
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'frmNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(142, 262)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtN4)
        Me.Controls.Add(Me.lblN4)
        Me.Controls.Add(Me.txtN3)
        Me.Controls.Add(Me.lblN3)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.lblN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.lblN1)
        Me.Name = "frmNumeros"
        Me.Text = "Números"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblN1 As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents lblN2 As System.Windows.Forms.Label
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents lblN3 As System.Windows.Forms.Label
    Friend WithEvents txtN3 As System.Windows.Forms.TextBox
    Friend WithEvents lblN4 As System.Windows.Forms.Label
    Friend WithEvents txtN4 As System.Windows.Forms.TextBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
