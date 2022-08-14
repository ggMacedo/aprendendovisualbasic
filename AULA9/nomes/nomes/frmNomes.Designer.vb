<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNomes
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
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.lbxLista1 = New System.Windows.Forms.ListBox()
        Me.lbxLista2 = New System.Windows.Forms.ListBox()
        Me.lbxLista3 = New System.Windows.Forms.ListBox()
        Me.btnProximo = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnProximoPlus = New System.Windows.Forms.Button()
        Me.btnProximo2 = New System.Windows.Forms.Button()
        Me.btnAnterior2 = New System.Windows.Forms.Button()
        Me.btnAnteriorPlus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(9, 9)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 0
        Me.lblNome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(12, 28)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 1
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(118, 27)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(28, 20)
        Me.btnAdicionar.TabIndex = 2
        Me.btnAdicionar.Text = "+"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'lbxLista1
        '
        Me.lbxLista1.FormattingEnabled = True
        Me.lbxLista1.Location = New System.Drawing.Point(12, 67)
        Me.lbxLista1.Name = "lbxLista1"
        Me.lbxLista1.Size = New System.Drawing.Size(120, 147)
        Me.lbxLista1.TabIndex = 3
        '
        'lbxLista2
        '
        Me.lbxLista2.FormattingEnabled = True
        Me.lbxLista2.Location = New System.Drawing.Point(200, 67)
        Me.lbxLista2.Name = "lbxLista2"
        Me.lbxLista2.Size = New System.Drawing.Size(120, 147)
        Me.lbxLista2.TabIndex = 4
        '
        'lbxLista3
        '
        Me.lbxLista3.FormattingEnabled = True
        Me.lbxLista3.Location = New System.Drawing.Point(390, 67)
        Me.lbxLista3.Name = "lbxLista3"
        Me.lbxLista3.Size = New System.Drawing.Size(120, 147)
        Me.lbxLista3.TabIndex = 5
        '
        'btnProximo
        '
        Me.btnProximo.Location = New System.Drawing.Point(152, 83)
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(33, 23)
        Me.btnProximo.TabIndex = 3
        Me.btnProximo.Text = ">"
        Me.btnProximo.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(152, 124)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(33, 23)
        Me.btnAnterior.TabIndex = 4
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnProximoPlus
        '
        Me.btnProximoPlus.Location = New System.Drawing.Point(152, 163)
        Me.btnProximoPlus.Name = "btnProximoPlus"
        Me.btnProximoPlus.Size = New System.Drawing.Size(33, 23)
        Me.btnProximoPlus.TabIndex = 5
        Me.btnProximoPlus.Text = ">>"
        Me.btnProximoPlus.UseVisualStyleBackColor = True
        '
        'btnProximo2
        '
        Me.btnProximo2.Location = New System.Drawing.Point(344, 83)
        Me.btnProximo2.Name = "btnProximo2"
        Me.btnProximo2.Size = New System.Drawing.Size(31, 23)
        Me.btnProximo2.TabIndex = 6
        Me.btnProximo2.Text = ">"
        Me.btnProximo2.UseVisualStyleBackColor = True
        '
        'btnAnterior2
        '
        Me.btnAnterior2.Location = New System.Drawing.Point(344, 124)
        Me.btnAnterior2.Name = "btnAnterior2"
        Me.btnAnterior2.Size = New System.Drawing.Size(31, 23)
        Me.btnAnterior2.TabIndex = 7
        Me.btnAnterior2.Text = "<"
        Me.btnAnterior2.UseVisualStyleBackColor = True
        '
        'btnAnteriorPlus
        '
        Me.btnAnteriorPlus.Location = New System.Drawing.Point(344, 163)
        Me.btnAnteriorPlus.Name = "btnAnteriorPlus"
        Me.btnAnteriorPlus.Size = New System.Drawing.Size(31, 23)
        Me.btnAnteriorPlus.TabIndex = 8
        Me.btnAnteriorPlus.Text = "<<"
        Me.btnAnteriorPlus.UseVisualStyleBackColor = True
        '
        'frmNomes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 229)
        Me.Controls.Add(Me.btnAnteriorPlus)
        Me.Controls.Add(Me.btnAnterior2)
        Me.Controls.Add(Me.btnProximo2)
        Me.Controls.Add(Me.btnProximoPlus)
        Me.Controls.Add(Me.btnAnterior)
        Me.Controls.Add(Me.btnProximo)
        Me.Controls.Add(Me.lbxLista3)
        Me.Controls.Add(Me.lbxLista2)
        Me.Controls.Add(Me.lbxLista1)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Name = "frmNomes"
        Me.Text = "Nomes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents lbxLista1 As System.Windows.Forms.ListBox
    Friend WithEvents lbxLista2 As System.Windows.Forms.ListBox
    Friend WithEvents lbxLista3 As System.Windows.Forms.ListBox
    Friend WithEvents btnProximo As System.Windows.Forms.Button
    Friend WithEvents btnAnterior As System.Windows.Forms.Button
    Friend WithEvents btnProximoPlus As System.Windows.Forms.Button
    Friend WithEvents btnProximo2 As System.Windows.Forms.Button
    Friend WithEvents btnAnterior2 As System.Windows.Forms.Button
    Friend WithEvents btnAnteriorPlus As System.Windows.Forms.Button

End Class
