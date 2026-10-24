Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class frmAdminDashboard

    Private selectedStudentNumber As String = ""
    Private chartLabels As New List(Of String)()
    Private chartValues As New List(Of Integer)()

    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateStudentDropdown()
    End Sub

    ' -------------------------------------------------------------
    ' POPULATE STUDENTS DROPDOWN
    ' -------------------------------------------------------------
    Private Sub PopulateStudentDropdown()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT student_number, CONCAT(last_name, ', ', first_name, ' (', student_number, ')') AS student_display FROM students ORDER BY last_name ASC"
                    Dim adapter As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    cmbStudents.DataSource = dt
                    cmbStudents.DisplayMember = "student_display"
                    cmbStudents.ValueMember = "student_number"

                    If cmbStudents.Items.Count > 0 Then
                        cmbStudents.SelectedIndex = 0
                    End If
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cmbStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStudents.SelectedIndexChanged
        If cmbStudents.SelectedValue IsNot Nothing AndAlso Not TypeOf cmbStudents.SelectedValue Is DataRowView Then
            selectedStudentNumber = cmbStudents.SelectedValue.ToString()
            LoadStudentOverview()
            LoadStudentChart()
            LoadStudentPortfolio()
        End If
    End Sub

    ' -------------------------------------------------------------
    ' LOAD STUDENT OVERVIEW METRICS
    ' -------------------------------------------------------------
    Private Sub LoadStudentOverview()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT COUNT(*) AS total_artifacts, COUNT(DISTINCT category_id) AS total_categories FROM portfolio_entries WHERE student_number = @stud"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", selectedStudentNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                lblTotalEntries.Text = reader("total_artifacts").ToString() & " Artifacts Logged"
                                lblActiveCategories.Text = reader("total_categories").ToString() & " Competencies Covered"
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    ' -------------------------------------------------------------
    ' LOAD CHART DATA FOR SELECTED STUDENT
    ' -------------------------------------------------------------
    Private Sub LoadStudentChart()
        chartLabels.Clear()
        chartValues.Clear()

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT c.category_name, COUNT(pe.entry_id) AS total_entries " &
                                          "FROM categories c " &
                                          "LEFT JOIN portfolio_entries pe ON c.category_id = pe.category_id AND pe.student_number = @stud " &
                                          "GROUP BY c.category_id, c.category_name " &
                                          "ORDER BY c.category_id ASC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", selectedStudentNumber)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                chartLabels.Add(reader("category_name").ToString())
                                chartValues.Add(Convert.ToInt32(reader("total_entries")))
                            End While
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
        End Try

        pnlAdminChart.Invalidate()
    End Sub

    ' -------------------------------------------------------------
    ' DRAW GDI+ CHART FOR ADMIN VIEW
    ' -------------------------------------------------------------
    Private Sub pnlAdminChart_Paint(sender As Object, e As PaintEventArgs) Handles pnlAdminChart.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        Dim marginX As Integer = 50
        Dim marginTop As Integer = 35
        Dim marginBottom As Integer = 35
        Dim drawWidth As Single = pnlAdminChart.Width - (marginX * 2)
        Dim drawHeight As Single = pnlAdminChart.Height - marginTop - marginBottom

        If chartValues.Count = 0 OrElse chartValues.Sum() = 0 Then
            Using fontHint As New Font("Segoe UI", 9.0!, FontStyle.Italic)
                g.DrawString("No portfolio records logged for this student yet.", fontHint, Brushes.Gray, marginX, marginTop + 15)
            End Using
            Return
        End If

        Dim maxVal As Single = Math.Max(4, chartValues.Max())
        Dim itemWidth As Single = drawWidth / chartValues.Count
        Dim barWidth As Single = Math.Min(itemWidth * 0.5F, 50.0F)

        For i As Integer = 0 To chartValues.Count - 1
            Dim countVal As Integer = chartValues(i)
            Dim barHeight As Single = (countVal / maxVal) * drawHeight

            Dim barX As Single = marginX + (i * itemWidth) + ((itemWidth - barWidth) / 2.0F)
            Dim barY As Single = (pnlAdminChart.Height - marginBottom) - barHeight

            If barHeight > 0 Then
                Dim renderRect As New RectangleF(barX, barY, barWidth, barHeight)
                Using barBrush As New LinearGradientBrush(renderRect, Color.FromArgb(24, 88, 54), Color.FromArgb(45, 125, 80), LinearGradientMode.Vertical)
                    g.FillRectangle(barBrush, renderRect)
                End Using

                Using fontBadge As New Font("Segoe UI", 8.0!, FontStyle.Bold)
                    Dim valStr As String = countVal.ToString()
                    Dim badgeSize As SizeF = g.MeasureString(valStr, fontBadge)
                    g.DrawString(valStr, fontBadge, Brushes.DarkSlateGray, barX + ((barWidth - badgeSize.Width) / 2.0F), barY - 16)
                End Using
            End If

            Using fontX As New Font("Segoe UI", 7.5!, FontStyle.Bold)
                Dim labelStr As String = chartLabels(i)
                If labelStr.Length > 12 Then labelStr = labelStr.Substring(0, 10) & ".."
                Dim lblSize As SizeF = g.MeasureString(labelStr, fontX)
                g.DrawString(labelStr, fontX, Brushes.DimGray, barX + ((barWidth - lblSize.Width) / 2.0F), pnlAdminChart.Height - marginBottom + 4)
            End Using
        Next

        Using axisPen As New Pen(Color.FromArgb(180, 190, 185), 1.5F)
            g.DrawLine(axisPen, marginX, pnlAdminChart.Height - marginBottom, pnlAdminChart.Width - marginX, pnlAdminChart.Height - marginBottom)
        End Using
    End Sub

    ' -------------------------------------------------------------
    ' LOAD PORTFOLIO ENTRIES FOR SELECTED STUDENT
    ' -------------------------------------------------------------
    Private Sub LoadStudentPortfolio()
        If String.IsNullOrEmpty(selectedStudentNumber) Then Return

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT pe.entry_id AS 'ID', pe.title AS 'Title', " &
                                          "pe.description AS 'Description', " &
                                          "c.category_name AS 'Skill Competency', " &
                                          "IFNULL(pe.course_code, 'N/A') AS 'Course Code', " &
                                          "at.type_name AS 'Activity Type', " &
                                          "pe.date_completed AS 'Date Completed' " &
                                          "FROM portfolio_entries pe " &
                                          "INNER JOIN categories c ON pe.category_id = c.category_id " &
                                          "INNER JOIN activity_types at ON pe.activity_type_id = at.activity_type_id " &
                                          "WHERE pe.student_number = @stud "

                    If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                        query &= "AND (pe.title LIKE @search OR pe.description LIKE @search OR pe.course_code LIKE @search) "
                    End If

                    query &= "ORDER BY pe.date_completed DESC"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@stud", selectedStudentNumber)

                        If Not String.IsNullOrWhiteSpace(txtSearch.Text) Then
                            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text.Trim() & "%")
                        End If

                        Dim adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)

                        dgvAdminPortfolio.DataSource = table
                    End Using
                End If
            End Using
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadStudentPortfolio()
    End Sub

End Class