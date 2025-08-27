<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Out_Patient_Report
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Filter :"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(329, 19)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightGreen
        Me.Button1.Location = New System.Drawing.Point(200, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 33)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(80, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Patient ID:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGreen
        Me.Button2.Location = New System.Drawing.Point(449, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 33)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Out_Patient_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 624)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Out_Patient_Report"
        Me.Text = "Out_Patient_Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
