Imports System.Data.OleDb
Imports System.Globalization
Public Class formBulletien
    'Saisi Bulletien
    Dim qry As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public Sub SearchEmploye()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT Nom_Prenom FROM Employe", cnx)
        da.Fill(dt)
        Dim r As DataRow
        Znpr.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            Znpr.AutoCompleteCustomSource.Add(r.Item(0).ToString)
        Next
        Znpr.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Znpr.AutoCompleteSource = AutoCompleteSource.CustomSource

    End Sub

    Private Sub TabControl1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabControl1.Enter
        cnx.Close()
        cnx.Open()
        Call SearchEmploye()

        'Load months list
        Dim i As Integer = 1
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        For Each month As String In months
            If Not String.IsNullOrEmpty(month) Then
                Lmonth.Items.Add(month)
                i += 1
            End If
        Next
        Lmonth.SelectedText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Date.Today.Month)
        'Load +10 years list
        Zyear.SelectedText = Date.Now.Year
    End Sub


    Dim vAnc As Integer
    Dim vEnf As Integer
    Private Sub Znpr_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Znpr.TextChanged
        qry = "SELECT Mat, Nom_Prenom, Fonction, DEM, Enfants FROM Employe WHERE Nom_Prenom = @npr "
        cmd = New OleDbCommand(qry, cnx)
        cmd.Parameters.Add("@npr", OleDbType.VarWChar).Value = Znpr.Text
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            Zmat.Text = dr("Mat")
            Zfn.Text = dr("Fonction")
            vEnf = dr("Enfants")
            vAnc = Date.Now.Year - Convert.ToDateTime(dr("DEM")).ToString("yyyy")
        End If
        Zmat.Enabled = False
        Znen.Text = vEnf
        Zseniority.Text = vAnc
    End Sub

    Private Sub Zht_th_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zht.TextChanged, Zth.TextChanged
        Dim vHt, vTh, calc As Single
        vHt = Val(Zht.Text)
        vTh = Val(Zth.Text)
        calc = vHt * vTh
        Zsba.Text = calc
    End Sub

    Private Sub Zhs25_50_100_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zhs25.TextChanged, Zhs50.TextChanged, Zhs100.TextChanged
        Dim v25, v50, v100, vTh, calc As Integer
        v25 = Val(Zhs25.Text)
        v50 = Val(Zhs50.Text)
        v100 = Val(Zhs100.Text)
        vTh = Val(Zth.Text)
        calc = vTh * (v25 * 1.25 + v50 * 1.5 + v100 * 2)
        zhsTotal.Text = calc
    End Sub

    ' Calc Prime De Enfants
    Private Sub Zsba_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zsba.TextChanged
        Dim vSba, vTaux, calc As Single
        vSba = Val(Zsba.Text)
        vTaux = primeAnc(vAnc)
        calc = vSba * vTaux
        Zseniority.Text = calc

        Znen.Text = Helpers.primeEnf(vEnf)
    End Sub

    'Calc Salaire Brut
    Private Sub Zsba_HS_Primes_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zsba.TextChanged, zhsTotal.TextChanged, Znen.TextChanged 'Zseniority.TextChanged
        Dim vSba, vHS, vEnf1, vAnc1, calc As Single
        vSba = Val(Zsba.Text)
        vHS = Val(zhsTotal.Text)
        vEnf1 = Val(Znen.Text)
        vAnc1 = Val(Zseniority.Text)
        calc = vSba + vHS + vEnf1 + vAnc1
        Zsbr.Text = String.Format("{0:#,##0.00}", calc)
    End Sub

    'Calc Montant CNSS
    Private Sub Zsbr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zsbr.TextChanged
        Dim vSbrConvert, calc As Single
        Dim vSbr As String = Zsbr.Text

        Try
            vSbrConvert = Decimal.Parse(vSbr, NumberStyles.AllowCurrencySymbol Or NumberStyles.Number)
        Catch ex As Exception

        End Try

        If vSbrConvert < 6000 Then
            calc = vSbrConvert * 0.0429
        Else
            calc = 257.4
        End If

        ZmCnss.Text = String.Format("{0:#,##0.00}", calc) 'calc.ToString("C2", New CultureInfo("en-MA")) 'FormatCurrency(calc) 'String.Format("{0:n}", calc)
    End Sub

    'Calc Montant Retraite
    Private Sub Ztr_Zsbr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ztr.TextChanged, Zsbr.TextChanged
        Dim vSbrConvert, vTr, calc As Single
        Dim vSbr As String = Zsbr.Text

        Try
            vSbrConvert = Decimal.Parse(vSbr, NumberStyles.AllowCurrencySymbol Or NumberStyles.Number)
        Catch ex As Exception

        End Try

        vTr = Val(Ztr.Text)
        calc = vSbrConvert * (vTr / 100)
        Zmr.Text = String.Format("{0:#,##0.00}", calc)
    End Sub

    'Calc Net A Payer
    Private Sub Zsbr_ZmCnss_Zmr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zsbr.TextChanged, ZmCnss.TextChanged, Zmr.TextChanged
        Dim vSbrConvert, vMCnssConvert, vMrConvert, calc As Single
        Dim vSbr, vMCnss, vMr As String
        vSbr = Zsbr.Text
        vMCnss = ZmCnss.Text
        vMr = Zmr.Text
        If vMr = "" Then
            vMr = "0"
        End If
        Try
            vSbrConvert = Decimal.Parse(vSbr, NumberStyles.AllowCurrencySymbol Or NumberStyles.Number)
            vMCnssConvert = Decimal.Parse(vMCnss, NumberStyles.AllowCurrencySymbol Or NumberStyles.Number)
            vMrConvert = Decimal.Parse(vMr, NumberStyles.AllowCurrencySymbol Or NumberStyles.Number)
        Catch

        End Try
        calc = vSbrConvert - (vMCnssConvert + vMrConvert)
        Znet.Text = String.Format("{0:#,##0.00 DH}", calc)
    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Helpers.clearTextBox(Me)
    End Sub
End Class