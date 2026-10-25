Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class frmAdminLogin

    Private isPasswordVisible As Boolean = False

    Private Sub frmAdminLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.OptimizedDoubleBuffer, True)
        Me.UpdateStyles()

        txtUsername.Text = ""
        txtPassword.Text = ""
        txtPassword.UseSystemPasswordChar = True
        isPasswordVisible = False

        CenterCard()
    End Sub

    Private Sub frmAdminLogin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        CenterCard()
    End Sub

    Private Sub CenterCard()
        If pnlCard IsNot Nothing Then
            pnlCard.Location = New Point((Me.ClientSize.Width - pnlCard.Width) \ 2, (Me.ClientSize.Height - pnlCard.Height) \ 2)
        End If
    End Sub

    ' Ultra-Dark Background Renderer with Ambient Glow & Dot Grid
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' 1. Dark Gradient Canvas (#070E0A to #0D1B12)
        Using bgBrush As New LinearGradientBrush(Me.ClientRectangle,
                                                 Color.FromArgb(7, 14, 10),
                                                 Color.FromArgb(13, 27, 18),
                                                 LinearGradientMode.ForwardDiagonal)
            g.FillRectangle(bgBrush, Me.ClientRectangle)
        End Using

        ' 2. Central Glow Effect behind pnlCard
        Using path As New GraphicsPath()
            Dim glowBounds As New Rectangle(pnlCard.Left - 100, pnlCard.Top - 100, pnlCard.Width + 200, pnlCard.Height + 200)
            path.AddEllipse(glowBounds)
            Using pthGrBrush As New PathGradientBrush(path)
                pthGrBrush.CenterColor = Color.FromArgb(40, 20, 110, 65)
                pthGrBrush.SurroundColors = New Color() {Color.Transparent}
                g.FillEllipse(pthGrBrush, glowBounds)
            End Using
        End Using

        ' 3. Fine Dark-Green Grid Dots
        Using dotBrush As New SolidBrush(Color.FromArgb(45, 60, 110, 80))
            Dim dotSpacing As Integer = 24
            Dim dotSize As Integer = 2

            For x As Integer = 0 To Me.Width Step dotSpacing
                For y As Integer = 0 To Me.Height Step dotSpacing
                    g.FillEllipse(dotBrush, x, y, dotSize, dotSize)
                Next
            Next
        End Using
    End Sub

    ' Card Border Effect
    Private Sub pnlCard_Paint(sender As Object, e As PaintEventArgs) Handles pnlCard.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Using borderPen As New Pen(Color.FromArgb(225, 230, 235), 1.5F)
            g.DrawRectangle(borderPen, 0, 0, pnlCard.Width - 1, pnlCard.Height - 1)
        End Using
    End Sub

    ' Password Eye Icon Toggle
    Private Sub lblEyeToggle_Click(sender As Object, e As EventArgs) Handles lblEyeToggle.Click
        isPasswordVisible = Not isPasswordVisible
        txtPassword.UseSystemPasswordChar = Not isPasswordVisible
        lblEyeToggle.Text = If(isPasswordVisible, "🙈", "👁")
    End Sub

    ' Hover States for Exit Button
    Private Sub btnExit_MouseEnter(sender As Object, e As EventArgs) Handles btnExit.MouseEnter
        btnExit.BackColor = Color.FromArgb(190, 40, 40)
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = Color.FromArgb(20, 35, 25)
    End Sub

    ' Exit Application Action
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Login Action Logic
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
                    Dim query As String = "SELECT admin_id, full_name FROM admins WHERE username = @user AND password_hash = @pass LIMIT 1"
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