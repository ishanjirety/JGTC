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
        Label2.Text = loginValidation.role
        pc_name.Text = IPView()
        PannelBill.Hide()
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
        FunHide()
    End Sub
    Private Sub Btn_Bill_Click_1(sender As Object, e As EventArgs) Handles Btn_Bill.Click
        FunHide()
        PannelBill.Show()
        PannelBill.Dock = DockStyle.Fill
    End Sub
    Private Sub Btn_Acc_Click_1(sender As Object, e As EventArgs) Handles Btn_Acc.Click
        FunHide()
        Accounts.Show()
        Accounts.Dock = DockStyle.Fill
    End Sub
    Private Sub RetailBtn_Click_1(sender As Object, e As EventArgs) Handles RetailBtn.Click
        With SalesVoucher
            .TopLevel = False
            main.Controls.Add(SalesVoucher)
            .Dock = DockStyle.Fill
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
    Private Sub Btn_vouch_Click(sender As Object, e As EventArgs) Handles Btn_vouch.Click
        FunHide()
        Vouchers.Show()
        Vouchers.Dock = DockStyle.Fill
    End Sub

    Private Sub FunHide()
        Inventory.Hide()
        Accounts.Hide()
        PannelBill.Hide()
        Vouchers.Hide()
    End Sub

    Private Sub Btn_Inven_Click(sender As Object, e As EventArgs) Handles Btn_Inven.Click
        FunHide()
        Inventory.Show()
        Inventory.Dock = DockStyle.Fill
    End Sub
    'Colour Changes'
    Private Sub Btn_Bill_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Bill.MouseEnter
        Btn_Bill.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Bill_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Bill.MouseLeave
        Btn_Bill.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Acc_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Acc.MouseEnter
        Btn_Acc.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Acc_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Acc.MouseLeave
        Btn_Acc.ForeColor = Color.Black
    End Sub

    Private Sub Btn_vouch_MouseEnter(sender As Object, e As EventArgs) Handles Btn_vouch.MouseEnter
        Btn_vouch.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_vouch_MouseLeave(sender As Object, e As EventArgs) Handles Btn_vouch.MouseLeave
        Btn_vouch.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Inven_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Inven.MouseEnter
        Btn_Inven.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Inven_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Inven.MouseLeave
        Btn_Inven.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Payroll_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Payroll.MouseEnter
        Btn_Payroll.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Payroll_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Payroll.MouseLeave
        Btn_Payroll.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Analytics_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Analytics.MouseEnter
        Btn_Analytics.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Analytics_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Analytics.MouseLeave
        Btn_Analytics.ForeColor = Color.Black
    End Sub

    Private Sub Btn_User_MouseEnter(sender As Object, e As EventArgs) Handles Btn_User.MouseEnter
        Btn_User.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_User_MouseLeave(sender As Object, e As EventArgs) Handles Btn_User.MouseLeave
        Btn_User.ForeColor = Color.Black
    End Sub

    Private Sub Btn_info_MouseEnter(sender As Object, e As EventArgs) Handles Btn_info.MouseEnter
        Btn_info.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_info_MouseLeave(sender As Object, e As EventArgs) Handles Btn_info.MouseLeave
        Btn_info.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Logout_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Logout.MouseEnter
        Btn_Logout.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Logout_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Logout.MouseLeave
        Btn_Logout.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Admin_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Admin.MouseEnter
        Btn_Admin.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Admin_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Admin.MouseLeave
        Btn_Admin.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Dev_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Dev.MouseEnter
        Btn_Dev.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Dev_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Dev.MouseLeave
        Btn_Dev.ForeColor = Color.Black
    End Sub

    Private Sub Btn_challan_MouseEnter(sender As Object, e As EventArgs) Handles Btn_challan.MouseEnter
        Btn_challan.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_challan_MouseLeave(sender As Object, e As EventArgs) Handles Btn_challan.MouseLeave
        Btn_challan.ForeColor = Color.Black
    End Sub

    Private Sub RetailBtn_MouseEnter(sender As Object, e As EventArgs) Handles RetailBtn.MouseEnter
        RetailBtn.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub RetailBtn_MouseLeave(sender As Object, e As EventArgs) Handles RetailBtn.MouseLeave
        RetailBtn.ForeColor = Color.Black
    End Sub
    Private Sub Btn_deb_MouseEnter(sender As Object, e As EventArgs)
        Btn_deb.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_deb_MouseLeave(sender As Object, e As EventArgs)
        Btn_deb.ForeColor = Color.Black
    End Sub

    Private Sub btn_dep_MouseEnter(sender As Object, e As EventArgs)
        Btn_dep.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_dep_MouseLeave(sender As Object, e As EventArgs)
        Btn_dep.ForeColor = Color.Black
    End Sub

    Private Sub Btn_CB_MouseEnter(sender As Object, e As EventArgs)
        Btn_CB.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_CB_MouseLeave(sender As Object, e As EventArgs)
        Btn_CB.ForeColor = Color.Black
    End Sub

    Private Sub Btn_BS_MouseEnter(sender As Object, e As EventArgs)
        Btn_BS.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_BS_MouseLeave(sender As Object, e As EventArgs)
        Btn_BS.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Gst_MouseEnter(sender As Object, e As EventArgs)
        Btn_Gst.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Gst_MouseLeave(sender As Object, e As EventArgs)
        Btn_Gst.ForeColor = Color.Black
    End Sub

    Private Sub Btn_PurVoucher_MouseEnter(sender As Object, e As EventArgs) Handles Btn_PurVoucher.MouseEnter
        Btn_PurVoucher.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_PurVoucher_MouseLeave(sender As Object, e As EventArgs) Handles Btn_PurVoucher.MouseLeave
        Btn_PurVoucher.ForeColor = Color.Black
    End Sub

    Private Sub Btn_SVoucher_MouseEnter(sender As Object, e As EventArgs) Handles Btn_SVoucher.MouseEnter
        Btn_SVoucher.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_SVoucher_MouseLeave(sender As Object, e As EventArgs) Handles Btn_SVoucher.MouseLeave
        Btn_SVoucher.ForeColor = Color.Black
    End Sub

    Private Sub Btn_Jvoucher_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Jvoucher.MouseEnter
        Btn_Jvoucher.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_Jvoucher_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Jvoucher.MouseLeave
        Btn_Jvoucher.ForeColor = Color.Black
    End Sub

    Private Sub Btn_CVoucher_MouseEnter(sender As Object, e As EventArgs) Handles Btn_CVoucher.MouseEnter
        Btn_CVoucher.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_CVoucher_MouseLeave(sender As Object, e As EventArgs) Handles Btn_CVoucher.MouseLeave
        Btn_CVoucher.ForeColor = Color.Black
    End Sub

    Private Sub Btn_viewInv_MouseEnter(sender As Object, e As EventArgs) Handles Btn_viewInv.MouseEnter
        Btn_viewInv.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_viewInv_MouseLeave(sender As Object, e As EventArgs) Handles Btn_viewInv.MouseLeave
        Btn_viewInv.ForeColor = Color.Black
    End Sub
    Private Sub Btn_invManage_MouseEnter(sender As Object, e As EventArgs) Handles Btn_invManage.MouseEnter
        Btn_invManage.ForeColor = Color.DodgerBlue
    End Sub

    Private Sub Btn_invManage_MouseLeave(sender As Object, e As EventArgs) Handles Btn_invManage.MouseLeave
        Btn_invManage.ForeColor = Color.Black
    End Sub

    Private Sub Btn_viewInv_Click(sender As Object, e As EventArgs) Handles Btn_viewInv.Click
        CloseForms()
        With ViewInventory
            .TopLevel = False
            main.Controls.Add(ViewInventory)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Btn_ledger_Click(sender As Object, e As EventArgs)
        CloseForms()
        With Create_Led
            .TopLevel = False
            main.Controls.Add(Create_Led)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub CloseForms()
        add.Close()
        Create_Led.Close()
        ViewInventory.Close()
        UserCreationvb.Close()
        AdminPanel.Close()
        SalesVoucher.Close()
        PurchaseVoucher.Close()
        View_Ledgers.Close()
    End Sub

    Private Sub Btn_PurVoucher_Click(sender As Object, e As EventArgs) Handles Btn_PurVoucher.Click
        CloseForms()
        With PurchaseVoucher
            .TopLevel = False
            main.Controls.Add(PurchaseVoucher)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ViewLedger_Click(sender As Object, e As EventArgs) Handles ViewLedger.Click
        CloseForms()
        With View_Ledgers
            .TopLevel = False
            main.Controls.Add(View_Ledgers)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub
    Private Sub Btn_SVoucher_Click(sender As Object, e As EventArgs) Handles Btn_SVoucher.Click
        CloseForms()
        With SalesVoucher
            .TopLevel = False
            main.Controls.Add(SalesVoucher)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CloseForms()
        With Create_Led
            .TopLevel = False
            main.Controls.Add(Create_Led)
            .Dock = DockStyle.Fill
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Btn_dep_Click(sender As Object, e As EventArgs) Handles Btn_dep.Click

    End Sub
End Class
