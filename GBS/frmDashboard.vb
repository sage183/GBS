Public Class frmDashboard
    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmProducts.ShowDialog()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        frmCustomers.ShowDialog()
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        frmSales.ShowDialog()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnSalesHistory_Click(sender As Object, e As EventArgs) Handles btnSalesHistory.Click
        FrmReceipts.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        FrmReports.ShowDialog()
    End Sub

    Private Sub btnReceipts_Click(sender As Object, e As EventArgs) Handles btnReceipts.Click
        FrmReceipts.ShowDialog()
    End Sub
End Class