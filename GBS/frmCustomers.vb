Imports Microsoft.Data.SqlClient

Public Class FrmCustomers

    Dim selectedCustomerID As Integer = 0

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub

    Private Sub LoadCustomers()

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim sql As String = "SELECT * FROM Customers"

                Using da As New SqlDataAdapter(sql, con)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvCustomers.DataSource = dt
                End Using

            End Using

        Catch ex As Exception
            MsgBox("Error loading customers: " & ex.Message)
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtCustomerName.Text.Trim() = "" Or txtPhone.Text.Trim() = "" Then
            MsgBox("Enter the customer name and phone number.")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim sql As String = "INSERT INTO Customers (CustomerName, Phone) VALUES (@name, @phone)"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim())
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MsgBox("Customer saved successfully!")
            LoadCustomers()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error saving customer: " & ex.Message)
        End Try

    End Sub

    Private Sub dgvCustomers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCustomers.Rows(e.RowIndex)

            selectedCustomerID = Convert.ToInt32(row.Cells("CustomerID").Value)
            txtCustomerName.Text = row.Cells("CustomerName").Value.ToString()
            txtPhone.Text = row.Cells("Phone").Value.ToString()
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If selectedCustomerID = 0 Then
            MsgBox("Select a customer first.")
            Return
        End If

        If txtCustomerName.Text.Trim() = "" Or txtPhone.Text.Trim() = "" Then
            MsgBox("Enter the customer name and phone number.")
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim sql As String = "UPDATE Customers SET CustomerName=@name, Phone=@phone WHERE CustomerID=@id"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@name", txtCustomerName.Text.Trim())
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", selectedCustomerID)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MsgBox("Customer updated successfully!")
            LoadCustomers()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error updating customer: " & ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If selectedCustomerID = 0 Then
            MsgBox("Select a customer first.")
            Return
        End If

        If MessageBox.Show("Delete this customer?", "Confirm",
                           MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim sql As String = "DELETE FROM Customers WHERE CustomerID=@id"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@id", selectedCustomerID)
                    cmd.ExecuteNonQuery()
                End Using

            End Using

            MsgBox("Customer deleted successfully!")
            LoadCustomers()
            ClearFields()

        Catch ex As Exception
            MsgBox("Error deleting customer: " & ex.Message)
        End Try

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            Using con As New SqlConnection(connectionString)
                con.Open()

                Dim sql As String = "SELECT * FROM Customers WHERE CustomerName LIKE @search OR Phone LIKE @search"

                Using cmd As New SqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")

                    Using da As New SqlDataAdapter(cmd)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        dgvCustomers.DataSource = dt
                    End Using

                End Using
            End Using

        Catch ex As Exception
            MsgBox("Search error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()

        txtCustomerName.Clear()
        txtPhone.Clear()
        txtSearch.Clear()
        selectedCustomerID = 0
        dgvCustomers.ClearSelection()

    End Sub

End Class