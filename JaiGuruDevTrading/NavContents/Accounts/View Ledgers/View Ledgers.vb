Imports MySql.Data.MySqlClient
Public Class View_Ledgers
    Dim SELECTEDYEAR As String
    Dim yearEnded As New List(Of String)
    Dim Ledgers As New List(Of String)
    Dim startDate As String
    Dim EndDate As String
    Private Sub LEDTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LEDTYPE.SelectedIndexChanged
        Clr()
        Ledgers.Clear()
        If ComboBox1.Text <> Nothing Then
            buffer.BringToFront()
            buffer.Visible = True
            buffer.Enabled = True
            SELECT_LEDGERS()
            INSERT_LEDGER_BALANCE()
            buffer.SendToBack()
            buffer.Visible = False
            buffer.Enabled = False
            CalculateTotal()
        Else
            MsgBox("SELECT ACCOUNTING YEAR", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub View_Ledgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        buffer.Show()
        buffer.SendToBack()
        buffer.Enabled = True
        LOAD_ACCOUNTING_PERIODS()
    End Sub
    Private Function SELECT_LEDGERS()
        Try
            conn.Close()
            conn.Open()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter
            Dim Str As String = "Select Name,Category,LedNumber,DateOfCreation FROM `ledgernames` where Category='" + LEDTYPE.Text + "'"
            Dim cmd As MySqlCommand = New MySqlCommand(Str, DbFunctions.conn)
            da.SelectCommand = cmd
            da.Fill(ds, "ledgernames")
            Dim a As Integer = ds.Tables("ledgernames").Rows.Count - 1
            For i As Integer = 0 To a
                ledgers.add(ds.Tables("ledgernames").Rows(i)(0).ToString())
                ListBox1.Items.Add(ds.Tables("ledgernames").Rows(i)(3).ToString())
                ListBox2.Items.Add(ds.Tables("ledgernames").Rows(i)(0).ToString())
                ListBox3.Items.Add(ds.Tables("ledgernames").Rows(i)(1).ToString())
                ListBox4.Items.Add(ds.Tables("ledgernames").Rows(i)(2).ToString())

                ShowBalances(ds.Tables("ledgernames").Rows(i)(0).ToString())
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox("Error Occured : " + ex.Message)
        End Try
    End Function
    Private Function LOAD_ACCOUNTING_PERIODS()
        Try
            conn.Close()
            conn.Open()
            Dim CMD_STR As String = "SELECT * FROM `accountingyear`"
            Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
            Dim DR As MySqlDataReader = CMD.ExecuteReader()
            If DR.Read() Then
                startDate = DR.GetValue(1)
                EndDate = DR.GetValue(2)
            End If
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
        ComboBox1.Items.Clear()
        GET_ACCOUNTING_YEARS(startDate.Trim(), EndDate.Trim())

    End Function
    Private Function GET_ACCOUNTING_YEARS(ByVal startdate, ByVal enddate)
        Try
            conn.Close()
            conn.Open()
            Dim CMD_STR As String = "SELECT * FROM `yearended`"
            Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
            Dim DS As New DataSet
            Dim DR As New MySqlDataAdapter
            DR.SelectCommand = CMD
            DR.Fill(DS, "yearended")
            Dim N As Integer = DS.Tables("yearended").Rows.Count - 1
            For i As Integer = 0 To N
                yearEnded.Add(DS.Tables("yearended").Rows(i)(1).ToString())
                Dim YEAR_BEGIN As String = startdate.substring(0, 6) + DS.Tables("yearended").Rows(i)(1).ToString()
                Dim YEAR_END As String = enddate.substring(0, 6) + DS.Tables("yearended").Rows(i)(1).ToString()
                ComboBox1.Items.Add(YEAR_BEGIN.Trim + " - " + YEAR_END.Trim)
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try

    End Function
    Private Function ShowBalances(ByVal ledgername As String)
        Dim SIDE_TOTAL As String
        Dim SIDE_DENOTE As String
        'MsgBox(ledgername)
        Try
            conn.Close()
            conn.Open()
            Dim CMD_STR_TO As String = "SELECT `Cur_Denote`,`Cur_B/D` FROM `balances` where `ledgername`='" + ledgername.ToLower() + "' AND `Date_of_bal` LIKE '%" + SELECTEDYEAR.Trim() + "%'"
            Dim CMD_TO As MySqlCommand = New MySqlCommand(CMD_STR_TO, conn)
            Dim DR_TO As MySqlDataReader = CMD_TO.ExecuteReader()
            If DR_TO.Read() Then
                SIDE_TOTAL = DR_TO.GetValue(1)
                SIDE_DENOTE = DR_TO.GetValue(0)
            End If
            If SIDE_DENOTE = "Dr" Then
                ListBox5.Items.Add(SIDE_TOTAL)
            Else
                ListBox6.Items.Add(SIDE_TOTAL)
            End If
            conn.Close()
        Catch ex As mysqlException
            MsgBox("AN ERROR OCCURED GETLEDGERTOTAL : " + ex.Message)
            conn.Close()
        End Try
    End Function
    Private Function GET_LEDGER_TOTAL(ByVal ledgername As String)
        Dim DR_SIDE_TOTAL As Integer
        Dim CR_SIDE_TOTAL As Integer
        'MsgBox(ledgername)
        Try
            conn.Close()
            conn.Open()
            Dim CMD_STR_TO As String = "SELECT SUM(AMOUNT) FROM `" + ledgername.ToLower() + "` WHERE DENOTE='TO' AND DATE LIKE '%" + SELECTEDYEAR.Trim() + "%'"
            Dim CMD_TO As MySqlCommand = New MySqlCommand(CMD_STR_TO, conn)
            Dim DR_TO As MySqlDataReader = CMD_TO.ExecuteReader()
            If DR_TO.Read() Then
                If IsDBNull(DR_TO(0)) Then
                    DR_SIDE_TOTAL = 0
                Else
                    DR_SIDE_TOTAL = DR_TO(0)
                End If
            End If
            conn.Close()
            conn.Open()
            Dim CMD_STR_BY As String = "SELECT SUM(AMOUNT) FROM `" + ledgername.ToLower() + "` WHERE DENOTE='BY' AND DATE LIKE '%" + SELECTEDYEAR.Trim() + "%'"
            Dim CMD_BY As MySqlCommand = New MySqlCommand(CMD_STR_BY, conn)
            Dim DR_BY As MySqlDataReader = CMD_BY.ExecuteReader()
            If DR_BY.Read() Then
                If IsDBNull(DR_BY(0)) Then
                    CR_SIDE_TOTAL = 0
                Else
                    CR_SIDE_TOTAL = DR_BY(0)
                End If
            End If

            If DR_SIDE_TOTAL > CR_SIDE_TOTAL Then
                If Math.Abs(DR_SIDE_TOTAL - CR_SIDE_TOTAL) <> 0 Then
                    ListBox5.Items.Add(Math.Abs(DR_SIDE_TOTAL - CR_SIDE_TOTAL))
                End If
            Else
                    If Math.Abs(CR_SIDE_TOTAL - DR_SIDE_TOTAL) <> 0 Then
                    ListBox6.Items.Add(Math.Abs(CR_SIDE_TOTAL - DR_SIDE_TOTAL))
                End If
            End If
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED GETLEDGERTOTAL : " + ex.Message)
            conn.Close()
        End Try
    End Function
    Private Sub Clr()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        TOT1.Text = Nothing
        TOT2.Text = Nothing
        CLB1.Text = Nothing
        CLB2.Text = Nothing
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Clr()
        SELECTEDYEAR = ComboBox1.Text.Substring(6, 4)
        'MsgBox(SELECTEDYEAR)
        If LEDTYPE.Text <> Nothing Then
            SELECT_LEDGERS()
        Else
            MsgBox("SELECT LEDGER", MsgBoxStyle.Exclamation)
        End If
        CalculateTotal()
    End Sub
    Private Sub INSERT_LEDGER_BALANCE()
        'fetch entries of 2020-1 if there is no entry there is no curr bal
        'MsgBox("HERE IN INSERT_LEDGER_BALANCE")
        Dim PrevDenote As String
        Dim PrevBal As String
        Try

            'Fetching Entries Of DateTime.year.now -1  if dr.read = null
            'insert 0 in prev of current year entry else insert curr of todays-1 into todays prev

            For i As Integer = 0 To Ledgers.Count - 1
                Dim bool As Boolean = CheckIfEntryIsNew(Ledgers(i)) 'Check If previous Year Ledger Is Present
                If bool = True Then
                    conn.Close()
                    conn.Open()
                    Dim dt As String = (DateAndTime.Now.Year - 1).ToString().Trim()
                    'MsgBox("ILB" + dt)
                    'MsgBox((DateAndTime.Now.Year - 1).ToString().Trim())
                    Dim CMD_STR As String = "SELECT `Cur_Denote`,`Cur_B/D` FROM `balances` WHERE ledgername='" + Ledgers(i).ToLower() + "' AND `Date_of_bal` LIKE '%" + dt + "'"
                    Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
                    Dim DR As MySqlDataReader = CMD.ExecuteReader()
                    If DR.Read() Then
                        PrevDenote = DR.GetValue(0)
                        PrevBal = DR.GetValue(1)
                    End If
                    'check prev bal denote and add to SUM(amount) of side it belongs to and subtract greater amount from other side and insert into current bal
                    'MsgBox(PrevDenote + "  " + PrevBal)
                    conn.Close()
                    conn.Open()
                    Dim CMD_STR_INS As String = "INSERT INTO `balances` (`Date_of_bal`, `ledgername`, `Prev_Denote`, `Prev_B/D`) VALUES ('" + DateAndTime.Now.Year.ToString().Trim() + "', '" + Ledgers(i).ToLower() + "', '" + PrevDenote + "', '" + PrevBal + "')"
                    Dim CMD_INS As MySqlCommand = New MySqlCommand(CMD_STR_INS, conn)
                    Dim DR_INS As MySqlDataReader = CMD_INS.ExecuteReader()
                    ADD_AND_CALCULATE_INSERT(PrevDenote, PrevBal, Ledgers(i))
                Else
                    'check prev bal denote and add to SUM(amount) of side it belongs to and subtract greater amount from other side and insert into current bal
                    'MsgBox(PrevDenote + "  " + PrevBal)
                    ADD_AND_CALCULATE_INSERT("Cr", 0, Ledgers(i))
                End If
            Next
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED INSERT_IN_LEDGER_BALANCE" + ex.Message)
        End Try
    End Sub
    Private Sub ADD_AND_CALCULATE_INSERT(ByVal PrevDenote As String, ByVal PrevBal As String, ByVal ledgerName As String)
        Dim DR_TOTAL As String
        Dim CR_TOTAL As String
        Try
            conn.Close()
            conn.Open()
            Dim CMDSTR_TO As String = "SELECT SUM(AMOUNT) FROM `" + ledgerName.ToLower() + "` WHERE DENOTE='TO' AND DATE LIKE '%" + DateAndTime.Now.Year.ToString().Trim() + "%'"
            Dim CMD_TO As MySqlCommand = New MySqlCommand(CMDSTR_TO, conn)
            Dim DR_TO As MySqlDataReader = CMD_TO.ExecuteReader()
            If DR_TO.Read() Then
                If IsDBNull(DR_TO.GetValue(0)) Then
                    DR_TOTAL = 0
                Else
                    DR_TOTAL = DR_TO.GetValue(0)
                End If
            End If
            conn.Close()
            conn.Open()
            Dim CMDSTR_BY As String = "SELECT SUM(AMOUNT) FROM `" + ledgerName.ToLower() + "` WHERE DENOTE='BY' AND DATE LIKE '%" + DateAndTime.Now.Year.ToString().Trim() + "%'"
            Dim CMD_BY As MySqlCommand = New MySqlCommand(CMDSTR_BY, conn)
            Dim CR_BY As MySqlDataReader = CMD_BY.ExecuteReader()
            If CR_BY.Read() Then
                If IsDBNull(CR_BY.GetValue(0)) Then
                    CR_TOTAL = 0
                Else
                    CR_TOTAL = CR_BY.GetValue(0)
                    'MsgBox(CR_TOTAL)
                End If
            End If
            If PrevDenote = "Dr" Then
                DR_TOTAL = Conversion.Val(PrevBal) + Conversion.Val(DR_TOTAL)
            Else
                CR_TOTAL = Conversion.Val(PrevBal) + Conversion.Val(CR_TOTAL)
            End If
            If DR_TOTAL > CR_TOTAL Then
                'INSERT DR. & DR_TOTAL-CR_TOTAL into current year's current
                UPDATE_BALANCES("Dr", Math.Abs(DR_TOTAL - CR_TOTAL), ledgerName.ToLower(), PrevBal, PrevDenote)
                ' MsgBox(Math.Abs(DR_TOTAL - CR_TOTAL))
            Else
                UPDATE_BALANCES("Cr", Math.Abs(CR_TOTAL - DR_TOTAL), ledgerName.ToLower(), PrevBal, PrevDenote)
                'MsgBox(Math.Abs(CR_TOTAL - DR_TOTAL))
            End If
            conn.Close()
        Catch ex As mysqlException
            MsgBox("AN ERROR OCCURED :" + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub UPDATE_BALANCES(ByVal Denote As String, ByVal Total As String, ByVal ledgerName As String, ByVal previousbal As String, ByVal previousdenote As String)
        'MsgBox(Denote + " " + Total + " " + ledgerName.ToLower() + " " + previousbal + " " + previousdenote)
        If CheckEntryIsPresent(ledgerName) = True Then
            'Updating Balances
            Try
                conn.Close()
                conn.Open()
                Dim CMD_STR As String = "UPDATE `balances` SET `Prev_Denote`='" + previousdenote + "',`Prev_B/D`='" + previousbal + "',`Cur_Denote`='" + Denote + "',`Cur_B/D`='" + Total + "' WHERE `ledgername`='" + ledgerName.ToLower() + "' AND `Date_of_bal` LIKE '" + DateAndTime.Now.Year.ToString().Trim() + "'"
                Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
                Dim DR As MySqlDataReader = CMD.ExecuteReader()
                conn.Close()
                'MsgBox("BAL UPDATED (UPDATE_BALANCES(UPDATE))")
            Catch ex As Exception
                MsgBox("AN ERROR OCCURED(UPDATE_BALANCES(UPDATE)) :" + ex.Message)
                conn.Close()
            End Try
        Else
            'Inserting
            Try
                conn.Close()
                conn.Open()
                Dim CMD_STR As String = "INSERT INTO `balances` (`Date_of_bal`, `ledgername`, `Prev_Denote`, `Prev_B/D`, `Cur_Denote`, `Cur_B/D`) VALUES ('" + DateAndTime.Now.Year.ToString().Trim() + "', '" + ledgerName.ToLower() + "', '" + previousdenote + "', '" + previousbal + "', '" + Denote + "', '" + Total + "');"
                Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
                Dim DR As MySqlDataReader = CMD.ExecuteReader()
                conn.Close()
                'MsgBox("BAL UPDATED (UPDATE_BALANCES(INSERT))")
            Catch ex As Exception
                MsgBox("AN ERROR OCCURED(UPDATE_BALANCES(INSERT)) :" + ex.Message)
                conn.Close()
            End Try
        End If
    End Sub
    Private Function CheckEntryIsPresent(ByVal LedgerName) As Boolean 'Associated With UPDATE_BALANCES
        Try
            conn.Close()
            conn.Open()
            Dim CMD_STR As String = "SELECT * FROM `balances` WHERE `ledgername`='" + LedgerName.ToLower() + "' AND `Date_of_bal` LIKE '%" + DateTime.Now.Year.ToString().Trim() + "%'"
            Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
            Dim DR As MySqlDataReader = CMD.ExecuteReader()
            If DR.HasRows Then
                conn.Close()
                Return True
            Else
                conn.Close()
                Return False
            End If
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED : " + ex.Message)
            conn.Close()
        End Try
    End Function
    Private Function CheckIfEntryIsNew(ByVal Name As String) As Boolean  'ASSOCIATED WITH INSERT LEDGER BALANCE
        Try
            Dim DT As String = Conversion.Str(DateTime.Now.Year - 1).ToString().Trim()
            'MsgBox("CEIFEN" + DT)
            conn.Close()
            conn.Open()
            Dim CMD_STR As String = "SELECT * FROM `" + Name.ToLower() + "` WHERE DATE LIKE '%" + DT + "%'"
            Dim CMD As MySqlCommand = New MySqlCommand(CMD_STR, conn)
            Dim DR As MySqlDataReader = CMD.ExecuteReader()
            If DR.HasRows Then
                conn.Close()
                'MsgBox("ENTRY EXIST")
                Return True
            Else
                conn.Close()
                Return False
            End If
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED CHECK_IF_ENTRY_IS_NEW: " + ex.Message)
            conn.Close()
        End Try
    End Function
    Private Sub CalculateTotal()
        Dim sumDr, sumCr, FinalAmt As Integer
        For i As Integer = 0 To ListBox5.Items.Count - 1
            ListBox5.SetSelected(i, True)
            sumDr = Conversion.Val(ListBox5.SelectedItem) + sumDr
        Next
        For i As Integer = 0 To ListBox6.Items.Count - 1
            ListBox6.SetSelected(i, True)
            sumCr = Conversion.Val(ListBox6.SelectedItem) + sumCr
        Next
        TOT1.Text = sumDr
        TOT2.Text = sumCr
        If sumDr > sumCr Then
            FinalAmt = Math.Abs(sumDr - sumCr)
            CLB1.Text = FinalAmt.ToString() + " Dr."
        Else
            FinalAmt = Math.Abs(sumCr - sumDr)
            CLB2.Text = FinalAmt.ToString() + " Cr."
        End If

    End Sub
End Class
