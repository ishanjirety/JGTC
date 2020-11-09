Imports MySql.Data.MySqlClient
Public Class GrantRoles
    Dim usname As String
    Private Sub GrantRoles_Load(sender As Object, e As EventArgs) Handles Me.Load
        NameCmb.Enabled = False
        billCmb.Enabled = False
        AccCmb.Enabled = False
        InvCmb.Enabled = False
        PRCmb.Enabled = False
        AlyCmb.Enabled = False
        voucherCmb.Enabled = False
        ActiveCmb.Enabled = False
        LoadRoles()
        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\test.txt")
        'MsgBox(fileReader)

    End Sub
    Public Sub LoadRoles()
        DbFunctions.conn.Close()
        Try
            Dim Str As String = "SELECT * FROM `roles` "
            DbFunctions.conn.Open()
            Dim Search As New MySqlDataAdapter(Str, DbFunctions.conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "roles")
            DataGridView1.DataSource = ds.Tables("roles")
            DbFunctions.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            DbFunctions.conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim chk As Boolean = check(NameCmb.Text)
        If NameCmb.Text = Nothing And billCmb.Text = Nothing And AccCmb.Text = Nothing And InvCmb.Text = Nothing And PRCmb.Text = Nothing And AlyCmb.Text = Nothing And ActiveCmb.Text = Nothing Then
            MsgBox("Fields Cannot Be Empty", MsgBoxStyle.Exclamation)
        Else
            If chk = True Then
                Try
                    DbFunctions.conn.Close()
                    DbFunctions.conn.Open()
                    Dim str As String = "INSERT INTO `roles` VALUES('" + NameCmb.Text + "','" + billCmb.Text + "','" + AccCmb.Text + "','" + InvCmb.Text + "','" + PRCmb.Text + "','" + AlyCmb.Text + "','" + voucherCmb.Text + "','" + ActiveCmb.Text + "')"
                    Dim cmd As MySqlCommand = New MySqlCommand(str, DbFunctions.conn)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read Then
                    Else
                        MsgBox("Role added sucessfully", MsgBoxStyle.Information)
                        DbFunctions.conn.Close()
                        LoadRoles()
                    End If
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    DbFunctions.conn.Close()
                End Try
            Else
                Try
                    DbFunctions.conn.Close()
                    DbFunctions.conn.Open()
                    Dim str As String = "UPDATE `roles` SET `role_name`='" + NameCmb.Text + "',`bills`='" + billCmb.Text + "',`accounts`='" + AccCmb.Text + "',`inventory`='" + InvCmb.Text + "',`payroll`='" + PRCmb.Text + "',`analytics`='" + AlyCmb.Text + "',`vouchers`='" + voucherCmb.Text + "',`active_users`='" + ActiveCmb.Text + "' WHERE `role_name`='" + usname + "'"
                    Dim cmd As MySqlCommand = New MySqlCommand(str, DbFunctions.conn)
                    Dim dr As MySqlDataReader = cmd.ExecuteReader
                    If dr.Read Then
                    Else
                        MsgBox("Role Updated sucessfully", MsgBoxStyle.Information)
                        DbFunctions.conn.Close()
                        LoadRoles()
                    End If
                Catch ex As MySqlException
                    MsgBox(ex.Message)
                    DbFunctions.conn.Close()
                End Try
            End If
        End If
    End Sub
    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        Dim selectedrow As DataGridViewRow
        index = e.RowIndex
        selectedrow = DataGridView1.Rows(index)
        usname = selectedrow.Cells(0).Value.ToString()
        NameCmb.Text = selectedrow.Cells(0).Value.ToString()
        billCmb.Text = selectedrow.Cells(1).Value.ToString()
        AccCmb.Text = selectedrow.Cells(2).Value.ToString()
        InvCmb.Text = selectedrow.Cells(3).Value.ToString()
        PRCmb.Text = selectedrow.Cells(4).Value.ToString()
        AlyCmb.Text = selectedrow.Cells(5).Value.ToString()
        voucherCmb.Text() = selectedrow.Cells(6).Value.ToString()
        ActiveCmb.Text = selectedrow.Cells(7).Value.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NameCmb.Enabled = True
        billCmb.Enabled = True
        AccCmb.Enabled = True
        InvCmb.Enabled = True
        PRCmb.Enabled = True
        AlyCmb.Enabled = True
        voucherCmb.Enabled = True
        ActiveCmb.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        NameCmb.Enabled = False
        billCmb.Enabled = False
        AccCmb.Enabled = False
        InvCmb.Enabled = False
        PRCmb.Enabled = False
        AlyCmb.Enabled = False
        voucherCmb.Enabled = False
        ActiveCmb.Enabled = False
    End Sub
    Function check(ByVal Rolename) As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `roles` WHERE `role_name`='" + Rolename + "'", conn)
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim chk As Boolean = check(NameCmb.Text)
        If chk = False Then
            If NameCmb.Text = Nothing And billCmb.Text = Nothing And AccCmb.Text = Nothing And InvCmb.Text = Nothing And PRCmb.Text = Nothing And AlyCmb.Text = Nothing And ActiveCmb.Text = Nothing Then
                MsgBox("Please Select Role To Delete", MsgBoxStyle.Exclamation)
            Else
                If MessageBox.Show("Are You Sure You Want To Delete This Role?", "Finanza", MessageBoxButtons.YesNo) = vbYes Then
                    Try
                        DbFunctions.conn.Close()
                        DbFunctions.conn.Open()
                        Dim str As String = "DELETE FROM `roles` WHERE `role_name`='" + NameCmb.Text + "'"
                        Dim cmd As MySqlCommand = New MySqlCommand(str, DbFunctions.conn)
                        Dim dr As MySqlDataReader = cmd.ExecuteReader
                        If dr.Read Then
                        Else
                            MsgBox("Role Deleted sucessfully", MsgBoxStyle.Information)
                            DbFunctions.conn.Close()
                            LoadRoles()
                        End If
                    Catch ex As MySqlException
                        MsgBox(ex.Message)
                        DbFunctions.conn.Close()
                    End Try
                End If
            End If
        Else
            MsgBox("Role Doesn't Exist", MsgBoxStyle.Exclamation)
        End If
        NameCmb.Text = Nothing
        billCmb.Text = Nothing
        AccCmb.Text = Nothing
        InvCmb.Text = Nothing
        PRCmb.Text = Nothing
        AlyCmb.Text = Nothing
        voucherCmb.Text = Nothing
        ActiveCmb.Text = Nothing

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        NameCmb.Enabled = False
        billCmb.Enabled = False
        AccCmb.Enabled = False
        InvCmb.Enabled = False
        PRCmb.Enabled = False
        AlyCmb.Enabled = False
        voucherCmb.Enabled = False
        ActiveCmb.Enabled = False
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class