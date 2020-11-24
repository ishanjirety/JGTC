<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepriciationMethod
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Btn_SET = New System.Windows.Forms.Button()
        Me.Btn_Cancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Image = Global.JaiGuruDevTrading.My.Resources.Resources.icons8_general_ledger_30
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SET DEPRICIATION METHOD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SELECT DEPRICIATION METHOD"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"WDVM", "SLM"})
        Me.ComboBox1.Location = New System.Drawing.Point(209, 81)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(124, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.White
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(19, 128)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(314, 96)
        Me.RichTextBox1.TabIndex = 3
        Me.RichTextBox1.Text = "* WDVM : WRITTEN DOWN VALUE METHOD" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "* SLM : STRAIGHT LINE METHOD"
        '
        'Btn_SET
        '
        Me.Btn_SET.FlatAppearance.BorderSize = 0
        Me.Btn_SET.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_SET.Location = New System.Drawing.Point(19, 222)
        Me.Btn_SET.Name = "Btn_SET"
        Me.Btn_SET.Size = New System.Drawing.Size(174, 23)
        Me.Btn_SET.TabIndex = 4
        Me.Btn_SET.Text = "SET"
        Me.Btn_SET.UseVisualStyleBackColor = True
        '
        'Btn_Cancel
        '
        Me.Btn_Cancel.FlatAppearance.BorderSize = 0
        Me.Btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Cancel.Location = New System.Drawing.Point(209, 222)
        Me.Btn_Cancel.Name = "Btn_Cancel"
        Me.Btn_Cancel.Size = New System.Drawing.Size(174, 23)
        Me.Btn_Cancel.TabIndex = 4
        Me.Btn_Cancel.Text = "CANCEL"
        Me.Btn_Cancel.UseVisualStyleBackColor = True
        '
        'DepriciationMethod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_Cancel)
        Me.Controls.Add(Me.Btn_SET)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DepriciationMethod"
        Me.Text = "labe"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Btn_SET As Button
    Friend WithEvents Btn_Cancel As Button
End Class
