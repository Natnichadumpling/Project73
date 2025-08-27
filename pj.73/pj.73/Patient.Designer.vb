<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelPatient = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnManagePatient = New System.Windows.Forms.Button()
        Me.btnWaitinglist = New System.Windows.Forms.Button()
        Me.btnInPatientReport = New System.Windows.Forms.Button()
        Me.btnOutPatientReport = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelPatient.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelPatient
        '
        Me.PanelPatient.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelPatient.Controls.Add(Me.PictureBox1)
        Me.PanelPatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPatient.Location = New System.Drawing.Point(0, 0)
        Me.PanelPatient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelPatient.Name = "PanelPatient"
        Me.PanelPatient.Size = New System.Drawing.Size(661, 365)
        Me.PanelPatient.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnManagePatient, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnWaitinglist, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnInPatientReport, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnOutPatientReport, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(177, 98)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(309, 180)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnManagePatient
        '
        Me.btnManagePatient.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnManagePatient.Location = New System.Drawing.Point(2, 2)
        Me.btnManagePatient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnManagePatient.Name = "btnManagePatient"
        Me.btnManagePatient.Size = New System.Drawing.Size(150, 86)
        Me.btnManagePatient.TabIndex = 0
        Me.btnManagePatient.Text = "Manage Patient"
        Me.btnManagePatient.UseVisualStyleBackColor = True
        '
        'btnWaitinglist
        '
        Me.btnWaitinglist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWaitinglist.Location = New System.Drawing.Point(156, 2)
        Me.btnWaitinglist.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnWaitinglist.Name = "btnWaitinglist"
        Me.btnWaitinglist.Size = New System.Drawing.Size(151, 86)
        Me.btnWaitinglist.TabIndex = 1
        Me.btnWaitinglist.Text = "Waiting list"
        Me.btnWaitinglist.UseVisualStyleBackColor = True
        '
        'btnInPatientReport
        '
        Me.btnInPatientReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnInPatientReport.Location = New System.Drawing.Point(2, 92)
        Me.btnInPatientReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInPatientReport.Name = "btnInPatientReport"
        Me.btnInPatientReport.Size = New System.Drawing.Size(150, 86)
        Me.btnInPatientReport.TabIndex = 2
        Me.btnInPatientReport.Text = "In Patient Report"
        Me.btnInPatientReport.UseVisualStyleBackColor = True
        '
        'btnOutPatientReport
        '
        Me.btnOutPatientReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnOutPatientReport.Location = New System.Drawing.Point(156, 92)
        Me.btnOutPatientReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnOutPatientReport.Name = "btnOutPatientReport"
        Me.btnOutPatientReport.Size = New System.Drawing.Size(151, 86)
        Me.btnOutPatientReport.TabIndex = 3
        Me.btnOutPatientReport.Text = "Out Patient Report"
        Me.btnOutPatientReport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.Screenshot_2025_08_08_161313
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(661, 365)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 365)
        Me.Controls.Add(Me.PanelPatient)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Patient"
        Me.Text = "Patient"
        Me.PanelPatient.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPatient As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnManagePatient As Button
    Friend WithEvents btnWaitinglist As Button
    Friend WithEvents btnInPatientReport As Button
    Friend WithEvents btnOutPatientReport As Button
End Class
