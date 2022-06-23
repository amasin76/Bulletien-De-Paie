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
        Me.Crember = New System.Windows.Forms.CheckBox()
        Me.Lincorrect = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.LrePwdStatus = New System.Windows.Forms.Label()
        Me.LcharMin = New System.Windows.Forms.Label()
        Me.LpwdStatus = New System.Windows.Forms.Label()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ZuserNew = New System.Windows.Forms.TextBox()
        Me.Zpwd2New = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Caccepte = New System.Windows.Forms.CheckBox()
        Me.ZpwdNew = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Zuser.ForeColor = System.Drawing.Color.DarkGray
        Me.Zuser.Location = New System.Drawing.Point(68, 126)
        Me.Zuser.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Zuser.Name = "Zuser"
        Me.Zuser.Size = New System.Drawing.Size(260, 29)
        Me.Zuser.TabIndex = 1
        Me.Zuser.Text = "Nom D'Utilisateur"
        '
        'Zpswd
        '
        Me.Zpswd.ForeColor = System.Drawing.Color.DarkGray
        Me.Zpswd.Location = New System.Drawing.Point(68, 189)
        Me.Zpswd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Zpswd.Name = "Zpswd"
        Me.Zpswd.Size = New System.Drawing.Size(260, 29)
        Me.Zpswd.TabIndex = 2
        Me.Zpswd.Text = "Mot De Passe"
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
        Me.Lincorrect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lincorrect.ForeColor = System.Drawing.Color.Red
        Me.Lincorrect.Location = New System.Drawing.Point(65, 254)
        Me.Lincorrect.Name = "Lincorrect"
        Me.Lincorrect.Size = New System.Drawing.Size(0, 15)
        Me.Lincorrect.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.Lincorrect)
        Me.Panel1.Controls.Add(Me.Crember)
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
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.LrePwdStatus)
        Me.Panel3.Controls.Add(Me.LcharMin)
        Me.Panel3.Controls.Add(Me.LpwdStatus)
        Me.Panel3.Controls.Add(Me.Bsave)
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.ZuserNew)
        Me.Panel3.Controls.Add(Me.Zpwd2New)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Caccepte)
        Me.Panel3.Controls.Add(Me.ZpwdNew)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(0, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 466)
        Me.Panel3.TabIndex = 8
        Me.Panel3.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Bulletien_De_Paie.My.Resources.Resources.purpleWavesA90
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(125, 96)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 12
        Me.PictureBox5.TabStop = False
        '
        'LrePwdStatus
        '
        Me.LrePwdStatus.AutoSize = True
        Me.LrePwdStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LrePwdStatus.ForeColor = System.Drawing.Color.White
        Me.LrePwdStatus.Location = New System.Drawing.Point(61, 254)
        Me.LrePwdStatus.Name = "LrePwdStatus"
        Me.LrePwdStatus.Size = New System.Drawing.Size(0, 17)
        Me.LrePwdStatus.TabIndex = 10
        '
        'LcharMin
        '
        Me.LcharMin.AutoSize = True
        Me.LcharMin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LcharMin.ForeColor = System.Drawing.Color.White
        Me.LcharMin.Location = New System.Drawing.Point(61, 206)
        Me.LcharMin.Name = "LcharMin"
        Me.LcharMin.Size = New System.Drawing.Size(0, 17)
        Me.LcharMin.TabIndex = 10
        '
        'LpwdStatus
        '
        Me.LpwdStatus.AutoSize = True
        Me.LpwdStatus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LpwdStatus.ForeColor = System.Drawing.Color.White
        Me.LpwdStatus.Location = New System.Drawing.Point(328, 182)
        Me.LpwdStatus.Name = "LpwdStatus"
        Me.LpwdStatus.Size = New System.Drawing.Size(0, 17)
        Me.LpwdStatus.TabIndex = 9
        '
        'Bsave
        '
        Me.Bsave.Location = New System.Drawing.Point(61, 302)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(260, 36)
        Me.Bsave.TabIndex = 8
        Me.Bsave.Text = "Save"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Bulletien_De_Paie.My.Resources.Resources.x
        Me.PictureBox4.Location = New System.Drawing.Point(346, 18)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'ZuserNew
        '
        Me.ZuserNew.ForeColor = System.Drawing.Color.DarkGray
        Me.ZuserNew.Location = New System.Drawing.Point(61, 126)
        Me.ZuserNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ZuserNew.Name = "ZuserNew"
        Me.ZuserNew.Size = New System.Drawing.Size(260, 29)
        Me.ZuserNew.TabIndex = 1
        Me.ZuserNew.Text = "Nom D'Utilisateur"
        '
        'Zpwd2New
        '
        Me.Zpwd2New.ForeColor = System.Drawing.Color.DarkGray
        Me.Zpwd2New.Location = New System.Drawing.Point(61, 225)
        Me.Zpwd2New.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Zpwd2New.Name = "Zpwd2New"
        Me.Zpwd2New.Size = New System.Drawing.Size(260, 29)
        Me.Zpwd2New.TabIndex = 1
        Me.Zpwd2New.Text = "Répéter Mot De Passe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(40, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 15)
        Me.Label5.TabIndex = 4
        '
        'Caccepte
        '
        Me.Caccepte.AutoSize = True
        Me.Caccepte.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Caccepte.ForeColor = System.Drawing.Color.White
        Me.Caccepte.Location = New System.Drawing.Point(61, 270)
        Me.Caccepte.Name = "Caccepte"
        Me.Caccepte.Size = New System.Drawing.Size(238, 21)
        Me.Caccepte.TabIndex = 5
        Me.Caccepte.Text = " J’accepte les conditions d’utilisation"
        Me.Caccepte.UseVisualStyleBackColor = True
        '
        'ZpwdNew
        '
        Me.ZpwdNew.ForeColor = System.Drawing.Color.DarkGray
        Me.ZpwdNew.Location = New System.Drawing.Point(61, 176)
        Me.ZpwdNew.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ZpwdNew.Name = "ZpwdNew"
        Me.ZpwdNew.Size = New System.Drawing.Size(260, 29)
        Me.ZpwdNew.TabIndex = 1
        Me.ZpwdNew.Text = "Mot De Passe"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Bulletien_De_Paie.My.Resources.Resources.purpleWavesA
        Me.PictureBox3.Location = New System.Drawing.Point(255, 370)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(125, 96)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Bulletien_De_Paie.My.Resources.Resources.purpleWavesA90
        Me.PictureBox7.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(125, 96)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 8
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Bulletien_De_Paie.My.Resources.Resources.purpleWavesA
        Me.PictureBox6.Location = New System.Drawing.Point(255, 370)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(125, 96)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 7
        Me.PictureBox6.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(153, 355)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 17)
        Me.LinkLabel1.TabIndex = 6
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Create Account"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(307, 221)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 466)
        Me.Panel2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(307, 58)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "La gestion des employés n'est plus un casse-tête."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(122, 111)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 65)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TECH"
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Bulletien_De_Paie.My.Resources.Resources.purple_waves
        Me.PictureBox2.Location = New System.Drawing.Point(0, 169)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(388, 317)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(760, 466)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Blogin As System.Windows.Forms.Button
    Friend WithEvents Zuser As System.Windows.Forms.TextBox
    Friend WithEvents Zpswd As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Crember As System.Windows.Forms.CheckBox
    Friend WithEvents Lincorrect As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ZuserNew As System.Windows.Forms.TextBox
    Friend WithEvents ZpwdNew As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Caccepte As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Zpwd2New As System.Windows.Forms.TextBox
    Friend WithEvents Bsave As System.Windows.Forms.Button
    Friend WithEvents LpwdStatus As System.Windows.Forms.Label
    Friend WithEvents LcharMin As System.Windows.Forms.Label
    Friend WithEvents LrePwdStatus As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
End Class
