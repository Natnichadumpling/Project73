<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffList
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
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.list_filter = New System.Windows.Forms.ComboBox()
        Me.list_src = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFilter
        '
        Me.btnFilter.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFilter.Location = New System.Drawing.Point(605, 29)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(78, 24)
        Me.btnFilter.TabIndex = 17
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = False
        '
        'list_filter
        '
        Me.list_filter.FormattingEnabled = True
        Me.list_filter.Location = New System.Drawing.Point(475, 29)
        Me.list_filter.Name = "list_filter"
        Me.list_filter.Size = New System.Drawing.Size(124, 24)
        Me.list_filter.TabIndex = 16
        '
        'list_src
        '
        Me.list_src.Location = New System.Drawing.Point(145, 29)
        Me.list_src.Name = "list_src"
        Me.list_src.Size = New System.Drawing.Size(142, 22)
        Me.list_src.TabIndex = 15
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(293, 28)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(78, 24)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'StaffList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.list_filter)
        Me.Controls.Add(Me.list_src)
        Me.Controls.Add(Me.btnSearch)
        Me.Name = "StaffList"
        Me.Text = "StaffList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFilter As Button
    Friend WithEvents list_filter As ComboBox
    Friend WithEvents list_src As TextBox
    Friend WithEvents btnSearch As Button
End Class
