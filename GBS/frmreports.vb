Imports Microsoft.Data.SqlClient

Public Class FrmReports

    Private Sub FrmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReports()
    End Sub

    Private Sub LoadReports()

        Try
            Using con As New SqlConnection(connectionString)

                con.Open()

                Dim sql As String = "SELECT * FROM [Sale] ORDER BY SaleDate DESC"

                Using da As New SqlDataAdapter(sql, con)

                    Dim dt As New DataTable()
                    da.Fill(dt)

                    dgvReports.DataSource = dt

                End Using

                Dim totalSQL As String = "SELECT ISNULL(SUM(Total),0) FROM [Sale]"

                Using cmd As New SqlCommand(totalSQL, con)
                    lblTotalSales.Text = "Total Sales: KSh " & Convert.ToDecimal(cmd.ExecuteScalar()).ToString("N2")
                End Using

            End Using

        Catch ex As Exception
            MsgBox("Report error: " & ex.Message)
        End Try

    End Sub

    Private Sub btnLoadReports_Click(sender As Object, e As EventArgs) Handles btnLoadReports.Click
        LoadReports()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class