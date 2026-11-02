<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Label1 = New Label()
        btnProducts = New Button()
        btnCustomers = New Button()
        btnSales = New Button()
        btnLogout = New Button()
        btnSalesHistory = New Button()
        btnReceipts = New Button()
        btnReports = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.RosyBrown
        Label1.Font = New Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.MenuHighlight
        Label1.Location = New Point(187, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(393, 40)
        Label1.TabIndex = 0
        Label1.Text = "GBStation Dashboard"
        ' 
        ' btnProducts
        ' 
        btnProducts.Location = New Point(12, 205)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(176, 57)
        btnProducts.TabIndex = 1
        btnProducts.Text = "Products"
        btnProducts.UseVisualStyleBackColor = True
        ' 
        ' btnCustomers
        ' 
        btnCustomers.Location = New Point(234, 209)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(191, 48)
        btnCustomers.TabIndex = 2
        btnCustomers.Text = "Customers"
        btnCustomers.UseVisualStyleBackColor = True
        ' 
        ' btnSales
        ' 
        btnSales.Location = New Point(453, 213)
        btnSales.Name = "btnSales"
        btnSales.Size = New Size(166, 45)
        btnSales.TabIndex = 3
        btnSales.Text = "Sales"
        btnSales.UseVisualStyleBackColor = True
        ' 
        ' btnLogout
        ' 
        btnLogout.Location = New Point(637, 219)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(148, 44)
        btnLogout.TabIndex = 4
        btnLogout.Text = "Logout"
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnSalesHistory
        ' 
        btnSalesHistory.Location = New Point(326, 281)
        btnSalesHistory.Name = "btnSalesHistory"
        btnSalesHistory.Size = New Size(183, 75)
        btnSalesHistory.TabIndex = 5
        btnSalesHistory.Text = "Sales History"
        btnSalesHistory.UseVisualStyleBackColor = True
        ' 
        ' btnReceipts
        ' 
        btnReceipts.Location = New Point(556, 284)
        btnReceipts.Name = "btnReceipts"
        btnReceipts.Size = New Size(183, 78)
        btnReceipts.TabIndex = 6
        btnReceipts.Text = "Receipts"
        btnReceipts.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Location = New Point(73, 294)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(213, 59)
        btnReports.TabIndex = 7
        btnReports.Text = "Reports"
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.IndianRed
        ClientSize = New Size(800, 450)
        Controls.Add(btnReports)
        Controls.Add(btnReceipts)
        Controls.Add(btnSalesHistory)
        Controls.Add(btnLogout)
        Controls.Add(btnSales)
        Controls.Add(btnCustomers)
        Controls.Add(btnProducts)
        Controls.Add(Label1)
        Name = "frmDashboard"
        Text = "frmDashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnSales As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSalesHistory As Button
    Friend WithEvents btnReceipts As Button
    Friend WithEvents btnReports As Button
End Class
