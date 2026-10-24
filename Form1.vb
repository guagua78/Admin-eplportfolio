Imports MySql.Data.MySqlClient

Public Class frmAdminLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT admin_id, full_name FROM admins WHERE username = @user AND password_hash = @pass"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@user", username)
                        cmd.Parameters.AddWithValue("@pass", password)

                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                Dim adminName As String = reader("full_name").ToString()
                                MessageBox.Show($"Welcome back, {adminName}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

                                Dim mainAdminForm As New frmAdminDashboard()
                                mainAdminForm.Show()
                                Me.Hide()
                            Else
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error logging in: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class