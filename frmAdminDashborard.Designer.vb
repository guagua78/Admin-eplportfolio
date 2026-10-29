<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminDashboard
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents pnlTopNav As System.Windows.Forms.Panel
    Friend WithEvents lblNavTitle As System.Windows.Forms.Label
    Friend WithEvents lblNavSub As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button

    Friend WithEvents pnlSearchCard As System.Windows.Forms.Panel
    Friend WithEvents lblSearchHeader As System.Windows.Forms.Label
    Friend WithEvents cboStudentSearch As System.Windows.Forms.ComboBox

    Friend WithEvents pnlArtifactsCard As System.Windows.Forms.Panel
    Friend WithEvents lblArtifactsVal As System.Windows.Forms.Label
    Friend WithEvents lblArtifactsSub As System.Windows.Forms.Label

    Friend WithEvents pnlCompetenciesCard As System.Windows.Forms.Panel
    Friend WithEvents lblCompetenciesVal As System.Windows.Forms.Label
    Friend WithEvents lblCompetenciesSub As System.Windows.Forms.Label

    Friend WithEvents pnlLastActivityCard As System.Windows.Forms.Panel
    Friend WithEvents lblLastActivityVal As System.Windows.Forms.Label
    Friend WithEvents lblLastActivitySub As System.Windows.Forms.Label

    Friend WithEvents pnlChartCard As System.Windows.Forms.Panel
    Friend WithEvents pnlAdminChart As System.Windows.Forms.Panel
    Friend WithEvents btnViewCompetencies As System.Windows.Forms.Button
    Friend WithEvents btnViewAcademic As System.Windows.Forms.Button

    Friend WithEvents pnlStudentInfo As System.Windows.Forms.Panel
    Friend WithEvents lblInfoStudentNum As System.Windows.Forms.Label
    Friend WithEvents lblInfoFullName As System.Windows.Forms.Label
    Friend WithEvents lblInfoProgram As System.Windows.Forms.Label

    Friend WithEvents pnlTableSection As System.Windows.Forms.Panel
    Friend WithEvents lblTableTitle As System.Windows.Forms.Label
    Friend WithEvents lblSearchFilter As System.Windows.Forms.Label
    Friend WithEvents txtFilterRecords As System.Windows.Forms.TextBox
    Friend WithEvents dgvAdminPortfolio As System.Windows.Forms.DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTopNav = New System.Windows.Forms.Panel()
        Me.lblNavTitle = New System.Windows.Forms.Label()
        Me.lblNavSub = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.pnlSearchCard = New System.Windows.Forms.Panel()
        Me.lblSearchHeader = New System.Windows.Forms.Label()
        Me.cboStudentSearch = New System.Windows.Forms.ComboBox()
        Me.pnlArtifactsCard = New System.Windows.Forms.Panel()
        Me.lblArtifactsVal = New System.Windows.Forms.Label()
        Me.lblArtifactsSub = New System.Windows.Forms.Label()
        Me.pnlCompetenciesCard = New System.Windows.Forms.Panel()
        Me.lblCompetenciesVal = New System.Windows.Forms.Label()
        Me.lblCompetenciesSub = New System.Windows.Forms.Label()
        Me.pnlLastActivityCard = New System.Windows.Forms.Panel()
        Me.lblLastActivityVal = New System.Windows.Forms.Label()
        Me.lblLastActivitySub = New System.Windows.Forms.Label()
        Me.pnlChartCard = New System.Windows.Forms.Panel()
        Me.pnlAdminChart = New System.Windows.Forms.Panel()
        Me.btnViewCompetencies = New System.Windows.Forms.Button()
        Me.btnViewAcademic = New System.Windows.Forms.Button()
        Me.pnlStudentInfo = New System.Windows.Forms.Panel()
        Me.lblInfoStudentNum = New System.Windows.Forms.Label()
        Me.lblInfoFullName = New System.Windows.Forms.Label()
        Me.lblInfoProgram = New System.Windows.Forms.Label()
        Me.pnlTableSection = New System.Windows.Forms.Panel()
        Me.lblTableTitle = New System.Windows.Forms.Label()
        Me.lblSearchFilter = New System.Windows.Forms.Label()
        Me.txtFilterRecords = New System.Windows.Forms.TextBox()
        Me.dgvAdminPortfolio = New System.Windows.Forms.DataGridView()
        Me.pnlTopNav.SuspendLayout()
        Me.pnlSearchCard.SuspendLayout()
        Me.pnlArtifactsCard.SuspendLayout()
        Me.pnlCompetenciesCard.SuspendLayout()
        Me.pnlLastActivityCard.SuspendLayout()
        Me.pnlChartCard.SuspendLayout()
        Me.pnlStudentInfo.SuspendLayout()
        Me.pnlTableSection.SuspendLayout()
        CType(Me.dgvAdminPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlTopNav
        '
        Me.pnlTopNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.pnlTopNav.Controls.Add(Me.lblNavTitle)
        Me.pnlTopNav.Controls.Add(Me.lblNavSub)
        Me.pnlTopNav.Controls.Add(Me.btnRefresh)
        Me.pnlTopNav.Controls.Add(Me.btnLogout)
        Me.pnlTopNav.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopNav.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopNav.Name = "pnlTopNav"
        Me.pnlTopNav.Size = New System.Drawing.Size(1180, 60)
        Me.pnlTopNav.TabIndex = 0
        '
        'lblNavTitle
        '
        Me.lblNavTitle.AutoSize = True
        Me.lblNavTitle.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblNavTitle.ForeColor = System.Drawing.Color.White
        Me.lblNavTitle.Location = New System.Drawing.Point(15, 8)
        Me.lblNavTitle.Name = "lblNavTitle"
        Me.lblNavTitle.Size = New System.Drawing.Size(431, 30)
        Me.lblNavTitle.TabIndex = 0
        Me.lblNavTitle.Text = "E-PLPortfolio Admin - Student Overview"
        '
        'lblNavSub
        '
        Me.lblNavSub.AutoSize = True
        Me.lblNavSub.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblNavSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblNavSub.Location = New System.Drawing.Point(16, 36)
        Me.lblNavSub.Name = "lblNavSub"
        Me.lblNavSub.Size = New System.Drawing.Size(217, 19)
        Me.lblNavSub.TabIndex = 1
        Me.lblNavSub.Text = "Pamantasan ng Lungsod ng Pasig"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Location = New System.Drawing.Point(955, 14)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(100, 32)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.Text = "🔄 Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Location = New System.Drawing.Point(1065, 14)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(100, 32)
        Me.btnLogout.TabIndex = 3
        Me.btnLogout.Text = "🚪 Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'pnlSearchCard
        '
        Me.pnlSearchCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSearchCard.BackColor = System.Drawing.Color.White
        Me.pnlSearchCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSearchCard.Controls.Add(Me.lblSearchHeader)
        Me.pnlSearchCard.Controls.Add(Me.cboStudentSearch)
        Me.pnlSearchCard.Location = New System.Drawing.Point(15, 72)
        Me.pnlSearchCard.Name = "pnlSearchCard"
        Me.pnlSearchCard.Size = New System.Drawing.Size(380, 75)
        Me.pnlSearchCard.TabIndex = 1
        '
        'lblSearchHeader
        '
        Me.lblSearchHeader.AutoSize = True
        Me.lblSearchHeader.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblSearchHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSearchHeader.Location = New System.Drawing.Point(12, 10)
        Me.lblSearchHeader.Name = "lblSearchHeader"
        Me.lblSearchHeader.Size = New System.Drawing.Size(153, 19)
        Me.lblSearchHeader.TabIndex = 0
        Me.lblSearchHeader.Text = "🔍 SEARCH STUDENT"
        '
        'cboStudentSearch
        '
        Me.cboStudentSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStudentSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboStudentSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboStudentSearch.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cboStudentSearch.FormattingEnabled = True
        Me.cboStudentSearch.Location = New System.Drawing.Point(12, 32)
        Me.cboStudentSearch.Name = "cboStudentSearch"
        Me.cboStudentSearch.Size = New System.Drawing.Size(354, 31)
        Me.cboStudentSearch.TabIndex = 1
        '
        'pnlArtifactsCard
        '
        Me.pnlArtifactsCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlArtifactsCard.BackColor = System.Drawing.Color.White
        Me.pnlArtifactsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlArtifactsCard.Controls.Add(Me.lblArtifactsVal)
        Me.pnlArtifactsCard.Controls.Add(Me.lblArtifactsSub)
        Me.pnlArtifactsCard.Location = New System.Drawing.Point(405, 72)
        Me.pnlArtifactsCard.Name = "pnlArtifactsCard"
        Me.pnlArtifactsCard.Size = New System.Drawing.Size(240, 75)
        Me.pnlArtifactsCard.TabIndex = 2
        '
        'lblArtifactsVal
        '
        Me.lblArtifactsVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblArtifactsVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblArtifactsVal.Location = New System.Drawing.Point(10, 15)
        Me.lblArtifactsVal.Name = "lblArtifactsVal"
        Me.lblArtifactsVal.Size = New System.Drawing.Size(60, 40)
        Me.lblArtifactsVal.TabIndex = 0
        Me.lblArtifactsVal.Text = "0"
        Me.lblArtifactsVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblArtifactsSub
        '
        Me.lblArtifactsSub.AutoSize = True
        Me.lblArtifactsSub.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblArtifactsSub.ForeColor = System.Drawing.Color.DimGray
        Me.lblArtifactsSub.Location = New System.Drawing.Point(75, 28)
        Me.lblArtifactsSub.Name = "lblArtifactsSub"
        Me.lblArtifactsSub.Size = New System.Drawing.Size(140, 19)
        Me.lblArtifactsSub.TabIndex = 1
        Me.lblArtifactsSub.Text = "ARTIFACTS LOGGED"
        '
        'pnlCompetenciesCard
        '
        Me.pnlCompetenciesCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCompetenciesCard.BackColor = System.Drawing.Color.White
        Me.pnlCompetenciesCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCompetenciesCard.Controls.Add(Me.lblCompetenciesVal)
        Me.pnlCompetenciesCard.Controls.Add(Me.lblCompetenciesSub)
        Me.pnlCompetenciesCard.Location = New System.Drawing.Point(655, 72)
        Me.pnlCompetenciesCard.Name = "pnlCompetenciesCard"
        Me.pnlCompetenciesCard.Size = New System.Drawing.Size(240, 75)
        Me.pnlCompetenciesCard.TabIndex = 3
        '
        'lblCompetenciesVal
        '
        Me.lblCompetenciesVal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompetenciesVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblCompetenciesVal.Location = New System.Drawing.Point(10, 15)
        Me.lblCompetenciesVal.Name = "lblCompetenciesVal"
        Me.lblCompetenciesVal.Size = New System.Drawing.Size(80, 40)
        Me.lblCompetenciesVal.TabIndex = 0
        Me.lblCompetenciesVal.Text = "0/7"
        Me.lblCompetenciesVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCompetenciesSub
        '
        Me.lblCompetenciesSub.AutoSize = True
        Me.lblCompetenciesSub.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblCompetenciesSub.ForeColor = System.Drawing.Color.DimGray
        Me.lblCompetenciesSub.Location = New System.Drawing.Point(95, 28)
        Me.lblCompetenciesSub.Name = "lblCompetenciesSub"
        Me.lblCompetenciesSub.Size = New System.Drawing.Size(112, 19)
        Me.lblCompetenciesSub.TabIndex = 1
        Me.lblCompetenciesSub.Text = "COMPETENCIES"
        '
        'pnlLastActivityCard
        '
        Me.pnlLastActivityCard.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlLastActivityCard.BackColor = System.Drawing.Color.White
        Me.pnlLastActivityCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlLastActivityCard.Controls.Add(Me.lblLastActivityVal)
        Me.pnlLastActivityCard.Controls.Add(Me.lblLastActivitySub)
        Me.pnlLastActivityCard.Location = New System.Drawing.Point(905, 72)
        Me.pnlLastActivityCard.Name = "pnlLastActivityCard"
        Me.pnlLastActivityCard.Size = New System.Drawing.Size(260, 75)
        Me.pnlLastActivityCard.TabIndex = 4
        '
        'lblLastActivityVal
        '
        Me.lblLastActivityVal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastActivityVal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblLastActivityVal.Location = New System.Drawing.Point(10, 12)
        Me.lblLastActivityVal.Name = "lblLastActivityVal"
        Me.lblLastActivityVal.Size = New System.Drawing.Size(240, 25)
        Me.lblLastActivityVal.TabIndex = 0
        Me.lblLastActivityVal.Text = "N/A"
        '
        'lblLastActivitySub
        '
        Me.lblLastActivitySub.AutoSize = True
        Me.lblLastActivitySub.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblLastActivitySub.ForeColor = System.Drawing.Color.DimGray
        Me.lblLastActivitySub.Location = New System.Drawing.Point(10, 42)
        Me.lblLastActivitySub.Name = "lblLastActivitySub"
        Me.lblLastActivitySub.Size = New System.Drawing.Size(107, 19)
        Me.lblLastActivitySub.TabIndex = 1
        Me.lblLastActivitySub.Text = "LAST ACTIVITY"
        '
        'pnlChartCard
        '
        Me.pnlChartCard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlChartCard.BackColor = System.Drawing.Color.White
        Me.pnlChartCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChartCard.Controls.Add(Me.btnViewAcademic)
        Me.pnlChartCard.Controls.Add(Me.btnViewCompetencies)
        Me.pnlChartCard.Controls.Add(Me.pnlAdminChart)
        Me.pnlChartCard.Location = New System.Drawing.Point(15, 158)
        Me.pnlChartCard.Name = "pnlChartCard"
        Me.pnlChartCard.Size = New System.Drawing.Size(1150, 175)
        Me.pnlChartCard.TabIndex = 5
        '
        'btnViewCompetencies
        '
        Me.btnViewCompetencies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewCompetencies.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnViewCompetencies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewCompetencies.FlatAppearance.BorderSize = 0
        Me.btnViewCompetencies.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewCompetencies.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewCompetencies.ForeColor = System.Drawing.Color.White
        Me.btnViewCompetencies.Location = New System.Drawing.Point(885, 8)
        Me.btnViewCompetencies.Name = "btnViewCompetencies"
        Me.btnViewCompetencies.Size = New System.Drawing.Size(120, 26)
        Me.btnViewCompetencies.TabIndex = 1
        Me.btnViewCompetencies.Text = "📊 Competencies"
        Me.btnViewCompetencies.UseVisualStyleBackColor = False
        '
        'btnViewAcademic
        '
        Me.btnViewAcademic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnViewAcademic.BackColor = System.Drawing.Color.Gainsboro
        Me.btnViewAcademic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewAcademic.FlatAppearance.BorderSize = 0
        Me.btnViewAcademic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewAcademic.Font = New System.Drawing.Font("Segoe UI", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnViewAcademic.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnViewAcademic.Location = New System.Drawing.Point(1010, 8)
        Me.btnViewAcademic.Name = "btnViewAcademic"
        Me.btnViewAcademic.Size = New System.Drawing.Size(130, 26)
        Me.btnViewAcademic.TabIndex = 2
        Me.btnViewAcademic.Text = "📚 Academic Courses"
        Me.btnViewAcademic.UseVisualStyleBackColor = False
        '
        'pnlAdminChart
        '
        Me.pnlAdminChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlAdminChart.Location = New System.Drawing.Point(0, 0)
        Me.pnlAdminChart.Name = "pnlAdminChart"
        Me.pnlAdminChart.Size = New System.Drawing.Size(1148, 173)
        Me.pnlAdminChart.TabIndex = 0
        '
        'pnlStudentInfo
        '
        Me.pnlStudentInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStudentInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.pnlStudentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlStudentInfo.Controls.Add(Me.lblInfoStudentNum)
        Me.pnlStudentInfo.Controls.Add(Me.lblInfoFullName)
        Me.pnlStudentInfo.Controls.Add(Me.lblInfoProgram)
        Me.pnlStudentInfo.Location = New System.Drawing.Point(15, 342)
        Me.pnlStudentInfo.Name = "pnlStudentInfo"
        Me.pnlStudentInfo.Size = New System.Drawing.Size(1150, 38)
        Me.pnlStudentInfo.TabIndex = 6
        '
        'lblInfoStudentNum
        '
        Me.lblInfoStudentNum.AutoSize = True
        Me.lblInfoStudentNum.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblInfoStudentNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblInfoStudentNum.Location = New System.Drawing.Point(15, 8)
        Me.lblInfoStudentNum.Name = "lblInfoStudentNum"
        Me.lblInfoStudentNum.Size = New System.Drawing.Size(171, 20)
        Me.lblInfoStudentNum.TabIndex = 0
        Me.lblInfoStudentNum.Text = "Student ID: All Records"
        '
        'lblInfoFullName
        '
        Me.lblInfoFullName.AutoSize = True
        Me.lblInfoFullName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInfoFullName.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoFullName.Location = New System.Drawing.Point(230, 8)
        Me.lblInfoFullName.Name = "lblInfoFullName"
        Me.lblInfoFullName.Size = New System.Drawing.Size(205, 20)
        Me.lblInfoFullName.TabIndex = 1
        Me.lblInfoFullName.Text = "Full Name: System Wide View"
        '
        'lblInfoProgram
        '
        Me.lblInfoProgram.AutoSize = True
        Me.lblInfoProgram.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblInfoProgram.ForeColor = System.Drawing.Color.DimGray
        Me.lblInfoProgram.Location = New System.Drawing.Point(520, 8)
        Me.lblInfoProgram.Name = "lblInfoProgram"
        Me.lblInfoProgram.Size = New System.Drawing.Size(242, 20)
        Me.lblInfoProgram.TabIndex = 2
        Me.lblInfoProgram.Text = "Degree Program: All Enrolled CS/IT"
        '
        'pnlTableSection
        '
        Me.pnlTableSection.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTableSection.BackColor = System.Drawing.Color.White
        Me.pnlTableSection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTableSection.Controls.Add(Me.lblTableTitle)
        Me.pnlTableSection.Controls.Add(Me.lblSearchFilter)
        Me.pnlTableSection.Controls.Add(Me.txtFilterRecords)
        Me.pnlTableSection.Controls.Add(Me.dgvAdminPortfolio)
        Me.pnlTableSection.Location = New System.Drawing.Point(15, 390)
        Me.pnlTableSection.Name = "pnlTableSection"
        Me.pnlTableSection.Size = New System.Drawing.Size(1150, 315)
        Me.pnlTableSection.TabIndex = 7
        '
        'lblTableTitle
        '
        Me.lblTableTitle.AutoSize = True
        Me.lblTableTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTableTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.lblTableTitle.Location = New System.Drawing.Point(15, 12)
        Me.lblTableTitle.Name = "lblTableTitle"
        Me.lblTableTitle.Size = New System.Drawing.Size(278, 23)
        Me.lblTableTitle.TabIndex = 0
        Me.lblTableTitle.Text = "ARTIFACT RECORDS REPOSITORY"
        '
        'lblSearchFilter
        '
        Me.lblSearchFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSearchFilter.AutoSize = True
        Me.lblSearchFilter.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblSearchFilter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.lblSearchFilter.Location = New System.Drawing.Point(745, 13)
        Me.lblSearchFilter.Name = "lblSearchFilter"
        Me.lblSearchFilter.Size = New System.Drawing.Size(130, 20)
        Me.lblSearchFilter.TabIndex = 1
        Me.lblSearchFilter.Text = "🔍 Search Records:"
        '
        'txtFilterRecords
        '
        Me.txtFilterRecords.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilterRecords.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFilterRecords.ForeColor = System.Drawing.Color.Gray
        Me.txtFilterRecords.Location = New System.Drawing.Point(880, 10)
        Me.txtFilterRecords.Name = "txtFilterRecords"
        Me.txtFilterRecords.Size = New System.Drawing.Size(255, 27)
        Me.txtFilterRecords.TabIndex = 2
        Me.txtFilterRecords.Text = "Search artifact title, student, or course..."
        '
        'dgvAdminPortfolio
        '
        Me.dgvAdminPortfolio.AllowUserToAddRows = False
        Me.dgvAdminPortfolio.AllowUserToDeleteRows = False
        Me.dgvAdminPortfolio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAdminPortfolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdminPortfolio.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdminPortfolio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAdminPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdminPortfolio.Location = New System.Drawing.Point(0, 48)
        Me.dgvAdminPortfolio.Name = "dgvAdminPortfolio"
        Me.dgvAdminPortfolio.ReadOnly = True
        Me.dgvAdminPortfolio.RowHeadersVisible = False
        Me.dgvAdminPortfolio.RowHeadersWidth = 51
        Me.dgvAdminPortfolio.RowTemplate.Height = 28
        Me.dgvAdminPortfolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdminPortfolio.Size = New System.Drawing.Size(1148, 265)
        Me.dgvAdminPortfolio.TabIndex = 3
        '
        'frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1180, 720)
        Me.Controls.Add(Me.pnlTopNav)
        Me.Controls.Add(Me.pnlSearchCard)
        Me.Controls.Add(Me.pnlArtifactsCard)
        Me.Controls.Add(Me.pnlCompetenciesCard)
        Me.Controls.Add(Me.pnlLastActivityCard)
        Me.Controls.Add(Me.pnlChartCard)
        Me.Controls.Add(Me.pnlStudentInfo)
        Me.Controls.Add(Me.pnlTableSection)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Portal - Student Portfolio Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlTopNav.ResumeLayout(False)
        Me.pnlTopNav.PerformLayout()
        Me.pnlSearchCard.ResumeLayout(False)
        Me.pnlSearchCard.PerformLayout()
        Me.pnlArtifactsCard.ResumeLayout(False)
        Me.pnlArtifactsCard.PerformLayout()
        Me.pnlCompetenciesCard.ResumeLayout(False)
        Me.pnlCompetenciesCard.PerformLayout()
        Me.pnlLastActivityCard.ResumeLayout(False)
        Me.pnlLastActivityCard.PerformLayout()
        Me.pnlChartCard.ResumeLayout(False)
        Me.pnlStudentInfo.ResumeLayout(False)
        Me.pnlStudentInfo.PerformLayout()
        Me.pnlTableSection.ResumeLayout(False)
        Me.pnlTableSection.PerformLayout()
        CType(Me.dgvAdminPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class