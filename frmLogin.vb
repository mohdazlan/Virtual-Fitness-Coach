Public Class frmLogin
    Dim userName As String = "azlan"
    Dim admin As String = "admin"
    Dim password As String = "1234"
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim loginCredential As String = txtUserName.Text
        If loginCredential = userName AndAlso txtPassword.Text = password Then
        ElseIf loginCredential = userName AndAlso txtPassword.Text = password Then
        Else
            MessageBox.Show("No user in the system", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub
End Class
