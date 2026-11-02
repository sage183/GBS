<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreceipts
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
        dgvreceipts = New DataGridView()
        btnRefresh = New Button()
        btnClose = New Button()
        CType(dgvreceipts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvreceipts
        ' 
        dgvreceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvreceipts.Location = New Point(1, 107)
        dgvreceipts.Name = "dgvreceipts"
        dgvreceipts.Size = New Size(376, 180)
        dgvreceipts.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(519, 70)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(226, 100)
        btnRefresh.TabIndex = 1
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(535, 199)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(226, 99)
        btnClose.TabIndex = 2
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' frmreceipts
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightPink
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnRefresh)
        Controls.Add(dgvreceipts)
        Name = "frmreceipts"
        Text = "frmreceipts"
        CType(dgvreceipts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvreceipts As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnClose As Button
End Class
