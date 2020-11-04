Imports MySql.Data.MySqlClient
Imports System.Net
Module DbFunctions
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;username=root;database=jgtc")
    Dim entry_status As String = "NULL"
    Public Sub MakeLogEntry()
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
            con.Close()
            con.Open()
            Try
                Dim cmd As MySqlCommand = New MySqlCommand("insert into logs(`log_username`,`log_pc`,`log_ip`,`last_login_date`,`last_login_time`) VALUES('" & User_Login.UsernameTextBox.Text & "','" & name & "','" & ip(0).ToString & "','" & todaysdate & "','" & time & "')", con)
                reader = cmd.ExecuteReader()
                con.Close()
            Catch ex As MySqlException
                MsgBox("error", ex.Message)
                con.Close()
            End Try
        End If

    End Sub
    Private Sub val()
        Dim name As String = Dns.GetHostName
        Dim hname As IPHostEntry = Dns.GetHostByName(name)
        Dim ip As IPAddress() = hname.AddressList

        Dim SQL = "SELECT * FROM logs WHERE last_login_date = @pcname AND log_ip=@ip"
        Dim cmd As MySqlCommand = New MySqlCommand(SQL, con)
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        con.Close()
        con.Open()
        cmd.Parameters.Add(New MySqlParameter("@pcname", todaysdate))
        cmd.Parameters.Add(New MySqlParameter("@ip", ip(0).ToString))
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        If rdr.HasRows Then
            entry_status = "True"
        End If
    End Sub
    Public Sub logout()
        val()
        Dim name As String = Dns.GetHostName
        Dim hname As IPHostEntry = Dns.GetHostByName(name)
        Dim ip As IPAddress() = hname.AddressList
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim time As String = Format(Now, "hh:mm:ss tt")
        Dim reader As MySqlDataReader
        If entry_status = "True" Then
            con.Close()
            con.Open()
            Try
                Dim cmd As MySqlCommand = New MySqlCommand("UPDATE logs SET  last_logout_time = '" & time & "' WHERE last_login_date='" & todaysdate & "'", con)
                reader = cmd.ExecuteReader()
                con.Close()
            Catch ex As MySqlException
                MsgBox("error", ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Function registeration(ByVal cipher As String, ByVal username As String, ByVal role As String)
        Dim chk As Boolean = check(username)
        If chk = True Then
            Try
                con.Close()
                con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand("Insert Into userlogin(username,password,role) values('" + username + "','" + cipher + "','" + role + "')", con)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader
                If rdr.HasRows Then
                    MsgBox("Exist")
                    con.Close()
                End If
            Catch ex As MySqlException
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Function
    Function check(ByVal username) As Boolean
        Try
            con.Close()
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM userlogin WHERE username='" + username + "'", con)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            If rdr.HasRows Then
                MsgBox("User Already Exists")
                con.Close()
                Return False
            Else
                Return True
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Function
    Public Function LoadTable() As DataSet
        '
        Try
            Dim Str As String = "SELECT * FROM `userlogin` "
            con.Open()
            Dim Search As New MySqlDataAdapter(Str, con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "userlogin")
            UserManagement.DataGridView1.DataSource = ds.Tables("userlogin")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Function
    Function loadpasswd(ByVal username As String)
        Dim cipher As String
        Try
            Dim Str As String = "SELECT password FROM `userlogin` where username = '" + username + "'"
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(Str, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read() Then
                cipher = dr.GetValue(0)
                UserManagement.Passwd.Text = UserManagement.decoding(cipher)
            End If
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try

    End Function
    Public Function Loadlogs() As DataSet
        Try
            Dim Str As String = "SELECT * FROM `logs` "
            con.Open()
            Dim Search As New MySqlDataAdapter(Str, con)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "logs")
            Logs.DataGridView1.DataSource = ds.Tables("logs")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
    End Function
End Module
