Imports MySql.Data.MySqlClient
Public Class GrantRoles

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub GrantRoles_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadRoles()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Public Sub LoadRoles()
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
        Try
            DbFunctions.conn.Close()
            DbFunctions.conn.Open()
            Dim str As String = "INSERT INTO `roles` VALUES('" + NameCmb.Text + "','" + billCmb.Text + "','" + AccCmb.Text + "','" + InvCmb.Text + "','" + PRCmb.Text + "','" + AlyCmb.Text + "','" + ActiveCmb.Text + "')"
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
    End Sub
    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        Dim selectedrow As DataGridViewRow
        index = e.RowIndex
        selectedrow = DataGridView1.Rows(index)
        NameCmb.Text = selectedrow.Cells(0).Value.ToString()
        billCmb.Text = selectedrow.Cells(1).Value.ToString()
        AccCmb.Text = selectedrow.Cells(2).Value.ToString()
        InvCmb.Text = selectedrow.Cells(3).Value.ToString()
        PRCmb.Text = selectedrow.Cells(4).Value.ToString()
        AlyCmb.Text = selectedrow.Cells(5).Value.ToString()
        ActiveCmb.Text = selectedrow.Cells(6).Value.ToString()
    End Sub
End Class