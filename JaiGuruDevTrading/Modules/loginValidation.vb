'<----------------Libraries-------------------------->'
Imports MySql.Data.MySqlClient
'<----------------Libraries-------------------------->'
Module loginValidation
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;username=root;database=jgtc")
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

End Module
