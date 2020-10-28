Imports System.Net
Imports System.Reflection
Public Class Form1
    '<-----------Pannel Style------------>
    Dim pannelWidth
    Dim notHidden As String
    '<-----------Pannel Style------------>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pc_name.Text = IPView()
        pannelWidth = Panel2.Width
        notHidden = "False"
        Panel2.Hide()
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
        If notHidden = "False" Then
            Panel2.Width = Panel2.Width + 30
            If Panel2.Width >= pannelWidth Then
                Timer1.Stop()
                notHidden = "True"
                Me.Refresh()
            End If
        Else
            Panel2.Width = Panel2.Width - 30
            If Panel2.Width <= 0 Then
                Timer1.Stop()
                notHidden = "False"
                Me.Refresh()
            End If

        End If
    End Sub
    Private Sub Btn_Bill_Click(sender As Object, e As EventArgs) Handles Btn_Bill.Click
        Panel2.Show()
        Timer1.Start()
        PannelBill.Show()
        Accounts.Hide()
    End Sub


    Private Sub Btn_Acc_Click(sender As Object, e As EventArgs) Handles Btn_Acc.Click
        Panel2.Show()
        Timer1.Start()
        PannelBill.Hide()
        Accounts.Show()
        Accounts.Dock = DockStyle.Fill
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
    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        logout()
        DevelopersAuth.Close()
        User_Login.Show()
        User_Login.UsernameTextBox.Text = Nothing
        User_Login.PasswordTextBox.Text = Nothing
        Me.Close()
    End Sub

    Private Sub Btn_Bill_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Bill.MouseEnter
        Btn_Bill.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_Bill_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Bill.MouseLeave
        Btn_Bill.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Acc_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Acc.MouseEnter
        Btn_Acc.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_Acc_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Acc.MouseLeave
        Btn_Acc.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Inven_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Inven.MouseLeave
        Btn_Inven.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Inven_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Inven.MouseEnter
        Btn_Inven.ForeColor = Color.Purple
    End Sub
    Private Sub Btn_Payroll_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Payroll.MouseEnter, Button1.MouseEnter, Button4.MouseEnter, Btn_Analytics.MouseEnter, Btn_User.MouseEnter
        Btn_Payroll.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_Payroll_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Payroll.MouseLeave, Button1.MouseLeave, Button4.MouseLeave, Btn_Analytics.MouseLeave, Btn_User.MouseLeave
        Btn_Payroll.ForeColor = Color.Black
    End Sub
    Private Sub Btn_info_MouseLeave(sender As Object, e As EventArgs) Handles Btn_info.MouseLeave
        Btn_info.ForeColor = Color.Black
    End Sub
    Private Sub Btn_info_MouseEnter(sender As Object, e As EventArgs) Handles Btn_info.MouseEnter
        Btn_info.ForeColor = Color.Purple
    End Sub
    Private Sub Btn_Logout_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Logout.MouseEnter
        Btn_Logout.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_Logout_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Logout.MouseLeave
        Btn_Logout.ForeColor = Color.Black
    End Sub

    Private Sub Btn_challan_MouseLeave(sender As Object, e As EventArgs) Handles Btn_challan.MouseLeave
        Btn_challan.ForeColor = Color.Black
    End Sub

    Private Sub Btn_challan_MouseEnter(sender As Object, e As EventArgs) Handles Btn_challan.MouseEnter
        Btn_challan.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_ledger_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ledger.MouseEnter
        Btn_ledger.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_ledger_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ledger.MouseLeave
        Btn_ledger.ForeColor = Color.Black
    End Sub

    Private Sub Btn_BS_MouseEnter(sender As Object, e As EventArgs) Handles Btn_BS.MouseEnter
        Btn_BS.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_BS_MouseLeave(sender As Object, e As EventArgs) Handles Btn_BS.MouseLeave
        Btn_BS.ForeColor = Color.Black
    End Sub

    Private Sub Btn_deb_MouseEnter(sender As Object, e As EventArgs) Handles Btn_deb.MouseEnter
        Btn_deb.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_deb_MouseLeave(sender As Object, e As EventArgs) Handles Btn_deb.MouseLeave
        Btn_deb.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Gst_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Gst.MouseEnter
        Btn_Gst.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_Gst_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Gst.MouseLeave
        Btn_Gst.ForeColor = Color.Black
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        logout()
        Application.Exit()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub RetailBtn_MouseEnter(sender As Object, e As EventArgs) Handles RetailBtn.MouseEnter
        RetailBtn.ForeColor = Color.Purple
    End Sub

    Private Sub RetailBtn_MouseLeave(sender As Object, e As EventArgs) Handles RetailBtn.MouseLeave
        RetailBtn.ForeColor = Color.Black
    End Sub

    Private Sub Btn_journal_MouseEnter(sender As Object, e As EventArgs) Handles Btn_journal.MouseEnter
        Btn_journal.ForeColor = Color.Purple
    End Sub
    Private Sub Btn_journal_MouseLeave(sender As Object, e As EventArgs) Handles Btn_journal.MouseLeave
        Btn_journal.ForeColor = Color.Black
    End Sub

    Private Sub Btn_vouch_MouseEnter(sender As Object, e As EventArgs) Handles Btn_vouch.MouseEnter
        Btn_vouch.ForeColor = Color.Purple
    End Sub

    Private Sub Btn_vouch_MouseLeave(sender As Object, e As EventArgs) Handles Btn_vouch.MouseLeave
        Btn_vouch.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminAuth.Close()
        DevelopersAuth.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DevelopersAuth.Close()
        AdminAuth.Show()
    End Sub
End Class
