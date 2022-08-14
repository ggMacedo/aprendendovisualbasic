<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx1_3Nomes
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
        Me.lblNome1 = New System.Windows.Forms.Label()
        Me.lblNome2 = New System.Windows.Forms.Label()
        Me.lblNome3 = New System.Windows.Forms.Label()
        Me.txtNome1 = New System.Windows.Forms.TextBox()
        Me.txtNome2 = New System.Windows.Forms.TextBox()
        Me.txtNome3 = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNome1
        '
        Me.lblNome1.AutoSize = True
        Me.lblNome1.Location = New System.Drawing.Point(8, 26)
        Me.lblNome1.Name = "lblNome1"
        Me.lblNome1.Size = New System.Drawing.Size(47, 13)
        Me.lblNome1.TabIndex = 0
        Me.lblNome1.Text = "Nome 1:"
        '
        'lblNome2
        '
        Me.lblNome2.AutoSize = True
        Me.lblNome2.Location = New System.Drawing.Point(8, 91)
        Me.lblNome2.Name = "lblNome2"
        Me.lblNome2.Size = New System.Drawing.Size(47, 13)
        Me.lblNome2.TabIndex = 1
        Me.lblNome2.Text = "Nome 2:"
        '
        'lblNome3
        '
        Me.lblNome3.AutoSize = True
        Me.lblNome3.Location = New System.Drawing.Point(8, 157)
        Me.lblNome3.Name = "lblNome3"
        Me.lblNome3.Size = New System.Drawing.Size(47, 13)
        Me.lblNome3.TabIndex = 2
        Me.lblNome3.Text = "Nome 3:"
        '
        'txtNome1
        '
        Me.txtNome1.Location = New System.Drawing.Point(11, 53)
        Me.txtNome1.Name = "txtNome1"
        Me.txtNome1.Size = New System.Drawing.Size(100, 20)
        Me.txtNome1.TabIndex = 1
        '
        'txtNome2
        '
        Me.txtNome2.Location = New System.Drawing.Point(11, 121)
        Me.txtNome2.Name = "txtNome2"
        Me.txtNome2.Size = New System.Drawing.Size(100, 20)
        Me.txtNome2.TabIndex = 2
        '
        'txtNome3
        '
        Me.txtNome3.Location = New System.Drawing.Point(11, 184)
        Me.txtNome3.Name = "txtNome3"
        Me.txtNome3.Size = New System.Drawing.Size(100, 20)
        Me.txtNome3.TabIndex = 3
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(11, 210)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 4
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'frmEx1_3Nomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(168, 262)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtNome3)
        Me.Controls.Add(Me.txtNome2)
        Me.Controls.Add(Me.txtNome1)
        Me.Controls.Add(Me.lblNome3)
        Me.Controls.Add(Me.lblNome2)
        Me.Controls.Add(Me.lblNome1)
        Me.Name = "frmEx1_3Nomes"
        Me.Text = "Nomes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome1 As System.Windows.Forms.Label
    Friend WithEvents lblNome2 As System.Windows.Forms.Label
    Friend WithEvents lblNome3 As System.Windows.Forms.Label
    Friend WithEvents txtNome1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNome2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNome3 As System.Windows.Forms.TextBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
