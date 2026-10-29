Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmAdminDashboard

    ' 1 = Competency View, 2 = Academic Course View
    Private activeChartViewMode As Integer = 1

    ' Clicked Bar Filter State
    Private selectedChartCategory As String = ""

    ' Dynamic Clickable Rectangles Map (Bar Index -> Bounding Rectangle)
    Private barClickBounds As New Dictionary(Of Integer, Rectangle)()
    Private currentBarLabels As New List(Of String)()

    Private Sub frmAdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnViewAcademic.BringToFront()
        btnViewCompetencies.BringToFront()
        PopulateStudentComboBox()
        LoadArtifactRecords()
    End Sub

    ''' <summary>
    ''' Populates the student search dropdown with all registered students.
    ''' </summary>
    Private Sub PopulateStudentComboBox()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT student_number, CONCAT(student_number, ' - ', last_name, ', ', first_name) AS display_name FROM students ORDER BY last_name ASC"
                    Dim adapter As New MySqlDataAdapter(query, conn)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' Insert default option for viewing all students
                    Dim dr As DataRow = dt.NewRow()
                    dr("student_number") = "ALL"
                    dr("display_name") = "-- All Registered Students --"
                    dt.Rows.InsertAt(dr, 0)

                    cboStudentSearch.DataSource = dt
                    cboStudentSearch.DisplayMember = "display_name"
                    cboStudentSearch.ValueMember = "student_number"
                    cboStudentSearch.SelectedIndex = 0
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading student list: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Loads artifact entries filtered by the selected student dropdown, search keyword, and clicked chart bar.
    ''' </summary>
    Private Sub LoadArtifactRecords()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim selectedStudentNo As String = If(cboStudentSearch.SelectedValue IsNot Nothing, cboStudentSearch.SelectedValue.ToString(), "ALL")
                    Dim filterText As String = txtFilterRecords.Text.Trim()
                    If filterText = "Search artifact title, student, or course..." Then filterText = ""

                    ' Cleaned SQL Query for Admin Portfolio View
                    Dim query As String = "SELECT " &
                      "  p.entry_id AS 'ID', " &
                      "  p.student_number AS 'Student No.', " &
                      "  CONCAT(s.last_name, ', ', s.first_name) AS 'Student Name', " &
                      "  p.title AS 'Title', " &
                      "  COALESCE(c.category_name, 'Uncategorized') AS 'Skill Competency', " &
                      "  COALESCE(p.course_code, 'N/A') AS 'Course Code', " &
                      "  COALESCE(act.type_name, 'General') AS 'Activity Type', " &
                      "  p.date_completed AS 'Date Completed' " &
                      "FROM portfolio_entries p " &
                      "INNER JOIN students s ON p.student_number = s.student_number " &
                      "LEFT JOIN categories c ON p.category_id = c.category_id " &
                      "LEFT JOIN activity_types act ON p.activity_type_id = act.activity_type_id " &
                      "WHERE 1=1"

                    ' Apply Student Dropdown Filter
                    If selectedStudentNo <> "ALL" Then
                        query &= " AND p.student_number = @selectedStudentNo"
                    End If

                    ' Apply Keyword Search Filter
                    If Not String.IsNullOrWhiteSpace(filterText) Then
                        query &= " AND (p.student_number LIKE @filter " &
                                 "   OR s.first_name LIKE @filter " &
                                 "   OR s.last_name LIKE @filter " &
                                 "   OR p.title LIKE @filter " &
                                 "   OR p.course_code LIKE @filter)"
                    End If

                    ' Apply Clicked Chart Bar Filter
                    If Not String.IsNullOrWhiteSpace(selectedChartCategory) Then
                        If activeChartViewMode = 1 Then
                            query &= " AND c.category_name = @chartCategory"
                        Else
                            If selectedChartCategory = "N/A" Then
                                query &= " AND (p.course_code IS NULL OR p.course_code = 'N/A')"
                            Else
                                query &= " AND p.course_code = @chartCategory"
                            End If
                        End If
                    End If

                    query &= " ORDER BY p.entry_id DESC"

                    Dim cmd As New MySqlCommand(query, conn)
                    If selectedStudentNo <> "ALL" Then
                        cmd.Parameters.AddWithValue("@selectedStudentNo", selectedStudentNo)
                    End If
                    If Not String.IsNullOrWhiteSpace(filterText) Then
                        cmd.Parameters.AddWithValue("@filter", "%" & filterText & "%")
                    End If
                    If Not String.IsNullOrWhiteSpace(selectedChartCategory) AndAlso selectedChartCategory <> "N/A" Then
                        cmd.Parameters.AddWithValue("@chartCategory", selectedChartCategory)
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvAdminPortfolio.DataSource = dt
                    AddActionButtonColumn()

                    ' Update Stats & Info Header
                    UpdateSummaryMetrics(selectedStudentNo, dt)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading portfolio entries: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Updates card metrics (Artifacts Logged, Competencies Covered, Last Activity, and Student Info).
    ''' </summary>
    Private Sub UpdateSummaryMetrics(selectedStudentNo As String, dt As DataTable)
        lblArtifactsVal.Text = dt.Rows.Count.ToString()

        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then

                    If selectedStudentNo = "ALL" Then
                        lblInfoStudentNum.Text = "Student ID: All Records"
                        lblInfoFullName.Text = "Full Name: System Wide View"
                        lblInfoProgram.Text = "Degree Program: All Enrolled CS/IT"

                        Dim globalCompQuery As String = "SELECT COUNT(DISTINCT category_id) FROM portfolio_entries"
                        Using cmdComp As New MySqlCommand(globalCompQuery, conn)
                            Dim compCount As Integer = Convert.ToInt32(cmdComp.ExecuteScalar())
                            lblCompetenciesVal.Text = $"{compCount}/7"
                        End Using

                        Dim globalLastQuery As String = "SELECT MAX(date_completed) FROM portfolio_entries"
                        Using cmdLast As New MySqlCommand(globalLastQuery, conn)
                            Dim lastDateObj = cmdLast.ExecuteScalar()
                            If lastDateObj IsNot DBNull.Value AndAlso lastDateObj IsNot Nothing Then
                                lblLastActivityVal.Text = Convert.ToDateTime(lastDateObj).ToString("MM/dd/yyyy")
                            Else
                                lblLastActivityVal.Text = "N/A"
                            End If
                        End Using

                    Else
                        Dim studQuery As String = "SELECT first_name, last_name, degree_program FROM students WHERE student_number = @sNo LIMIT 1"
                        Using cmd As New MySqlCommand(studQuery, conn)
                            cmd.Parameters.AddWithValue("@sNo", selectedStudentNo)
                            Using reader As MySqlDataReader = cmd.ExecuteReader()
                                If reader.Read() Then
                                    lblInfoStudentNum.Text = $"Student ID: {selectedStudentNo}"
                                    lblInfoFullName.Text = $"Full Name: {reader("last_name")}, {reader("first_name")}"
                                    lblInfoProgram.Text = $"Degree Program: {reader("degree_program")}"
                                End If
                            End Using
                        End Using

                        Dim compQuery As String = "SELECT COUNT(DISTINCT category_id) FROM portfolio_entries WHERE student_number = @sNo"
                        Using cmdComp As New MySqlCommand(compQuery, conn)
                            cmdComp.Parameters.AddWithValue("@sNo", selectedStudentNo)
                            Dim compCount As Integer = Convert.ToInt32(cmdComp.ExecuteScalar())
                            lblCompetenciesVal.Text = $"{compCount}/7"
                        End Using

                        Dim lastActQuery As String = "SELECT MAX(date_completed) FROM portfolio_entries WHERE student_number = @sNo"
                        Using cmdLast As New MySqlCommand(lastActQuery, conn)
                            cmdLast.Parameters.AddWithValue("@sNo", selectedStudentNo)
                            Dim lastDateObj = cmdLast.ExecuteScalar()
                            If lastDateObj IsNot DBNull.Value AndAlso lastDateObj IsNot Nothing Then
                                lblLastActivityVal.Text = Convert.ToDateTime(lastDateObj).ToString("MM/dd/yyyy")
                            Else
                                lblLastActivityVal.Text = "N/A"
                            End If
                        End Using

                    End If
                End If
            End Using
        Catch ex As Exception
            ' Fallback
        End Try

        pnlAdminChart.Invalidate()
    End Sub

    ''' <summary>
    ''' Custom GDI+ renderer with click-area recording and active bar highlighting.
    ''' </summary>
    Private Sub pnlAdminChart_Paint(sender As Object, e As PaintEventArgs) Handles pnlAdminChart.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

        barClickBounds.Clear()
        currentBarLabels.Clear()

        Dim labels As New List(Of String)()
        Dim counts As New List(Of Integer)()

        If activeChartViewMode = 1 Then
            ' --- 📊 COMPETENCIES VIEW ---
            Dim categories() As String = {"Leadership", "Communication", "Teamwork", "Technical Skills", "Professional Development", "Community Engagement", "Personal Development"}
            For Each cat In categories
                labels.Add(cat)
                counts.Add(0)
            Next

            ' Calculate totals directly from DB to preserve true chart totals
            Try
                Using conn As MySqlConnection = database.GetConnection()
                    If conn IsNot Nothing Then
                        Dim selStud As String = If(cboStudentSearch.SelectedValue IsNot Nothing, cboStudentSearch.SelectedValue.ToString(), "ALL")
                        Dim q As String = "SELECT c.category_name, COUNT(p.entry_id) AS cnt " &
                                         "FROM categories c " &
                                         "LEFT JOIN portfolio_entries p ON c.category_id = p.category_id " &
                                         If(selStud <> "ALL", " AND p.student_number = @sNo ", "") &
                                         "GROUP BY c.category_id, c.category_name"
                        Using cmd As New MySqlCommand(q, conn)
                            If selStud <> "ALL" Then cmd.Parameters.AddWithValue("@sNo", selStud)
                            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                                While rdr.Read()
                                    Dim cName As String = rdr("category_name").ToString()
                                    Dim cVal As Integer = Convert.ToInt32(rdr("cnt"))
                                    For i As Integer = 0 To labels.Count - 1
                                        If labels(i).Equals(cName, StringComparison.OrdinalIgnoreCase) Then
                                            counts(i) = cVal
                                            Exit For
                                        End If
                                    Next
                                End While
                            End Using
                        End Using
                    End If
                End Using
            Catch ex As Exception
            End Try
        Else
            ' --- 📚 ACADEMIC COURSES VIEW ---
            Try
                Using conn As MySqlConnection = database.GetConnection()
                    If conn IsNot Nothing Then
                        Dim selStud As String = If(cboStudentSearch.SelectedValue IsNot Nothing, cboStudentSearch.SelectedValue.ToString(), "ALL")
                        Dim q As String = "SELECT COALESCE(p.course_code, 'N/A') AS ccode, COUNT(p.entry_id) AS cnt " &
                                         "FROM portfolio_entries p " &
                                         If(selStud <> "ALL", " WHERE p.student_number = @sNo ", "") &
                                         "GROUP BY ccode ORDER BY cnt DESC"
                        Using cmd As New MySqlCommand(q, conn)
                            If selStud <> "ALL" Then cmd.Parameters.AddWithValue("@sNo", selStud)
                            Using rdr As MySqlDataReader = cmd.ExecuteReader()
                                While rdr.Read()
                                    labels.Add(rdr("ccode").ToString())
                                    counts.Add(Convert.ToInt32(rdr("cnt")))
                                End While
                            End Using
                        End Using
                    End If
                End Using
            Catch ex As Exception
            End Try

            If labels.Count = 0 Then
                labels.Add("No Courses")
                counts.Add(0)
            End If
        End If

        currentBarLabels.AddRange(labels)

        Dim maxCount As Integer = 1
        For Each cnt As Integer In counts
            If cnt > maxCount Then maxCount = cnt
        Next

        Dim panelWidth As Integer = pnlAdminChart.Width
        Dim panelHeight As Integer = pnlAdminChart.Height
        Dim barWidth As Integer = Math.Min(36, (panelWidth \ (labels.Count + 1)) - 10)
        Dim spacing As Integer = panelWidth \ (labels.Count + 1)

        Using defaultBrush As New SolidBrush(Color.FromArgb(8, 88, 48)),
              highlightBrush As New SolidBrush(Color.FromArgb(220, 100, 20)),
              textBrush As New SolidBrush(Color.FromArgb(60, 70, 80)),
              lblFont As New Font("Segoe UI", 8.0!, FontStyle.Regular),
              valFont As New Font("Segoe UI", 9.0!, FontStyle.Bold)

            For i As Integer = 0 To labels.Count - 1
                Dim xCenter As Integer = spacing * (i + 1)
                Dim xPos As Integer = xCenter - (barWidth \ 2)

                Dim barHeight As Integer = CInt((counts(i) / CSng(maxCount)) * (panelHeight - 65))
                If counts(i) > 0 AndAlso barHeight < 6 Then barHeight = 6

                Dim yPos As Integer = panelHeight - 35 - barHeight

                ' Save hit-test area for clicking
                Dim barRect As New Rectangle(xPos - 5, yPos, barWidth + 10, barHeight + 35)
                barClickBounds(i) = barRect

                ' Draw active bar with orange highlight if selected
                Dim isSelected As Boolean = (labels(i).Equals(selectedChartCategory, StringComparison.OrdinalIgnoreCase))
                Dim activeBrush As SolidBrush = If(isSelected, highlightBrush, defaultBrush)

                If counts(i) > 0 Then
                    g.FillRectangle(activeBrush, xPos, yPos, barWidth, barHeight)
                Else
                    g.FillRectangle(Brushes.LightGray, xPos, panelHeight - 37, barWidth, 2)
                End If

                Dim countStr As String = counts(i).ToString()
                Dim valSize As SizeF = g.MeasureString(countStr, valFont)
                g.DrawString(countStr, valFont, textBrush, xCenter - (valSize.Width / 2), yPos - 18)

                Dim labelText As String = labels(i)
                If labelText.Length > 12 Then labelText = labelText.Substring(0, 10) & ".."
                Dim lblSize As SizeF = g.MeasureString(labelText, lblFont)
                g.DrawString(labelText, lblFont, textBrush, xCenter - (lblSize.Width / 2), panelHeight - 25)
            Next
        End Using
    End Sub

    ''' <summary>
    ''' Handles clicking individual chart bars to filter DataGridView records.
    ''' </summary>
    Private Sub pnlAdminChart_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlAdminChart.MouseClick
        For Each kvp In barClickBounds
            If kvp.Value.Contains(e.Location) Then
                Dim clickedIdx As Integer = kvp.Key
                If clickedIdx >= 0 AndAlso clickedIdx < currentBarLabels.Count Then
                    Dim clickedCategory As String = currentBarLabels(clickedIdx)

                    ' Toggle click: deselect if clicked twice
                    If selectedChartCategory.Equals(clickedCategory, StringComparison.OrdinalIgnoreCase) Then
                        selectedChartCategory = ""
                    Else
                        selectedChartCategory = clickedCategory
                    End If

                    pnlAdminChart.Invalidate()
                    LoadArtifactRecords()
                End If
                Exit Sub
            End If
        Next
    End Sub

    ' --- TOGGLE SWITCHERS ---
    Private Sub btnViewCompetencies_Click(sender As Object, e As EventArgs) Handles btnViewCompetencies.Click
        activeChartViewMode = 1
        selectedChartCategory = ""
        btnViewCompetencies.BackColor = Color.FromArgb(8, 75, 42)
        btnViewCompetencies.ForeColor = Color.White
        btnViewAcademic.BackColor = Color.Gainsboro
        btnViewAcademic.ForeColor = Color.DarkSlateGray
        LoadArtifactRecords()
    End Sub

    Private Sub btnViewAcademic_Click(sender As Object, e As EventArgs) Handles btnViewAcademic.Click
        activeChartViewMode = 2
        selectedChartCategory = ""
        btnViewAcademic.BackColor = Color.FromArgb(8, 75, 42)
        btnViewAcademic.ForeColor = Color.White
        btnViewCompetencies.BackColor = Color.Gainsboro
        btnViewCompetencies.ForeColor = Color.DarkSlateGray
        LoadArtifactRecords()
    End Sub

    ' --- SEARCH PLACEHOLDER & FILTER EVENTS ---
    Private Sub txtFilterRecords_Enter(sender As Object, e As EventArgs) Handles txtFilterRecords.Enter
        If txtFilterRecords.Text = "Search artifact title, student, or course..." Then
            txtFilterRecords.Text = ""
            txtFilterRecords.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtFilterRecords_Leave(sender As Object, e As EventArgs) Handles txtFilterRecords.Leave
        If String.IsNullOrWhiteSpace(txtFilterRecords.Text) Then
            txtFilterRecords.Text = "Search artifact title, student, or course..."
            txtFilterRecords.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub cboStudentSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudentSearch.SelectedIndexChanged
        If cboStudentSearch.ValueMember <> "" Then
            selectedChartCategory = ""
            LoadArtifactRecords()
        End If
    End Sub

    Private Sub AddActionButtonColumn()
        If Not dgvAdminPortfolio.Columns.Contains("btnActions") Then
            Dim btnColumn As New DataGridViewButtonColumn()
            btnColumn.Name = "btnActions"
            btnColumn.HeaderText = "Actions"
            btnColumn.Text = "View"
            btnColumn.UseColumnTextForButtonValue = True
            btnColumn.Width = 80
            btnColumn.FlatStyle = FlatStyle.Standard

            dgvAdminPortfolio.Columns.Add(btnColumn)
        End If
    End Sub

    Private Sub dgvAdminPortfolio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAdminPortfolio.CellContentClick
        If e.RowIndex >= 0 AndAlso dgvAdminPortfolio.Columns(e.ColumnIndex).Name = "btnActions" Then
            Dim selectedRow As DataGridViewRow = dgvAdminPortfolio.Rows(e.RowIndex)

            Dim entryId As String = selectedRow.Cells("ID").Value.ToString()
            Dim studentNo As String = selectedRow.Cells("Student No.").Value.ToString()
            Dim studentName As String = selectedRow.Cells("Student Name").Value.ToString()
            Dim artifactTitle As String = selectedRow.Cells("Title").Value.ToString()

            OpenArtifactDetailModal(entryId, studentNo, studentName, artifactTitle)
        End If
    End Sub

    Private Sub OpenArtifactDetailModal(entryId As String, studentNo As String, studentName As String, title As String)
        Dim numericId As Integer = 0
        If Integer.TryParse(entryId, numericId) Then
            Dim modal As New frmArtifactDetailModal(numericId)
            modal.ShowDialog(Me)
        End If
    End Sub

    Private Sub txtFilterRecords_TextChanged(sender As Object, e As EventArgs) Handles txtFilterRecords.TextChanged
        LoadArtifactRecords()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        PopulateStudentComboBox()
        selectedChartCategory = ""
        txtFilterRecords.Text = "Search artifact title, student, or course..."
        txtFilterRecords.ForeColor = Color.Gray
        LoadArtifactRecords()
    End Sub


    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out from the Admin Portal?",
                                                    "Confirm Admin Logout",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Redirect to Admin Login Form
            Dim loginAdminForm As New frmAdminLogin()
            loginAdminForm.Show()
            Me.Close()
        End If
    End Sub

End Class