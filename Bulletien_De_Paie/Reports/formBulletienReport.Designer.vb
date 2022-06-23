<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBulletienReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.BulletienWithEmployeNameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.employee_dbDataSet = New Bulletien_De_Paie.employee_dbDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BulletienWithEmployeNameTableAdapter = New Bulletien_De_Paie.employee_dbDataSetTableAdapters.BulletienWithEmployeNameTableAdapter()
        CType(Me.BulletienWithEmployeNameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employee_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BulletienWithEmployeNameBindingSource
        '
        Me.BulletienWithEmployeNameBindingSource.DataMember = "BulletienWithEmployeName"
        Me.BulletienWithEmployeNameBindingSource.DataSource = Me.employee_dbDataSet
        '
        'employee_dbDataSet
        '
        Me.employee_dbDataSet.DataSetName = "employee_dbDataSet"
        Me.employee_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BulletienWithEmployeNameBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Bulletien_De_Paie.BulletiensAsGrid.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(936, 827)
        Me.ReportViewer1.TabIndex = 0
        '
        'BulletienWithEmployeNameTableAdapter
        '
        Me.BulletienWithEmployeNameTableAdapter.ClearBeforeFill = True
        '
        'formBulletienReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 827)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "formBulletienReport"
        Me.Text = "formBulletienReport"
        CType(Me.BulletienWithEmployeNameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employee_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BulletienWithEmployeNameBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents employee_dbDataSet As Bulletien_De_Paie.employee_dbDataSet
    Friend WithEvents BulletienWithEmployeNameTableAdapter As Bulletien_De_Paie.employee_dbDataSetTableAdapters.BulletienWithEmployeNameTableAdapter
End Class
