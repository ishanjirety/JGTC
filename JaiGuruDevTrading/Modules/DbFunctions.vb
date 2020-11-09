Imports MySql.Data.MySqlClient
Imports System.Net
Module DbFunctions
    Dim fileReader As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\test.txt")
    ' Reads Connection From txt file For Future Modifications
    Public conn As MySqlConnection = New MySqlConnection(fileReader)
    Dim entry_status As String = "NULL"

    Public Sub MakeLogEntry()           'Makes Entry In Database Of Login And Logout
        '<----------------------------->
        Dim name As String = Dns.GetHostName
        Dim hname As IPHostEntry = Dns.GetHostByName(name)
        Dim ip As IPAddress() = hname.AddressList
        '<----------------------------->
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim time As String = Format(Now, "hh:mm:ss tt")
        Dim reader As MySqlDataReader
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        val() 'Checking If HOST Already Present IN logs Table If Yes return True Else Remain NULL
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        If entry_status = "NULL" Then
            conn.Close()
            conn.Open()
            Try
                Dim cmd As MySqlCommand = New MySqlCommand("insert into logs(`log_username`,`log_pc`,`log_ip`,`last_login_date`,`last_login_time`) VALUES('" & User_Login.UsernameTextBox.Text & "','" & name & "','" & ip(0).ToString & "','" & todaysdate & "','" & time & "')", conn)
                reader = cmd.ExecuteReader()
                conn.Close()
            Catch ex As MySqlException
                MsgBox("error", ex.Message)
                conn.Close()
            End Try
        End If

    End Sub
    Private Sub val()   'Validates If last login date is todays date and sets entry status true if yes
        Dim name As String = Dns.GetHostName
        Dim hname As IPHostEntry = Dns.GetHostByName(name)
        Dim ip As IPAddress() = hname.AddressList

        Dim SQL = "SELECT * FROM `logs` WHERE `last_login_date` = @date AND `log_ip`=@ip"
        Dim cmd As MySqlCommand = New MySqlCommand(SQL, conn)
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        conn.Close()
        conn.Open()
        cmd.Parameters.Add(New MySqlParameter("@date", todaysdate))
        cmd.Parameters.Add(New MySqlParameter("@ip", ip(0).ToString))
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        If rdr.HasRows Then
            entry_status = "True"
        End If
    End Sub
    Public Sub logout()     'Makes Logout Entry In DB
        val()
        Dim name As String = Dns.GetHostName
        Dim hname As IPHostEntry = Dns.GetHostByName(name)
        Dim ip As IPAddress() = hname.AddressList
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim time As String = Format(Now, "hh:mm:ss tt")
        Dim reader As MySqlDataReader
        If entry_status = "True" Then
            conn.Close()
            conn.Open()
            Try
                Dim cmd As MySqlCommand = New MySqlCommand("UPDATE logs SET  last_logout_time = '" & time & "' WHERE last_login_date='" & todaysdate & "'", conn)
                reader = cmd.ExecuteReader()
                conn.Close()
            Catch ex As MySqlException
                MsgBox("error", ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
    Function registeration(ByVal cipher As String, ByVal username As String, ByVal role As String)  'User Registeration
        Dim chk As Boolean = check(username)
        If chk = True Then
            Try
                conn.Close()
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("Insert Into userlogin(username,password,role) values('" + username + "','" + cipher + "','" + role + "')", conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                If rdr.HasRows Then
                    conn.Close()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Function
    Function check(ByVal username) As Boolean   'Checks If Username Exists and returns Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM userlogin WHERE username='" + username + "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            If rdr.HasRows Then
                MsgBox("User Already Exists")
                conn.Close()
                Return False
            Else
                Return True
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Function
    Public Function LoadTable() As DataSet  'Loads Userlogin Table
        '
        Try
            Dim Str As String = "SELECT * FROM `userlogin` "
            conn.Close()
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "userlogin")
            UserManagement.DataGridView1.DataSource = ds.Tables("userlogin")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Function
    Function loadpasswd(ByVal username As String)   'Loads Password For Decoding
        Dim cipher As String
        Try
            Dim Str As String = "SELECT password FROM `userlogin` where username = '" + username + "'"
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(Str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                cipher = dr.GetValue(0)
                UserManagement.Passwd.Text = UserManagement.decoding(cipher)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

    End Function
    Public Function Loadlogs() As DataSet   'Loads Login Logout info
        conn.Close()
        Try
            Dim Str As String = "SELECT * FROM `logs` "
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "logs")
            Logs.DataGridView1.DataSource = ds.Tables("logs")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Function
End Module
