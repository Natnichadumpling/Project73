<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageStaff
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
        Me.manage_staff = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnNewstaff = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAddQuali = New System.Windows.Forms.Button()
        Me.btnExper = New System.Windows.Forms.Button()
        Me.btnPayroll = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.manage_name = New System.Windows.Forms.TextBox()
        Me.manage_surname = New System.Windows.Forms.TextBox()
        Me.manage_addr = New System.Windows.Forms.TextBox()
        Me.manage_tel = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.manage_sex = New System.Windows.Forms.ComboBox()
        Me.manage_position = New System.Windows.Forms.TextBox()
        Me.manage_contract = New System.Windows.Forms.ComboBox()
        Me.manage_nin = New System.Windows.Forms.TextBox()
        Me.manage_charn = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'manage_staff
        '
        Me.manage_staff.Location = New System.Drawing.Point(196, 29)
        Me.manage_staff.Name = "manage_staff"
        Me.manage_staff.Size = New System.Drawing.Size(142, 22)
        Me.manage_staff.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Staff ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(358, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 24)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNewstaff
        '
        Me.btnNewstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewstaff.Location = New System.Drawing.Point(523, 27)
        Me.btnNewstaff.Name = "btnNewstaff"
        Me.btnNewstaff.Size = New System.Drawing.Size(97, 24)
        Me.btnNewstaff.TabIndex = 12
        Me.btnNewstaff.Text = "NEW STAFF"
        Me.btnNewstaff.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(523, 74)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(97, 24)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Red
        Me.btnDel.Location = New System.Drawing.Point(523, 123)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(97, 26)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "DELETE"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAddQuali
        '
        Me.btnAddQuali.BackColor = System.Drawing.Color.Silver
        Me.btnAddQuali.Location = New System.Drawing.Point(523, 181)
        Me.btnAddQuali.Name = "btnAddQuali"
        Me.btnAddQuali.Size = New System.Drawing.Size(141, 24)
        Me.btnAddQuali.TabIndex = 15
        Me.btnAddQuali.Text = "Add Qualification"
        Me.btnAddQuali.UseVisualStyleBackColor = False
        '
        'btnExper
        '
        Me.btnExper.BackColor = System.Drawing.Color.Silver
        Me.btnExper.Location = New System.Drawing.Point(523, 231)
        Me.btnExper.Name = "btnExper"
        Me.btnExper.Size = New System.Drawing.Size(141, 24)
        Me.btnExper.TabIndex = 16
        Me.btnExper.Text = "Work Experience"
        Me.btnExper.UseVisualStyleBackColor = False
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.Silver
        Me.btnPayroll.Location = New System.Drawing.Point(523, 283)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(141, 24)
        Me.btnPayroll.TabIndex = 17
        Me.btnPayroll.Text = "Payroll"
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(130, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Personal Detail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(429, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ContractType"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 400)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Birthday"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(486, 397)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "NIN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 461)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 16)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Sex"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(429, 461)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ChargeNurse"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(130, 519)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Position"
        '
        'manage_name
        '
        Me.manage_name.Location = New System.Drawing.Point(196, 126)
        Me.manage_name.Name = "manage_name"
        Me.manage_name.Size = New System.Drawing.Size(142, 22)
        Me.manage_name.TabIndex = 29
        '
        'manage_surname
        '
        Me.manage_surname.Location = New System.Drawing.Point(196, 175)
        Me.manage_surname.Name = "manage_surname"
        Me.manage_surname.Size = New System.Drawing.Size(142, 22)
        Me.manage_surname.TabIndex = 30
        '
        'manage_addr
        '
        Me.manage_addr.Location = New System.Drawing.Point(196, 225)
        Me.manage_addr.Name = "manage_addr"
        Me.manage_addr.Size = New System.Drawing.Size(240, 22)
        Me.manage_addr.TabIndex = 31
        '
        'manage_tel
        '
        Me.manage_tel.Location = New System.Drawing.Point(196, 334)
        Me.manage_tel.Name = "manage_tel"
        Me.manage_tel.Size = New System.Drawing.Size(142, 22)
        Me.manage_tel.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(196, 394)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 22)
        Me.DateTimePicker1.TabIndex = 33
        '
        'manage_sex
        '
        Me.manage_sex.FormattingEnabled = True
        Me.manage_sex.Location = New System.Drawing.Point(196, 458)
        Me.manage_sex.Name = "manage_sex"
        Me.manage_sex.Size = New System.Drawing.Size(153, 24)
        Me.manage_sex.TabIndex = 34
        '
        'manage_position
        '
        Me.manage_position.Location = New System.Drawing.Point(196, 513)
        Me.manage_position.Name = "manage_position"
        Me.manage_position.Size = New System.Drawing.Size(142, 22)
        Me.manage_position.TabIndex = 35
        '
        'manage_contract
        '
        Me.manage_contract.FormattingEnabled = True
        Me.manage_contract.Location = New System.Drawing.Point(523, 334)
        Me.manage_contract.Name = "manage_contract"
        Me.manage_contract.Size = New System.Drawing.Size(153, 24)
        Me.manage_contract.TabIndex = 36
        '
        'manage_nin
        '
        Me.manage_nin.Location = New System.Drawing.Point(523, 394)
        Me.manage_nin.Name = "manage_nin"
        Me.manage_nin.Size = New System.Drawing.Size(153, 22)
        Me.manage_nin.TabIndex = 37
        '
        'manage_charn
        '
        Me.manage_charn.Location = New System.Drawing.Point(523, 455)
        Me.manage_charn.Name = "manage_charn"
        Me.manage_charn.Size = New System.Drawing.Size(153, 22)
        Me.manage_charn.TabIndex = 38
        '
        'ManageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 695)
        Me.Controls.Add(Me.manage_charn)
        Me.Controls.Add(Me.manage_nin)
        Me.Controls.Add(Me.manage_contract)
        Me.Controls.Add(Me.manage_position)
        Me.Controls.Add(Me.manage_sex)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.manage_tel)
        Me.Controls.Add(Me.manage_addr)
        Me.Controls.Add(Me.manage_surname)
        Me.Controls.Add(Me.manage_name)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnPayroll)
        Me.Controls.Add(Me.btnExper)
        Me.Controls.Add(Me.btnAddQuali)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNewstaff)
        Me.Controls.Add(Me.manage_staff)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "ManageStaff"
        Me.Text = "ManageStaff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents manage_staff As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnNewstaff As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAddQuali As Button
    Friend WithEvents btnExper As Button
    Friend WithEvents btnPayroll As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents manage_name As TextBox
    Friend WithEvents manage_surname As TextBox
    Friend WithEvents manage_addr As TextBox
    Friend WithEvents manage_tel As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents manage_sex As ComboBox
    Friend WithEvents manage_position As TextBox
    Friend WithEvents manage_contract As ComboBox
    Friend WithEvents manage_nin As TextBox
    Friend WithEvents manage_charn As TextBox
End Class
