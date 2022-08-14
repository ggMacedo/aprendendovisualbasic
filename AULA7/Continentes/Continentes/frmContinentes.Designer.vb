<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContinentes
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
        Me.cmbContinente = New System.Windows.Forms.ComboBox()
        Me.cmbPaises = New System.Windows.Forms.ComboBox()
        Me.pcbBandeira = New System.Windows.Forms.PictureBox()
        Me.lblContinente = New System.Windows.Forms.Label()
        Me.lblPaises = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        CType(Me.pcbBandeira, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbContinente
        '
        Me.cmbContinente.FormattingEnabled = True
        Me.cmbContinente.Items.AddRange(New Object() {"África", "Ásia", "América", "Europa", "Oceania"})
        Me.cmbContinente.Location = New System.Drawing.Point(12, 42)
        Me.cmbContinente.Name = "cmbContinente"
        Me.cmbContinente.Size = New System.Drawing.Size(121, 21)
        Me.cmbContinente.TabIndex = 1
        '
        'cmbPaises
        '
        Me.cmbPaises.FormattingEnabled = True
        Me.cmbPaises.Location = New System.Drawing.Point(15, 133)
        Me.cmbPaises.Name = "cmbPaises"
        Me.cmbPaises.Size = New System.Drawing.Size(121, 21)
        Me.cmbPaises.TabIndex = 2
        '
        'pcbBandeira
        '
        Me.pcbBandeira.Location = New System.Drawing.Point(160, 42)
        Me.pcbBandeira.Name = "pcbBandeira"
        Me.pcbBandeira.Size = New System.Drawing.Size(175, 112)
        Me.pcbBandeira.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbBandeira.TabIndex = 2
        Me.pcbBandeira.TabStop = False
        '
        'lblContinente
        '
        Me.lblContinente.AutoSize = True
        Me.lblContinente.BackColor = System.Drawing.SystemColors.Control
        Me.lblContinente.Location = New System.Drawing.Point(9, 18)
        Me.lblContinente.Name = "lblContinente"
        Me.lblContinente.Size = New System.Drawing.Size(61, 13)
        Me.lblContinente.TabIndex = 3
        Me.lblContinente.Text = "Continente:"
        '
        'lblPaises
        '
        Me.lblPaises.AutoSize = True
        Me.lblPaises.Location = New System.Drawing.Point(12, 104)
        Me.lblPaises.Name = "lblPaises"
        Me.lblPaises.Size = New System.Drawing.Size(43, 13)
        Me.lblPaises.TabIndex = 4
        Me.lblPaises.Text = "Países:"
        '
        'dtpData
        '
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpData.Location = New System.Drawing.Point(237, 12)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Size = New System.Drawing.Size(98, 20)
        Me.dtpData.TabIndex = 3
        '
        'frmContinentes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(347, 181)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.lblPaises)
        Me.Controls.Add(Me.lblContinente)
        Me.Controls.Add(Me.pcbBandeira)
        Me.Controls.Add(Me.cmbPaises)
        Me.Controls.Add(Me.cmbContinente)
        Me.Name = "frmContinentes"
        Me.Text = "Continentes"
        CType(Me.pcbBandeira, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbContinente As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPaises As System.Windows.Forms.ComboBox
    Friend WithEvents pcbBandeira As System.Windows.Forms.PictureBox
    Friend WithEvents lblContinente As System.Windows.Forms.Label
    Friend WithEvents lblPaises As System.Windows.Forms.Label
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker

End Class
