Public Class AdminAuth
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Btn_validate_Click(sender As Object, e As EventArgs) Handles Btn_validate.Click
        With AdminPanel
            .TopLevel = False
            Form1.main.Controls.Add(AdminPanel)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class