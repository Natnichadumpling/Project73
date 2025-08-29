<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageRequisition
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
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.manage_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.manage_amout = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.manage_supplyname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.manage_supplyid = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.manage_wardid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(530, 645)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 42)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOrder.Location = New System.Drawing.Point(351, 645)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(104, 42)
        Me.btnOrder.TabIndex = 55
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'manage_type
        '
        Me.manage_type.FormattingEnabled = True
        Me.manage_type.Location = New System.Drawing.Point(387, 237)
        Me.manage_type.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.manage_type.Name = "manage_type"
        Me.manage_type.Size = New System.Drawing.Size(217, 28)
        Me.manage_type.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 322)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Amount"
        '
        'manage_amout
        '
        Me.manage_amout.Location = New System.Drawing.Point(387, 317)
        Me.manage_amout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.manage_amout.Name = "manage_amout"
        Me.manage_amout.Size = New System.Drawing.Size(217, 26)
        Me.manage_amout.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 237)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Supply Name"
        '
        'manage_supplyname
        '
        Me.manage_supplyname.Location = New System.Drawing.Point(387, 155)
        Me.manage_supplyname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.manage_supplyname.Name = "manage_supplyname"
        Me.manage_supplyname.Size = New System.Drawing.Size(217, 26)
        Me.manage_supplyname.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Supply ID"
        '
        'manage_supplyid
        '
        Me.manage_supplyid.Location = New System.Drawing.Point(387, 80)
        Me.manage_supplyid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.manage_supplyid.Name = "manage_supplyid"
        Me.manage_supplyid.Size = New System.Drawing.Size(217, 26)
        Me.manage_supplyid.TabIndex = 47
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(636, 6)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(136, 42)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'manage_wardid
        '
        Me.manage_wardid.Location = New System.Drawing.Point(387, 12)
        Me.manage_wardid.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.manage_wardid.Name = "manage_wardid"
        Me.manage_wardid.Size = New System.Drawing.Size(217, 26)
        Me.manage_wardid.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(297, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = " Ward ID"
        '
        'ManageRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 562)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.manage_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.manage_amout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.manage_supplyname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.manage_supplyid)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.manage_wardid)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ManageRequisition"
        Me.Text = "ManageRequsition"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents manage_type As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents manage_amout As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents manage_supplyname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents manage_supplyid As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents manage_wardid As TextBox
    Friend WithEvents Label1 As Label
End Class
