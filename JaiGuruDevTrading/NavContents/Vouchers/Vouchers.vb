Imports MySql.Data.MySqlClient
Module Vouchers
    Public voucherno As String
    Dim str As String
    Public Sub FILLCMB(ByVal CalledBy)
        Try
            Dim arr As New List(Of String)

            conn.Close()
            conn.Open()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter
            If calledBy = "PurchaseVoucher" Then
                Str = "SELECT `Name` FROM `ledgernames` WHERE `Category`='Sundry Creditors' OR `Category`='Cash' OR `Category`='Bank'"
            ElseIf calledBy = "SalesVoucher" Then
                Str = "SELECT `Name` FROM `ledgernames` WHERE `Category`='Sundry Debtors' OR `Category`='Cash' OR `Category`='Bank'"
            End If
            Dim cmd As MySqlCommand = New MySqlCommand(Str, DbFunctions.conn)
            da.SelectCommand = cmd
            da.Fill(ds, "ledgernames")
            Dim a As Integer = ds.Tables("ledgernames").Rows.Count - 1
            'voucherno = ds.Tables("ledgernames").Rows(a)(1).ToString()
            For i As Integer = 0 To a
                arr.Add(ds.Tables("ledgernames").Rows(i)(0).ToString())
            Next
            SalesVoucher.TextBox1.AutoCompleteCustomSource.AddRange(arr.ToArray)
            PurchaseVoucher.TextBox1.AutoCompleteCustomSource.AddRange(arr.ToArray)
            conn.Close()
            VOUCHERNUMBER()
        Catch ex As Exception
            MsgBox("Error Occured : " + ex.Message)
        End Try
    End Sub
    Public Sub VOUCHERNUMBER()
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "select Vouch_ID from vouchers order by Vouch_ID desc limit 0,1"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                voucherno = dr.GetValue(0)
            End If
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
        End Try
    End Sub
    Public Sub MakeVoucherEntry(ByVal TYPE, ByVal CREATEDATE, ByVal PARTYLEDGER, ByVal AMOUNT, ByVal DENOTE)
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "INSERT INTO `vouchers` ( `Type`, `Date`, `Entry Ledger`, `PartyLedger`, `amount`) VALUES ('" + TYPE + "', '" + CREATEDATE + "', 'purchasea/c', '" + PurchaseVoucher.TextBox1.Text + "','" + AMOUNT + "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            MsgBox("VOUCHER CREATED", MsgBoxStyle.Information)
            MakeLedgerEntryPurchase(CREATEDATE, PARTYLEDGER, AMOUNT)
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub MakeVoucherEntrySales(ByVal TYPE, ByVal CREATEDATE, ByVal PARTYLEDGER, ByVal AMOUNT, ByVal DENOTE)
        Try
            conn.Close()
            conn.Open()
            Dim str As String = "INSERT INTO `vouchers` ( `Type`, `Date`, `Entry Ledger`, `PartyLedger`, `amount`) VALUES ('" + TYPE + "', '" + CREATEDATE + "', 'salesa/c', '" + SalesVoucher.TextBox1.Text + "','" + AMOUNT + "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            MsgBox("VOUCHER CREATED", MsgBoxStyle.Information)
            MakeLedgerEntrySales(CREATEDATE, PARTYLEDGER, AMOUNT)
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub MakeLedgerEntryPurchase(ByVal CREATEDATE, ByVal PARTYLEDGER, ByVal AMOUNT)
        Try
            conn.Close()
            conn.Open()
            Try
                Dim str1 As String = "INSERT INTO `" + PARTYLEDGER + "` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES ('" + CREATEDATE + "', 'BY', 'purchasea/c' , '" + AMOUNT + "')"
                Dim str2 As String = "INSERT INTO `purchasea/c` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES ('" + CREATEDATE + "', 'TO', '" + PARTYLEDGER + "', '" + AMOUNT + "')"
                Dim cmd1 As MySqlCommand = New MySqlCommand(str1, conn)
                Dim cmd2 As MySqlCommand = New MySqlCommand(str2, conn)
                Dim dr1 As MySqlDataReader = cmd1.ExecuteReader
                conn.Close()
                conn.Open()
                Dim dr2 As MySqlDataReader = cmd2.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox("AN ERROR OCCURED :" + ex.Message)
                conn.Close()
            End Try
        Catch ex As Exception

        End Try
    End Sub
    Private Sub MakeLedgerEntrySales(ByVal CREATEDATE, ByVal PARTYLEDGER, ByVal AMOUNT)
        Try
            conn.Close()
            conn.Open()
            Try
                Dim str1 As String = "INSERT INTO `" + PARTYLEDGER + "` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES ('" + CREATEDATE + "', 'TO', 'salesa/c' , '" + AMOUNT + "')"
                Dim str2 As String = "INSERT INTO `salesa/c` (`DATE`, `DENOTE`, `PARTICULAR`, `AMOUNT`) VALUES ('" + CREATEDATE + "', 'BY', '" + PARTYLEDGER + "', '" + AMOUNT + "')"
                Dim cmd1 As MySqlCommand = New MySqlCommand(str1, conn)
                Dim cmd2 As MySqlCommand = New MySqlCommand(str2, conn)
                Dim dr1 As MySqlDataReader = cmd1.ExecuteReader
                conn.Close()
                conn.Open()
                Dim dr2 As MySqlDataReader = cmd2.ExecuteReader
                conn.Close()
            Catch ex As Exception
                MsgBox("AN ERROR OCCURED :" + ex.Message)
                conn.Close()
            End Try
        Catch ex As Exception

        End Try
    End Sub
End Module
