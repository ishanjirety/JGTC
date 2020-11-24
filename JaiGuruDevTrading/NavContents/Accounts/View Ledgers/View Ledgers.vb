Imports MySql.Data.MySqlClient
Public Class View_Ledgers
    Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)
    Dim DBdate As String
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Clr()
        Label4.Text = ComboBox1.Text
        GetLedgerEntriesBY(ComboBox1.Text)
        GetLedgerEntriesTO(ComboBox1.Text)
        insertLine()
    End Sub
    Public Sub GetLedgerEntriesBY(ByVal Name)
        Try
            conn.Close()
            conn.Open()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter
            Dim Str As String = "SELECT * FROM `" + Name + "` WHERE DENOTE='BY'"
            Dim cmd As MySqlCommand = New MySqlCommand(Str, conn)
            da.SelectCommand = cmd
            da.Fill(ds, Name)
            Dim a As Integer = ds.Tables(Name).Rows.Count - 1
            For i As Integer = 0 To a
                ListBox4.Items.Add(ds.Tables(Name).Rows(i)(0).ToString())
                ListBox5.Items.Add("BY " + ds.Tables(Name).Rows(i)(2).ToString())
                ListBox6.Items.Add(ds.Tables(Name).Rows(i)(3).ToString())
            Next
            Dim n As Integer = 0
            Dim amt As Integer
            Dim sumdr As Integer
            Dim sumcr As Integer
            For i As Integer = 0 To (a * 2) + 1
                If i Mod 2 = 0 Then

                    ListBox8.Items.Add(ds.Tables(Name).Rows(n)(2).ToString() + "        Dr.")
                    ListBox8.Items.Add("        To  " + ComboBox1.Text)
                    ListBox9.Items.Add(ds.Tables(Name).Rows(n)(3).ToString())
                    ListBox7.Items.Add(ds.Tables(Name).Rows(n)(0).ToString())
                    amt = ds.Tables(Name).Rows(n)(3).ToString()
                    ListBox10.Items.Add(" ")
                    n += 1
                Else
                    ListBox7.Items.Add("")
                    ListBox9.Items.Add("")
                    ListBox10.Items.Add(amt)
                End If
            Next
            For i As Integer = 0 To ListBox9.Items.Count - 1
                If i Mod 2 = 0 Then
                    ListBox9.SetSelected(i, True)
                    sumdr = sumdr + Conversion.Val(ListBox9.SelectedItem)
                Else
                    ListBox10.SetSelected(i, True)
                    sumcr = sumcr + Conversion.Val(ListBox10.SelectedItem)
                End If
            Next
            drTotal.Text = sumdr
            crTotal.Text = sumcr
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCORED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Public Sub GetLedgerEntriesTO(ByVal Name)
        Try
            conn.Close()
            conn.Open()
            Dim ds As New DataSet
            Dim da As New MySqlDataAdapter
            Dim Str As String = "SELECT * FROM `" + Name + "` WHERE DENOTE='TO'"
            Dim cmd As MySqlCommand = New MySqlCommand(Str, conn)
            da.SelectCommand = cmd
            da.Fill(ds, Name)
            Dim a As Integer = ds.Tables(Name).Rows.Count - 1
            For i As Integer = 0 To a
                ListBox1.Items.Add(ds.Tables(Name).Rows(i)(0).ToString())
                ListBox2.Items.Add("TO " + ds.Tables(Name).Rows(i)(2).ToString())
                ListBox3.Items.Add(ds.Tables(Name).Rows(i)(3).ToString())
            Next

            Dim n As Integer = 0
            Dim amt As Integer
            Dim sumdr As Integer
            Dim sumcr As Integer
            For i As Integer = 0 To (a * 2) + 1
                If i Mod 2 = 0 Then

                    ListBox8.Items.Add("" + ComboBox1.Text)
                    ListBox8.Items.Add("        To " + ds.Tables(Name).Rows(n)(2).ToString())
                    ListBox9.Items.Add(ds.Tables(Name).Rows(n)(3).ToString())
                    amt = ds.Tables(Name).Rows(n)(3).ToString()
                    ListBox7.Items.Add(ds.Tables(Name).Rows(n)(0).ToString())
                    ListBox10.Items.Add(" ")
                    n += 1
                Else
                    ListBox7.Items.Add("")
                    ListBox9.Items.Add("")
                    ListBox10.Items.Add(amt)
                End If
            Next
            For i As Integer = 0 To ListBox9.Items.Count - 1
                If i Mod 2 = 0 Then
                    ListBox9.SetSelected(i, True)
                    sumdr = sumdr + Conversion.Val(ListBox9.SelectedItem)
                Else
                    ListBox10.SetSelected(i, True)
                    sumcr = sumcr + Conversion.Val(ListBox10.SelectedItem)
                End If
            Next
            conn.Close()
        Catch ex As Exception
            MsgBox("AN ERROR OCCORED : " + ex.Message)
            conn.Close()
        End Try
    End Sub
    Private Sub View_Ledgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = Nothing
        conn.Close()
        conn.Open()
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter
        Dim Str As String = "SELECT Name From `ledgernames`"
        Dim cmd As MySqlCommand = New MySqlCommand(Str, DbFunctions.conn)
        da.SelectCommand = cmd
        da.Fill(ds, "ledgernames")
        Dim a As Integer = ds.Tables("ledgernames").Rows.Count - 1
        For i As Integer = 0 To a
            ComboBox1.Items.Add(ds.Tables("ledgernames").Rows(i)(0).ToString())
        Next
    End Sub
    Private Sub Clr()
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ListBox4.Items.Clear()
        ListBox5.Items.Clear()
        ListBox6.Items.Clear()
        ListBox7.Items.Clear()
        ListBox8.Items.Clear()
        ListBox9.Items.Clear()
        ListBox10.Items.Clear()
    End Sub
    Private Sub insertLine()
        MsgBox(DBdate)
        Dim bool As Boolean = checkYearStatus()
        If todaysdate = DBdate Then
            Dim DrSide As Integer = 0
            Dim CrSide As Integer = 0
            For i As Integer = 0 To ListBox3.Items.Count - 1
                ListBox3.SetSelected(i, True)
                DrSide = Val(ListBox3.SelectedItem()) + DrSide
            Next
            For i As Integer = 0 To ListBox6.Items.Count - 1
                ListBox6.SetSelected(i, True)
                CrSide = Val(ListBox6.SelectedItem()) + CrSide
            Next

            If ListBox6.Items.Count > ListBox3.Items.Count Then
                For i As Integer = ListBox3.Items.Count To ListBox6.Items.Count - 2
                    ListBox3.Items.Add("")
                    ListBox2.Items.Add("")
                Next

            Else
                For i As Integer = ListBox6.Items.Count To ListBox3.Items.Count - 2
                    ListBox6.Items.Add("")
                    ListBox5.Items.Add("")
                Next
            End If
            If DrSide > CrSide Then
                ListBox6.Items.Add(Math.Abs(DrSide - CrSide))
                ListBox5.Items.Add("TO Bal C/d")
            Else
                ListBox3.Items.Add(Math.Abs(DrSide - CrSide))
                ListBox2.Items.Add("TO Bal C/d")
            End If

            ListBox6.Items.Insert(ListBox6.Items.Count, "_________________________")
            ListBox6.Items.Insert(ListBox6.Items.Count, drTotal.Text)
            ListBox3.Items.Insert(ListBox3.Items.Count, "_________________________")
            ListBox3.Items.Insert(ListBox3.Items.Count, crTotal.Text)
        End If
    End Sub
    Private Function checkYearStatus() As Boolean
        Dim bool As Boolean
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `accountingyear` WHERE Status='TRUE'", conn)
            Dim dr As MySqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                DBdate = dr.GetValue(2)
                bool = dr.GetValue(0)
            End If
            conn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        Return bool
    End Function
End Class