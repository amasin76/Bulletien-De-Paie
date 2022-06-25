Imports Microsoft.Reporting.WinForms
Imports Bulletien_De_Paie.classCongeDetails
Public Class formCongeDemande

    Private Sub formCongeDemande_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CenterToScreen()

        Dim nbrJoursPr As New ReportParameter("nJours", nJours)
        Dim DsortiePr As New ReportParameter("Dsortie", Dsortie)
        Dim DretourPr As New ReportParameter("Dretour", Dretour)
        Dim typePr As New ReportParameter("type", type)
        Dim matriculePr As New ReportParameter("matricule", matricule)
        Dim nomPrenomPr As New ReportParameter("nomPrenom", nomPrenom)
        Dim fonctionPr As New ReportParameter("fonction", fonction)

        ReportViewer1.LocalReport.SetParameters(nbrJoursPr)
        ReportViewer1.LocalReport.SetParameters(DsortiePr)
        ReportViewer1.LocalReport.SetParameters(DretourPr)
        ReportViewer1.LocalReport.SetParameters(typePr)
        ReportViewer1.LocalReport.SetParameters(matriculePr)
        ReportViewer1.LocalReport.SetParameters(nomPrenomPr)
        ReportViewer1.LocalReport.SetParameters(fonctionPr)

        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class