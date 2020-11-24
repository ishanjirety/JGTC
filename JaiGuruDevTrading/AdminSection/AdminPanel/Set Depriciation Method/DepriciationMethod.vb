Imports MySql.Data.MySqlClient
Public Class DepriciationMethod
    Private Sub Btn_SET_Click(sender As Object, e As EventArgs) Handles Btn_SET.Click
        If GetEntryStatus() = False Then
            MsgBox("YOU CANNOT CHANGE DEPRICIATION METHOD ONCE UPDATED", MsgBoxStyle.Critical)

        Else
            MakeMethodEntry()
        End If
    End Sub
    Private Function GetEntryStatus() As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `depriciation_method`", conn)
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
    Private Sub MakeMethodEntry()
        If MessageBox.Show("You Cannot Update Depriciation Method Once SET", "Finanza", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                conn.Close()
                conn.Open()
                Dim str As String = "INSERT INTO `depriciation_method` VALUES('" + ComboBox1.Text + "')"
                Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader
                MsgBox("METHOD UPDATED", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("AN ERROR OCCURED : " + ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
End Class