Imports Microsoft.Data.SqlClient

Public Class FrmReceipts

    Private Sub FrmReceipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReceipts()
    End Sub

    Private Sub LoadReceipts()

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String =
                    "SELECT Sale.SaleID, Products.ProductName, Sale.Quantity, Sale.UnitPrice, Sale.Total, Sale.SaleDate " &
                    "FROM Sale INNER JOIN Products ON Sale.ProductID = Products.ProductID " &
                    "ORDER BY Sale.SaleID DESC"

                Using da As New SqlDataAdapter(sql, con)

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvreceipts.DataSource = dt

                End Using

            End Using

        Catch ex As Exception
            MsgBox("Error loading sales history: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadReceipts()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class