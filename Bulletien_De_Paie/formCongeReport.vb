Public Class formCongeReport

    Private Sub formCongeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If

        Dim cmd As New OleDb.OleDbCommand("SELECT * from CongeWithEmployeDetails", cnx)
        cmd.CommandTimeout = 4096
        Dim ta As New OleDb.OleDbDataAdapter(cmd)
        ta.Fill(dt)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("employee_dbDataSet", dt))
        End With

        ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class