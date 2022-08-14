<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListas
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
        Me.list1 = New System.Windows.Forms.ListBox()
        Me.list2 = New System.Windows.Forms.ListBox()
        Me.list3 = New System.Windows.Forms.ListBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btn1p2 = New System.Windows.Forms.Button()
        Me.btn2p1 = New System.Windows.Forms.Button()
        Me.btn1p3 = New System.Windows.Forms.Button()
        Me.btn2p3 = New System.Windows.Forms.Button()
        Me.btn3p2 = New System.Windows.Forms.Button()
        Me.btn3p1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'list1
        '
        Me.list1.FormattingEnabled = True
        Me.list1.Location = New System.Drawing.Point(3, 54)
        Me.list1.Name = "list1"
        Me.list1.Size = New System.Drawing.Size(120, 199)
        Me.list1.TabIndex = 0
        '
        'list2
        '
        Me.list2.FormattingEnabled = True
        Me.list2.Location = New System.Drawing.Point(191, 54)
        Me.list2.Name = "list2"
        Me.list2.Size = New System.Drawing.Size(120, 199)
        Me.list2.TabIndex = 1
        '
        'list3
        '
        Me.list3.FormattingEnabled = True
        Me.list3.Location = New System.Drawing.Point(389, 54)
        Me.list3.Name = "list3"
        Me.list3.Size = New System.Drawing.Size(120, 199)
        Me.list3.TabIndex = 2
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(3, 13)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(38, 13)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(3, 28)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 4
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(110, 28)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 5
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btn1p2
        '
        Me.btn1p2.Location = New System.Drawing.Point(141, 93)
        Me.btn1p2.Name = "btn1p2"
        Me.btn1p2.Size = New System.Drawing.Size(34, 23)
        Me.btn1p2.TabIndex = 6
        Me.btn1p2.Text = ">"
        Me.btn1p2.UseVisualStyleBackColor = True
        '
        'btn2p1
        '
        Me.btn2p1.Location = New System.Drawing.Point(141, 123)
        Me.btn2p1.Name = "btn2p1"
        Me.btn2p1.Size = New System.Drawing.Size(34, 23)
        Me.btn2p1.TabIndex = 7
        Me.btn2p1.Text = "<"
        Me.btn2p1.UseVisualStyleBackColor = True
        '
        'btn1p3
        '
        Me.btn1p3.Location = New System.Drawing.Point(141, 153)
        Me.btn1p3.Name = "btn1p3"
        Me.btn1p3.Size = New System.Drawing.Size(34, 23)
        Me.btn1p3.TabIndex = 8
        Me.btn1p3.Text = ">>"
        Me.btn1p3.UseVisualStyleBackColor = True
        '
        'btn2p3
        '
        Me.btn2p3.Location = New System.Drawing.Point(334, 93)
        Me.btn2p3.Name = "btn2p3"
        Me.btn2p3.Size = New System.Drawing.Size(33, 23)
        Me.btn2p3.TabIndex = 9
        Me.btn2p3.Text = ">"
        Me.btn2p3.UseVisualStyleBackColor = True
        '
        'btn3p2
        '
        Me.btn3p2.Location = New System.Drawing.Point(334, 123)
        Me.btn3p2.Name = "btn3p2"
        Me.btn3p2.Size = New System.Drawing.Size(33, 23)
        Me.btn3p2.TabIndex = 10
        Me.btn3p2.Text = "<"
        Me.btn3p2.UseVisualStyleBackColor = True
        '
        'btn3p1
        '
        Me.btn3p1.Location = New System.Drawing.Point(334, 152)
        Me.btn3p1.Name = "btn3p1"
        Me.btn3p1.Size = New System.Drawing.Size(33, 23)
        Me.btn3p1.TabIndex = 11
        Me.btn3p1.Text = "<<"
        Me.btn3p1.UseVisualStyleBackColor = True
        '
        'frmListas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 276)
        Me.Controls.Add(Me.btn3p1)
        Me.Controls.Add(Me.btn3p2)
        Me.Controls.Add(Me.btn2p3)
        Me.Controls.Add(Me.btn1p3)
        Me.Controls.Add(Me.btn2p1)
        Me.Controls.Add(Me.btn1p2)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.list3)
        Me.Controls.Add(Me.list2)
        Me.Controls.Add(Me.list1)
        Me.Name = "frmListas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents list1 As System.Windows.Forms.ListBox
    Friend WithEvents list2 As System.Windows.Forms.ListBox
    Friend WithEvents list3 As System.Windows.Forms.ListBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents btn1p2 As System.Windows.Forms.Button
    Friend WithEvents btn2p1 As System.Windows.Forms.Button
    Friend WithEvents btn1p3 As System.Windows.Forms.Button
    Friend WithEvents btn2p3 As System.Windows.Forms.Button
    Friend WithEvents btn3p2 As System.Windows.Forms.Button
    Friend WithEvents btn3p1 As System.Windows.Forms.Button

End Class
