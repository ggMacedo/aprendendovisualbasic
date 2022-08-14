<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiraLetra
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
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.lblPalavra = New System.Windows.Forms.Label()
        Me.lblLetra = New System.Windows.Forms.Label()
        Me.txtPalavra = New System.Windows.Forms.TextBox()
        Me.txtLetra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(19, 171)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 3
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'lblPalavra
        '
        Me.lblPalavra.AutoSize = True
        Me.lblPalavra.Location = New System.Drawing.Point(16, 26)
        Me.lblPalavra.Name = "lblPalavra"
        Me.lblPalavra.Size = New System.Drawing.Size(46, 13)
        Me.lblPalavra.TabIndex = 1
        Me.lblPalavra.Text = "Palavra:"
        '
        'lblLetra
        '
        Me.lblLetra.AutoSize = True
        Me.lblLetra.Location = New System.Drawing.Point(16, 99)
        Me.lblLetra.Name = "lblLetra"
        Me.lblLetra.Size = New System.Drawing.Size(34, 13)
        Me.lblLetra.TabIndex = 2
        Me.lblLetra.Text = "Letra:"
        '
        'txtPalavra
        '
        Me.txtPalavra.Location = New System.Drawing.Point(19, 53)
        Me.txtPalavra.Name = "txtPalavra"
        Me.txtPalavra.Size = New System.Drawing.Size(100, 20)
        Me.txtPalavra.TabIndex = 1
        '
        'txtLetra
        '
        Me.txtLetra.Location = New System.Drawing.Point(19, 130)
        Me.txtLetra.Name = "txtLetra"
        Me.txtLetra.Size = New System.Drawing.Size(100, 20)
        Me.txtLetra.TabIndex = 2
        '
        'frmTiraLetra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 211)
        Me.Controls.Add(Me.txtLetra)
        Me.Controls.Add(Me.txtPalavra)
        Me.Controls.Add(Me.lblLetra)
        Me.Controls.Add(Me.lblPalavra)
        Me.Controls.Add(Me.btnExibir)
        Me.Name = "frmTiraLetra"
        Me.Text = "Tira Letra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExibir As System.Windows.Forms.Button
    Friend WithEvents lblPalavra As System.Windows.Forms.Label
    Friend WithEvents lblLetra As System.Windows.Forms.Label
    Friend WithEvents txtPalavra As System.Windows.Forms.TextBox
    Friend WithEvents txtLetra As System.Windows.Forms.TextBox

End Class
