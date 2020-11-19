Public Class Create_Led
    Public OpenedBy As String
    Private Sub fire_Click(sender As Object, e As EventArgs) Handles fire.Click
        If CusNAME.Text <> Nothing And CusMOB.Text <> Nothing And CusADDR.Text <> Nothing And CusBank.Text <> Nothing Then
            CREATE_LEDGER(LedNAME.Text, ComboBox1.Text, CusNAME.Text, CusADDR.Text, CusMOB.Text, CusBank.Text)
            FillLedgerData()
            If OpenedBy = "PV" Then
                PurchaseVoucher.btn_create.PerformClick()
                Me.Close()
            End If
        Else
            If OpenedBy = "PV" Then
                MsgBox("All Details Are Mandatory", MsgBoxStyle.Exclamation)
            Else
                CREATE_LEDGER(LedNAME.Text, ComboBox1.Text, "NULL", "NULL", "NULL", "NULL")
                FillLedgerData()
            End If

        End If

    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click
        LedNAME.Text = Nothing
        CusADDR.Text = Nothing
        CusBank.Text = Nothing
        CusMOB.Text = Nothing
        CusNAME.Text = Nothing
        ComboBox1.Text = Nothing
    End Sub

    Private Sub Create_Led_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FillLedgerData()
        DataGridView1.Columns(0).HeaderText = "Available Ledgers"
        GridPanel.Enabled = False
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class