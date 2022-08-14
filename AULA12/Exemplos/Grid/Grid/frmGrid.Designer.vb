<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrid
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
        Me.dgvGrid = New System.Windows.Forms.DataGridView()
        Me.btnPrencher = New System.Windows.Forms.Button()
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGrid
        '
        Me.dgvGrid.AllowUserToAddRows = False
        Me.dgvGrid.AllowUserToDeleteRows = False
        Me.dgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrid.Location = New System.Drawing.Point(25, 12)
        Me.dgvGrid.MultiSelect = False
        Me.dgvGrid.Name = "dgvGrid"
        Me.dgvGrid.ReadOnly = True
        Me.dgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrid.Size = New System.Drawing.Size(361, 150)
        Me.dgvGrid.TabIndex = 0
        '
        'btnPrencher
        '
        Me.btnPrencher.Location = New System.Drawing.Point(168, 208)
        Me.btnPrencher.Name = "btnPrencher"
        Me.btnPrencher.Size = New System.Drawing.Size(81, 23)
        Me.btnPrencher.TabIndex = 1
        Me.btnPrencher.Text = "Prencher"
        Me.btnPrencher.UseVisualStyleBackColor = True
        '
        'frmGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 251)
        Me.Controls.Add(Me.btnPrencher)
        Me.Controls.Add(Me.dgvGrid)
        Me.Name = "frmGrid"
        Me.Text = "Grid"
        CType(Me.dgvGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrencher As System.Windows.Forms.Button

End Class
