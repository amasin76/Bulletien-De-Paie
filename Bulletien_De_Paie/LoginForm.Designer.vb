<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.Blogin = New System.Windows.Forms.Button()
        Me.Zuser = New System.Windows.Forms.TextBox()
        Me.Zpswd = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Crember = New System.Windows.Forms.CheckBox()
        Me.Lincorrect = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Blogin
        '
        Me.Blogin.Location = New System.Drawing.Point(68, 289)
        Me.Blogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Blogin.Name = "Blogin"
        Me.Blogin.Size = New System.Drawing.Size(260, 36)
        Me.Blogin.TabIndex = 0
        Me.Blogin.Text = "Login"
        Me.Blogin.UseVisualStyleBackColor = True
        '
        'Zuser
        '
        Me.Zuser.Location = New System.Drawing.Point(68, 126)
        Me.Zuser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Zuser.Name = "Zuser"
        Me.Zuser.Size = New System.Drawing.Size(260, 29)
        Me.Zuser.TabIndex = 1
        '
        'Zpswd
        '
        Me.Zpswd.Location = New System.Drawing.Point(68, 189)
        Me.Zpswd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Zpswd.Name = "Zpswd"
        Me.Zpswd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Zpswd.Size = New System.Drawing.Size(260, 29)
        Me.Zpswd.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bulletien_De_Paie.My.Resources.Resources.eye
        Me.PictureBox1.Location = New System.Drawing.Point(307, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(156, 348)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Create Account"
        '
        'Crember
        '
        Me.Crember.AutoSize = True
        Me.Crember.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Crember.ForeColor = System.Drawing.Color.White
        Me.Crember.Location = New System.Drawing.Point(68, 226)
        Me.Crember.Name = "Crember"
        Me.Crember.Size = New System.Drawing.Size(113, 21)
        Me.Crember.TabIndex = 5
        Me.Crember.Text = "Remember me"
        Me.Crember.UseVisualStyleBackColor = True
        '
        'Lincorrect
        '
        Me.Lincorrect.AutoSize = True
        Me.Lincorrect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lincorrect.ForeColor = System.Drawing.Color.Red
        Me.Lincorrect.Location = New System.Drawing.Point(249, 293)
        Me.Lincorrect.Name = "Lincorrect"
        Me.Lincorrect.Size = New System.Drawing.Size(0, 17)
        Me.Lincorrect.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Crember)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Blogin)
        Me.Panel1.Controls.Add(Me.Zpswd)
        Me.Panel1.Controls.Add(Me.Zuser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(380, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 466)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Lincorrect)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 466)
        Me.Panel2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(30, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 65)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "BIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(123, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 65)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TECH"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Blogin As System.Windows.Forms.Button
    Friend WithEvents Zuser As System.Windows.Forms.TextBox
    Friend WithEvents Zpswd As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Crember As System.Windows.Forms.CheckBox
    Friend WithEvents Lincorrect As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
