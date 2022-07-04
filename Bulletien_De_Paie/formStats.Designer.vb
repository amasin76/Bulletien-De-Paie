<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStats
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Lfn_count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Lcng_count = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Lbul_tot = New System.Windows.Forms.Label()
        Me.Lbul_count = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Lemp_f = New System.Windows.Forms.Label()
        Me.Lemp_h = New System.Windows.Forms.Label()
        Me.Lemp_count = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChartEmpGender = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AgeRangeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_dbDataSet = New Bulletien_De_Paie.employee_dbDataSet()
        Me.ChartDepr = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartHrs = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ChartCng = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.AgeRangeTableAdapter = New Bulletien_De_Paie.employee_dbDataSetTableAdapters.AgeRangeTableAdapter()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.ChartEmpGender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgeRangeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartDepr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartHrs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartCng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Lfn_count)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.PictureBox5)
        Me.Panel5.Location = New System.Drawing.Point(707, 23)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 120)
        Me.Panel5.TabIndex = 5
        '
        'Lfn_count
        '
        Me.Lfn_count.AutoSize = True
        Me.Lfn_count.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lfn_count.Location = New System.Drawing.Point(11, 49)
        Me.Lfn_count.Name = "Lfn_count"
        Me.Lfn_count.Size = New System.Drawing.Size(59, 20)
        Me.Lfn_count.TabIndex = 6
        Me.Lfn_count.Text = "Count : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fonctions"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Lcng_count)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Location = New System.Drawing.Point(479, 23)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(200, 120)
        Me.Panel6.TabIndex = 6
        '
        'Lcng_count
        '
        Me.Lcng_count.AutoSize = True
        Me.Lcng_count.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lcng_count.Location = New System.Drawing.Point(11, 49)
        Me.Lcng_count.Name = "Lcng_count"
        Me.Lcng_count.Size = New System.Drawing.Size(55, 20)
        Me.Lcng_count.TabIndex = 7
        Me.Lcng_count.Text = "Count :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Conges"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Lbul_tot)
        Me.Panel7.Controls.Add(Me.Lbul_count)
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Controls.Add(Me.PictureBox7)
        Me.Panel7.Location = New System.Drawing.Point(251, 23)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 120)
        Me.Panel7.TabIndex = 4
        '
        'Lbul_tot
        '
        Me.Lbul_tot.AutoSize = True
        Me.Lbul_tot.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lbul_tot.Location = New System.Drawing.Point(11, 79)
        Me.Lbul_tot.Name = "Lbul_tot"
        Me.Lbul_tot.Size = New System.Drawing.Size(53, 20)
        Me.Lbul_tot.TabIndex = 6
        Me.Lbul_tot.Text = "Total : "
        '
        'Lbul_count
        '
        Me.Lbul_count.AutoSize = True
        Me.Lbul_count.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lbul_count.Location = New System.Drawing.Point(11, 49)
        Me.Lbul_count.Name = "Lbul_count"
        Me.Lbul_count.Size = New System.Drawing.Size(59, 20)
        Me.Lbul_count.TabIndex = 5
        Me.Lbul_count.Text = "Count : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(11, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Bulletien"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Lemp_f)
        Me.Panel8.Controls.Add(Me.Lemp_h)
        Me.Panel8.Controls.Add(Me.Lemp_count)
        Me.Panel8.Controls.Add(Me.Label2)
        Me.Panel8.Controls.Add(Me.PictureBox8)
        Me.Panel8.Location = New System.Drawing.Point(23, 23)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(200, 120)
        Me.Panel8.TabIndex = 3
        '
        'Lemp_f
        '
        Me.Lemp_f.AutoSize = True
        Me.Lemp_f.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lemp_f.Location = New System.Drawing.Point(64, 79)
        Me.Lemp_f.Name = "Lemp_f"
        Me.Lemp_f.Size = New System.Drawing.Size(27, 20)
        Me.Lemp_f.TabIndex = 4
        Me.Lemp_f.Text = "F : "
        '
        'Lemp_h
        '
        Me.Lemp_h.AutoSize = True
        Me.Lemp_h.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lemp_h.Location = New System.Drawing.Point(11, 79)
        Me.Lemp_h.Name = "Lemp_h"
        Me.Lemp_h.Size = New System.Drawing.Size(31, 20)
        Me.Lemp_h.TabIndex = 3
        Me.Lemp_h.Text = "H : "
        '
        'Lemp_count
        '
        Me.Lemp_count.AutoSize = True
        Me.Lemp_count.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Lemp_count.Location = New System.Drawing.Point(11, 49)
        Me.Lemp_count.Name = "Lemp_count"
        Me.Lemp_count.Size = New System.Drawing.Size(59, 20)
        Me.Lemp_count.TabIndex = 2
        Me.Lemp_count.Text = "Count : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(11, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employes"
        '
        'ChartEmpGender
        '
        Me.ChartEmpGender.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartArea1.AxisX.Title = "Tranche d'âge"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated270
        ChartArea1.AxisY.Title = "employées"
        ChartArea1.Name = "ChartArea1"
        Me.ChartEmpGender.ChartAreas.Add(ChartArea1)
        Me.ChartEmpGender.DataSource = Me.AgeRangeBindingSource
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.ChartEmpGender.Legends.Add(Legend1)
        Me.ChartEmpGender.Location = New System.Drawing.Point(23, 166)
        Me.ChartEmpGender.Name = "ChartEmpGender"
        Series1.ChartArea = "ChartArea1"
        Series1.CustomProperties = "DrawingStyle=LightToDark, LabelStyle=Bottom"
        Series1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelBorderColor = System.Drawing.Color.Transparent
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "AgeRange"
        Series1.XValueMember = "AgeGroup"
        Series1.YValueMembers = "CountOfAgeGroup"
        Me.ChartEmpGender.Series.Add(Series1)
        Me.ChartEmpGender.Size = New System.Drawing.Size(428, 231)
        Me.ChartEmpGender.TabIndex = 7
        Me.ChartEmpGender.Text = "Chart1"
        '
        'AgeRangeBindingSource
        '
        Me.AgeRangeBindingSource.DataMember = "AgeRange"
        Me.AgeRangeBindingSource.DataSource = Me.Employee_dbDataSet
        '
        'Employee_dbDataSet
        '
        Me.Employee_dbDataSet.DataSetName = "employee_dbDataSet"
        Me.Employee_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ChartDepr
        '
        Me.ChartDepr.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartArea2.AxisX.Title = "Fonctions"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea2.AxisY.Title = "employées"
        ChartArea2.Name = "ChartArea1"
        Me.ChartDepr.ChartAreas.Add(ChartArea2)
        Legend2.Enabled = False
        Legend2.Name = "Legend1"
        Me.ChartDepr.Legends.Add(Legend2)
        Me.ChartDepr.Location = New System.Drawing.Point(479, 166)
        Me.ChartDepr.Name = "ChartDepr"
        Series2.ChartArea = "ChartArea1"
        Series2.CustomProperties = "DrawingStyle=LightToDark, LabelStyle=Bottom"
        Series2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.ChartDepr.Series.Add(Series2)
        Me.ChartDepr.Size = New System.Drawing.Size(428, 231)
        Me.ChartDepr.TabIndex = 7
        Me.ChartDepr.Text = "Chart1"
        '
        'ChartHrs
        '
        Me.ChartHrs.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartArea3.AxisX.Title = "Heures Travailler (Top 5)"
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        ChartArea3.AxisY.Title = "heures"
        ChartArea3.Name = "ChartArea1"
        Me.ChartHrs.ChartAreas.Add(ChartArea3)
        Legend3.Enabled = False
        Legend3.Name = "Legend1"
        Me.ChartHrs.Legends.Add(Legend3)
        Me.ChartHrs.Location = New System.Drawing.Point(23, 420)
        Me.ChartHrs.Name = "ChartHrs"
        Series3.ChartArea = "ChartArea1"
        Series3.CustomProperties = "DrawingStyle=LightToDark, LabelStyle=Bottom"
        Series3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.IsValueShownAsLabel = True
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.ChartHrs.Series.Add(Series3)
        Me.ChartHrs.Size = New System.Drawing.Size(428, 231)
        Me.ChartHrs.TabIndex = 7
        Me.ChartHrs.Text = "Chart1"
        '
        'ChartCng
        '
        Me.ChartCng.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        ChartArea4.AxisX.Title = "Total des vacances"
        ChartArea4.AxisX.TitleFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        ChartArea4.AxisY.Title = "jours"
        ChartArea4.Name = "ChartArea1"
        Me.ChartCng.ChartAreas.Add(ChartArea4)
        Legend4.Enabled = False
        Legend4.Name = "Legend1"
        Me.ChartCng.Legends.Add(Legend4)
        Me.ChartCng.Location = New System.Drawing.Point(479, 420)
        Me.ChartCng.Name = "ChartCng"
        Series4.ChartArea = "ChartArea1"
        Series4.CustomProperties = "DrawingStyle=LightToDark, LabelStyle=Bottom"
        Series4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.LabelForeColor = System.Drawing.Color.White
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.ChartCng.Series.Add(Series4)
        Me.ChartCng.Size = New System.Drawing.Size(428, 231)
        Me.ChartCng.TabIndex = 7
        Me.ChartCng.Text = "Chart1"
        '
        'AgeRangeTableAdapter
        '
        Me.AgeRangeTableAdapter.ClearBeforeFill = True
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox5.Image = Global.Bulletien_De_Paie.My.Resources.Resources.hierarchy
        Me.PictureBox5.Location = New System.Drawing.Point(129, 49)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox6.Image = Global.Bulletien_De_Paie.My.Resources.Resources.holiday
        Me.PictureBox6.Location = New System.Drawing.Point(129, 49)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 2
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox7.Image = Global.Bulletien_De_Paie.My.Resources.Resources.invoice
        Me.PictureBox7.Location = New System.Drawing.Point(129, 49)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 1
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.PictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox8.Image = Global.Bulletien_De_Paie.My.Resources.Resources.tie
        Me.PictureBox8.Location = New System.Drawing.Point(129, 49)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'formStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(930, 672)
        Me.Controls.Add(Me.ChartDepr)
        Me.Controls.Add(Me.ChartCng)
        Me.Controls.Add(Me.ChartHrs)
        Me.Controls.Add(Me.ChartEmpGender)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "formStats"
        Me.Text = "formStats"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.ChartEmpGender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgeRangeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartDepr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartHrs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartCng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChartEmpGender As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartDepr As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartHrs As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ChartCng As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Employee_dbDataSet As Bulletien_De_Paie.employee_dbDataSet
    Friend WithEvents AgeRangeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgeRangeTableAdapter As Bulletien_De_Paie.employee_dbDataSetTableAdapters.AgeRangeTableAdapter
    Friend WithEvents Lemp_count As System.Windows.Forms.Label
    Friend WithEvents Lemp_h As System.Windows.Forms.Label
    Friend WithEvents Lemp_f As System.Windows.Forms.Label
    Friend WithEvents Lfn_count As System.Windows.Forms.Label
    Friend WithEvents Lcng_count As System.Windows.Forms.Label
    Friend WithEvents Lbul_tot As System.Windows.Forms.Label
    Friend WithEvents Lbul_count As System.Windows.Forms.Label

End Class
