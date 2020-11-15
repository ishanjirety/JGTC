Imports MySql.Data.MySqlClient
Public Class ViewInventory
    Dim nameStore As String
    Private Sub ViewInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Edit.Enabled = False
        FillData()
        DataGridView1.Columns(0).HeaderText = "ID"
        DataGridView1.Columns(1).HeaderText = "Name"
        DataGridView1.Columns(2).HeaderText = "Quantity"
        DataGridView1.Columns(3).HeaderText = "Batch No./Code"
        DataGridView1.Columns(4).HeaderText = "MFG"
        DataGridView1.Columns(5).HeaderText = "EXP"
        DataGridView1.Columns(6).HeaderText = "Costprice"
        DataGridView1.Columns(7).HeaderText = "Selling Price"
        DataGridView1.Columns(8).HeaderText = "Tax To Be Charged"
        DataGridView1.Columns(9).HeaderText = "Discount To Be Given"
        DataGridView1.Columns(10).HeaderText = "Date Of Entry"
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
        Dim index As Integer
        Dim selectedrow As DataGridViewRow
        index = e.RowIndex
        selectedrow = DataGridView1.Rows(index)
        TextBox1.Text = selectedrow.Cells(1).Value.ToString()
        nameStore = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = Nothing
        TextBox1.Text = Nothing
        Edit.Enabled = False
    End Sub
End Class
