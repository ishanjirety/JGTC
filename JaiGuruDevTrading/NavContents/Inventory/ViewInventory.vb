Imports MySql.Data.MySqlClient
Public Class ViewInventory

    Dim nameStore As String
    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Edit.Enabled = False
        FillData()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Quantity"
        DataGridView1.Columns(3).HeaderText = "Amount"
        DataGridView1.Columns(4).HeaderText = "Date Of Entry"
        Me.DoubleBuffered = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            DbFunctions.conn.Close()
            DbFunctions.conn.Open()
            Dim searchQuery As String = "SELECT * FROM `inventory` WHERE `inv_itemName` like '%" + TextBox1.Text + "%'"
            Dim command As New MySqlCommand(searchQuery, DbFunctions.conn)
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable
            adapter.Fill(table)
            DbFunctions.conn.Close()
            DataGridView1.DataSource = table
        Catch ex As MySqlException
            MsgBox(ex.Message)
            DbFunctions.conn.Close()
        End Try
    End Sub

    Private Sub Btn_edit_Click(sender As Object, e As EventArgs) Handles Btn_edit.Click
        If TextBox1.Text <> Nothing Then
            Edit.Enabled = True
            TextBox2.Text = nameStore
        Else
            MsgBox("Please Select a value to Edit ", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim index As Integer
            Dim selectedrow As DataGridViewRow
            index = e.RowIndex
            selectedrow = DataGridView1.Rows(index)
            TextBox1.Text = selectedrow.Cells(1).Value.ToString()
            nameStore = TextBox1.Text
        Catch ex As Exception
            MsgBox("Please Select A Single Row", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = Nothing
        TextBox1.Text = Nothing
        Edit.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Str As String
        If ComboBox1.Text = "QUANTITY" Then
            Str = "UPDATE `inventory` SET `inv_itemQty` = '" + TextBox3.Text + "' WHERE `inv_itemName` = '" + TextBox2.Text + "'"
        ElseIf ComboBox1.Text = "AMOUNT" Then
            Str = "UPDATE `inventory` SET `amount` = '" + TextBox3.Text + "' WHERE `inv_itemName` = '" + TextBox2.Text + "'"
        ElseIf ComboBox1.Text = "ENTRY DATE" Then
            Str = "UPDATE `inventory` SET `EntryDate` = '" + TextBox3.Text + "' WHERE `inv_itemName` = '" + TextBox2.Text + "'"
        Else
            MsgBox("Please Select Value To UPDATE", MsgBoxStyle.Exclamation)
        End If

        If ComboBox1.Text <> Nothing Then
            Try
                conn.Close()
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(Str, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                MsgBox("Item Updated", MsgBoxStyle.Information)
                clr()
                FillData()
                conn.Close()
            Catch ex As MySqlException
                MsgBox(ex.Message)
                conn.Close()
            End Try
        End If
        FillData()
    End Sub
    Private Sub clr()
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        ComboBox1.Text = Nothing
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "DELETE FROM `inventory` WHERE `inv_itemName` = '" + TextBox1.Text + "'"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            MsgBox("Item Deleted", MsgBoxStyle.Information)
            clr()
            FillData()
            Edit.Enabled = False
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Edit_Paint(sender As Object, e As PaintEventArgs) Handles Edit.Paint

    End Sub
End Class
