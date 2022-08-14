<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTemp))
        Me.lblTempC = New System.Windows.Forms.Label()
        Me.txtTempC = New System.Windows.Forms.TextBox()
        Me.btnConverter = New System.Windows.Forms.Button()
        Me.lblTempF = New System.Windows.Forms.Label()
        Me.txtTempF = New System.Windows.Forms.TextBox()
        Me.lblTempK = New System.Windows.Forms.Label()
        Me.txtTempK = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTempC
        '
        Me.lblTempC.AutoSize = True
        Me.lblTempC.Location = New System.Drawing.Point(13, 13)
        Me.lblTempC.Name = "lblTempC"
        Me.lblTempC.Size = New System.Drawing.Size(98, 13)
        Me.lblTempC.TabIndex = 0
        Me.lblTempC.Text = "Temperatura em °C"
        '
        'txtTempC
        '
        Me.txtTempC.Location = New System.Drawing.Point(16, 44)
        Me.txtTempC.Name = "txtTempC"
        Me.txtTempC.Size = New System.Drawing.Size(100, 20)
        Me.txtTempC.TabIndex = 1
        '
        'btnConverter
        '
        Me.btnConverter.Location = New System.Drawing.Point(16, 88)
        Me.btnConverter.Name = "btnConverter"
        Me.btnConverter.Size = New System.Drawing.Size(100, 23)
        Me.btnConverter.TabIndex = 2
        Me.btnConverter.Text = "Converter"
        Me.btnConverter.UseVisualStyleBackColor = True
        '
        'lblTempF
        '
        Me.lblTempF.AutoSize = True
        Me.lblTempF.Location = New System.Drawing.Point(16, 129)
        Me.lblTempF.Name = "lblTempF"
        Me.lblTempF.Size = New System.Drawing.Size(97, 13)
        Me.lblTempF.TabIndex = 3
        Me.lblTempF.Text = "Temperatura em °F"
        '
        'txtTempF
        '
        Me.txtTempF.Location = New System.Drawing.Point(19, 163)
        Me.txtTempF.Name = "txtTempF"
        Me.txtTempF.Size = New System.Drawing.Size(100, 20)
        Me.txtTempF.TabIndex = 3
        '
        'lblTempK
        '
        Me.lblTempK.AutoSize = True
        Me.lblTempK.Location = New System.Drawing.Point(16, 206)
        Me.lblTempK.Name = "lblTempK"
        Me.lblTempK.Size = New System.Drawing.Size(98, 13)
        Me.lblTempK.TabIndex = 5
        Me.lblTempK.Text = "Temperatura em °K"
        '
        'txtTempK
        '
        Me.txtTempK.Location = New System.Drawing.Point(19, 246)
        Me.txtTempK.Name = "txtTempK"
        Me.txtTempK.Size = New System.Drawing.Size(100, 20)
        Me.txtTempK.TabIndex = 4
        '
        'frmTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(199, 290)
        Me.Controls.Add(Me.txtTempK)
        Me.Controls.Add(Me.lblTempK)
        Me.Controls.Add(Me.txtTempF)
        Me.Controls.Add(Me.lblTempF)
        Me.Controls.Add(Me.btnConverter)
        Me.Controls.Add(Me.txtTempC)
        Me.Controls.Add(Me.lblTempC)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTemp"
        Me.Text = "Temperatura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTempC As System.Windows.Forms.Label
    Friend WithEvents txtTempC As System.Windows.Forms.TextBox
    Friend WithEvents btnConverter As System.Windows.Forms.Button
    Friend WithEvents lblTempF As System.Windows.Forms.Label
    Friend WithEvents txtTempF As System.Windows.Forms.TextBox
    Friend WithEvents lblTempK As System.Windows.Forms.Label
    Friend WithEvents txtTempK As System.Windows.Forms.TextBox

End Class
