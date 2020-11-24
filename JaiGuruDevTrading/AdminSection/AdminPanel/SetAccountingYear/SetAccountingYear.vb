Imports MySql.Data.MySqlClient
Public Class SetAccountingYear
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        Dim bool As Boolean = CheckStatus()
        If bool = False Then
            MsgBox("You Cannnot Change Accounting Year Once Set", MsgBoxStyle.Exclamation)
        Else
            updateAccountingYear()
        End If
    End Sub
    Private Function CheckStatus() As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `accountingyear` WHERE Status='TRUE'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            If rdr.HasRows Then
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
    Private Sub updateAccountingYear()
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "INSERT INTO `accountingyear` VALUES('TRUE','" + DateTimePicker1.Text + "','" + DateTimePicker2.Text + "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            MsgBox("Accounting Year Updated Successfully", MsgBoxStyle.Information)
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class