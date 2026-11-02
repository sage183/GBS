Imports Microsoft.Data.SqlClient

Public Class FrmProducts

    Dim selectedProductID As Integer = 0

    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

    'DISPLAY PRODUCTS
    Private Sub LoadProducts()

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String = "SELECT * FROM Products"

                Using da As New SqlDataAdapter(sql, con)

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvProducts.DataSource = dt

                    If dgvProducts.Columns.Contains("ProductID") Then
                        dgvProducts.Columns("ProductID").Visible = False
                    End If

                End Using

            End Using

        Catch ex As Exception
            MsgBox("Error loading products: " & ex.Message)
        End Try

    End Sub

    'SAVE PRODUCT
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim price As Decimal
        Dim quantity As Integer

        If txtProductName.Text.Trim() = "" Or txtCategory.Text.Trim() = "" Then
            MsgBox("Please enter the product name and category.")
            Return
        End If

        If Not Decimal.TryParse(txtPrice.Text, price) OrElse price < 0 Then
            MsgBox("Enter a valid price.")
            Return
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity < 0 Then
            MsgBox("Enter a valid quantity.")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String = "INSERT INTO Products (ProductName, Category, Price, Quantity) VALUES (@name, @category, @price, @quantity)"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim())
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim())
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@quantity", quantity)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MsgBox("Product saved successfully!")

            LoadProducts()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error saving product: " & ex.Message)
        End Try

    End Sub

    'SELECT PRODUCT FROM GRID
    Private Sub dgvProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducts.CellClick

        If e.RowIndex >= 0 Then

            Dim row As DataGridViewRow = dgvProducts.Rows(e.RowIndex)

            selectedProductID = Convert.ToInt32(row.Cells("ProductID").Value)

            txtProductName.Text = row.Cells("ProductName").Value.ToString()
            txtCategory.Text = row.Cells("Category").Value.ToString()
            txtPrice.Text = row.Cells("Price").Value.ToString()
            txtQuantity.Text = row.Cells("Quantity").Value.ToString()

        End If

    End Sub

    'UPDATE PRODUCT
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedProductID = 0 Then
            MsgBox("Please select a product from the table first.")
            Return
        End If

        Dim price As Decimal
        Dim quantity As Integer

        If Not Decimal.TryParse(txtPrice.Text, price) OrElse price < 0 Then
            MsgBox("Enter a valid price.")
            Return
        End If

        If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity < 0 Then
            MsgBox("Enter a valid quantity.")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String = "UPDATE Products SET ProductName=@name, Category=@category, Price=@price, Quantity=@quantity WHERE ProductID=@id"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim())
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text.Trim())
                    cmd.Parameters.AddWithValue("@price", price)
                    cmd.Parameters.AddWithValue("@quantity", quantity)
                    cmd.Parameters.AddWithValue("@id", selectedProductID)

                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MsgBox("Product updated successfully!")

            LoadProducts()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error updating product: " & ex.Message)
        End Try

    End Sub

    'DELETE PRODUCT
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedProductID = 0 Then
            MsgBox("Please select a product first.")
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this product?",
                           "Confirm Delete",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String = "DELETE FROM Products WHERE ProductID=@id"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@id", selectedProductID)
                    cmd.ExecuteNonQuery()

                End Using

            End Using

            MsgBox("Product deleted successfully!")

            LoadProducts()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error deleting product: " & ex.Message)
        End Try

    End Sub

    'SEARCH PRODUCTS
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String = "SELECT * FROM Products WHERE ProductName LIKE @search OR Category LIKE @search"

                Using cmd As New SqlCommand(sql, con)

                    cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

                    Using da As New SqlDataAdapter(cmd)

                        Dim dt As New DataTable()
                        da.Fill(dt)

                        dgvProducts.DataSource = dt

                        If dgvProducts.Columns.Contains("ProductID") Then
                            dgvProducts.Columns("ProductID").Visible = False
                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MsgBox("Search error: " & ex.Message)
        End Try

    End Sub

    'CLEAR FIELDS
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()

        txtProductName.Clear()
        txtCategory.Clear()
        txtPrice.Clear()
        txtQuantity.Clear()
        txtSearch.Clear()

        selectedProductID = 0

        dgvProducts.ClearSelection()

    End Sub
    'OPEN FILE
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs) Handles mnuOpen.Click

        OpenFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                txtProductName.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
                MsgBox("File opened successfully!")
            Catch ex As Exception
                MsgBox("Unable to open file: " & ex.Message)
            End Try
        End If

    End Sub

    'SAVE FILE
    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click

        SaveFileDialog1.Filter = "Text Files (*.txt)|*.txt"
        SaveFileDialog1.FileName = "ProductDetails.txt"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim details As String =
                    "Product Name: " & txtProductName.Text & vbCrLf &
                    "Category: " & txtCategory.Text & vbCrLf &
                    "Price: " & txtPrice.Text & vbCrLf &
                    "Quantity: " & txtQuantity.Text

                IO.File.WriteAllText(SaveFileDialog1.FileName, details)

                MsgBox("File saved successfully!")

            Catch ex As Exception
                MsgBox("Unable to save file: " & ex.Message)
            End Try
        End If

    End Sub

    'EXIT
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    'COPY
    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click

        If txtProductName.SelectedText <> "" Then
            Clipboard.SetText(txtProductName.SelectedText)
        Else
            MsgBox("Select some product name text first.")
        End If

    End Sub

    'PASTE
    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click

        If Clipboard.ContainsText() Then
            txtProductName.SelectedText = Clipboard.GetText()
        End If

    End Sub

    'CHANGE FONT
    Private Sub mnuFont_Click(sender As Object, e As EventArgs) Handles mnuFont.Click

        If FontDialog1.ShowDialog() = DialogResult.OK Then
            Me.Font = FontDialog1.Font
        End If

    End Sub

    'CHANGE BACKGROUND COLOUR
    Private Sub mnuColor_Click(sender As Object, e As EventArgs) Handles mnuColor.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Me.BackColor = ColorDialog1.Color
        End If

    End Sub

    'ABOUT
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("GBStation Stationery Supplies System" & vbCrLf &
                        "Developed by RUMEIZA HEES" & vbCrLf &
                        "Umma University",
                        "About",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

    End Sub

End Class