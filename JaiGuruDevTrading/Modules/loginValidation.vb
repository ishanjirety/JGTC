'<----------------Libraries-------------------------->'
Imports MySql.Data.MySqlClient
'<----------------Libraries-------------------------->'
Module loginValidation
    Dim fileReader As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\test.txt")
    ' Reads Connection From txt file For Future Modifications
    Dim con As MySqlConnection = New MySqlConnection(fileReader)
    Dim bill As String
    Dim accounts As String
    Dim inventory As String
    Dim PR As String
    Dim analytics As String
    Dim voucher As String
    Dim Active As String
    Public role As String
    'Dim con As MySqlConnection = New MySqlConnection("server=localhost;username=root;database=jgtc")
    Public Sub Validate1()

        Dim cipher As String = encoding() ' Encodes Current Password And Compares It to database 
        Dim SQL = "SELECT * FROM userlogin WHERE username = @uname AND password = @pword"
        Dim cmd As MySqlCommand = New MySqlCommand(SQL, con)
        con.Close()
        con.Open()
        cmd.Parameters.Add(New MySqlParameter("@uname", User_Login.UsernameTextBox.Text))
        cmd.Parameters.Add(New MySqlParameter("@pword", cipher))
        Dim rdr As MySqlDataReader = cmd.ExecuteReader

        If rdr.HasRows Then
            If rdr.Read() Then
                role = rdr.GetValue(3)
                SetInitialScreens(role)
            End If
            DbFunctions.MakeLogEntry()
            Form1.usrname.Text = User_Login.UsernameTextBox.Text
            Form1.Show()
            User_Login.Close()
        Else
            MessageBox.Show("Invalid Credentials", "Finanzà", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Function encoding() As String 'Returns String
        Dim password As String = User_Login.PasswordTextBox.Text
        Dim key As String = "IJ2000"
        Dim wrapper As New EncryptionDecryption(key)
        Dim cipher As String = wrapper.EncryptData(password)
        'My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\cipher.txt", cipher, False)
        'MsgBox(cipher)
        Return cipher
    End Function
    Private Sub SetInitialScreens(ByVal role1)
        Try
            con.Close()
            con.Open()
            Dim str As String = "SELECT * FROM `roles` WHERE `role_name`='" + role1 + "'"
            Dim cmd As MySqlCommand = New MySqlCommand(str, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                bill = dr.GetValue(1)
                accounts = dr.GetValue(2)
                inventory = dr.GetValue(3)
                PR = dr.GetValue(4)
                analytics = dr.GetValue(5)
                voucher = dr.GetValue(6)
                Active = dr.GetValue(7)
                FormChanges(bill, accounts, inventory, PR, analytics, voucher, Active)
            End If
            con.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Sub
    Private Sub FormChanges(ByVal bill, ByVal accounts, ByVal inventory, ByVal PR, ByVal analytics, ByVal voucher, ByVal active)
        If bill <> "True" Then
            Form1.Btn_Bill.Visible = False
        Else
            Form1.Btn_Bill.Visible = True
            Form1.Btn_Bill.Dock = DockStyle.Top
        End If
        If accounts <> "True" Then
            Form1.Btn_Acc.Visible = False
        Else
            Form1.Btn_Acc.Visible = True
            Form1.Btn_Acc.Dock = DockStyle.Top
        End If
        If inventory <> "True" Then
            Form1.Btn_Inven.Visible = False
        Else
            Form1.Btn_Inven.Visible = True
            Form1.Btn_Inven.Dock = DockStyle.Top
        End If
        If PR <> "True" Then
            Form1.Btn_Payroll.Visible = False
        Else
            Form1.Btn_Payroll.Visible = True
            Form1.Btn_Payroll.Dock = DockStyle.Top
        End If
        If analytics <> "True" Then
            Form1.Btn_Analytics.Visible = False
        Else
            Form1.Btn_Analytics.Visible = True
            Form1.Btn_Analytics.Dock = DockStyle.Top
        End If
        If voucher <> "True" Then
            Form1.Btn_vouch.Visible = False
        Else
            Form1.Btn_vouch.Visible = True
            Form1.Btn_vouch.Dock = DockStyle.Top
        End If
        If active <> "True" Then
            Form1.Btn_User.Visible = False
        Else
            Form1.Btn_User.Visible = True
            Form1.Btn_User.Dock = DockStyle.Top
        End If

    End Sub
End Module
