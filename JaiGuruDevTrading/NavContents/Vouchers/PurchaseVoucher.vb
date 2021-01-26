Imports MySql.Data.MySqlClient
Public Class PurchaseVoucher
    Dim acName = "purchasea/c"
    Dim type As String = "PURCHASE"
    Dim bool As Boolean
    Dim status As String
    Dim arr As New List(Of String)
    Private Sub PurchaseVoucher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
        filltxtbox()
        FILLCMB("PurchaseVoucher")
        txtVouchNo.Text = voucherno + 1
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If txtAmt.Text <> Nothing And txtItemName.Text <> Nothing And txtQuantity.Text <> Nothing Then
            ListBox3.Items.Add(txtItemName.Text)
            ListBox2.Items.Add(txtQuantity.Text)
            ListBox4.Items.Add(txtAmt.Text)
            Dim QA As Integer = Conversion.Val(txtQuantity.Text) * Conversion.Val(txtAmt.Text)
            ListBox1.Items.Add(QA)

            Dim sum As Integer = 0
            For i As Integer = 0 To ListBox3.Items.Count - 1
                ListBox1.SetSelected(i, True)
                sum = sum + Conversion.Val(ListBox1.SelectedItem)
                TotalAmount.Text = sum
            Next
        Else
            MsgBox("ADD ITEMS TO CREATE VOUCHER", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If txtAmt.Text <> Nothing And TextBox1.Text <> Nothing And txtItemName.Text <> Nothing And txtQuantity.Text <> Nothing Then
            bool = checkLedger(TextBox1.Text.ToLower())
            If bool = False Then
                GetEntryStatus(TextBox1.Text.ToLower())
                MakeVoucherEntry(type, txtDate.Text, TextBox1.Text.ToLower(), TotalAmount.Text, "TO")
                If status = "YES" Then
                    Dim bool1 As Boolean = check(txtItemName.Text)
                    If bool1 = False Then
                        MakeInventoryEntryUPDATE()
                    Else
                        MakeInventoryEntryINSERT()
                    End If
                End If
                MakeRecordEntry()
                txtVouchNo.Text = Conversion.Val(txtVouchNo.Text) + 1

                clr()
            Else
                makeledger()
            End If
        Else
            MsgBox("SELECT LEDGER TO INPUT ENTRIES", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub clr()
        txtAmt.Text = Nothing
        txtItemName.Text = Nothing
        txtQuantity.Text = Nothing
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()

    End Sub
    Private Sub GetEntryStatus(ByVal Name)
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "SELECT `AffectsInventory` FROM `ledgernames` WHERE `Name`='" + acName + "'"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                status = dr.GetValue(0)
            End If
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub MakeInventoryEntryUPDATE()

        Try
            conn.Close()
            conn.Open()
            For i As Integer = 0 To ListBox3.Items.Count - 1
                ListBox1.SetSelected(i, True)
                ListBox2.SetSelected(i, True)
                ListBox3.SetSelected(i, True)
                Dim ItemNme As String = ListBox3.SelectedItem
                Dim str As String = "SELECT `inv_itemQty` FROM `inventory` WHERE `inv_itemName`='" + ItemNme + "'"
                Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                Dim value As String
                If dr.Read() Then
                    value = dr.GetValue(0)
                End If
                conn.Close()
                conn.Open()
                Dim sum As Integer = Conversion.Val(value) + Conversion.Val(ListBox2.SelectedItem)
                Dim str1 As String = "UPDATE `inventory` SET `inv_itemQty` = '" + Conversion.Str(sum) + "' WHERE `inv_itemName` = '" + ItemNme + "'"
                Dim cmd1 As MySqlCommand = New MySqlCommand(str1, conn)
                Dim dr1 As MySqlDataReader = cmd1.ExecuteReader()
                conn.Close()
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub MakeInventoryEntryINSERT()
        insertData(txtItemName.Text, txtQuantity.Text, txtAmt.Text)
    End Sub
    Private Function check(ByVal name) As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `inventory` WHERE `inv_itemName`='" + name + "'", conn)
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
    Private Sub filltxtbox()
        Try
            conn.Close()
            conn.Open()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter
            Dim Str As String = "SELECT `inv_itemName` FROM `inventory`"
            Dim cmd As MySqlCommand = New MySqlCommand(Str, DbFunctions.conn)
            da.SelectCommand = cmd
            da.Fill(ds, "inventory")
            Dim a As Integer = ds.Tables("inventory").Rows.Count - 1
            For i As Integer = 0 To a
                arr.Add(ds.Tables("inventory").Rows(i)(0).ToString())
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occured : " + ex.Message)
        End Try
        txtItemName.AutoCompleteCustomSource.AddRange(arr.ToArray)
    End Sub

    Private Function checkLedger(ByVal name) As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `ledgernames` WHERE `Name`='" + name + "'", conn)
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
    Private Sub makeledger()
        Create_Led.Show()
        Create_Led.OpenedBy = "PV"
        Create_Led.LedNAME.Text = TextBox1.Text.ToLower()
        Create_Led.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
    Private Sub btn_clr_Click(sender As Object, e As EventArgs) Handles btn_clr.Click
        clr()
    End Sub
    Private Sub MakeRecordEntry()
        Try
            conn.Close()
            For i As Integer = 0 To ListBox1.Items.Count - 1
                conn.Open()
                ListBox1.SetSelected(i, True)
                ListBox2.SetSelected(i, True)
                ListBox3.SetSelected(i, True)
                ListBox4.SetSelected(i, True)
                Dim itemName As String = ListBox3.SelectedItem
                Dim QTY As String = ListBox2.SelectedItem
                Dim Rate As String = ListBox4.SelectedItem
                Dim amt As String = ListBox1.SelectedItem

                Dim str As String = "INSERT INTO `purchase` (`VoucherNo`, `ItemName`, `ItemQty`, `Rate`, `Amount`) VALUES ( '" + txtVouchNo.Text + "', '" + itemName + "', '" + QTY + "', '" + Rate + "', '" + amt + "')"
                Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()
                conn.Close()
            Next
        Catch ex As mysqlException
            MsgBox("AN ERROR OCCURED : " + ex.Message)
        End Try
    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtItemName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemName.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) = 32 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub txtAmt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmt.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) = 32 Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class