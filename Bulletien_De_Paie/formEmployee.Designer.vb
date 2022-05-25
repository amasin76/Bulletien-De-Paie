<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEmployee
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabAjoute = New System.Windows.Forms.TabPage()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.LcnxState = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Znen = New System.Windows.Forms.TextBox()
        Me.Zdem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Zemail = New System.Windows.Forms.TextBox()
        Me.Ztel = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Zvil = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Zadrs = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Zfn = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Znpr = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Zmat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelAction = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Bajoute = New System.Windows.Forms.Button()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabConsulter = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Bannuler_sr = New System.Windows.Forms.Button()
        Me.Brechercher = New System.Windows.Forms.Button()
        Me.PanelGrid = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LrowsCount = New System.Windows.Forms.Label()
        Me.BtableLast = New System.Windows.Forms.Button()
        Me.BtableNext = New System.Windows.Forms.Button()
        Me.BtableFirst = New System.Windows.Forms.Button()
        Me.BtablePrev = New System.Windows.Forms.Button()
        Me.PanelBoxes = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Zsearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Employee_dbDataSet = New Bulletien_De_Paie.employee_dbDataSet()
        Me.EmployeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeTableAdapter = New Bulletien_De_Paie.employee_dbDataSetTableAdapters.EmployeTableAdapter()
        Me.MatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomPrenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FonctionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VilleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DEMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnfantsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.CVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRecDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabAjoute.SuspendLayout()
        Me.PanelMain.SuspendLayout()
        Me.PanelAction.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.TabConsulter.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelGrid.SuspendLayout()
        Me.PanelBoxes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabAjoute)
        Me.TabControl1.Controls.Add(Me.TabConsulter)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(914, 633)
        Me.TabControl1.TabIndex = 0
        '
        'TabAjoute
        '
        Me.TabAjoute.Controls.Add(Me.PanelMain)
        Me.TabAjoute.Controls.Add(Me.PanelAction)
        Me.TabAjoute.Controls.Add(Me.PanelTitle)
        Me.TabAjoute.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabAjoute.Location = New System.Drawing.Point(4, 30)
        Me.TabAjoute.Name = "TabAjoute"
        Me.TabAjoute.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAjoute.Size = New System.Drawing.Size(906, 599)
        Me.TabAjoute.TabIndex = 0
        Me.TabAjoute.Text = "Ajouter"
        Me.TabAjoute.UseVisualStyleBackColor = True
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.LcnxState)
        Me.PanelMain.Controls.Add(Me.Label24)
        Me.PanelMain.Controls.Add(Me.Label23)
        Me.PanelMain.Controls.Add(Me.Label22)
        Me.PanelMain.Controls.Add(Me.Label21)
        Me.PanelMain.Controls.Add(Me.Label20)
        Me.PanelMain.Controls.Add(Me.Label19)
        Me.PanelMain.Controls.Add(Me.Znen)
        Me.PanelMain.Controls.Add(Me.Zdem)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.Zemail)
        Me.PanelMain.Controls.Add(Me.Ztel)
        Me.PanelMain.Controls.Add(Me.Label3)
        Me.PanelMain.Controls.Add(Me.Zvil)
        Me.PanelMain.Controls.Add(Me.Label4)
        Me.PanelMain.Controls.Add(Me.Zadrs)
        Me.PanelMain.Controls.Add(Me.Label5)
        Me.PanelMain.Controls.Add(Me.Zfn)
        Me.PanelMain.Controls.Add(Me.Label6)
        Me.PanelMain.Controls.Add(Me.Znpr)
        Me.PanelMain.Controls.Add(Me.Label25)
        Me.PanelMain.Controls.Add(Me.Label7)
        Me.PanelMain.Controls.Add(Me.Zmat)
        Me.PanelMain.Controls.Add(Me.Label8)
        Me.PanelMain.Controls.Add(Me.Label9)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(3, 52)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(900, 440)
        Me.PanelMain.TabIndex = 8
        '
        'LcnxState
        '
        Me.LcnxState.AutoSize = True
        Me.LcnxState.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LcnxState.Location = New System.Drawing.Point(805, 48)
        Me.LcnxState.Name = "LcnxState"
        Me.LcnxState.Size = New System.Drawing.Size(0, 21)
        Me.LcnxState.TabIndex = 9
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(691, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(120, 21)
        Me.Label24.TabIndex = 8
        Me.Label24.Text = "Base Donnees :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label23.Location = New System.Drawing.Point(10, 445)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(158, 13)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "[ ] : les conditions de champs"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label22.Location = New System.Drawing.Point(10, 424)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(117, 13)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = " *  :  champs optional"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(429, 379)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 21)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "CV * [ pdf ]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(429, 97)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(174, 21)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Photo * [ max : 256ko ]"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 21)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Entrez les donnes"
        '
        'Znen
        '
        Me.Znen.Location = New System.Drawing.Point(181, 371)
        Me.Znen.Name = "Znen"
        Me.Znen.Size = New System.Drawing.Size(183, 29)
        Me.Znen.TabIndex = 2
        '
        'Zdem
        '
        Me.Zdem.Location = New System.Drawing.Point(181, 336)
        Me.Zdem.Name = "Zdem"
        Me.Zdem.Size = New System.Drawing.Size(183, 29)
        Me.Zdem.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Matricule "
        '
        'Zemail
        '
        Me.Zemail.Location = New System.Drawing.Point(180, 265)
        Me.Zemail.Name = "Zemail"
        Me.Zemail.Size = New System.Drawing.Size(183, 29)
        Me.Zemail.TabIndex = 2
        '
        'Ztel
        '
        Me.Ztel.Location = New System.Drawing.Point(181, 301)
        Me.Ztel.Name = "Ztel"
        Me.Ztel.Size = New System.Drawing.Size(183, 29)
        Me.Ztel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nom / Prenom "
        '
        'Zvil
        '
        Me.Zvil.Location = New System.Drawing.Point(181, 229)
        Me.Zvil.Name = "Zvil"
        Me.Zvil.Size = New System.Drawing.Size(183, 29)
        Me.Zvil.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fonction "
        '
        'Zadrs
        '
        Me.Zadrs.Location = New System.Drawing.Point(181, 194)
        Me.Zadrs.Multiline = True
        Me.Zadrs.Name = "Zadrs"
        Me.Zadrs.Size = New System.Drawing.Size(183, 29)
        Me.Zadrs.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Adresse "
        '
        'Zfn
        '
        Me.Zfn.Location = New System.Drawing.Point(181, 159)
        Me.Zfn.Name = "Zfn"
        Me.Zfn.Size = New System.Drawing.Size(183, 29)
        Me.Zfn.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 237)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ville "
        '
        'Znpr
        '
        Me.Znpr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Znpr.Location = New System.Drawing.Point(181, 124)
        Me.Znpr.Name = "Znpr"
        Me.Znpr.Size = New System.Drawing.Size(183, 29)
        Me.Znpr.TabIndex = 2
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 273)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(48, 21)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Telephone "
        '
        'Zmat
        '
        Me.Zmat.Location = New System.Drawing.Point(181, 89)
        Me.Zmat.Name = "Zmat"
        Me.Zmat.Size = New System.Drawing.Size(183, 29)
        Me.Zmat.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 21)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Date d'embauche "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 379)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Nombre d'enfant "
        '
        'PanelAction
        '
        Me.PanelAction.Controls.Add(Me.Button3)
        Me.PanelAction.Controls.Add(Me.Button2)
        Me.PanelAction.Controls.Add(Me.Bajoute)
        Me.PanelAction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelAction.Location = New System.Drawing.Point(3, 492)
        Me.PanelAction.Name = "PanelAction"
        Me.PanelAction.Size = New System.Drawing.Size(900, 104)
        Me.PanelAction.TabIndex = 7
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(621, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(205, 61)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Actualiser"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(359, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 61)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Bajoute
        '
        Me.Bajoute.Location = New System.Drawing.Point(97, 22)
        Me.Bajoute.Name = "Bajoute"
        Me.Bajoute.Size = New System.Drawing.Size(205, 61)
        Me.Bajoute.TabIndex = 0
        Me.Bajoute.Text = "Ajouter"
        Me.Bajoute.UseVisualStyleBackColor = True
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.Label1)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(3, 3)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(900, 49)
        Me.PanelTitle.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saisi d'un nouveau employe"
        '
        'TabConsulter
        '
        Me.TabConsulter.Controls.Add(Me.Panel2)
        Me.TabConsulter.Controls.Add(Me.PanelGrid)
        Me.TabConsulter.Controls.Add(Me.PanelBoxes)
        Me.TabConsulter.Controls.Add(Me.Panel1)
        Me.TabConsulter.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulter.Location = New System.Drawing.Point(4, 30)
        Me.TabConsulter.Name = "TabConsulter"
        Me.TabConsulter.Padding = New System.Windows.Forms.Padding(3)
        Me.TabConsulter.Size = New System.Drawing.Size(906, 599)
        Me.TabConsulter.TabIndex = 1
        Me.TabConsulter.Text = "Consulter"
        Me.TabConsulter.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Bannuler_sr)
        Me.Panel2.Controls.Add(Me.Brechercher)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(3, 492)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(900, 104)
        Me.Panel2.TabIndex = 12
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(621, 22)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(205, 61)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Actualiser"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Bannuler_sr
        '
        Me.Bannuler_sr.Location = New System.Drawing.Point(359, 22)
        Me.Bannuler_sr.Name = "Bannuler_sr"
        Me.Bannuler_sr.Size = New System.Drawing.Size(205, 61)
        Me.Bannuler_sr.TabIndex = 0
        Me.Bannuler_sr.Text = "Annuler"
        Me.Bannuler_sr.UseVisualStyleBackColor = True
        '
        'Brechercher
        '
        Me.Brechercher.Location = New System.Drawing.Point(97, 22)
        Me.Brechercher.Name = "Brechercher"
        Me.Brechercher.Size = New System.Drawing.Size(205, 61)
        Me.Brechercher.TabIndex = 0
        Me.Brechercher.Text = "Rechercher"
        Me.Brechercher.UseVisualStyleBackColor = True
        '
        'PanelGrid
        '
        Me.PanelGrid.AutoScroll = True
        Me.PanelGrid.Controls.Add(Me.DataGridView1)
        Me.PanelGrid.Controls.Add(Me.Label13)
        Me.PanelGrid.Controls.Add(Me.LrowsCount)
        Me.PanelGrid.Controls.Add(Me.BtableLast)
        Me.PanelGrid.Controls.Add(Me.BtableNext)
        Me.PanelGrid.Controls.Add(Me.BtableFirst)
        Me.PanelGrid.Controls.Add(Me.BtablePrev)
        Me.PanelGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelGrid.Location = New System.Drawing.Point(3, 109)
        Me.PanelGrid.Name = "PanelGrid"
        Me.PanelGrid.Size = New System.Drawing.Size(900, 487)
        Me.PanelGrid.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label13.Location = New System.Drawing.Point(767, 311)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 21)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Result(s) :"
        '
        'LrowsCount
        '
        Me.LrowsCount.AutoSize = True
        Me.LrowsCount.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LrowsCount.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.LrowsCount.Location = New System.Drawing.Point(860, 311)
        Me.LrowsCount.Name = "LrowsCount"
        Me.LrowsCount.Size = New System.Drawing.Size(0, 21)
        Me.LrowsCount.TabIndex = 2
        '
        'BtableLast
        '
        Me.BtableLast.Location = New System.Drawing.Point(204, 305)
        Me.BtableLast.Name = "BtableLast"
        Me.BtableLast.Size = New System.Drawing.Size(52, 32)
        Me.BtableLast.TabIndex = 1
        Me.BtableLast.Text = ">>"
        Me.BtableLast.UseVisualStyleBackColor = True
        '
        'BtableNext
        '
        Me.BtableNext.Location = New System.Drawing.Point(146, 305)
        Me.BtableNext.Name = "BtableNext"
        Me.BtableNext.Size = New System.Drawing.Size(52, 32)
        Me.BtableNext.TabIndex = 1
        Me.BtableNext.Text = ">"
        Me.BtableNext.UseVisualStyleBackColor = True
        '
        'BtableFirst
        '
        Me.BtableFirst.Location = New System.Drawing.Point(30, 305)
        Me.BtableFirst.Name = "BtableFirst"
        Me.BtableFirst.Size = New System.Drawing.Size(52, 32)
        Me.BtableFirst.TabIndex = 1
        Me.BtableFirst.Text = "<<"
        Me.BtableFirst.UseVisualStyleBackColor = True
        '
        'BtablePrev
        '
        Me.BtablePrev.Location = New System.Drawing.Point(88, 305)
        Me.BtablePrev.Name = "BtablePrev"
        Me.BtablePrev.Size = New System.Drawing.Size(52, 32)
        Me.BtablePrev.TabIndex = 1
        Me.BtablePrev.Text = "<"
        Me.BtablePrev.UseVisualStyleBackColor = True
        '
        'PanelBoxes
        '
        Me.PanelBoxes.Controls.Add(Me.Label10)
        Me.PanelBoxes.Controls.Add(Me.Zsearch)
        Me.PanelBoxes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBoxes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelBoxes.Location = New System.Drawing.Point(3, 52)
        Me.PanelBoxes.Name = "PanelBoxes"
        Me.PanelBoxes.Size = New System.Drawing.Size(900, 57)
        Me.PanelBoxes.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(9, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Search"
        '
        'Zsearch
        '
        Me.Zsearch.Location = New System.Drawing.Point(74, 13)
        Me.Zsearch.Name = "Zsearch"
        Me.Zsearch.Size = New System.Drawing.Size(280, 29)
        Me.Zsearch.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 49)
        Me.Panel1.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(360, 30)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Afficher un ou plusieurs employees"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatDataGridViewTextBoxColumn, Me.NomPrenomDataGridViewTextBoxColumn, Me.FonctionDataGridViewTextBoxColumn, Me.AdresseDataGridViewTextBoxColumn, Me.VilleDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelephoneDataGridViewTextBoxColumn, Me.DEMDataGridViewTextBoxColumn, Me.EnfantsDataGridViewTextBoxColumn, Me.PhotoDataGridViewImageColumn, Me.CVDataGridViewTextBoxColumn, Me.DateRecDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmployeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(13, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(882, 280)
        Me.DataGridView1.TabIndex = 3
        '
        'Employee_dbDataSet
        '
        Me.Employee_dbDataSet.DataSetName = "employee_dbDataSet"
        Me.Employee_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeBindingSource
        '
        Me.EmployeBindingSource.DataMember = "Employe"
        Me.EmployeBindingSource.DataSource = Me.Employee_dbDataSet
        '
        'EmployeTableAdapter
        '
        Me.EmployeTableAdapter.ClearBeforeFill = True
        '
        'MatDataGridViewTextBoxColumn
        '
        Me.MatDataGridViewTextBoxColumn.DataPropertyName = "Mat"
        Me.MatDataGridViewTextBoxColumn.HeaderText = "Mat"
        Me.MatDataGridViewTextBoxColumn.Name = "MatDataGridViewTextBoxColumn"
        '
        'NomPrenomDataGridViewTextBoxColumn
        '
        Me.NomPrenomDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NomPrenomDataGridViewTextBoxColumn.DataPropertyName = "Nom_Prenom"
        Me.NomPrenomDataGridViewTextBoxColumn.HeaderText = "Nom_Prenom"
        Me.NomPrenomDataGridViewTextBoxColumn.Name = "NomPrenomDataGridViewTextBoxColumn"
        '
        'FonctionDataGridViewTextBoxColumn
        '
        Me.FonctionDataGridViewTextBoxColumn.DataPropertyName = "Fonction"
        Me.FonctionDataGridViewTextBoxColumn.HeaderText = "Fonction"
        Me.FonctionDataGridViewTextBoxColumn.Name = "FonctionDataGridViewTextBoxColumn"
        Me.FonctionDataGridViewTextBoxColumn.Width = 120
        '
        'AdresseDataGridViewTextBoxColumn
        '
        Me.AdresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse"
        Me.AdresseDataGridViewTextBoxColumn.HeaderText = "Adresse"
        Me.AdresseDataGridViewTextBoxColumn.Name = "AdresseDataGridViewTextBoxColumn"
        Me.AdresseDataGridViewTextBoxColumn.Visible = False
        '
        'VilleDataGridViewTextBoxColumn
        '
        Me.VilleDataGridViewTextBoxColumn.DataPropertyName = "Ville"
        Me.VilleDataGridViewTextBoxColumn.HeaderText = "Ville"
        Me.VilleDataGridViewTextBoxColumn.Name = "VilleDataGridViewTextBoxColumn"
        Me.VilleDataGridViewTextBoxColumn.Width = 120
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.Visible = False
        '
        'TelephoneDataGridViewTextBoxColumn
        '
        Me.TelephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.HeaderText = "Telephone"
        Me.TelephoneDataGridViewTextBoxColumn.Name = "TelephoneDataGridViewTextBoxColumn"
        Me.TelephoneDataGridViewTextBoxColumn.Width = 120
        '
        'DEMDataGridViewTextBoxColumn
        '
        Me.DEMDataGridViewTextBoxColumn.DataPropertyName = "DEM"
        Me.DEMDataGridViewTextBoxColumn.HeaderText = "DEM"
        Me.DEMDataGridViewTextBoxColumn.Name = "DEMDataGridViewTextBoxColumn"
        Me.DEMDataGridViewTextBoxColumn.Width = 120
        '
        'EnfantsDataGridViewTextBoxColumn
        '
        Me.EnfantsDataGridViewTextBoxColumn.DataPropertyName = "Enfants"
        Me.EnfantsDataGridViewTextBoxColumn.HeaderText = "Enfants"
        Me.EnfantsDataGridViewTextBoxColumn.Name = "EnfantsDataGridViewTextBoxColumn"
        '
        'PhotoDataGridViewImageColumn
        '
        Me.PhotoDataGridViewImageColumn.DataPropertyName = "Photo"
        Me.PhotoDataGridViewImageColumn.HeaderText = "Photo"
        Me.PhotoDataGridViewImageColumn.Name = "PhotoDataGridViewImageColumn"
        Me.PhotoDataGridViewImageColumn.Visible = False
        '
        'CVDataGridViewTextBoxColumn
        '
        Me.CVDataGridViewTextBoxColumn.DataPropertyName = "CV"
        Me.CVDataGridViewTextBoxColumn.HeaderText = "CV"
        Me.CVDataGridViewTextBoxColumn.Name = "CVDataGridViewTextBoxColumn"
        Me.CVDataGridViewTextBoxColumn.Visible = False
        '
        'DateRecDataGridViewTextBoxColumn
        '
        Me.DateRecDataGridViewTextBoxColumn.DataPropertyName = "dateRec"
        Me.DateRecDataGridViewTextBoxColumn.HeaderText = "dateRec"
        Me.DateRecDataGridViewTextBoxColumn.Name = "DateRecDataGridViewTextBoxColumn"
        Me.DateRecDataGridViewTextBoxColumn.Visible = False
        '
        'formEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 633)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formEmployee"
        Me.Text = "formEmploye2"
        Me.TabControl1.ResumeLayout(False)
        Me.TabAjoute.ResumeLayout(False)
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.PanelAction.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.TabConsulter.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelGrid.ResumeLayout(False)
        Me.PanelGrid.PerformLayout()
        Me.PanelBoxes.ResumeLayout(False)
        Me.PanelBoxes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabAjoute As TabPage
    Friend WithEvents TabConsulter As TabPage
    Friend WithEvents PanelMain As Panel
    Friend WithEvents LcnxState As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Znen As TextBox
    Friend WithEvents Zdem As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Zemail As TextBox
    Friend WithEvents Ztel As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Zvil As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Zadrs As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Zfn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Znpr As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Zmat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PanelAction As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Bajoute As Button
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Bannuler_sr As Button
    Friend WithEvents Brechercher As Button
    Friend WithEvents PanelGrid As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents LrowsCount As Label
    Friend WithEvents BtableLast As Button
    Friend WithEvents BtableNext As Button
    Friend WithEvents BtableFirst As Button
    Friend WithEvents BtablePrev As Button
    Friend WithEvents PanelBoxes As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Zsearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Employee_dbDataSet As Bulletien_De_Paie.employee_dbDataSet
    Friend WithEvents EmployeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeTableAdapter As Bulletien_De_Paie.employee_dbDataSetTableAdapters.EmployeTableAdapter
    Friend WithEvents MatDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomPrenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FonctionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VilleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DEMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EnfantsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhotoDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents CVDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateRecDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
