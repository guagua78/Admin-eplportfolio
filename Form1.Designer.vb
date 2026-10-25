<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdminLogin
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

    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblIconHeader As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblEyeToggle As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents lblFooterLeft As System.Windows.Forms.Label
    Friend WithEvents lblFooterStatus As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblIconHeader = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblEyeToggle = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.lblFooterLeft = New System.Windows.Forms.Label()
        Me.lblFooterStatus = New System.Windows.Forms.Label()
        Me.pnlCard.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(1215, 20)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(45, 45)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "✕"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlCard
        '
        Me.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlCard.BackColor = System.Drawing.Color.White
        Me.pnlCard.Controls.Add(Me.pnlFooter)
        Me.pnlCard.Controls.Add(Me.lblIconHeader)
        Me.pnlCard.Controls.Add(Me.lblTitle)
        Me.pnlCard.Controls.Add(Me.lblSubtitle)
        Me.pnlCard.Controls.Add(Me.lblUsername)
        Me.pnlCard.Controls.Add(Me.txtUsername)
        Me.pnlCard.Controls.Add(Me.lblPassword)
        Me.pnlCard.Controls.Add(Me.lblEyeToggle)
        Me.pnlCard.Controls.Add(Me.txtPassword)
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Location = New System.Drawing.Point(370, 50)
        Me.pnlCard.Name = "pnlCard"
        Me.pnlCard.Size = New System.Drawing.Size(540, 620)
        Me.pnlCard.TabIndex = 0
        '
        'lblIconHeader
        '
        Me.lblIconHeader.Font = New System.Drawing.Font("Segoe UI", 28.0!)
        Me.lblIconHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.lblIconHeader.Location = New System.Drawing.Point(20, 28)
        Me.lblIconHeader.Name = "lblIconHeader"
        Me.lblIconHeader.Size = New System.Drawing.Size(500, 50)
        Me.lblIconHeader.TabIndex = 0
        Me.lblIconHeader.Text = "🎓"
        Me.lblIconHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(20, 80)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(500, 50)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "E-PLPortfolio Admin"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSubtitle
        '
        Me.lblSubtitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(110, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(135, Byte), Integer))
        Me.lblSubtitle.Location = New System.Drawing.Point(20, 132)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(500, 30)
        Me.lblSubtitle.TabIndex = 2
        Me.lblSubtitle.Text = "Pamantasan ng Lungsod ng Pasig • Academic Evaluation"
        Me.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(50, 190)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(152, 25)
        Me.lblUsername.TabIndex = 3
        Me.lblUsername.Text = "Admin Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(50, 220)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(440, 34)
        Me.txtUsername.TabIndex = 4
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(50, 280)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(92, 25)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPassword.Location = New System.Drawing.Point(50, 310)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(395, 34)
        Me.txtPassword.TabIndex = 6
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblEyeToggle
        '
        Me.lblEyeToggle.AutoSize = True
        Me.lblEyeToggle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEyeToggle.Font = New System.Drawing.Font("Segoe UI", 12.5!)
        Me.lblEyeToggle.ForeColor = System.Drawing.Color.Gray
        Me.lblEyeToggle.Location = New System.Drawing.Point(452, 312)
        Me.lblEyeToggle.Name = "lblEyeToggle"
        Me.lblEyeToggle.Size = New System.Drawing.Size(39, 30)
        Me.lblEyeToggle.TabIndex = 7
        Me.lblEyeToggle.Text = "👁"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(50, 395)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(440, 54)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "AUTHENTICATE"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlFooter.Controls.Add(Me.lblFooterLeft)
        Me.pnlFooter.Controls.Add(Me.lblFooterStatus)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Location = New System.Drawing.Point(0, 565)
        Me.pnlFooter.Name = "pnlFooter"
        Me.pnlFooter.Size = New System.Drawing.Size(540, 55)
        Me.pnlFooter.TabIndex = 9
        '
        'lblFooterLeft
        '
        Me.lblFooterLeft.AutoSize = True
        Me.lblFooterLeft.Font = New System.Drawing.Font("Segoe UI", 8.5!)
        Me.lblFooterLeft.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblFooterLeft.Location = New System.Drawing.Point(25, 18)
        Me.lblFooterLeft.Name = "lblFooterLeft"
        Me.lblFooterLeft.Size = New System.Drawing.Size(164, 20)
        Me.lblFooterLeft.TabIndex = 0
        Me.lblFooterLeft.Text = "Authorized Access Only"
        '
        'lblFooterStatus
        '
        Me.lblFooterStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFooterStatus.AutoSize = True
        Me.lblFooterStatus.Font = New System.Drawing.Font("Segoe UI", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lblFooterStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.lblFooterStatus.Location = New System.Drawing.Point(375, 18)
        Me.lblFooterStatus.Name = "lblFooterStatus"
        Me.lblFooterStatus.Size = New System.Drawing.Size(140, 20)
        Me.lblFooterStatus.TabIndex = 1
        Me.lblFooterStatus.Text = "● SECURE ENDPOINT"
        '
        'frmAdminLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pnlCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdminLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Portal - Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

End Class