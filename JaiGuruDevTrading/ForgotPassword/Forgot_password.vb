Public Class Forgot_password
    Public OTP1 As String
    Private Sub Forgot_password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = Nothing
        LinkLabel1.Enabled = True
        TextBox1.PasswordChar = "*"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text -= +1
        If Label3.Text = 0 Then
            Timer1.Stop()
            LinkLabel1.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Label4.Text = "In"
        Label3.Text = "200"
        Timer1.Start()
        LinkLabel1.Enabled = False
        otp()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User_Login.Show()
        Me.Close()
    End Sub
    Private Sub Btn_val_Click(sender As Object, e As EventArgs) Handles Btn_val.Click
        If OTP1 <> TextBox1.Text Then
            MsgBox("OTP mismatch")
        Else
            UserCreationvb.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Btn_otp_Click(sender As Object, e As EventArgs) Handles Btn_otp.Click
        Label2.Text = "OTP sent To " + SMS.numbers
        otp()
    End Sub
End Class