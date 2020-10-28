'<----------------Libraries-------------------------->'
Imports System.Net
Imports MySql.Data.MySqlClient
'<----------------Libraries-------------------------->'
Module IpEntry
    Public Function IPView() As String
        Dim name As String = Dns.GetHostName
        Dim hname As IPHostEntry = Dns.GetHostByName(name)
        Dim ip As IPAddress() = hname.AddressList
        Return name
    End Function

End Module
