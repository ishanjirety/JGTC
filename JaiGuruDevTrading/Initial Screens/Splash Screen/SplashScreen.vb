Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Width += 20
        If Panel2.Width >= 350 And Panel2.Width <= 500 Then
            Label1.Text = "Loading resources..."
        ElseIf Panel2.Width >= 500 Then
            Label1.Text = "Starting Application..."
        End If

        If Panel2.Width >= 700 Then
            Me.Opacity -= 0.2
            If Me.Opacity = 0 Then
                User_Login.Show()
                Me.Hide()
                Timer1.Stop()
            End If
        End If
    End Sub

End Class