Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 10
        If Panel2.Width = PictureBox1.Width Then
            Timer1.Stop()
            User_Login.Show()
            Me.Hide()
        End If
    End Sub
End Class