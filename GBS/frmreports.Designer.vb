<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreports
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
        dgvReports = New DataGridView()
        lblTotalSales = New Label()
        btnLoadReports = New Button()
        btnClose = New Button()
        CType(dgvReports, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvReports
        ' 
        dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvReports.Location = New Point(12, 54)
        dgvReports.Name = "dgvReports"
        dgvReports.Size = New Size(217, 202)
        dgvReports.TabIndex = 0
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalSales.Location = New Point(170, 9)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(194, 36)
        lblTotalSales.TabIndex = 1
        lblTotalSales.Text = "TOTAL SALES"
        ' 
        ' btnLoadReports
        ' 
        btnLoadReports.Location = New Point(272, 83)
        btnLoadReports.Name = "btnLoadReports"
        btnLoadReports.Size = New Size(228, 75)
        btnLoadReports.TabIndex = 2
        btnLoadReports.Text = "Load Reports"
        btnLoadReports.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(272, 164)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(255, 84)
        btnClose.TabIndex = 3
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' FrmReports
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        ClientSize = New Size(800, 450)
        Controls.Add(btnClose)
        Controls.Add(btnLoadReports)
        Controls.Add(lblTotalSales)
        Controls.Add(dgvReports)
        Name = "FrmReports"
        Text = "frmreports"
        CType(dgvReports, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents btnLoadReports As Button
    Friend WithEvents btnClose As Button
End Class
