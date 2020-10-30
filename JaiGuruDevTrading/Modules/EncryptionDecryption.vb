Imports System.Security.Cryptography
Public NotInheritable Class EncryptionDecryption
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Function TruncateHas(ByVal key As String, ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        Dim keybyte() As Byte = System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keybyte)
        ReDim Preserve hash(length - 1)
        Return hash
    End Function
    Sub New(ByVal key As String)
        TripleDes.Key = TruncateHas(key, TripleDes.KeySize / 8)
        TripleDes.IV = TruncateHas("", TripleDes.BlockSize / 8)
    End Sub
    Public Function EncryptData(ByVal plaintext As String) As String
        Dim plaintextbytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)
        Dim ms As New System.IO.MemoryStream
        Dim enc As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)
        enc.Write(plaintextbytes, 0, plaintextbytes.Length)
        enc.FlushFinalBlock()
        Return Convert.ToBase64String(ms.ToArray)

    End Function
    Public Function DecryptData(ByVal EncryptedString As String) As String
        Dim encryptBytes() As Byte = Convert.FromBase64String(EncryptedString)
        Dim ms As New System.IO.MemoryStream
        Dim decstream As New CryptoStream(ms, TripleDes.CreateDecryptor, System.Security.Cryptography.CryptoStreamMode.Write)
        decstream.Write(encryptBytes, 0, encryptBytes.Length)
        decstream.FlushFinalBlock()
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)

    End Function
End Class

