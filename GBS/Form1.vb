Public Class Form1

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CreateDatabase()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And
          txtPassword.Text = "1234" Then

            MsgBox("Login successful!")

            frmDashboard.Show()
            Me.Hide()

        Else
            MsgBox("Incorrect username or password!")
            txtPassword.Clear()
            txtPassword.Focus()

        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub



End Class