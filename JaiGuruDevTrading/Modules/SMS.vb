Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Module SMS
    Public numbers = "918878005371"
    Public Sub otp()
        Dim apikey = "3AuyU/TLlhI-jSmhZxvEyBtfDaTDsLUCqalCjlMzsh" 'API KEY
        Dim rn As New Random
        Dim rn1 As String = rn.Next(1000, 9999).ToString
        Dim OTP1 As String
        OTP1 = rn1
        Dim message = "Your OTP to Reset Credentials Is " + OTP1

        Dim strGet As String
        Dim Sendername = "TXTLCL"
        Dim url As String = "https://api.textlocal.in/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + Sendername

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MsgBox(result)
        Forgot_password.OTP1 = OTP1
    End Sub
    Public Sub SendMsg(ByVal SendMessage)
        Dim apikey = "3AuyU/TLlhI-jSmhZxvEyBtfDaTDsLUCqalCjlMzsh" 'API KEY
        Dim message = SendMessage

        Dim strGet As String
        Dim Sendername = "TXTLCL"
        Dim url As String = "https://api.textlocal.in/send/?"

        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + Sendername

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MsgBox(result)
        ' Forgot_password.OTP1 = OTP1
    End Sub
End Module
