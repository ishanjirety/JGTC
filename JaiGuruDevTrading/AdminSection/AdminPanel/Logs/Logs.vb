Imports MySql.Data.MySqlClient
Public Class Logs
    Private Sub Logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Loadlogs()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim fileReader As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\test.txt")
        ' Reads Connection From txt file For Future Modifications
        Dim con As MySqlConnection = New MySqlConnection(fileReader)
        Dim searchQuery As String = "SELECT * FROM `logs` WHERE `log_username` like '%" + TextBox1.Text + "%'"
        Dim command As New MySqlCommand(searchQuery, con)
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class