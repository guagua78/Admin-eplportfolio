Imports MySql.Data.MySqlClient

Public Class database

    ' 1. Double check these match your Aiven Overview page exactly
    Private Shared serverHost As String = "mysql-eplportfolio-kemangelowz-b5f3.i.aivencloud.com"
    Private Shared serverPort As Integer = 20753 ' Replace 21345 with your exact Aiven Port
    Private Shared dbName As String = "eportfoliodb"
    Private Shared dbUser As String = "avnadmin"
    Private Shared dbPass As String = "AVNS_Bv70rUB-VpRD9SW-wVg"

    ' 2. Ensure Port is formatted as Port=... and SslMode=Required is included
    Private Shared connString As String = $"Server={serverHost};Port={serverPort};Database={dbName};Uid={dbUser};Password={dbPass};SslMode=Required;Connection Timeout=15;"

    Public Shared Function GetConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connString)
        Try
            conn.Open()
            Return conn
        Catch ex As Exception
            MessageBox.Show("Cloud database connection error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

End Class