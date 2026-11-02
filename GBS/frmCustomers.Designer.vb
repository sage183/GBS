<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        txtCustomerName = New TextBox()
        txtPhone = New TextBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvCustomers = New DataGridView()
        btnSearch = New Button()
        txtSearch = New TextBox()
        lblcustomerForm = New Label()
        CType(dgvCustomers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(300, 66)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(257, 23)
        txtCustomerName.TabIndex = 0
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(300, 104)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(269, 23)
        txtPhone.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(230, 156)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(158, 48)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(444, 151)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(193, 59)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(264, 239)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(137, 49)
        btnDelete.TabIndex = 4
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(474, 242)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(206, 46)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvCustomers
        ' 
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCustomers.Location = New Point(12, 104)
        dgvCustomers.Name = "dgvCustomers"
        dgvCustomers.Size = New Size(203, 198)
        dgvCustomers.TabIndex = 6
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(276, 320)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(242, 48)
        btnSearch.TabIndex = 7
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(524, 334)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(206, 23)
        txtSearch.TabIndex = 8
        ' 
        ' lblcustomerForm
        ' 
        lblcustomerForm.AutoSize = True
        lblcustomerForm.BackColor = Color.SandyBrown
        lblcustomerForm.Font = New Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblcustomerForm.Location = New Point(276, 9)
        lblcustomerForm.Name = "lblcustomerForm"
        lblcustomerForm.Size = New Size(257, 36)
        lblcustomerForm.TabIndex = 9
        lblcustomerForm.Text = "CUSTOMER FORM"
        ' 
        ' frmCustomers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Cyan
        ClientSize = New Size(800, 450)
        Controls.Add(lblcustomerForm)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(dgvCustomers)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtPhone)
        Controls.Add(txtCustomerName)
        Name = "frmCustomers"
        Text = "frmCustomers"
        CType(dgvCustomers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvCustomers As DataGridView
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblcustomerForm As Label
End Class
