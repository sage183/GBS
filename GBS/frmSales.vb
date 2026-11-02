
Imports Microsoft.Data.SqlClient
Public Class frmSales

    Dim total As Decimal = 0

    Private Function CalculateTotal(price As Decimal, quantity As Integer) As Decimal

        Return price * quantity

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Try
            Dim productID As Integer
            Dim quantity As Integer

            If Not Integer.TryParse(txtProductID.Text, productID) OrElse productID <= 0 OrElse
               Not Integer.TryParse(txtSalesQuantity.Text, quantity) OrElse quantity <= 0 Then

                MsgBox("Enter a valid product ID and quantity.")
                Return

            End If

            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim cmd As New SqlCommand(
                    "SELECT Price FROM Products WHERE ProductID=@id", con)

                cmd.Parameters.AddWithValue("@id", productID)

                Dim result = cmd.ExecuteScalar()

                If result Is Nothing Then
                    MsgBox("Product not found.")
                    Return
                End If

                Dim price As Decimal = CDec(result)

                total = CalculateTotal(price, quantity)

                lblTotal.Text = "Total: KSh " & total.ToString("N2")

            End Using

        Catch ex As Exception
            MsgBox("Calculation error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        Dim productID As Integer
        Dim quantity As Integer

        If Not Integer.TryParse(txtProductID.Text, productID) OrElse
           Not Integer.TryParse(txtSalesQuantity.Text, quantity) OrElse
           productID <= 0 OrElse quantity <= 0 OrElse total <= 0 Then

            MsgBox("Calculate a valid sale first.")
            Return

        End If

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Using trans = con.BeginTransaction()

                    Try
                        Dim cmd As New SqlCommand(
                            "UPDATE Products SET Quantity=Quantity-@qty " &
                            "WHERE ProductID=@id AND Quantity>=@qty", con, trans)

                        cmd.Parameters.AddWithValue("@qty", quantity)
                        cmd.Parameters.AddWithValue("@id", productID)

                        If cmd.ExecuteNonQuery() = 0 Then
                            trans.Rollback()
                            MsgBox("Product not found or insufficient stock.")
                            Return
                        End If

                        trans.Commit()

                    Catch
                        trans.Rollback()
                        Throw
                    End Try

                End Using

            End Using

            MsgBox("Sale processed successfully! Total: KSh " & total.ToString("N2"))

            txtProductID.Clear()
            txtSalesQuantity.Clear()
            lblTotal.Text = "Total: KSh 0.00"
            total = 0

        Catch ex As Exception
            MsgBox("Sale error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtProductID.Clear()
        txtSalesQuantity.Clear()
        lblTotal.Text = "Total: KSh 0.00"
        total = 0

    End Sub
    Private Sub TestExceptions()

        Try
            Dim quantity As Integer = Integer.Parse(txtSalesQuantity.Text)

            Dim result As Decimal = 100 / quantity

            MsgBox("Calculation result: " & result)

        Catch ex As FormatException
            MsgBox("Please enter numbers only.")

        Catch ex As DivideByZeroException
            MsgBox("Division by zero is not allowed.")

        Catch ex As Exception
            MsgBox("An unexpected error occurred: " & ex.Message)

        End Try

    End Sub

End Class
