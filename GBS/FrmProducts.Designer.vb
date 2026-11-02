<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducts
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
        components = New ComponentModel.Container()
        lblProductName = New Label()
        lblCategory = New Label()
        lblPrice = New Label()
        lblQuantity = New Label()
        txtProductName = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ctxCopy = New ToolStripMenuItem()
        ctxPaste = New ToolStripMenuItem()
        ctxClear = New ToolStripMenuItem()
        txtCategory = New TextBox()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        txtSearch = New TextBox()
        btnSave = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        btnClear = New Button()
        dgvProducts = New DataGridView()
        lblheading = New Label()
        ColorDialog1 = New ColorDialog()
        FontDialog1 = New FontDialog()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        mnuOpen = New ToolStripMenuItem()
        mnuSave = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        mnuFont = New ToolStripMenuItem()
        mnuColor = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        EditToolStripMenuItem2 = New ToolStripMenuItem()
        mnuCopy = New ToolStripMenuItem()
        mnuPaste = New ToolStripMenuItem()
        ContextMenuStrip1.SuspendLayout()
        CType(dgvProducts, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblProductName
        ' 
        lblProductName.AutoSize = True
        lblProductName.Location = New Point(23, 50)
        lblProductName.Name = "lblProductName"
        lblProductName.Size = New Size(81, 15)
        lblProductName.TabIndex = 0
        lblProductName.Text = "ProductName"
        ' 
        ' lblCategory
        ' 
        lblCategory.AutoSize = True
        lblCategory.Location = New Point(23, 87)
        lblCategory.Name = "lblCategory"
        lblCategory.Size = New Size(55, 15)
        lblCategory.TabIndex = 1
        lblCategory.Text = "Category"
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(40, 126)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(33, 15)
        lblPrice.TabIndex = 2
        lblPrice.Text = "Price"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(40, 155)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(53, 15)
        lblQuantity.TabIndex = 3
        lblQuantity.Text = "Quantity"
        ' 
        ' txtProductName
        ' 
        txtProductName.ContextMenuStrip = ContextMenuStrip1
        txtProductName.Location = New Point(216, 55)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(216, 23)
        txtProductName.TabIndex = 4
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {ctxCopy, ctxPaste, ctxClear})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(103, 70)
        ' 
        ' ctxCopy
        ' 
        ctxCopy.Name = "ctxCopy"
        ctxCopy.Size = New Size(102, 22)
        ctxCopy.Text = "Copy"
        ' 
        ' ctxPaste
        ' 
        ctxPaste.Name = "ctxPaste"
        ctxPaste.Size = New Size(102, 22)
        ctxPaste.Text = "Paste"
        ' 
        ' ctxClear
        ' 
        ctxClear.Name = "ctxClear"
        ctxClear.Size = New Size(102, 22)
        ctxClear.Text = "Clear"
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(227, 84)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(205, 23)
        txtCategory.TabIndex = 5
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(227, 123)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(205, 23)
        txtPrice.TabIndex = 6
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(227, 155)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(192, 23)
        txtQuantity.TabIndex = 7
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(227, 192)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(190, 23)
        txtSearch.TabIndex = 8
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(484, 97)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(113, 72)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(645, 84)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(104, 85)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(484, 180)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 74)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(636, 186)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(135, 63)
        btnSearch.TabIndex = 12
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(546, 273)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(171, 52)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvProducts
        ' 
        dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProducts.Location = New Point(12, 251)
        dgvProducts.Name = "dgvProducts"
        dgvProducts.Size = New Size(223, 140)
        dgvProducts.TabIndex = 14
        ' 
        ' lblheading
        ' 
        lblheading.AutoSize = True
        lblheading.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblheading.Location = New Point(297, 19)
        lblheading.Name = "lblheading"
        lblheading.Size = New Size(315, 28)
        lblheading.TabIndex = 15
        lblheading.Text = "PRODUCT MANAGEMENT"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ViewToolStripMenuItem, HelpToolStripMenuItem, EditToolStripMenuItem2})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 16
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuOpen, mnuSave, mnuExit})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' mnuOpen
        ' 
        mnuOpen.Name = "mnuOpen"
        mnuOpen.ShortcutKeys = Keys.Control Or Keys.O
        mnuOpen.Size = New Size(146, 22)
        mnuOpen.Text = "Open"
        ' 
        ' mnuSave
        ' 
        mnuSave.Name = "mnuSave"
        mnuSave.ShortcutKeys = Keys.Control Or Keys.S
        mnuSave.Size = New Size(146, 22)
        mnuSave.Text = "Save"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(146, 22)
        mnuExit.Text = "Exit"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuFont, mnuColor})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(44, 20)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' mnuFont
        ' 
        mnuFont.Name = "mnuFont"
        mnuFont.Size = New Size(214, 22)
        mnuFont.Text = "Change Font"
        ' 
        ' mnuColor
        ' 
        mnuColor.Name = "mnuColor"
        mnuColor.Size = New Size(214, 22)
        mnuColor.Text = "Change Background Color"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {mnuAbout})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.Size = New Size(107, 22)
        mnuAbout.Text = "About"
        ' 
        ' EditToolStripMenuItem2
        ' 
        EditToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {mnuCopy, mnuPaste})
        EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        EditToolStripMenuItem2.Size = New Size(39, 20)
        EditToolStripMenuItem2.Text = "Edit"
        ' 
        ' mnuCopy
        ' 
        mnuCopy.Name = "mnuCopy"
        mnuCopy.ShortcutKeys = Keys.Control Or Keys.C
        mnuCopy.Size = New Size(144, 22)
        mnuCopy.Text = "Copy"
        ' 
        ' mnuPaste
        ' 
        mnuPaste.Name = "mnuPaste"
        mnuPaste.ShortcutKeys = Keys.Control Or Keys.V
        mnuPaste.Size = New Size(144, 22)
        mnuPaste.Text = "Paste"
        ' 
        ' FrmProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(800, 454)
        Controls.Add(lblheading)
        Controls.Add(dgvProducts)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtSearch)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(txtCategory)
        Controls.Add(txtProductName)
        Controls.Add(lblQuantity)
        Controls.Add(lblPrice)
        Controls.Add(lblCategory)
        Controls.Add(lblProductName)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FrmProducts"
        Text = "FrmProducts"
        ContextMenuStrip1.ResumeLayout(False)
        CType(dgvProducts, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProductName As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvProducts As DataGridView
    Friend WithEvents lblheading As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFont As ToolStripMenuItem
    Friend WithEvents mnuColor As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ctxCopy As ToolStripMenuItem
    Friend WithEvents ctxPaste As ToolStripMenuItem
    Friend WithEvents ctxClear As ToolStripMenuItem
End Class
