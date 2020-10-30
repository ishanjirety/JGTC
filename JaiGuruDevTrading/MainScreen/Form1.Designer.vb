<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Accounts = New System.Windows.Forms.Panel()
        Me.PannelBill = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Content = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Btn_Gst = New System.Windows.Forms.Button()
        Me.Btn_deb = New System.Windows.Forms.Button()
        Me.Btn_BS = New System.Windows.Forms.Button()
        Me.Btn_ledger = New System.Windows.Forms.Button()
        Me.Btn_journal = New System.Windows.Forms.Button()
        Me.Btn_challan = New System.Windows.Forms.Button()
        Me.RetailBtn = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pc_name = New System.Windows.Forms.Label()
        Me.usrname = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Btn_Logout = New System.Windows.Forms.Button()
        Me.Btn_info = New System.Windows.Forms.Button()
        Me.Btn_Admin = New System.Windows.Forms.Button()
        Me.Btn_Dev = New System.Windows.Forms.Button()
        Me.Btn_User = New System.Windows.Forms.Button()
        Me.Btn_Analytics = New System.Windows.Forms.Button()
        Me.Btn_Payroll = New System.Windows.Forms.Button()
        Me.Btn_vouch = New System.Windows.Forms.Button()
        Me.Btn_Inven = New System.Windows.Forms.Button()
        Me.Btn_Acc = New System.Windows.Forms.Button()
        Me.Btn_Bill = New System.Windows.Forms.Button()
        Me.Main = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Accounts.SuspendLayout()
        Me.PannelBill.SuspendLayout()
        Me.Content.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Btn_Logout)
        Me.Panel1.Controls.Add(Me.Btn_info)
        Me.Panel1.Controls.Add(Me.Btn_Admin)
        Me.Panel1.Controls.Add(Me.Btn_Dev)
        Me.Panel1.Controls.Add(Me.Btn_User)
        Me.Panel1.Controls.Add(Me.Btn_Analytics)
        Me.Panel1.Controls.Add(Me.Btn_Payroll)
        Me.Panel1.Controls.Add(Me.Btn_vouch)
        Me.Panel1.Controls.Add(Me.Btn_Inven)
        Me.Panel1.Controls.Add(Me.Btn_Acc)
        Me.Panel1.Controls.Add(Me.Btn_Bill)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(152, 543)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Accounts)
        Me.Panel2.Controls.Add(Me.PannelBill)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(152, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(206, 543)
        Me.Panel2.TabIndex = 4
        '
        'Accounts
        '
        Me.Accounts.Controls.Add(Me.Btn_Gst)
        Me.Accounts.Controls.Add(Me.Btn_deb)
        Me.Accounts.Controls.Add(Me.Btn_BS)
        Me.Accounts.Controls.Add(Me.Btn_ledger)
        Me.Accounts.Controls.Add(Me.Btn_journal)
        Me.Accounts.Location = New System.Drawing.Point(0, 236)
        Me.Accounts.Name = "Accounts"
        Me.Accounts.Size = New System.Drawing.Size(205, 195)
        Me.Accounts.TabIndex = 8
        '
        'PannelBill
        '
        Me.PannelBill.Controls.Add(Me.Btn_challan)
        Me.PannelBill.Controls.Add(Me.RetailBtn)
        Me.PannelBill.Location = New System.Drawing.Point(0, 108)
        Me.PannelBill.Name = "PannelBill"
        Me.PannelBill.Size = New System.Drawing.Size(204, 122)
        Me.PannelBill.TabIndex = 11
        '
        'Timer1
        '
        '
        'Content
        '
        Me.Content.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Content.Controls.Add(Me.Main)
        Me.Content.Controls.Add(Me.Panel4)
        Me.Content.Controls.Add(Me.Panel3)
        Me.Content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Content.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Content.Location = New System.Drawing.Point(152, 0)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(588, 543)
        Me.Content.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(586, 18)
        Me.Panel4.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(586, 34)
        Me.Panel3.TabIndex = 6
        '
        'Btn_Gst
        '
        Me.Btn_Gst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_Gst.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Gst.FlatAppearance.BorderSize = 0
        Me.Btn_Gst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Gst.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Gst.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Btn_Gst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Gst.Location = New System.Drawing.Point(0, 144)
        Me.Btn_Gst.Name = "Btn_Gst"
        Me.Btn_Gst.Size = New System.Drawing.Size(205, 36)
        Me.Btn_Gst.TabIndex = 1
        Me.Btn_Gst.Text = "GST"
        Me.Btn_Gst.UseVisualStyleBackColor = True
        '
        'Btn_deb
        '
        Me.Btn_deb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_deb.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_deb.FlatAppearance.BorderSize = 0
        Me.Btn_deb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_deb.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_deb.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Btn_deb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_deb.Location = New System.Drawing.Point(0, 108)
        Me.Btn_deb.Name = "Btn_deb"
        Me.Btn_deb.Size = New System.Drawing.Size(205, 36)
        Me.Btn_deb.TabIndex = 1
        Me.Btn_deb.Text = "          Debitor List"
        Me.Btn_deb.UseVisualStyleBackColor = True
        '
        'Btn_BS
        '
        Me.Btn_BS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_BS.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_BS.FlatAppearance.BorderSize = 0
        Me.Btn_BS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_BS.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_BS.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Btn_BS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_BS.Location = New System.Drawing.Point(0, 72)
        Me.Btn_BS.Name = "Btn_BS"
        Me.Btn_BS.Size = New System.Drawing.Size(205, 36)
        Me.Btn_BS.TabIndex = 1
        Me.Btn_BS.Text = "              Balance Sheet"
        Me.Btn_BS.UseVisualStyleBackColor = True
        '
        'Btn_ledger
        '
        Me.Btn_ledger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_ledger.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_ledger.FlatAppearance.BorderSize = 0
        Me.Btn_ledger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_ledger.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ledger.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Btn_ledger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ledger.Location = New System.Drawing.Point(0, 36)
        Me.Btn_ledger.Name = "Btn_ledger"
        Me.Btn_ledger.Size = New System.Drawing.Size(205, 36)
        Me.Btn_ledger.TabIndex = 0
        Me.Btn_ledger.Text = "Ledger"
        Me.Btn_ledger.UseVisualStyleBackColor = True
        '
        'Btn_journal
        '
        Me.Btn_journal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_journal.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_journal.FlatAppearance.BorderSize = 0
        Me.Btn_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_journal.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_journal.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Btn_journal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_journal.Location = New System.Drawing.Point(0, 0)
        Me.Btn_journal.Name = "Btn_journal"
        Me.Btn_journal.Size = New System.Drawing.Size(205, 36)
        Me.Btn_journal.TabIndex = 0
        Me.Btn_journal.Text = "Journal"
        Me.Btn_journal.UseVisualStyleBackColor = True
        '
        'Btn_challan
        '
        Me.Btn_challan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btn_challan.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_challan.FlatAppearance.BorderSize = 0
        Me.Btn_challan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_challan.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_challan.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_bill_30
        Me.Btn_challan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_challan.Location = New System.Drawing.Point(0, 36)
        Me.Btn_challan.Name = "Btn_challan"
        Me.Btn_challan.Size = New System.Drawing.Size(204, 36)
        Me.Btn_challan.TabIndex = 0
        Me.Btn_challan.Text = "Challan"
        Me.Btn_challan.UseVisualStyleBackColor = True
        '
        'RetailBtn
        '
        Me.RetailBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RetailBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.RetailBtn.FlatAppearance.BorderSize = 0
        Me.RetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RetailBtn.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailBtn.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_bill_30
        Me.RetailBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RetailBtn.Location = New System.Drawing.Point(0, 0)
        Me.RetailBtn.Name = "RetailBtn"
        Me.RetailBtn.Size = New System.Drawing.Size(204, 36)
        Me.RetailBtn.TabIndex = 0
        Me.RetailBtn.Text = "   Retail Bill"
        Me.RetailBtn.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources._1_l3wujEgEKOecwVzf_dqVrQ
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.pc_name)
        Me.Panel5.Controls.Add(Me.usrname)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(204, 108)
        Me.Panel5.TabIndex = 10
        '
        'pc_name
        '
        Me.pc_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pc_name.AutoSize = True
        Me.pc_name.BackColor = System.Drawing.Color.Transparent
        Me.pc_name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pc_name.ForeColor = System.Drawing.Color.Transparent
        Me.pc_name.Location = New System.Drawing.Point(110, 58)
        Me.pc_name.Name = "pc_name"
        Me.pc_name.Size = New System.Drawing.Size(77, 19)
        Me.pc_name.TabIndex = 10
        Me.pc_name.Text = "Username"
        '
        'usrname
        '
        Me.usrname.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.usrname.AutoSize = True
        Me.usrname.BackColor = System.Drawing.Color.Transparent
        Me.usrname.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrname.ForeColor = System.Drawing.Color.Transparent
        Me.usrname.Location = New System.Drawing.Point(110, 36)
        Me.usrname.Name = "usrname"
        Me.usrname.Size = New System.Drawing.Size(77, 19)
        Me.usrname.TabIndex = 10
        Me.usrname.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_person_128px_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 105)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_multiply_24__1_
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(560, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_minus_24
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_minus_24__1_
        Me.Button3.Location = New System.Drawing.Point(533, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(21, 25)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Btn_Logout
        '
        Me.Btn_Logout.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Logout.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_exit_30px
        Me.Btn_Logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Logout.FlatAppearance.BorderSize = 0
        Me.Btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Logout.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Logout.Location = New System.Drawing.Point(3, 440)
        Me.Btn_Logout.Name = "Btn_Logout"
        Me.Btn_Logout.Size = New System.Drawing.Size(146, 28)
        Me.Btn_Logout.TabIndex = 3
        Me.Btn_Logout.Text = "    Logout"
        Me.Btn_Logout.UseVisualStyleBackColor = True
        '
        'Btn_info
        '
        Me.Btn_info.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_info.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_info_30px
        Me.Btn_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_info.FlatAppearance.BorderSize = 0
        Me.Btn_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_info.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_info.Location = New System.Drawing.Point(2, 400)
        Me.Btn_info.Name = "Btn_info"
        Me.Btn_info.Size = New System.Drawing.Size(148, 31)
        Me.Btn_info.TabIndex = 3
        Me.Btn_info.Text = "Info"
        Me.Btn_info.UseVisualStyleBackColor = True
        '
        'Btn_Admin
        '
        Me.Btn_Admin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Admin.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_admin_settings_male_24px
        Me.Btn_Admin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Admin.FlatAppearance.BorderSize = 0
        Me.Btn_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Admin.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Admin.Location = New System.Drawing.Point(1, 472)
        Me.Btn_Admin.Name = "Btn_Admin"
        Me.Btn_Admin.Size = New System.Drawing.Size(147, 27)
        Me.Btn_Admin.TabIndex = 3
        Me.Btn_Admin.Text = "       Admin Control"
        Me.Btn_Admin.UseVisualStyleBackColor = True
        '
        'Btn_Dev
        '
        Me.Btn_Dev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Dev.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_macbook_settings_24px
        Me.Btn_Dev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Dev.FlatAppearance.BorderSize = 0
        Me.Btn_Dev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Dev.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Dev.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Btn_Dev.Location = New System.Drawing.Point(2, 508)
        Me.Btn_Dev.Name = "Btn_Dev"
        Me.Btn_Dev.Size = New System.Drawing.Size(146, 31)
        Me.Btn_Dev.TabIndex = 3
        Me.Btn_Dev.Text = "       Developers Section"
        Me.Btn_Dev.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Dev.UseVisualStyleBackColor = True
        '
        'Btn_User
        '
        Me.Btn_User.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_User_Group_2_24px
        Me.Btn_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_User.FlatAppearance.BorderSize = 0
        Me.Btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_User.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_User.Location = New System.Drawing.Point(4, 257)
        Me.Btn_User.Name = "Btn_User"
        Me.Btn_User.Size = New System.Drawing.Size(147, 31)
        Me.Btn_User.TabIndex = 3
        Me.Btn_User.Text = "         Active User"
        Me.Btn_User.UseVisualStyleBackColor = True
        '
        'Btn_Analytics
        '
        Me.Btn_Analytics.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_increase_32px
        Me.Btn_Analytics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Analytics.FlatAppearance.BorderSize = 0
        Me.Btn_Analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Analytics.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Analytics.Location = New System.Drawing.Point(4, 219)
        Me.Btn_Analytics.Name = "Btn_Analytics"
        Me.Btn_Analytics.Size = New System.Drawing.Size(147, 31)
        Me.Btn_Analytics.TabIndex = 3
        Me.Btn_Analytics.Text = "      Analytics"
        Me.Btn_Analytics.UseVisualStyleBackColor = True
        '
        'Btn_Payroll
        '
        Me.Btn_Payroll.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_payroll_24px
        Me.Btn_Payroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Payroll.FlatAppearance.BorderSize = 0
        Me.Btn_Payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Payroll.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Payroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Payroll.Location = New System.Drawing.Point(4, 181)
        Me.Btn_Payroll.Name = "Btn_Payroll"
        Me.Btn_Payroll.Size = New System.Drawing.Size(147, 31)
        Me.Btn_Payroll.TabIndex = 3
        Me.Btn_Payroll.Text = "   Payroll"
        Me.Btn_Payroll.UseVisualStyleBackColor = True
        '
        'Btn_vouch
        '
        Me.Btn_vouch.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_Voucher_24px
        Me.Btn_vouch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_vouch.FlatAppearance.BorderSize = 0
        Me.Btn_vouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_vouch.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_vouch.Location = New System.Drawing.Point(3, 98)
        Me.Btn_vouch.Name = "Btn_vouch"
        Me.Btn_vouch.Size = New System.Drawing.Size(148, 31)
        Me.Btn_vouch.TabIndex = 3
        Me.Btn_vouch.Text = "      Vouchers"
        Me.Btn_vouch.UseVisualStyleBackColor = True
        '
        'Btn_Inven
        '
        Me.Btn_Inven.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_trolley_24px
        Me.Btn_Inven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Inven.FlatAppearance.BorderSize = 0
        Me.Btn_Inven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Inven.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Inven.Location = New System.Drawing.Point(3, 138)
        Me.Btn_Inven.Name = "Btn_Inven"
        Me.Btn_Inven.Size = New System.Drawing.Size(148, 31)
        Me.Btn_Inven.TabIndex = 3
        Me.Btn_Inven.Text = "       Inventory"
        Me.Btn_Inven.UseVisualStyleBackColor = True
        '
        'Btn_Acc
        '
        Me.Btn_Acc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Acc.FlatAppearance.BorderSize = 0
        Me.Btn_Acc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Acc.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Acc.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Btn_Acc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Acc.Location = New System.Drawing.Point(-1, 55)
        Me.Btn_Acc.Name = "Btn_Acc"
        Me.Btn_Acc.Size = New System.Drawing.Size(152, 31)
        Me.Btn_Acc.TabIndex = 3
        Me.Btn_Acc.Text = "        Accounts"
        Me.Btn_Acc.UseVisualStyleBackColor = True
        '
        'Btn_Bill
        '
        Me.Btn_Bill.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_bill_30
        Me.Btn_Bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Bill.FlatAppearance.BorderSize = 0
        Me.Btn_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Bill.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Bill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Bill.Location = New System.Drawing.Point(5, 13)
        Me.Btn_Bill.Name = "Btn_Bill"
        Me.Btn_Bill.Size = New System.Drawing.Size(146, 31)
        Me.Btn_Bill.TabIndex = 3
        Me.Btn_Bill.Text = "Bills"
        Me.Btn_Bill.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.Location = New System.Drawing.Point(0, 52)
        Me.Main.Name = "Main"
        Me.Main.Size = New System.Drawing.Size(586, 489)
        Me.Main.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(740, 543)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Accounts.ResumeLayout(False)
        Me.PannelBill.ResumeLayout(False)
        Me.Content.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RetailBtn As Button
    Friend WithEvents Btn_Bill As Button
    Friend WithEvents Content As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents pc_name As Label
    Friend WithEvents usrname As Label
    Friend WithEvents PannelBill As Panel
    Friend WithEvents Btn_Acc As Button
    Friend WithEvents Accounts As Panel
    Friend WithEvents Btn_journal As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Btn_deb As Button
    Friend WithEvents Btn_BS As Button
    Friend WithEvents Btn_ledger As Button
    Friend WithEvents Btn_challan As Button
    Friend WithEvents Btn_Gst As Button
    Friend WithEvents Btn_Inven As Button
    Friend WithEvents Btn_Payroll As Button
    Friend WithEvents Btn_info As Button
    Friend WithEvents Btn_Logout As Button
    Friend WithEvents Btn_vouch As Button
    Friend WithEvents Btn_Dev As Button
    Friend WithEvents Btn_Admin As Button
    Friend WithEvents Btn_Analytics As Button
    Friend WithEvents Btn_User As Button
    Friend WithEvents Main As Panel
End Class
