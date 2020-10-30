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
        Else
            con.Close()
            con.Open()
            Try
                Dim cmd As MySqlCommand = New MySqlCommand("UPDATE logs SET last_login_date = '" & todaysdate & "' , last_login_time = '" & time & "' WHERE log_pc='" & name & "'", con)
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

        Dim SQL = "SELECT * FROM logs WHERE log_pc = @pcname AND log_ip = @ip"
        Dim cmd As MySqlCommand = New MySqlCommand(SQL, con)
        con.Close()
        con.Open()
        cmd.Parameters.Add(New MySqlParameter("@pcname", name))
        cmd.Parameters.Add(New MySqlParameter("@ip", ip(0).ToString))
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        If rdr.HasRows Then
            entry_status = "True"
        End If
    End Sub
    Public Sub logout()
        val()
        If entry_status = "True" Then
            Dim name As String = Dns.GetHostName
            Dim hname As IPHostEntry = Dns.GetHostByName(name)
            Dim ip As IPAddress() = hname.AddressList
            Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
            Dim time As String = Format(Now, "hh:mm:ss tt")
            Dim reader As MySqlDataReader
            con.Close()
            con.Open()
            Try
                Dim cmd As MySqlCommand = New MySqlCommand("UPDATE logs SET last_logout_date = '" & todaysdate & "' , last_logout_time = '" & time & "' WHERE log_pc='" & name & "'", con)
                reader = cmd.ExecuteReader()
                con.Close()
            Catch ex As MySqlException
                MsgBox("error", ex.Message)
                con.Close()
            End Try
        End If
    End Sub
    Function registeration(ByVal cipher As String)

    End Function

End Module
