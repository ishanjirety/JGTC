Imports MySql.Data.MySqlClient
Public Class MessageBody
    Private Sub CreateMSG_Click(sender As Object, e As EventArgs) Handles CreateMSG.Click

        If GetMessageStatus() = False Then
            If MessageBox.Show("You Are Going To Update Existing Message Do You Want To Continue?", "FINANZA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                UpdateExistingMessage()
            End If
        Else
            InsertNewMessage()
        End If
    End Sub
    Private Function GetMessageStatus() As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `msgbody` Where Exist='True'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            If rdr.HasRows Then
                Return False
            End If
            Return True
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Function
    Private Sub UpdateExistingMessage()
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "UPDATE `msgbody` SET `Msg`='" + RichTextBox1.Text + "',`Exist`='True' WHERE `Exist`='True'"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            MsgBox("New Message Updated", MsgBoxStyle.Information)
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub InsertNewMessage()
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "INSERT INTO `msgbody` (`Msg`, `Exist`) VALUES ('" + RichTextBox1.Text + "', 'True')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            MsgBox("New Message Updated", MsgBoxStyle.Information)
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub CancelMsg_Click(sender As Object, e As EventArgs) Handles CancelMsg.Click
        RichTextBox1.Text = Nothing
    End Sub
End Class