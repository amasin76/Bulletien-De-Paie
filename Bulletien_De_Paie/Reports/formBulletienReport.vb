Public Class formBulletienReport

    Private Sub formBulletienReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()
        'TODO: This line of code loads data into the 'employee_dbDataSet.BulletienWithEmployeName' table. You can move, or remove it, as needed.
        Me.BulletienWithEmployeNameTableAdapter.Fill(Me.employee_dbDataSet.BulletienWithEmployeName)
        If formBulletien.Zsearch.Text = "" Then
            Me.BulletienWithEmployeNameTableAdapter.Fill(Me.employee_dbDataSet.BulletienWithEmployeName)
        Else
            Me.BulletienWithEmployeNameTableAdapter.FillBy(Me.employee_dbDataSet.BulletienWithEmployeName, formBulletien.Zsearch.Text)
        End If
        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class