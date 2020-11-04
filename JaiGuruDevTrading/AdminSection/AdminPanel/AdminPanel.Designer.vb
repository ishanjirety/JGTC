<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPanel
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
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.Btn_Dump = New System.Windows.Forms.Button()
        Me.Btn_Truncate = New System.Windows.Forms.Button()
        Me.Btn_Create = New System.Windows.Forms.Button()
        Me.Btn_logs = New System.Windows.Forms.Button()
        Me.Btn_roles = New System.Windows.Forms.Button()
        Me.Btn_Usr = New System.Windows.Forms.Button()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.PanelControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelControl
        '
        Me.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelControl.Controls.Add(Me.Btn_Dump)
        Me.PanelControl.Controls.Add(Me.Btn_Truncate)
        Me.PanelControl.Controls.Add(Me.Btn_Create)
        Me.PanelControl.Controls.Add(Me.Btn_logs)
        Me.PanelControl.Controls.Add(Me.Btn_roles)
        Me.PanelControl.Controls.Add(Me.Btn_Usr)
        Me.PanelControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(180, 450)
        Me.PanelControl.TabIndex = 16
        '
        'Btn_Dump
        '
        Me.Btn_Dump.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Dump.FlatAppearance.BorderSize = 0
        Me.Btn_Dump.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Dump.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Dump.Location = New System.Drawing.Point(0, 155)
        Me.Btn_Dump.Name = "Btn_Dump"
        Me.Btn_Dump.Size = New System.Drawing.Size(178, 31)
        Me.Btn_Dump.TabIndex = 0
        Me.Btn_Dump.Text = "Dump DB"
        Me.Btn_Dump.UseVisualStyleBackColor = True
        '
        'Btn_Truncate
        '
        Me.Btn_Truncate.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Truncate.FlatAppearance.BorderSize = 0
        Me.Btn_Truncate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Truncate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Truncate.Location = New System.Drawing.Point(0, 124)
        Me.Btn_Truncate.Name = "Btn_Truncate"
        Me.Btn_Truncate.Size = New System.Drawing.Size(178, 31)
        Me.Btn_Truncate.TabIndex = 0
        Me.Btn_Truncate.Text = "Truncate Table"
        Me.Btn_Truncate.UseVisualStyleBackColor = True
        '
        'Btn_Create
        '
        Me.Btn_Create.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Create.FlatAppearance.BorderSize = 0
        Me.Btn_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Create.Location = New System.Drawing.Point(0, 93)
        Me.Btn_Create.Name = "Btn_Create"
        Me.Btn_Create.Size = New System.Drawing.Size(178, 31)
        Me.Btn_Create.TabIndex = 4
        Me.Btn_Create.Text = "Create User"
        Me.Btn_Create.UseVisualStyleBackColor = True
        '
        'Btn_logs
        '
        Me.Btn_logs.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_logs.FlatAppearance.BorderSize = 0
        Me.Btn_logs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_logs.Location = New System.Drawing.Point(0, 62)
        Me.Btn_logs.Name = "Btn_logs"
        Me.Btn_logs.Size = New System.Drawing.Size(178, 31)
        Me.Btn_logs.TabIndex = 0
        Me.Btn_logs.Text = "Logs"
        Me.Btn_logs.UseVisualStyleBackColor = True
        '
        'Btn_roles
        '
        Me.Btn_roles.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_roles.FlatAppearance.BorderSize = 0
        Me.Btn_roles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_roles.Location = New System.Drawing.Point(0, 31)
        Me.Btn_roles.Name = "Btn_roles"
        Me.Btn_roles.Size = New System.Drawing.Size(178, 31)
        Me.Btn_roles.TabIndex = 1
        Me.Btn_roles.Text = "Roles"
        Me.Btn_roles.UseVisualStyleBackColor = True
        '
        'Btn_Usr
        '
        Me.Btn_Usr.Dock = System.Windows.Forms.DockStyle.Top
        Me.Btn_Usr.FlatAppearance.BorderSize = 0
        Me.Btn_Usr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Usr.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Usr.Name = "Btn_Usr"
        Me.Btn_Usr.Size = New System.Drawing.Size(178, 31)
        Me.Btn_Usr.TabIndex = 0
        Me.Btn_Usr.Text = "UserManagement"
        Me.Btn_Usr.UseVisualStyleBackColor = True
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(180, 0)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(620, 450)
        Me.PanelContent.TabIndex = 17
        '
        'AdminPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.PanelControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdminPanel"
        Me.Text = "AdminPanel"
        Me.PanelControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl As Panel
    Friend WithEvents Btn_roles As Button
    Friend WithEvents Btn_Usr As Button
    Friend WithEvents Btn_logs As Button
    Friend WithEvents PanelContent As Panel
    Friend WithEvents Btn_Create As Button
    Friend WithEvents Btn_Truncate As Button
    Friend WithEvents Btn_Dump As Button
End Class
