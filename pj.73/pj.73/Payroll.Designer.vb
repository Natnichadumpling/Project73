<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payroll
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Lable4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pay_base = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pay_staffid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.pay_number = New System.Windows.Forms.TextBox()
        Me.pay_method = New System.Windows.Forms.ComboBox()
        Me.pay_name = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(596, 354)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 44)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.LightBlue
        Me.btnAdd.Location = New System.Drawing.Point(489, 354)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 44)
        Me.btnAdd.TabIndex = 30
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(388, 354)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 44)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Lable4
        '
        Me.Lable4.AutoSize = True
        Me.Lable4.Location = New System.Drawing.Point(256, 245)
        Me.Lable4.Name = "Lable4"
        Me.Lable4.Size = New System.Drawing.Size(96, 20)
        Me.Lable4.TabIndex = 27
        Me.Lable4.Text = " Bank Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Pay_Method"
        '
        'pay_base
        '
        Me.pay_base.Location = New System.Drawing.Point(354, 109)
        Me.pay_base.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pay_base.Name = "pay_base"
        Me.pay_base.Size = New System.Drawing.Size(159, 26)
        Me.pay_base.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Base_Salary"
        '
        'pay_staffid
        '
        Me.pay_staffid.Location = New System.Drawing.Point(354, 36)
        Me.pay_staffid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pay_staffid.Name = "pay_staffid"
        Me.pay_staffid.Size = New System.Drawing.Size(159, 26)
        Me.pay_staffid.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(282, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Staff ID"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(550, 30)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 30)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'pay_number
        '
        Me.pay_number.Location = New System.Drawing.Point(354, 299)
        Me.pay_number.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pay_number.Name = "pay_number"
        Me.pay_number.Size = New System.Drawing.Size(157, 26)
        Me.pay_number.TabIndex = 32
        '
        'pay_method
        '
        Me.pay_method.FormattingEnabled = True
        Me.pay_method.Location = New System.Drawing.Point(354, 169)
        Me.pay_method.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pay_method.Name = "pay_method"
        Me.pay_method.Size = New System.Drawing.Size(155, 28)
        Me.pay_method.TabIndex = 33
        '
        'pay_name
        '
        Me.pay_name.FormattingEnabled = True
        Me.pay_name.Location = New System.Drawing.Point(354, 235)
        Me.pay_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pay_name.Name = "pay_name"
        Me.pay_name.Size = New System.Drawing.Size(155, 28)
        Me.pay_name.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = " Bank Number"
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 562)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pay_name)
        Me.Controls.Add(Me.pay_method)
        Me.Controls.Add(Me.pay_number)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Lable4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pay_base)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pay_staffid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Payroll"
        Me.Text = "Payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents Lable4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pay_base As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pay_staffid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents pay_number As TextBox
    Friend WithEvents pay_method As ComboBox
    Friend WithEvents pay_name As ComboBox
    Friend WithEvents Label4 As Label
End Class
