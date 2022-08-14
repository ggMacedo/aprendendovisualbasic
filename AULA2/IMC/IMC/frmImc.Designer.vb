<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmImc
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
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.btnImc = New System.Windows.Forms.Button()
        Me.lblImc = New System.Windows.Forms.Label()
        Me.txtImc = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPeso
        '
        Me.lblPeso.AutoSize = True
        Me.lblPeso.Location = New System.Drawing.Point(13, 13)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(34, 13)
        Me.lblPeso.TabIndex = 0
        Me.lblPeso.Text = "Peso:"
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(16, 42)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(100, 20)
        Me.txtPeso.TabIndex = 1
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(13, 75)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(37, 13)
        Me.lblAltura.TabIndex = 2
        Me.lblAltura.Text = "Altura:"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(16, 101)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(100, 20)
        Me.txtAltura.TabIndex = 2
        '
        'btnImc
        '
        Me.btnImc.Location = New System.Drawing.Point(16, 141)
        Me.btnImc.Name = "btnImc"
        Me.btnImc.Size = New System.Drawing.Size(100, 23)
        Me.btnImc.TabIndex = 3
        Me.btnImc.Text = "IMC"
        Me.btnImc.UseVisualStyleBackColor = True
        '
        'lblImc
        '
        Me.lblImc.AutoSize = True
        Me.lblImc.Location = New System.Drawing.Point(16, 187)
        Me.lblImc.Name = "lblImc"
        Me.lblImc.Size = New System.Drawing.Size(27, 13)
        Me.lblImc.TabIndex = 5
        Me.lblImc.Text = "Imc:"
        '
        'txtImc
        '
        Me.txtImc.Location = New System.Drawing.Point(16, 216)
        Me.txtImc.Name = "txtImc"
        Me.txtImc.Size = New System.Drawing.Size(100, 20)
        Me.txtImc.TabIndex = 4
        '
        'frmImc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(154, 262)
        Me.Controls.Add(Me.txtImc)
        Me.Controls.Add(Me.lblImc)
        Me.Controls.Add(Me.btnImc)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.lblPeso)
        Me.Name = "frmImc"
        Me.Text = "IMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPeso As System.Windows.Forms.Label
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents btnImc As System.Windows.Forms.Button
    Friend WithEvents lblImc As System.Windows.Forms.Label
    Friend WithEvents txtImc As System.Windows.Forms.TextBox

End Class
