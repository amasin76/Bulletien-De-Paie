Imports System.Data.OleDb
Imports Microsoft.Reporting.WinForms
Imports Bulletien_De_Paie.classBulletienFilters
Public Class formBulletienReport

    Private Sub formBulletienReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()

        Dim dateFrom As New ReportParameter("dateFrom", date1)
        Dim dateTo As New ReportParameter("dateTo", date2)
        ReportViewer1.LocalReport.SetParameters(dateFrom)
        ReportViewer1.LocalReport.SetParameters(dateTo)

        If search = "" Then
            Me.BulletienWithEmployeNameTableAdapter.Fill(Me.employee_dbDataSet.BulletienWithEmployeName)
        Else
            Select Case selectedIndex
                Case 0
                    Me.BulletienWithEmployeNameTableAdapter.FillByNom(Me.employee_dbDataSet.BulletienWithEmployeName, search)
                Case 1
                    Me.BulletienWithEmployeNameTableAdapter.FillByFn(Me.employee_dbDataSet.BulletienWithEmployeName, search)
                Case 2
                    Me.BulletienWithEmployeNameTableAdapter.FillByMat(Me.employee_dbDataSet.BulletienWithEmployeName, search)
                Case 3
                    Me.BulletienWithEmployeNameTableAdapter.FillByN(Me.employee_dbDataSet.BulletienWithEmployeName, search)
            End Select
        End If

        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class