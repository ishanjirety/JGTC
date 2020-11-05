<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrantRoles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ActiveCmb = New System.Windows.Forms.ComboBox()
        Me.AlyCmb = New System.Windows.Forms.ComboBox()
        Me.PRCmb = New System.Windows.Forms.ComboBox()
        Me.InvCmb = New System.Windows.Forms.ComboBox()
        Me.AccCmb = New System.Windows.Forms.ComboBox()
        Me.billCmb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NameCmb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RoleName = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(613, 40)
        Me.Panel1.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_management_30px
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(12, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Create Roles"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ActiveCmb)
        Me.Panel2.Controls.Add(Me.AlyCmb)
        Me.Panel2.Controls.Add(Me.PRCmb)
        Me.Panel2.Controls.Add(Me.InvCmb)
        Me.Panel2.Controls.Add(Me.AccCmb)
        Me.Panel2.Controls.Add(Me.billCmb)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.NameCmb)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.RoleName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(201, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 348)
        Me.Panel2.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(218, 232)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Cancel"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(162, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(36, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 23)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Apply Changes"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Active Users"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Analytics"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Payroll"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Inventory"
        '
        'ActiveCmb
        '
        Me.ActiveCmb.FormattingEnabled = True
        Me.ActiveCmb.Items.AddRange(New Object() {"False", "True"})
        Me.ActiveCmb.Location = New System.Drawing.Point(137, 183)
        Me.ActiveCmb.Name = "ActiveCmb"
        Me.ActiveCmb.Size = New System.Drawing.Size(130, 21)
        Me.ActiveCmb.TabIndex = 25
        '
        'AlyCmb
        '
        Me.AlyCmb.FormattingEnabled = True
        Me.AlyCmb.Items.AddRange(New Object() {"False", "True"})
        Me.AlyCmb.Location = New System.Drawing.Point(137, 156)
        Me.AlyCmb.Name = "AlyCmb"
        Me.AlyCmb.Size = New System.Drawing.Size(130, 21)
        Me.AlyCmb.TabIndex = 26
        '
        'PRCmb
        '
        Me.PRCmb.FormattingEnabled = True
        Me.PRCmb.Items.AddRange(New Object() {"False", "True"})
        Me.PRCmb.Location = New System.Drawing.Point(137, 129)
        Me.PRCmb.Name = "PRCmb"
        Me.PRCmb.Size = New System.Drawing.Size(130, 21)
        Me.PRCmb.TabIndex = 27
        '
        'InvCmb
        '
        Me.InvCmb.FormattingEnabled = True
        Me.InvCmb.Items.AddRange(New Object() {"False", "True"})
        Me.InvCmb.Location = New System.Drawing.Point(137, 102)
        Me.InvCmb.Name = "InvCmb"
        Me.InvCmb.Size = New System.Drawing.Size(130, 21)
        Me.InvCmb.TabIndex = 28
        '
        'AccCmb
        '
        Me.AccCmb.FormattingEnabled = True
        Me.AccCmb.Items.AddRange(New Object() {"False", "True"})
        Me.AccCmb.Location = New System.Drawing.Point(137, 75)
        Me.AccCmb.Name = "AccCmb"
        Me.AccCmb.Size = New System.Drawing.Size(130, 21)
        Me.AccCmb.TabIndex = 29
        '
        'billCmb
        '
        Me.billCmb.FormattingEnabled = True
        Me.billCmb.Items.AddRange(New Object() {"False", "True"})
        Me.billCmb.Location = New System.Drawing.Point(137, 48)
        Me.billCmb.Name = "billCmb"
        Me.billCmb.Size = New System.Drawing.Size(130, 21)
        Me.billCmb.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Accounts"
        '
        'NameCmb
        '
        Me.NameCmb.Location = New System.Drawing.Point(137, 22)
        Me.NameCmb.Name = "NameCmb"
        Me.NameCmb.Size = New System.Drawing.Size(130, 20)
        Me.NameCmb.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Bills"
        '
        'RoleName
        '
        Me.RoleName.AutoSize = True
        Me.RoleName.Location = New System.Drawing.Point(41, 25)
        Me.RoleName.Name = "RoleName"
        Me.RoleName.Size = New System.Drawing.Size(60, 13)
        Me.RoleName.TabIndex = 23
        Me.RoleName.Text = "Role Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(169, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(218, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(201, 348)
        Me.DataGridView1.TabIndex = 32
        '
        'GrantRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 388)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GrantRoles"
        Me.Text = "GrantRoles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ActiveCmb As ComboBox
    Friend WithEvents AlyCmb As ComboBox
    Friend WithEvents PRCmb As ComboBox
    Friend WithEvents InvCmb As ComboBox
    Friend WithEvents AccCmb As ComboBox
    Friend WithEvents billCmb As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NameCmb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RoleName As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
