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

    Friend WithEvents pnlTopBar As System.Windows.Forms.Panel
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents lblSelectStudent As System.Windows.Forms.Label
    Friend WithEvents cmbStudents As System.Windows.Forms.ComboBox
    Friend WithEvents pnlOverview As System.Windows.Forms.Panel
    Friend WithEvents lblTotalEntries As System.Windows.Forms.Label
    Friend WithEvents lblActiveCategories As System.Windows.Forms.Label
    Friend WithEvents pnlAdminChart As System.Windows.Forms.Panel
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvAdminPortfolio As System.Windows.Forms.DataGridView

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTopBar = New System.Windows.Forms.Panel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSelectStudent = New System.Windows.Forms.Label()
        Me.cmbStudents = New System.Windows.Forms.ComboBox()
        Me.pnlOverview = New System.Windows.Forms.Panel()
        Me.lblTotalEntries = New System.Windows.Forms.Label()
        Me.lblActiveCategories = New System.Windows.Forms.Label()
        Me.pnlAdminChart = New System.Windows.Forms.Panel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.dgvAdminPortfolio = New System.Windows.Forms.DataGridView()
        Me.pnlTopBar.SuspendLayout()
        Me.pnlOverview.SuspendLayout()
        CType(Me.dgvAdminPortfolio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' pnlTopBar
        '
        Me.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlTopBar.Controls.Add(Me.lblHeader)
        Me.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopBar.Name = "pnlTopBar"
        Me.pnlTopBar.Size = New System.Drawing.Size(950, 50)
        '
        ' lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblHeader.ForeColor = System.Drawing.Color.White
        Me.lblHeader.Location = New System.Drawing.Point(20, 15)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(320, 21)
        Me.lblHeader.Text = "E-PLP Portfolio Admin - Student Overview"
        '
        ' lblSelectStudent
        '
        Me.lblSelectStudent.AutoSize = True
        Me.lblSelectStudent.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Bold)
        Me.lblSelectStudent.Location = New System.Drawing.Point(20, 68)
        Me.lblSelectStudent.Name = "lblSelectStudent"
        Me.lblSelectStudent.Size = New System.Drawing.Size(98, 17)
        Me.lblSelectStudent.Text = "Select Student:"
        '
        ' cmbStudents
        '
        Me.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStudents.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.cmbStudents.FormattingEnabled = True
        Me.cmbStudents.Location = New System.Drawing.Point(125, 65)
        Me.cmbStudents.Name = "cmbStudents"
        Me.cmbStudents.Size = New System.Drawing.Size(320, 25)
        '
        ' pnlOverview
        '
        Me.pnlOverview.BackColor = System.Drawing.Color.White
        Me.pnlOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOverview.Controls.Add(Me.lblTotalEntries)
        Me.pnlOverview.Controls.Add(Me.lblActiveCategories)
        Me.pnlOverview.Location = New System.Drawing.Point(465, 60)
        Me.pnlOverview.Name = "pnlOverview"
        Me.pnlOverview.Size = New System.Drawing.Size(460, 35)
        '
        ' lblTotalEntries
        '
        Me.lblTotalEntries.AutoSize = True
        Me.lblTotalEntries.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalEntries.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lblTotalEntries.Location = New System.Drawing.Point(15, 9)
        Me.lblTotalEntries.Name = "lblTotalEntries"
        Me.lblTotalEntries.Size = New System.Drawing.Size(100, 15)
        Me.lblTotalEntries.Text = "0 Artifacts Logged"
        '
        ' lblActiveCategories
        '
        Me.lblActiveCategories.AutoSize = True
        Me.lblActiveCategories.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblActiveCategories.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.lblActiveCategories.Location = New System.Drawing.Point(230, 9)
        Me.lblActiveCategories.Name = "lblActiveCategories"
        Me.lblActiveCategories.Size = New System.Drawing.Size(130, 15)
        Me.lblActiveCategories.Text = "0 Competencies Covered"
        '
        ' pnlAdminChart
        '
        Me.pnlAdminChart.BackColor = System.Drawing.Color.White
        Me.pnlAdminChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAdminChart.Location = New System.Drawing.Point(20, 110)
        Me.pnlAdminChart.Name = "pnlAdminChart"
        Me.pnlAdminChart.Size = New System.Drawing.Size(905, 180)
        '
        ' txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.txtSearch.Location = New System.Drawing.Point(20, 305)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(905, 25)
        '
        ' dgvAdminPortfolio
        '
        Me.dgvAdminPortfolio.AllowUserToAddRows = False
        Me.dgvAdminPortfolio.AllowUserToDeleteRows = False
        Me.dgvAdminPortfolio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAdminPortfolio.BackgroundColor = System.Drawing.Color.White
        Me.dgvAdminPortfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdminPortfolio.Location = New System.Drawing.Point(20, 340)
        Me.dgvAdminPortfolio.Name = "dgvAdminPortfolio"
        Me.dgvAdminPortfolio.ReadOnly = True
        Me.dgvAdminPortfolio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAdminPortfolio.Size = New System.Drawing.Size(905, 220)
        '
        ' frmAdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(950, 580)
        Me.Controls.Add(Me.pnlTopBar)
        Me.Controls.Add(Me.lblSelectStudent)
        Me.Controls.Add(Me.cmbStudents)
        Me.Controls.Add(Me.pnlOverview)
        Me.Controls.Add(Me.pnlAdminChart)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvAdminPortfolio)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Portal - Student Portfolio Viewer"
        Me.pnlTopBar.ResumeLayout(False)
        Me.pnlTopBar.PerformLayout()
        Me.pnlOverview.ResumeLayout(False)
        Me.pnlOverview.PerformLayout()
        CType(Me.dgvAdminPortfolio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
End Class