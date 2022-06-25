Imports Microsoft.Reporting.WinForms
Imports Bulletien_De_Paie.classCongeFilters
Public Class formCongeReport

    Private Sub formCongeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()

        Dim dateFrom As New ReportParameter("dateFrom", date1)
        Dim dateTo As New ReportParameter("dateTo", date2)
        ReportViewer1.LocalReport.SetParameters(dateFrom)
        ReportViewer1.LocalReport.SetParameters(dateTo)

        If search = "" Then
            Me.CongeWithEmployeDetailsTableAdapter.Fill(Me.employee_dbDataSet.CongeWithEmployeDetails)
        Else
            Select Case selectedIndex
                Case 0
                    Me.CongeWithEmployeDetailsTableAdapter.FillByNom(Me.employee_dbDataSet.CongeWithEmployeDetails, search)
                Case 1
                    Me.CongeWithEmployeDetailsTableAdapter.FillByFn(Me.employee_dbDataSet.CongeWithEmployeDetails, search)
                Case 2
                    Me.CongeWithEmployeDetailsTableAdapter.FillByMat(Me.employee_dbDataSet.CongeWithEmployeDetails, search)
                Case 3
                    Me.CongeWithEmployeDetailsTableAdapter.FillByC(Me.employee_dbDataSet.CongeWithEmployeDetails, search)
            End Select
        End If

        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class