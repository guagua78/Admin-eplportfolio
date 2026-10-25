Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms

Public Class frmArtifactDetailModal
    Inherits Form

    Private entryId As Integer
    Private txtDescription As TextBox
    Private lblTitle As Label
    Private lblMeta As Label

    Public Sub New(ByVal id As Integer)
        Me.entryId = id
        InitializeCustomComponents()
        LoadArtifactDetails()
    End Sub

    Private Sub InitializeCustomComponents()
        Me.Text = "Artifact Detail Viewer"
        Me.Size = New Size(620, 380)
        Me.StartPosition = FormStartPosition.CenterParent
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.BackColor = Color.FromArgb(245, 247, 248)

        ' Header Title
        lblTitle = New Label With {
            .Font = New Font("Segoe UI", 14.0!, FontStyle.Bold),
            .ForeColor = Color.FromArgb(8, 75, 42),
            .Location = New Point(20, 15),
            .Size = New Size(560, 35),
            .Text = "Loading Artifact..."
        }

        ' Metadata Subtitle
        lblMeta = New Label With {
            .Font = New Font("Segoe UI", 9.5!, FontStyle.Regular),
            .ForeColor = Color.DimGray,
            .Location = New Point(20, 50),
            .Size = New Size(560, 25),
            .Text = ""
        }

        ' Label: Description
        Dim lblDescHeader As New Label With {
            .Text = "Description & Reflection:",
            .Font = New Font("Segoe UI", 10.0!, FontStyle.Bold),
            .Location = New Point(20, 85),
            .Size = New Size(200, 20)
        }

        ' Description Textbox
        txtDescription = New TextBox With {
            .Multiline = True,
            .ReadOnly = True,
            .ScrollBars = ScrollBars.Vertical,
            .Font = New Font("Segoe UI", 10.0!),
            .BackColor = Color.White,
            .Location = New Point(20, 110),
            .Size = New Size(560, 160)
        }

        ' Close Button
        Dim btnClose As New Button With {
            .Text = "Close",
            .Font = New Font("Segoe UI", 10.0!, FontStyle.Bold),
            .BackColor = Color.FromArgb(8, 75, 42),
            .ForeColor = Color.White,
            .FlatStyle = FlatStyle.Flat,
            .Location = New Point(465, 285),
            .Size = New Size(115, 38),
            .Cursor = Cursors.Hand
        }
        btnClose.FlatAppearance.BorderSize = 0
        AddHandler btnClose.Click, Sub(sender, e) Me.Close()

        ' Controls Hierarchy
        Me.Controls.Add(lblTitle)
        Me.Controls.Add(lblMeta)
        Me.Controls.Add(lblDescHeader)
        Me.Controls.Add(txtDescription)
        Me.Controls.Add(btnClose)
    End Sub

    Private Sub LoadArtifactDetails()
        Try
            Using conn As MySqlConnection = database.GetConnection()
                If conn IsNot Nothing Then
                    Dim query As String = "SELECT p.title, p.description, p.student_number, " &
                                         "COALESCE(CONCAT(s.last_name, ', ', s.first_name), 'Unknown Student') AS student_name, " &
                                         "COALESCE(c.category_name, 'General') AS category_name " &
                                         "FROM portfolio_entries p " &
                                         "LEFT JOIN students s ON TRIM(p.student_number) = TRIM(s.student_number) " &
                                         "LEFT JOIN categories c ON p.category_id = c.category_id " &
                                         "WHERE p.entry_id = @id LIMIT 1"

                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", entryId)
                        Using reader As MySqlDataReader = cmd.ExecuteReader()
                            If reader.Read() Then
                                lblTitle.Text = reader("title").ToString()
                                lblMeta.Text = $"Student: {reader("student_name")} ({reader("student_number")}) | Competency: {reader("category_name")}"

                                Dim descObj = reader("description")
                                If descObj IsNot DBNull.Value AndAlso Not String.IsNullOrWhiteSpace(descObj.ToString()) Then
                                    txtDescription.Text = descObj.ToString()
                                Else
                                    txtDescription.Text = "No description or reflection was provided for this artifact."
                                End If
                            End If
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching artifact details: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class