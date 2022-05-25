<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEmployeDetails
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
        Me.Znen_dt = New System.Windows.Forms.TextBox()
        Me.Zdem_dt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Zemail_dt = New System.Windows.Forms.TextBox()
        Me.Ztel_dt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Zvil_dt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Zadrs_dt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Zfn_dt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Znpr_dt = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Zmat_dt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelAction = New System.Windows.Forms.Panel()
        Me.Bdelete = New System.Windows.Forms.Button()
        Me.Bsave = New System.Windows.Forms.Button()
        Me.Bedit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'Znen_dt
        '
        Me.Znen_dt.Enabled = False
        Me.Znen_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Znen_dt.Location = New System.Drawing.Point(217, 338)
        Me.Znen_dt.Name = "Znen_dt"
        Me.Znen_dt.Size = New System.Drawing.Size(183, 29)
        Me.Znen_dt.TabIndex = 20
        '
        'Zdem_dt
        '
        Me.Zdem_dt.Enabled = False
        Me.Zdem_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zdem_dt.Location = New System.Drawing.Point(217, 303)
        Me.Zdem_dt.Name = "Zdem_dt"
        Me.Zdem_dt.Size = New System.Drawing.Size(183, 29)
        Me.Zdem_dt.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Matricule "
        '
        'Zemail_dt
        '
        Me.Zemail_dt.Enabled = False
        Me.Zemail_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zemail_dt.Location = New System.Drawing.Point(216, 232)
        Me.Zemail_dt.Name = "Zemail_dt"
        Me.Zemail_dt.Size = New System.Drawing.Size(183, 29)
        Me.Zemail_dt.TabIndex = 17
        '
        'Ztel_dt
        '
        Me.Ztel_dt.Enabled = False
        Me.Ztel_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ztel_dt.Location = New System.Drawing.Point(217, 268)
        Me.Ztel_dt.Name = "Ztel_dt"
        Me.Ztel_dt.Size = New System.Drawing.Size(183, 29)
        Me.Ztel_dt.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nom / Prenom "
        '
        'Zvil_dt
        '
        Me.Zvil_dt.Enabled = False
        Me.Zvil_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zvil_dt.Location = New System.Drawing.Point(217, 196)
        Me.Zvil_dt.Name = "Zvil_dt"
        Me.Zvil_dt.Size = New System.Drawing.Size(183, 29)
        Me.Zvil_dt.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fonction "
        '
        'Zadrs_dt
        '
        Me.Zadrs_dt.Enabled = False
        Me.Zadrs_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zadrs_dt.Location = New System.Drawing.Point(217, 161)
        Me.Zadrs_dt.Multiline = True
        Me.Zadrs_dt.Name = "Zadrs_dt"
        Me.Zadrs_dt.Size = New System.Drawing.Size(183, 29)
        Me.Zadrs_dt.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(45, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Adresse "
        '
        'Zfn_dt
        '
        Me.Zfn_dt.Enabled = False
        Me.Zfn_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zfn_dt.Location = New System.Drawing.Point(217, 126)
        Me.Zfn_dt.Name = "Zfn_dt"
        Me.Zfn_dt.Size = New System.Drawing.Size(183, 29)
        Me.Zfn_dt.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Ville "
        '
        'Znpr_dt
        '
        Me.Znpr_dt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Znpr_dt.Enabled = False
        Me.Znpr_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Znpr_dt.Location = New System.Drawing.Point(217, 91)
        Me.Znpr_dt.Name = "Znpr_dt"
        Me.Znpr_dt.Size = New System.Drawing.Size(183, 29)
        Me.Znpr_dt.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(44, 240)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 21)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(45, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Telephone "
        '
        'Zmat_dt
        '
        Me.Zmat_dt.Enabled = False
        Me.Zmat_dt.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Zmat_dt.Location = New System.Drawing.Point(217, 56)
        Me.Zmat_dt.Name = "Zmat_dt"
        Me.Zmat_dt.Size = New System.Drawing.Size(183, 29)
        Me.Zmat_dt.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(45, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 21)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Date d'embauche "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 346)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 21)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Nombre d'enfant "
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(636, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 134)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'PanelAction
        '
        Me.PanelAction.Controls.Add(Me.Bdelete)
        Me.PanelAction.Controls.Add(Me.Bsave)
        Me.PanelAction.Controls.Add(Me.Bedit)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAction.Location = New System.Drawing.Point(0, 437)
        Me.PanelAction.Name = "PanelAction"
        Me.PanelAction.Size = New System.Drawing.Size(827, 104)
        Me.PanelAction.TabIndex = 22
        '
        'Bdelete
        '
        Me.Bdelete.Location = New System.Drawing.Point(573, 22)
        Me.Bdelete.Name = "Bdelete"
        Me.Bdelete.Size = New System.Drawing.Size(205, 61)
        Me.Bdelete.TabIndex = 0
        Me.Bdelete.Text = "Supprimer"
        Me.Bdelete.UseVisualStyleBackColor = True
        '
        'Bsave
        '
        Me.Bsave.Location = New System.Drawing.Point(311, 22)
        Me.Bsave.Name = "Bsave"
        Me.Bsave.Size = New System.Drawing.Size(205, 61)
        Me.Bsave.TabIndex = 0
        Me.Bsave.Text = "Enregistrer"
        Me.Bsave.UseVisualStyleBackColor = True
        '
        'Bedit
        '
        Me.Bedit.Location = New System.Drawing.Point(49, 22)
        Me.Bedit.Name = "Bedit"
        Me.Bedit.Size = New System.Drawing.Size(205, 61)
        Me.Bedit.TabIndex = 0
        Me.Bedit.Text = "Modifier"
        Me.Bedit.UseVisualStyleBackColor = True
        '
        'formEmployeDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 541)
        Me.Controls.Add(Me.PanelAction)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Znen_dt)
        Me.Controls.Add(Me.Zdem_dt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Zemail_dt)
        Me.Controls.Add(Me.Ztel_dt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Zvil_dt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Zadrs_dt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Zfn_dt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Znpr_dt)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Zmat_dt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Name = "formEmployeDetails"
        Me.Text = "formEmployeDetails"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAction.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Znen_dt As TextBox
    Friend WithEvents Zdem_dt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Zemail_dt As TextBox
    Friend WithEvents Ztel_dt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Zvil_dt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Zadrs_dt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Zfn_dt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Znpr_dt As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Zmat_dt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelAction As Panel
    Friend WithEvents Bdelete As Button
    Friend WithEvents Bsave As Button
    Friend WithEvents Bedit As Button
End Class
