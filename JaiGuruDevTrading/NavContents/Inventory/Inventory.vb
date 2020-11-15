Imports MySql.Data.MySqlClient
Module Inventory
    Dim fileReader As String = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\test.txt")
    ' Reads Connection From txt file For Future Modifications
    Private conn As MySqlConnection = New MySqlConnection(fileReader)

    Public Sub FillData()
        Try
            Dim Str As String = "SELECT * FROM `inventory`"
            conn.Close()
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "inventory")
            ViewInventory.DataGridView1.DataSource = ds.Tables("inventory")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub insertData(ByVal name, ByVal qty, ByVal code, ByVal mfg, ByVal exp, ByVal discount, ByVal cp, ByVal sp, ByVal tax)
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "INSERT INTO `inventory` (`inv_itemName`, `inv_itemQty`, `inv_itemCode`, `inv_itemMfg`, `inv_itemExp`, `inv_itemCP`, `inv_itemSP`, `inv_itemTax`, `inv_itemDisc`,`EntryDate`) VALUES ('" + name + "', '" + qty + "', '" + code + "', '" + mfg + "', '" + exp + "', '" + cp + "', '" + sp + "', '" + tax + "', '" + discount + "','" + DateTime.Now + "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            MsgBox("Item Inserted Successfully", MsgBoxStyle.Information)
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Module
