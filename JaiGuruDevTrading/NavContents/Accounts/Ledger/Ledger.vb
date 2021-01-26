Imports MySql.Data.MySqlClient
Module LedgerManagement
    Public Sub CREATE_LEDGER(ByVal NAME, ByVal AFFECTSINV, ByVal CUSNAME, ByVal ADDRESS, ByVal MOBILE, ByVal BANKDETAILS, ByVal Category)
        Dim bool As Boolean = check(NAME)
        If bool = True Then
            conn.Close()
            conn.Open()
            Try
                Dim str As String = "CREATE TABLE `" + NAME + "` ( `DATE` VARCHAR(20) NOT NULL , `DENOTE` VARCHAR(5) NOT NULL , `PARTICULAR` VARCHAR(30) NOT NULL , `AMOUNT` VARCHAR(20) NOT NULL ) ENGINE = InnoDB;"
                Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
                Dim dr As MySqlDataReader = cmd.ExecuteReader
                MsgBox("Ledger " + NAME + " Created Successfully", MsgBoxStyle.Information)
                conn.Close()
                MAKE_LEDGER_ENTRY(NAME, AFFECTSINV, CUSNAME, ADDRESS, MOBILE, BANKDETAILS, Category)
            Catch ex As Exception
                MsgBox("UNEXPECTED ERROR OCCURED " + ex.Message)
            End Try
        End If
    End Sub
    Private Sub MAKE_LEDGER_ENTRY(ByVal NAME, ByVal AFFECTSINV, ByVal CUSNAME, ByVal ADDRESS, ByVal MOBILE, ByVal BANKDETAILS, ByVal Category)
        conn.Close()
        conn.Open()
        Try
            MsgBox(NAME + "refLed")
            Dim str As String = "INSERT INTO `ledgernames` (`Name`, `AffectsInventory`, `CUSNAME`, `ADDRESS`, `MOBILE`, `BANKDETAILS`,`Category`,`DateOfCreation`) VALUES ('" + NAME + "', '" + AFFECTSINV + "', '" + CUSNAME + "', '" + ADDRESS + "', '" + MOBILE + "', '" + BANKDETAILS + "','" + Category + "','" + DateTime.Now + "')"
            Dim cmd As MySqlCommand = New MySqlCommand(str, conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            conn.Close()
        Catch ex As Exception
            MsgBox("UNEXPECTED ERROR OCCURED " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Function check(ByVal NAME) As Boolean   'Checks If Ledger Exists and returns Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `ledgernames` WHERE `Name`='" + NAME + "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            If rdr.HasRows Then
                MsgBox("LEDGER ALREADY EXISTS WITH THIS NAME", MsgBoxStyle.Critical)
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
    Public Sub FillLedgerData()
        Try
            Dim Str As String = "SELECT `Name` FROM `ledgernames`"
            conn.Close()
            conn.Open()
            Dim Search As New MySqlDataAdapter(Str, conn)
            Dim ds As DataSet = New DataSet
            Search.Fill(ds, "ledgernames")
            Create_Led.DataGridView1.DataSource = ds.Tables("ledgernames")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Module
