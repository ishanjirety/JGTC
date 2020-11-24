Imports System.Drawing.Printing
Imports System.Drawing
Imports MySql.Data.MySqlClient
Public Class Kisan
    Dim WithEvents mPrintDocument As New PrintDocument
    Dim mPrintBitMap As Bitmap
    Private Sub Kisan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
    Private Sub PrintBtn_Click(sender As Object, e As EventArgs)
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub TotalAmount_TextChanged(sender As Object, e As EventArgs)
        InEnglish.Text = GetInWords(TotalAmount.Text)
        InHindi.Text = changeToWords(TotalAmount.Text)
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim lwidth As Integer = e.MarginBounds.X + (e.MarginBounds.Width - mPrintBitMap.Width) \ 2
        Dim lheight As Integer = e.MarginBounds.Y + (e.MarginBounds.Height - mPrintBitMap.Height) \ 2
        e.Graphics.DrawImage(mPrintBitMap, lwidth, lheight)
        e.HasMorePages = False
    End Sub

    Private Sub OnPrintPage(ByVal sender As Object, ByVal e As Printing.PrintPageEventArgs)
        Using bmp As Bitmap = New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 0, Me.Width, Me.Height))
            Dim ration As Single = CSng(bmp.Width / bmp.Height)
            If ration > e.MarginBounds.Width / e.MarginBounds.Height Then
                e.Graphics.DrawImage(bmp, e.MarginBounds.Left, CInt(e.MarginBounds.Top + (e.MarginBounds.Height / 2) - ((e.MarginBounds.Width / ration) / 2)),
                    e.MarginBounds.Width, CInt(e.MarginBounds.Width / ration))
            Else
                e.Graphics.DrawImage(bmp, CInt(e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.MarginBounds.Height * ration / 2)),
e.MarginBounds.Top, CInt(e.MarginBounds.Height * ration), e.MarginBounds.Height)
            End If
        End Using

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SendMsg()
        Button3.Hide()
        Dim preview As New PrintPreviewDialog
        Dim pd As New System.Drawing.Printing.PrintDocument
        pd.DefaultPageSettings.Landscape = True
        AddHandler pd.PrintPage, AddressOf OnPrintPage
        preview.Document = pd
        preview.ShowDialog()
    End Sub
    Private Sub SendMsg()
        Dim Message As String = GetMsgDB()
        Dim bool As String = ContainsSpecialChars(Message, TotalAmount.Text)
        MsgBox(bool)

    End Sub
    Private Function GetMsgDB() As String
        Dim Message As String
        Try
            conn.Close()
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand("SELECT * FROM `msgbody` Where Exist='True'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader
            If rdr.HasRows Then
                If rdr.Read() Then
                    Message = rdr.GetValue(0)
                End If
                conn.Close()
                Return Message
            Else
                MsgBox("CANNOT SEND MESSAGE : MESSAGE BODY DOES NOT EXIST", MsgBoxStyle.Critical)
            End If
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Function
    Function ContainsSpecialChars(s As String, ByVal total As String) As String
        Dim result As String
        Dim bool As Boolean = s.IndexOfAny("&".ToCharArray) <> -1
        If bool = True Then
            result = Replace(s, "&", total)
        End If
        Return result
    End Function

End Class