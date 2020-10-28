Imports MySql.Data.MySqlClient
Public Class User_Login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Validate1()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub User_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
