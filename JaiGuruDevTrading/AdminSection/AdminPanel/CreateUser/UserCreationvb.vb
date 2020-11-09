Imports MySql.Data.MySqlClient
Public Class UserCreationvb
    Dim cipher2 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UsernameTxt.Text <> Nothing And PasswordTxt.Text <> Nothing And RePasswordTxt.Text <> Nothing And RoleCmb.Text <> Nothing Then
            If PasswordTxt.Text = RePasswordTxt.Text Then
                Dim data As String = encoding()
                registeration(data, UsernameTxt.Text, RoleCmb.Text)
                UsernameTxt.Text = Nothing
                PasswordTxt.Text = Nothing
                RePasswordTxt.Text = Nothing
                RoleCmb.Text = Nothing
            Else
                MessageBox.Show("Password Doesn't Match!", "Finanzà", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Fields Cannot Be Empty!!", "Finanzà", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Function encoding() As String
        Dim password As String = PasswordTxt.Text
        Dim key As String = "IJ2000"
        Dim wrapper As New EncryptionDecryption(key)
        Dim cipher As String = wrapper.EncryptData(password)
        cipher2 = cipher
        'My.Computer.FileSystem.WriteAllText(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\cipher.txt", cipher, False)
        'MsgBox(cipher)
        Return cipher
    End Function

    Private Sub UserCreationvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbFunctions.conn.Close()
        DbFunctions.conn.Open()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim Str As String = "select role_name From roles "
        Dim cmd As MySqlCommand = New MySqlCommand(Str, DbFunctions.conn)
        da.SelectCommand = cmd
        da.Fill(ds, "roles")
        Dim a As Integer = ds.Tables("roles").Rows.Count - 1
        For i As Integer = 0 To a
            RoleCmb.Items.Add(ds.Tables("roles").Rows(i)(0).ToString())
        Next
    End Sub

    Private Sub RoleCmb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RoleCmb.KeyPress
        e.Handled = False
    End Sub
    'Function decoding() As String
    '    Dim cipher As String = cipher2
    '    Dim key As String = "IJ2000"
    '    Dim wrapper As New EncryptionDecryption(key)

    '    Try
    '        Dim password As String = wrapper.DecryptData(cipher)
    '        Return password

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Function
End Class