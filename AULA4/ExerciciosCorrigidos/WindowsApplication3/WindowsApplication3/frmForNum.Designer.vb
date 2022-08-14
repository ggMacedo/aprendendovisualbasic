<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForNum
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
        Me.txtPNum = New System.Windows.Forms.TextBox()
        Me.txtSNum = New System.Windows.Forms.TextBox()
        Me.lblPNum = New System.Windows.Forms.Label()
        Me.lblSNum = New System.Windows.Forms.Label()
        Me.btnExibir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPNum
        '
        Me.txtPNum.Location = New System.Drawing.Point(69, 40)
        Me.txtPNum.Name = "txtPNum"
        Me.txtPNum.Size = New System.Drawing.Size(100, 20)
        Me.txtPNum.TabIndex = 0
        '
        'txtSNum
        '
        Me.txtSNum.Location = New System.Drawing.Point(69, 85)
        Me.txtSNum.Name = "txtSNum"
        Me.txtSNum.Size = New System.Drawing.Size(100, 20)
        Me.txtSNum.TabIndex = 1
        '
        'lblPNum
        '
        Me.lblPNum.AutoSize = True
        Me.lblPNum.Location = New System.Drawing.Point(69, 21)
        Me.lblPNum.Name = "lblPNum"
        Me.lblPNum.Size = New System.Drawing.Size(60, 13)
        Me.lblPNum.TabIndex = 2
        Me.lblPNum.Text = "1º Número:"
        '
        'lblSNum
        '
        Me.lblSNum.AutoSize = True
        Me.lblSNum.Location = New System.Drawing.Point(69, 66)
        Me.lblSNum.Name = "lblSNum"
        Me.lblSNum.Size = New System.Drawing.Size(60, 13)
        Me.lblSNum.TabIndex = 3
        Me.lblSNum.Text = "2º Número:"
        '
        'btnExibir
        '
        Me.btnExibir.Location = New System.Drawing.Point(83, 124)
        Me.btnExibir.Name = "btnExibir"
        Me.btnExibir.Size = New System.Drawing.Size(75, 23)
        Me.btnExibir.TabIndex = 4
        Me.btnExibir.Text = "Exibir"
        Me.btnExibir.UseVisualStyleBackColor = True
        '
        'frmForNum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExibir)
        Me.Controls.Add(Me.lblSNum)
        Me.Controls.Add(Me.lblPNum)
        Me.Controls.Add(Me.txtSNum)
        Me.Controls.Add(Me.txtPNum)
        Me.Name = "frmForNum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "For"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPNum As System.Windows.Forms.TextBox
    Friend WithEvents txtSNum As System.Windows.Forms.TextBox
    Friend WithEvents lblPNum As System.Windows.Forms.Label
    Friend WithEvents lblSNum As System.Windows.Forms.Label
    Friend WithEvents btnExibir As System.Windows.Forms.Button

End Class
