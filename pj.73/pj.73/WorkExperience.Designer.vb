<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkExperience
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
        Me.manage_staffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.mange_organizationname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.manage_position = New System.Windows.Forms.TextBox()
        Me.manage_start = New System.Windows.Forms.TextBox()
        Me.manage_end = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'manage_staffid
        '
        Me.manage_staffid.Location = New System.Drawing.Point(315, 20)
        Me.manage_staffid.Name = "manage_staffid"
        Me.manage_staffid.Size = New System.Drawing.Size(142, 22)
        Me.manage_staffid.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Staff ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(479, 18)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(168, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Organization Name"
        '
        'mange_organizationname
        '
        Me.mange_organizationname.Location = New System.Drawing.Point(315, 72)
        Me.mange_organizationname.Name = "mange_organizationname"
        Me.mange_organizationname.Size = New System.Drawing.Size(137, 22)
        Me.mange_organizationname.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Position"
        '
        'manage_position
        '
        Me.manage_position.Location = New System.Drawing.Point(315, 123)
        Me.manage_position.Name = "manage_position"
        Me.manage_position.Size = New System.Drawing.Size(137, 22)
        Me.manage_position.TabIndex = 9
        '
        'manage_start
        '
        Me.manage_start.Location = New System.Drawing.Point(315, 174)
        Me.manage_start.Name = "manage_start"
        Me.manage_start.Size = New System.Drawing.Size(137, 22)
        Me.manage_start.TabIndex = 11
        '
        'manage_end
        '
        Me.manage_end.Location = New System.Drawing.Point(315, 223)
        Me.manage_end.Name = "manage_end"
        Me.manage_end.Size = New System.Drawing.Size(137, 22)
        Me.manage_end.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(224, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(224, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "End Date"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(337, 272)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 35)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightBlue
        Me.btnAdd.Location = New System.Drawing.Point(434, 272)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 35)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(535, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 35)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'WorkExperience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 588)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.manage_end)
        Me.Controls.Add(Me.manage_start)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.manage_position)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.mange_organizationname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.manage_staffid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "WorkExperience"
        Me.Text = "WorkExperience"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents manage_staffid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents mange_organizationname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents manage_position As TextBox
    Friend WithEvents manage_start As TextBox
    Friend WithEvents manage_end As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
End Class
