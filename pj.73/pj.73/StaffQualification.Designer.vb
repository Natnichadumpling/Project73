<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffQualification
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
        Me.squali_staffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.squali_type = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.squali_date = New System.Windows.Forms.TextBox()
        Me.Lable4 = New System.Windows.Forms.Label()
        Me.squali_insti = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'squali_staffid
        '
        Me.squali_staffid.Location = New System.Drawing.Point(310, 25)
        Me.squali_staffid.Name = "squali_staffid"
        Me.squali_staffid.Size = New System.Drawing.Size(142, 22)
        Me.squali_staffid.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(246, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Staff ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(484, 23)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 24)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Type_Qual"
        '
        'squali_type
        '
        Me.squali_type.Location = New System.Drawing.Point(310, 86)
        Me.squali_type.Name = "squali_type"
        Me.squali_type.Size = New System.Drawing.Size(142, 22)
        Me.squali_type.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Date_Qual"
        '
        'squali_date
        '
        Me.squali_date.Location = New System.Drawing.Point(312, 136)
        Me.squali_date.Name = "squali_date"
        Me.squali_date.Size = New System.Drawing.Size(140, 22)
        Me.squali_date.TabIndex = 12
        '
        'Lable4
        '
        Me.Lable4.AutoSize = True
        Me.Lable4.Location = New System.Drawing.Point(221, 190)
        Me.Lable4.Name = "Lable4"
        Me.Lable4.Size = New System.Drawing.Size(69, 16)
        Me.Lable4.TabIndex = 13
        Me.Lable4.Text = "Instituation"
        '
        'squali_insti
        '
        Me.squali_insti.Location = New System.Drawing.Point(312, 184)
        Me.squali_insti.Name = "squali_insti"
        Me.squali_insti.Size = New System.Drawing.Size(140, 22)
        Me.squali_insti.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(538, 229)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(71, 35)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightBlue
        Me.btnAdd.Location = New System.Drawing.Point(437, 229)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(71, 35)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(340, 229)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(71, 35)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'StaffQualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.squali_insti)
        Me.Controls.Add(Me.Lable4)
        Me.Controls.Add(Me.squali_date)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.squali_type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.squali_staffid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "StaffQualification"
        Me.Text = "StaffQualification"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents squali_staffid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents squali_type As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents squali_date As TextBox
    Friend WithEvents Lable4 As Label
    Friend WithEvents squali_insti As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
End Class
