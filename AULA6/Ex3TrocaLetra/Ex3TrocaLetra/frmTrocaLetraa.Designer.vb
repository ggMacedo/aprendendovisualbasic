<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrocaLetraa
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
        Me.lblPalavra = New System.Windows.Forms.Label()
        Me.lblLetra1 = New System.Windows.Forms.Label()
        Me.lblLetra2 = New System.Windows.Forms.Label()
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.txtLetra1 = New System.Windows.Forms.TextBox()
        Me.txtLetra2 = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPalavra
        '
        Me.lblPalavra.AutoSize = True
        Me.lblPalavra.Location = New System.Drawing.Point(8, 24)
        Me.lblPalavra.Name = "lblPalavra"
        Me.lblPalavra.Size = New System.Drawing.Size(46, 13)
        Me.lblPalavra.TabIndex = 0
        Me.lblPalavra.Text = "Palavra:"
        '
        'lblLetra1
        '
        Me.lblLetra1.AutoSize = True
        Me.lblLetra1.Location = New System.Drawing.Point(12, 77)
        Me.lblLetra1.Name = "lblLetra1"
        Me.lblLetra1.Size = New System.Drawing.Size(43, 13)
        Me.lblLetra1.TabIndex = 1
        Me.lblLetra1.Text = "Letra 1:"
        '
        'lblLetra2
        '
        Me.lblLetra2.AutoSize = True
        Me.lblLetra2.Location = New System.Drawing.Point(12, 131)
        Me.lblLetra2.Name = "lblLetra2"
        Me.lblLetra2.Size = New System.Drawing.Size(43, 13)
        Me.lblLetra2.TabIndex = 2
        Me.lblLetra2.Text = "Letra 2:"
        '
        'txtPalavra
        '
        Me.txtPalavra.Location = New System.Drawing.Point(11, 40)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.Size = New System.Drawing.Size(100, 20)
        Me.txtPalavra.TabIndex = 1
        '
        'txtLetra1
        '
        Me.txtLetra1.Location = New System.Drawing.Point(12, 93)
        Me.txtLetra1.Name = "txtLetra1"
        Me.txtLetra1.Size = New System.Drawing.Size(100, 20)
        Me.txtLetra1.TabIndex = 2
        '
        'txtLetra2
        '
        Me.txtLetra2.Location = New System.Drawing.Point(11, 147)
        Me.txtLetra2.Name = "txtLetra2"
        Me.txtLetra2.Size = New System.Drawing.Size(100, 20)
        Me.txtLetra2.TabIndex = 3
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(11, 183)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 4
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'frmTrocaLetraa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(131, 218)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtLetra2)
        Me.Controls.Add(Me.txtLetra1)
        Me.Controls.Add(Me.txtPalavra)
        Me.Controls.Add(Me.lblLetra2)
        Me.Controls.Add(Me.lblLetra1)
        Me.Controls.Add(Me.lblPalavra)
        Me.Name = "frmTrocaLetraa"
        Me.Text = "Troca Letra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPalavra As System.Windows.Forms.Label
    Friend WithEvents lblLetra1 As System.Windows.Forms.Label
    Friend WithEvents lblLetra2 As System.Windows.Forms.Label
    Friend WithEvents txtPalavra As System.Windows.Forms.TextBox
    Friend WithEvents txtLetra1 As System.Windows.Forms.TextBox
    Friend WithEvents txtLetra2 As System.Windows.Forms.TextBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
