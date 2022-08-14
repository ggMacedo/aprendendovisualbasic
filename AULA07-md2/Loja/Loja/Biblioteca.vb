Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient

Public Class Biblioteca

    Public Shared Function Criptografar(valor As String) As String
        Dim Bytes() As Byte
        Dim sb As New StringBuilder()

        Bytes = Encoding.Default.GetBytes(valor)

        'Get md5 hash
        Bytes = MD5.Create().ComputeHash(Bytes)

        'Loop though the byte array and convert each byte to hex.
        For x As Integer = 0 To Bytes.Length - 1
            sb.Append(Bytes(x).ToString("x2"))
        Next

        'Return md5 hash.
        Return sb.ToString()
    End Function

    Public Shared Function Conexao() As SqlConnection
        Return New SqlConnection("Initial catalog=ExMercado;server=L3CORE517\SQLEXPRESS;UID=sa;PWD=etec")
    End Function

End Class
