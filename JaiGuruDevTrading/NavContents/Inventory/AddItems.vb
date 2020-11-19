Imports MySql.Data.MySqlClient
Public Class add
    Private Sub clr()
        ItemName.Text = Nothing
        Quantity.Text = Nothing
        Code.Text = Nothing
        Discount.Text = Nothing
        CP.Text = Nothing
        SP.Text = Nothing
        TAX.Text = Nothing
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub
    Private Sub updategraph()
        Dim READER As MySqlDataReader
        Try
            DbFunctions.conn.Close()
            DbFunctions.conn.Open()
            Dim Query As String
            Query = "select *  from inventory"
            Dim Command As MySqlCommand = New MySqlCommand(Query, DbFunctions.conn)
            READER = Command.ExecuteReader
            While READER.Read
                Dim name As String = READER.GetValue(1)
                Dim Qty As String = Conversion.Val(READER.GetValue(2))
                Chart1.Series("Item_And_Stock").Points.AddXY(name, Qty)

            End While
            DbFunctions.conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            DbFunctions.conn.Dispose()
        End Try

    End Sub

    Private Sub AdItems_Click_1(sender As Object, e As EventArgs) Handles AdItems.Click
        If ItemName.Text <> Nothing And Quantity.Text <> Nothing And Code.Text <> Nothing And Discount.Text <> Nothing And CP.Text <> Nothing And SP.Text <> Nothing And TAX.Text <> Nothing Then
            insertData(ItemName.Text, Quantity.Text, CP.Text)
            clr()
            Chart1.Series(0).Points.Clear()
            updategraph()
        Else
            MsgBox("All Fields Are Mandatory", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        clr()
    End Sub

    Private Sub AddItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updategraph()
    End Sub
End Class