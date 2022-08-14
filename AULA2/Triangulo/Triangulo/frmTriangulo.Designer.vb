<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriangulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTriangulo))
        Me.pbxTriangulo = New System.Windows.Forms.PictureBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.pbxTriangulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxTriangulo
        '
        Me.pbxTriangulo.Image = CType(resources.GetObject("pbxTriangulo.Image"), System.Drawing.Image)
        Me.pbxTriangulo.Location = New System.Drawing.Point(131, 91)
        Me.pbxTriangulo.Name = "pbxTriangulo"
        Me.pbxTriangulo.Size = New System.Drawing.Size(153, 152)
        Me.pbxTriangulo.TabIndex = 0
        Me.pbxTriangulo.TabStop = False
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(15, 144)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(100, 20)
        Me.txtA.TabIndex = 1
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(12, 117)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(17, 13)
        Me.lblA.TabIndex = 2
        Me.lblA.Text = "A:"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Location = New System.Drawing.Point(302, 117)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(17, 13)
        Me.lblC.TabIndex = 3
        Me.lblC.Text = "C:"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(305, 144)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(100, 20)
        Me.txtC.TabIndex = 2
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(195, 255)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(14, 13)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "B"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(153, 284)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(100, 23)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'frmTriangulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(433, 339)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.txtC)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.txtA)
        Me.Controls.Add(Me.pbxTriangulo)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "frmTriangulo"
        Me.Text = "Triangulo"
        CType(Me.pbxTriangulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxTriangulo As System.Windows.Forms.PictureBox
    Friend WithEvents txtA As System.Windows.Forms.TextBox
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblC As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button

End Class
