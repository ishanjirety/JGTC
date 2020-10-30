<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserCreationvb
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.UsernameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RePasswordTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoleCmb = New System.Windows.Forms.ComboBox()
        Me.Role = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 34)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(577, 18)
        Me.Panel4.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(577, 34)
        Me.Panel3.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_multiply_24__1_
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(551, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(21, 24)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackgroundImage = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_minus_24
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_minus_24__1_
        Me.Button3.Location = New System.Drawing.Point(524, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(21, 25)
        Me.Button3.TabIndex = 1
        Me.Button3.UseVisualStyleBackColor = True
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Location = New System.Drawing.Point(264, 94)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.Size = New System.Drawing.Size(206, 20)
        Me.UsernameTxt.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Username"
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(264, 127)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(206, 20)
        Me.PasswordTxt.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'RePasswordTxt
        '
        Me.RePasswordTxt.Location = New System.Drawing.Point(264, 165)
        Me.RePasswordTxt.Name = "RePasswordTxt"
        Me.RePasswordTxt.Size = New System.Drawing.Size(206, 20)
        Me.RePasswordTxt.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(126, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Re-Enter Password"
        '
        'RoleCmb
        '
        Me.RoleCmb.FormattingEnabled = True
        Me.RoleCmb.Location = New System.Drawing.Point(264, 205)
        Me.RoleCmb.Name = "RoleCmb"
        Me.RoleCmb.Size = New System.Drawing.Size(206, 21)
        Me.RoleCmb.TabIndex = 12
        '
        'Role
        '
        Me.Role.AutoSize = True
        Me.Role.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Role.Location = New System.Drawing.Point(126, 204)
        Me.Role.Name = "Role"
        Me.Role.Size = New System.Drawing.Size(38, 19)
        Me.Role.TabIndex = 11
        Me.Role.Text = "Role"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(234, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(337, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(97, 23)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Create"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'UserCreationvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 367)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RoleCmb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Role)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RePasswordTxt)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.UsernameTxt)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserCreationvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserCreationvb"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents UsernameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RePasswordTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoleCmb As ComboBox
    Friend WithEvents Role As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
