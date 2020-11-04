Imports MySql.Data.MySqlClient
Public Class UserManagement
    Dim con As MySqlConnection = New MySqlConnection("server=localhost;username=root;database=jgtc")
    Dim selectedrow As DataGridViewRow
    Dim username As String
    Dim password As String
    Dim role As String
    Dim click As Boolean = False
    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As DataSet = LoadTable()
        Btn_Edit.Enabled = True
        UsrTxt.Enabled = False
        Passwd.Enabled = False
        RoleCmb.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        selectedrow = DataGridView1.Rows(index)
        username = selectedrow.Cells(1).Value.ToString()
        role = selectedrow.Cells(3).Value.ToString()
        UsrTxt.Text = selectedrow.Cells(1).Value.ToString()
        RoleCmb.Text = selectedrow.Cells(3).Value.ToString()
        loadpasswd(selectedrow.Cells(1).Value.ToString())
        click = True
    End Sub
    Function decoding(ByVal cipherGet As String) As String
        Dim cipher As String = cipherGet
        Dim key As String = "IJ2000"
        Dim wrapper As New EncryptionDecryption(key)
        Try
            Dim password As String = wrapper.DecryptData(cipher)
            Return password
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub Btn_cancel_Click(sender As Object, e As EventArgs) Handles Btn_cancel.Click
        Btn_Edit.Enabled = True
        UsrTxt.Enabled = False
        Passwd.Enabled = False
        RoleCmb.Enabled = False
        UsrTxt.Text = Nothing
        RoleCmb.Text = Nothing
        Passwd.Text = Nothing
        Btn_Edit.Enabled = True
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        If UsrTxt.Text = Nothing And Passwd.Text = Nothing And RoleCmb.Text = Nothing Then
            MsgBox("Please Select A row To Edit", MsgBoxStyle.Information)
        Else
            Btn_Edit.Enabled = False
            UsrTxt.Enabled = True
            Passwd.Enabled = True
            RoleCmb.Enabled = True
        End If

    End Sub

    Private Sub Btn_Apply_Click(sender As Object, e As EventArgs) Handles Btn_Apply.Click
        If Passwd.Text <> Nothing And UsrTxt.Text <> Nothing And RoleCmb.Text <> Nothing Then
            If MessageBox.Show("Do You Really Want To Apply These Changes", "Finanza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                password = encoding(Passwd.Text)
                Try
                    con.Close()
                    con.Open()
                    Dim str As String = "UPDATE `userlogin` SET `username`='" + UsrTxt.Text + "',`password`='" + password + "',`role`='" + RoleCmb.Text + "' WHERE `username`='" + username + "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(str, con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        MsgBox("User updated successfully", MsgBoxStyle.Information)
                    End If
                    con.Close()
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    con.Close()
                End Try
                loadpasswd(selectedrow.Cells(1).Value.ToString())
                LoadTable()
                Btn_Edit.Enabled = True
                UsrTxt.Enabled = False
                Passwd.Enabled = False
                RoleCmb.Enabled = False
                UsrTxt.Text = Nothing
                RoleCmb.Text = Nothing
                Passwd.Text = Nothing
                Btn_Edit.Enabled = True
            End If
        Else
            MsgBox("Cannot Apply Changes With Null Fields", MsgBoxStyle.Critical)
        End If

    End Sub
    Function encoding(ByVal passwd) As String
        Dim password As String = passwd
        Dim key As String = "IJ2000"
        Dim wrapper As New EncryptionDecryption(key)
        Dim cipher As String = wrapper.EncryptData(password)
        'My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\cipher.txt", cipher, False)
        'MsgBox(cipher)
        Return cipher
    End Function

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If click = True Then
            If MessageBox.Show("Are You Sure You Want To Delete User " & username, "Finanza", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    con.Open()
                    Dim str As String = "DELETE FROM `userlogin` WHERE `username` = '" + UsrTxt.Text + "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(str, con)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read Then
                    Else
                        MsgBox("User Deleted Sucessfully", MsgBoxStyle.Information)
                        con.Close()
                    End If
                    LoadTable()
                    UsrTxt.Text = Nothing
                    RoleCmb.Text = Nothing
                    Passwd.Text = Nothing
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    con.Close()
                End Try
            End If
        Else
            MsgBox("Please Select A User", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim searchQuery As String = "SELECT * FROM `userlogin` WHERE `username` like '%" + TextBox1.Text + "%'"
        Dim command As New MySqlCommand(searchQuery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class