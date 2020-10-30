Imports MySql.Data.MySqlClient
Public Class User_Login
    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Validate1()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Forgot_password.Show()
        Me.Hide()
    End Sub
End Class
