Imports MySql.Data.MySqlClient
Public Class UserCreationvb
    Dim cipher2 As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data As String = encoding()
        registeration(data)
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
    Function decoding() As String
        Dim cipher As String = cipher2
        Dim key As String = "IJ2000"
        Dim wrapper As New EncryptionDecryption(key)

        Try
            Dim password As String = wrapper.DecryptData(cipher)
            Return password

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class