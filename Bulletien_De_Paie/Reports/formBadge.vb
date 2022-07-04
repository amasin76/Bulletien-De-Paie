Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Drawing
Imports Bulletien_De_Paie.classEmployeDetails
Public Class formBadge

    Private Sub formBadge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ms As New MemoryStream
            picture.Save(ms, picture.RawFormat)
            Dim arrPic As Byte()
            arrPic = ms.ToArray()
            Dim images As String = Convert.ToBase64String(arrPic)

            Dim Param As IList(Of ReportParameter) = New List(Of ReportParameter)
            Param.Add(New ReportParameter("npr", npr))
            Param.Add(New ReportParameter("fn", fn))
            Param.Add(New ReportParameter("mat", mat))
            Param.Add(New ReportParameter("img", images, True))

            ReportViewer1.LocalReport.EnableExternalImages = True
            ReportViewer1.LocalReport.SetParameters(Param)

            'LoadReport()
            ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("SVP, Complete les donnees")
        End Try

    End Sub
End Class