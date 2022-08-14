<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumerosCrescentes
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
        Me.lblNumero1 = New System.Windows.Forms.Label()
        Me.lblNumero2 = New System.Windows.Forms.Label()
        Me.lblNumero3 = New System.Windows.Forms.Label()
        Me.txtNumero3 = New System.Windows.Forms.TextBox()
        Me.txtNumero2 = New System.Windows.Forms.TextBox()
        Me.txtNumero1 = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNumero1
        '
        Me.lblNumero1.AutoSize = True
        Me.lblNumero1.Location = New System.Drawing.Point(70, 24)
        Me.lblNumero1.Name = "lblNumero1"
        Me.lblNumero1.Size = New System.Drawing.Size(56, 13)
        Me.lblNumero1.TabIndex = 0
        Me.lblNumero1.Text = "Número 1:"
        '
        'lblNumero2
        '
        Me.lblNumero2.AutoSize = True
        Me.lblNumero2.Location = New System.Drawing.Point(70, 73)
        Me.lblNumero2.Name = "lblNumero2"
        Me.lblNumero2.Size = New System.Drawing.Size(56, 13)
        Me.lblNumero2.TabIndex = 1
        Me.lblNumero2.Text = "Número 2:"
        '
        'lblNumero3
        '
        Me.lblNumero3.AutoSize = True
        Me.lblNumero3.Location = New System.Drawing.Point(70, 126)
        Me.lblNumero3.Name = "lblNumero3"
        Me.lblNumero3.Size = New System.Drawing.Size(56, 13)
        Me.lblNumero3.TabIndex = 2
        Me.lblNumero3.Text = "Número 3:"
        '
        'txtNumero3
        '
        Me.txtNumero3.Location = New System.Drawing.Point(52, 142)
        Me.txtNumero3.Name = "txtNumero3"
        Me.txtNumero3.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero3.TabIndex = 3
        '
        'txtNumero2
        '
        Me.txtNumero2.Location = New System.Drawing.Point(52, 89)
        Me.txtNumero2.Name = "txtNumero2"
        Me.txtNumero2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero2.TabIndex = 2
        '
        'txtNumero1
        '
        Me.txtNumero1.Location = New System.Drawing.Point(52, 40)
        Me.txtNumero1.Name = "txtNumero1"
        Me.txtNumero1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero1.TabIndex = 1
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(52, 179)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 4
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'frmNumerosCrescentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(240, 233)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtNumero1)
        Me.Controls.Add(Me.txtNumero2)
        Me.Controls.Add(Me.txtNumero3)
        Me.Controls.Add(Me.lblNumero3)
        Me.Controls.Add(Me.lblNumero2)
        Me.Controls.Add(Me.lblNumero1)
        Me.Name = "frmNumerosCrescentes"
        Me.Text = "Números Crescentes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNumero1 As System.Windows.Forms.Label
    Friend WithEvents lblNumero2 As System.Windows.Forms.Label
    Friend WithEvents lblNumero3 As System.Windows.Forms.Label
    Friend WithEvents txtNumero3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumero1 As System.Windows.Forms.TextBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
