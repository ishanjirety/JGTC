Imports System.Net
Imports System.Reflection
Public Class Form1
    '<-----------Pannel Style------------>
    Dim pannelWidth
    Dim notHidden As String
    Dim switch As Boolean = False
    Dim counter As Integer = 0
    '<-----------Pannel Style------------>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pc_name.Text = IPView()
        pannelWidth = Panel2.Width
        Panel1.Width = 0
        Panel2.Width = 0
        notHidden = "False"
        Me.DoubleBuffered = True
        DoubleBufferedPanel(Panel5, True)
        DoubleBufferedPanel(Panel2, True)
        DoubleBufferedPanel(Panel1, True)
        DoubleBufferedPanel(Panel3, True)
        DoubleBufferedPanel(Panel4, True)
        DoubleBufferedPicture(PictureBox1, True)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel2.Show()
        Panel1.Show()
        If notHidden = "False" Then

            If Panel1.Width <= 134 Then
                Panel1.Width += 30
            Else
                Panel2.Width = Panel2.Width + 30
                If Panel2.Width >= pannelWidth Then
                    Timer1.Stop()
                    notHidden = "True"
                    Me.Refresh()
                End If
            End If
        Else
            Panel2.Width = Panel2.Width - 30
            If Panel2.Width <= 0 Then
                If Panel1.Width <= 0 Then
                    Timer1.Stop()
                    notHidden = "False"
                    Me.Refresh()
                Else
                    Panel1.Width -= 30
                End If
            End If

        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        PannelBill.Dock = DockStyle.Fill
    End Sub
    Public Sub DoubleBufferedPanel(ByVal myPanel As Panel, ByVal setting As Boolean)
        Dim panType As Type = myPanel.[GetType]()
        Dim pi As PropertyInfo = panType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(myPanel, setting, Nothing)
    End Sub
    Public Sub DoubleBufferedPicture(ByVal myPanel As PictureBox, ByVal setting As Boolean)
        Dim panType As Type = myPanel.[GetType]()
        Dim pi As PropertyInfo = panType.GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        pi.SetValue(myPanel, setting, Nothing)
    End Sub
    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs)
        logout()
        DevelopersAuth.Close()
        User_Login.Show()
        User_Login.UsernameTextBox.Text = Nothing
        User_Login.PasswordTextBox.Text = Nothing
        Me.Close()
    End Sub
    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        PannelBill.Show()
        PannelBill.Dock = DockStyle.Fill
        Accounts.Hide()
    End Sub
    Private Sub Btn_Bill_Click_1(sender As Object, e As EventArgs) Handles Btn_Bill.Click
        PannelBill.Show()
        Accounts.Hide()
        PannelBill.Dock = DockStyle.Fill
    End Sub
    Private Sub Btn_Acc_Click_1(sender As Object, e As EventArgs) Handles Btn_Acc.Click
        PannelBill.Hide()
        Accounts.Show()
        Accounts.Dock = DockStyle.Fill
    End Sub
    Private Sub RetailBtn_Click_1(sender As Object, e As EventArgs) Handles RetailBtn.Click
        With UserCreationvb
            .TopLevel = False
            main.Controls.Add(UserCreationvb)
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        logout()
        Application.Exit()
    End Sub

    Private Sub Btn_Logout_Click_1(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        logout()
        Application.Exit()
    End Sub

    Private Sub Btn_Admin_Click(sender As Object, e As EventArgs) Handles Btn_Admin.Click
        DevelopersAuth.Close()
        AdminAuth.Show()
    End Sub

    Private Sub Btn_Dev_Click(sender As Object, e As EventArgs) Handles Btn_Dev.Click
        AdminAuth.Close()
        DevelopersAuth.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Colour Changes'
    Private Sub Btn_Bill_MouseEnter(sender As Object, e As EventArgs)
        Btn_Bill.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Bill_MouseLeave(sender As Object, e As EventArgs)
        Btn_Bill.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Acc_MouseEnter(sender As Object, e As EventArgs)
        Btn_Acc.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Acc_MouseLeave(sender As Object, e As EventArgs)
        Btn_Acc.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Inven_MouseLeave(sender As Object, e As EventArgs)
        Btn_Inven.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Inven_MouseEnter(sender As Object, e As EventArgs)
        Btn_Inven.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Payroll_MouseEnter(sender As Object, e As EventArgs)
        Btn_Payroll.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Payroll_MouseLeave(sender As Object, e As EventArgs)
        Btn_Payroll.ForeColor = Color.Black
    End Sub
    Private Sub Btn_info_MouseLeave(sender As Object, e As EventArgs)
        Btn_info.ForeColor = Color.Black
    End Sub
    Private Sub Btn_info_MouseEnter(sender As Object, e As EventArgs)
        Btn_info.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Logout_MouseEnter(sender As Object, e As EventArgs)
        Btn_Logout.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Logout_MouseLeave(sender As Object, e As EventArgs)
        Btn_Logout.ForeColor = Color.Black
    End Sub
    Private Sub Btn_challan_MouseLeave(sender As Object, e As EventArgs)
        Btn_challan.ForeColor = Color.Black
    End Sub
    Private Sub Btn_challan_MouseEnter(sender As Object, e As EventArgs)
        Btn_challan.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_ledger_MouseEnter(sender As Object, e As EventArgs)
        Btn_ledger.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_ledger_MouseLeave(sender As Object, e As EventArgs)
        Btn_ledger.ForeColor = Color.Black
    End Sub
    Private Sub Btn_BS_MouseEnter(sender As Object, e As EventArgs)
        Btn_BS.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_BS_MouseLeave(sender As Object, e As EventArgs)
        Btn_BS.ForeColor = Color.Black
    End Sub
    Private Sub Btn_deb_MouseEnter(sender As Object, e As EventArgs)
        Btn_deb.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_deb_MouseLeave(sender As Object, e As EventArgs)
        Btn_deb.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Gst_MouseEnter(sender As Object, e As EventArgs)
        Btn_Gst.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Gst_MouseLeave(sender As Object, e As EventArgs)
        Btn_Gst.ForeColor = Color.Black
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
    End Sub
    Private Sub RetailBtn_MouseEnter(sender As Object, e As EventArgs)
        RetailBtn.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub RetailBtn_MouseLeave(sender As Object, e As EventArgs)
        RetailBtn.ForeColor = Color.Black
    End Sub
    Private Sub Btn_journal_MouseEnter(sender As Object, e As EventArgs)
        Btn_journal.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_journal_MouseLeave(sender As Object, e As EventArgs)
        Btn_journal.ForeColor = Color.Black
    End Sub
    Private Sub Btn_vouch_MouseEnter(sender As Object, e As EventArgs)
        Btn_vouch.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_vouch_MouseLeave(sender As Object, e As EventArgs)
        Btn_vouch.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Analytics_MouseEnter(sender As Object, e As EventArgs)
        Btn_Analytics.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Analytics_MouseLeave(sender As Object, e As EventArgs)
        Btn_Analytics.ForeColor = Color.Black
    End Sub

    Private Sub Btn_User_MouseEnter(sender As Object, e As EventArgs)
        Btn_User.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_User_MouseLeave(sender As Object, e As EventArgs)
        Btn_User.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Admin_MouseLeave(sender As Object, e As EventArgs)
        Btn_Admin.ForeColor = Color.Black
    End Sub
    Private Sub Btn_Admin_MouseEnter(sender As Object, e As EventArgs)
        Btn_Admin.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Dev_MouseEnter(sender As Object, e As EventArgs)
        Btn_Dev.ForeColor = Color.DodgerBlue
    End Sub
    Private Sub Btn_Dev_MouseLeave(sender As Object, e As EventArgs)
        Btn_Dev.ForeColor = Color.Black
    End Sub
End Class
