'<----------------Libraries-------------------------->'
Imports MySql.Data.MySqlClient
Imports System
'<----------------Libraries-------------------------->'

Module loginValidation
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;username=root;database=jgtc")
    Public Sub Validate1()
        Dim SQL = "SELECT * FROM userlogin WHERE username = @uname AND password = @pword"
        Dim cmd As MySqlCommand = New MySqlCommand(SQL, con)
        con.Close()
        con.Open()
        cmd.Parameters.Add(New MySqlParameter("@uname", User_Login.UsernameTextBox.Text))
        cmd.Parameters.Add(New MySqlParameter("@pword", User_Login.PasswordTextBox.Text))
        Dim rdr As MySqlDataReader = cmd.ExecuteReader
        If rdr.HasRows Then
            DbFunctions.MakeLogEntry()
            Form1.usrname.Text = User_Login.UsernameTextBox.Text
            Form1.Show()
        Else
            MsgBox("Invalid Credentials", MsgBoxStyle.Critical)
        End If
    End Sub


End Module
