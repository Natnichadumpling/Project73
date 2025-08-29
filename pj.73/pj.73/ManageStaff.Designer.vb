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
        Me.manage_staff.Location = New System.Drawing.Point(220, 36)
        Me.manage_staff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_staff.Name = "manage_staff"
        Me.manage_staff.Size = New System.Drawing.Size(159, 26)
        Me.manage_staff.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Staff ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(403, 31)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 30)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnNewstaff
        '
        Me.btnNewstaff.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnNewstaff.Location = New System.Drawing.Point(588, 34)
        Me.btnNewstaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNewstaff.Name = "btnNewstaff"
        Me.btnNewstaff.Size = New System.Drawing.Size(109, 30)
        Me.btnNewstaff.TabIndex = 12
        Me.btnNewstaff.Text = "NEW STAFF"
        Me.btnNewstaff.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(588, 92)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(109, 30)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.Red
        Me.btnDel.Location = New System.Drawing.Point(588, 154)
        Me.btnDel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(109, 32)
        Me.btnDel.TabIndex = 14
        Me.btnDel.Text = "DELETE"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'btnAddQuali
        '
        Me.btnAddQuali.BackColor = System.Drawing.Color.Silver
        Me.btnAddQuali.Location = New System.Drawing.Point(588, 226)
        Me.btnAddQuali.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddQuali.Name = "btnAddQuali"
        Me.btnAddQuali.Size = New System.Drawing.Size(159, 30)
        Me.btnAddQuali.TabIndex = 15
        Me.btnAddQuali.Text = "Add Qualification"
        Me.btnAddQuali.UseVisualStyleBackColor = False
        '
        'btnExper
        '
        Me.btnExper.BackColor = System.Drawing.Color.Silver
        Me.btnExper.Location = New System.Drawing.Point(588, 289)
        Me.btnExper.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExper.Name = "btnExper"
        Me.btnExper.Size = New System.Drawing.Size(159, 30)
        Me.btnExper.TabIndex = 16
        Me.btnExper.Text = "Work Experience"
        Me.btnExper.UseVisualStyleBackColor = False
        '
        'btnPayroll
        '
        Me.btnPayroll.BackColor = System.Drawing.Color.Silver
        Me.btnPayroll.Location = New System.Drawing.Point(588, 354)
        Me.btnPayroll.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPayroll.Name = "btnPayroll"
        Me.btnPayroll.Size = New System.Drawing.Size(159, 30)
        Me.btnPayroll.TabIndex = 17
        Me.btnPayroll.Text = "Payroll"
        Me.btnPayroll.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Personal Detail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 289)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(146, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 20)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Tel"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(483, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "ContractType"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(146, 500)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 20)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Birthday"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(547, 496)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "NIN"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(146, 576)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Sex"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(483, 576)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 20)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "ChargeNurse"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(146, 649)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 20)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Position"
        '
        'manage_name
        '
        Me.manage_name.Location = New System.Drawing.Point(220, 158)
        Me.manage_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_name.Name = "manage_name"
        Me.manage_name.Size = New System.Drawing.Size(159, 26)
        Me.manage_name.TabIndex = 29
        '
        'manage_surname
        '
        Me.manage_surname.Location = New System.Drawing.Point(220, 219)
        Me.manage_surname.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_surname.Name = "manage_surname"
        Me.manage_surname.Size = New System.Drawing.Size(159, 26)
        Me.manage_surname.TabIndex = 30
        '
        'manage_addr
        '
        Me.manage_addr.Location = New System.Drawing.Point(220, 281)
        Me.manage_addr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_addr.Name = "manage_addr"
        Me.manage_addr.Size = New System.Drawing.Size(270, 26)
        Me.manage_addr.TabIndex = 31
        '
        'manage_tel
        '
        Me.manage_tel.Location = New System.Drawing.Point(220, 418)
        Me.manage_tel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_tel.Name = "manage_tel"
        Me.manage_tel.Size = New System.Drawing.Size(159, 26)
        Me.manage_tel.TabIndex = 32
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(220, 492)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(282, 26)
        Me.DateTimePicker1.TabIndex = 33
        '
        'manage_sex
        '
        Me.manage_sex.FormattingEnabled = True
        Me.manage_sex.Location = New System.Drawing.Point(220, 572)
        Me.manage_sex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_sex.Name = "manage_sex"
        Me.manage_sex.Size = New System.Drawing.Size(172, 28)
        Me.manage_sex.TabIndex = 34
        '
        'manage_position
        '
        Me.manage_position.Location = New System.Drawing.Point(220, 641)
        Me.manage_position.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_position.Name = "manage_position"
        Me.manage_position.Size = New System.Drawing.Size(159, 26)
        Me.manage_position.TabIndex = 35
        '
        'manage_contract
        '
        Me.manage_contract.FormattingEnabled = True
        Me.manage_contract.Location = New System.Drawing.Point(588, 418)
        Me.manage_contract.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_contract.Name = "manage_contract"
        Me.manage_contract.Size = New System.Drawing.Size(172, 28)
        Me.manage_contract.TabIndex = 36
        '
        'manage_nin
        '
        Me.manage_nin.Location = New System.Drawing.Point(588, 492)
        Me.manage_nin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_nin.Name = "manage_nin"
        Me.manage_nin.Size = New System.Drawing.Size(172, 26)
        Me.manage_nin.TabIndex = 37
        '
        'manage_charn
        '
        Me.manage_charn.Location = New System.Drawing.Point(588, 569)
        Me.manage_charn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.manage_charn.Name = "manage_charn"
        Me.manage_charn.Size = New System.Drawing.Size(172, 26)
        Me.manage_charn.TabIndex = 38
        '
        'ManageStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 562)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
