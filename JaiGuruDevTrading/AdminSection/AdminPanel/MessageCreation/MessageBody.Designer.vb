<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageBody
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CancelMsg = New System.Windows.Forms.Button()
        Me.CreateMSG = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_group_message_24px
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label3.Location = New System.Drawing.Point(3, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "CREATE RETAIL MESSAGE"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CancelMsg)
        Me.Panel2.Controls.Add(Me.CreateMSG)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 46)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(676, 404)
        Me.Panel2.TabIndex = 1
        '
        'CancelMsg
        '
        Me.CancelMsg.FlatAppearance.BorderSize = 0
        Me.CancelMsg.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelMsg.Location = New System.Drawing.Point(248, 314)
        Me.CancelMsg.Name = "CancelMsg"
        Me.CancelMsg.Size = New System.Drawing.Size(129, 23)
        Me.CancelMsg.TabIndex = 4
        Me.CancelMsg.Text = "CANCEL"
        Me.CancelMsg.UseVisualStyleBackColor = True
        '
        'CreateMSG
        '
        Me.CreateMSG.FlatAppearance.BorderSize = 0
        Me.CreateMSG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CreateMSG.Location = New System.Drawing.Point(101, 314)
        Me.CreateMSG.Name = "CreateMSG"
        Me.CreateMSG.Size = New System.Drawing.Size(129, 23)
        Me.CreateMSG.TabIndex = 4
        Me.CreateMSG.Text = "CREATE"
        Me.CreateMSG.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(101, 249)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(497, 22)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "कृपया राशि के स्थान पर '&' दर्ज करें"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(101, 225)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(497, 15)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "PLEASE ENTER  '&'  IN PLACE OF AMOUNT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(101, 37)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(497, 178)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message Body"
        '
        'MessageBody
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(676, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MessageBody"
        Me.Text = "MessageBody"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CreateMSG As Button
    Friend WithEvents CancelMsg As Button
End Class
