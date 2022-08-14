<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEx4Fatorial
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
        Me.btnFatorial = New System.Windows.Forms.Button()
        Me.lblFatorial = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnFatorial
        '
        Me.btnFatorial.Location = New System.Drawing.Point(12, 61)
        Me.btnFatorial.Name = "btnFatorial"
        Me.btnFatorial.Size = New System.Drawing.Size(100, 23)
        Me.btnFatorial.TabIndex = 0
        Me.btnFatorial.Text = "Fatorial"
        Me.btnFatorial.UseVisualStyleBackColor = True
        '
        'lblFatorial
        '
        Me.lblFatorial.AutoSize = True
        Me.lblFatorial.Location = New System.Drawing.Point(9, 19)
        Me.lblFatorial.Name = "lblFatorial"
        Me.lblFatorial.Size = New System.Drawing.Size(44, 13)
        Me.lblFatorial.TabIndex = 1
        Me.lblFatorial.Text = "Fatorial:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(12, 35)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 2
        '
        'frmEx4Fatorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(156, 115)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblFatorial)
        Me.Controls.Add(Me.btnFatorial)
        Me.Name = "frmEx4Fatorial"
        Me.Text = "Ex4Fatorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFatorial As System.Windows.Forms.Button
    Friend WithEvents lblFatorial As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox

End Class
