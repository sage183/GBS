<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        lblProductID = New Label()
        lblQuantity = New Label()
        lblTotal = New Label()
        txtProductID = New TextBox()
        txtQuantity = New TextBox()
        txtTotal = New TextBox()
        btnCalculate = New Button()
        btnProcess = New Button()
        btnClear = New Button()
        txtSalesQuantity = New TextBox()
        SuspendLayout()
        ' 
        ' lblProductID
        ' 
        lblProductID.AutoSize = True
        lblProductID.Location = New Point(28, 9)
        lblProductID.Name = "lblProductID"
        lblProductID.Size = New Size(60, 15)
        lblProductID.TabIndex = 0
        lblProductID.Text = "ProductID"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(28, 59)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 1
        lblQuantity.Text = "Quantity"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(28, 115)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(32, 15)
        lblTotal.TabIndex = 2
        lblTotal.Text = "Total"
        ' 
        ' txtProductID
        ' 
        txtProductID.Location = New Point(193, 12)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(194, 23)
        txtProductID.TabIndex = 3
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(193, 56)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(210, 23)
        txtQuantity.TabIndex = 4
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(193, 107)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(224, 23)
        txtTotal.TabIndex = 5
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(311, 195)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(177, 50)
        btnCalculate.TabIndex = 6
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnProcess
        ' 
        btnProcess.Location = New Point(555, 198)
        btnProcess.Name = "btnProcess"
        btnProcess.Size = New Size(150, 49)
        btnProcess.TabIndex = 7
        btnProcess.Text = "Process"
        btnProcess.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(431, 276)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(178, 37)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtSalesQuantity
        ' 
        txtSalesQuantity.Location = New Point(502, 33)
        txtSalesQuantity.Name = "txtSalesQuantity"
        txtSalesQuantity.Size = New Size(219, 23)
        txtSalesQuantity.TabIndex = 9
        ' 
        ' frmSales
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkKhaki
        ClientSize = New Size(800, 450)
        Controls.Add(txtSalesQuantity)
        Controls.Add(btnClear)
        Controls.Add(btnProcess)
        Controls.Add(btnCalculate)
        Controls.Add(txtTotal)
        Controls.Add(txtQuantity)
        Controls.Add(txtProductID)
        Controls.Add(lblTotal)
        Controls.Add(lblQuantity)
        Controls.Add(lblProductID)
        Name = "frmSales"
        Text = "frmSales"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProductID As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSalesQuantity As TextBox
End Class
