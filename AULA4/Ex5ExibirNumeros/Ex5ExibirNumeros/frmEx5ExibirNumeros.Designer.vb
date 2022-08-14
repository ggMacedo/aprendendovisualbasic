<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx5ExibirNumeros
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
        Me.lblNu1 = New System.Windows.Forms.Label()
        Me.txtNu1 = New System.Windows.Forms.TextBox()
        Me.lblNu2 = New System.Windows.Forms.Label()
        Me.txtNu2 = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNu1
        '
        Me.lblNu1.AutoSize = True
        Me.lblNu1.Location = New System.Drawing.Point(12, 26)
        Me.lblNu1.Name = "lblNu1"
        Me.lblNu1.Size = New System.Drawing.Size(56, 13)
        Me.lblNu1.TabIndex = 0
        Me.lblNu1.Text = "Número 1:"
        '
        'txtNu1
        '
        Me.txtNu1.Location = New System.Drawing.Point(15, 52)
        Me.txtNu1.Name = "txtNu1"
        Me.txtNu1.Size = New System.Drawing.Size(100, 20)
        Me.txtNu1.TabIndex = 1
        '
        'lblNu2
        '
        Me.lblNu2.AutoSize = True
        Me.lblNu2.Location = New System.Drawing.Point(12, 90)
        Me.lblNu2.Name = "lblNu2"
        Me.lblNu2.Size = New System.Drawing.Size(56, 13)
        Me.lblNu2.TabIndex = 2
        Me.lblNu2.Text = "Número 2:"
        '
        'txtNu2
        '
        Me.txtNu2.Location = New System.Drawing.Point(15, 121)
        Me.txtNu2.Name = "txtNu2"
        Me.txtNu2.Size = New System.Drawing.Size(100, 20)
        Me.txtNu2.TabIndex = 2
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(15, 158)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 3
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'frmEx5ExibirNumeros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 199)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtNu2)
        Me.Controls.Add(Me.lblNu2)
        Me.Controls.Add(Me.txtNu1)
        Me.Controls.Add(Me.lblNu1)
        Me.Name = "frmEx5ExibirNumeros"
        Me.Text = "Exibir números"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNu1 As System.Windows.Forms.Label
    Friend WithEvents txtNu1 As System.Windows.Forms.TextBox
    Friend WithEvents lblNu2 As System.Windows.Forms.Label
    Friend WithEvents txtNu2 As System.Windows.Forms.TextBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
