<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblMes = New System.Windows.Forms.Label()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(8, 9)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(167, 13)
        Me.lblMes.TabIndex = 0
        Me.lblMes.Text = "Digite o número do mês desejado:"
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(42, 35)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 1
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(42, 72)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(100, 23)
        Me.btnExibir.TabIndex = 2
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(187, 129)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.lblMes)
        Me.Name = "Form1"
        Me.Text = "Mês"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents txtMes As System.Windows.Forms.TextBox
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
