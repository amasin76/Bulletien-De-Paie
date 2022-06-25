Imports System.Data.OleDb
Imports System.Globalization
Imports Bulletien_De_Paie.classBulletienFilters
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

    Private Sub formBulletien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SearchEmploye()
        cnx.Close()
        'Load months list
        Dim i As Integer = 1
        Dim months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames
        For Each month As String In months
            If Not String.IsNullOrEmpty(month) Then
                Lmonth.Items.Add(month)
                i += 1
            End If
        Next
        Lmonth.SelectedIndex = Lmonth.FindStringExact(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Date.Today.Month))
        'Load year
        Zyear.SelectedText = Date.Now.Year

        'Load ID
        cmd = New OleDb.OleDbCommand("select N_Bulletien from Bulletien order by CDate(dateRec) desc", cnx)
        Dim maxId As Object
        Dim strId As String
        Dim initId As Integer

        'cmd.CommandText = "select N_Bulletien from Bulletien order by CDate(dateRec) desc"
        cnx.Open()
        maxId = cmd.ExecuteScalar
        If maxId Is DBNull.Value Then
            initId = 1
        Else
            strId = CType(maxId.Remove(0, 1), String)
            initId = CType(strId, String)
            initId += 1
        End If
        Zcode.Text = "B" & initId.ToString()
        Znpr.Focus()
        cnx.Close()
    End Sub

    Private Sub Zmat_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zmat.KeyUp
        cnx.Close()
        cnx.Open()
        cmd = New OleDbCommand("select Nom_Prenom from Employe WHERE Mat = @Mat", cnx)
        cmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text
        'cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read And dr.HasRows Then
            Znpr.Text = dr("Nom_Prenom")
        Else
            Znpr.Clear()
            Zfn.Clear()
        End If
        cnx.Close()
    End Sub



    Dim nAnc, nEnf As Integer
    Dim monthString As String
    Dim calcSba, vTaux, vTr, calcHS, calcEnf, calcAnc, calcAns, calcSbr, calcMCnss, calcMr, calcNet As Single

    Private Sub Znpr_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Znpr.TextChanged
        cnx.Close()
        cnx.Open()
        qry = "SELECT Mat, Nom_Prenom, Fonction, DEM, Enfants FROM Employe WHERE Nom_Prenom = @npr "
        cmd = New OleDbCommand(qry, cnx)
        cmd.Parameters.Add("@npr", OleDbType.VarWChar).Value = Znpr.Text
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader
        If dr.Read Then
            Zmat.Text = dr("Mat")
            Zfn.Text = dr("Fonction")
            nEnf = dr("Enfants")
            nAnc = Date.Now.Year - Convert.ToDateTime(dr("DEM")).ToString("yyyy")
        End If
        Lnen.Text = "Prime Enfants (" & nEnf & ")"
        Lseniority.Text = "Prime Ancienneté (" & nAnc & ")"

        calcAnc = Helpers.primeAnc(nAnc)
        calcEnf = Helpers.primeEnf(nEnf)

        If Not String.IsNullOrWhiteSpace(Znpr.Text) Then
            Znen.Text = String.Format("{0:#,##0.00}", calcEnf)
        End If
        cnx.Close()
    End Sub

    Private Sub Zht_th_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zht.KeyUp, Zth.KeyUp, Zhs25.KeyUp, Zhs50.KeyUp, Zhs100.KeyUp, Ztr.KeyUp, Znpr.KeyUp, Lmonth.SelectionChangeCommitted, Bsave.Click
        Dim vHt, vTh, v25, v50, v100, vTaux, vTr As Single
        vHt = Val(Zht.Text)
        vTh = Val(Zth.Text)
        v25 = Val(Zhs25.Text)
        v50 = Val(Zhs50.Text)
        v100 = Val(Zhs100.Text)
        vTh = Val(Zth.Text)
        vTaux = primeAnc(nAnc)
        vTr = Val(Ztr.Text)
        monthString = Lmonth.SelectedIndex + 1
        If (monthString.Length < 2) Then
            monthString = "0" & monthString
        End If

        calcSba = vHt * vTh
        calcHS = vTh * (v25 * 1.25 + v50 * 1.5 + v100 * 2)
        calcAnc = calcSba * vTaux
        calcAns = Helpers.primeAns(calcSba, monthString)
        calcSbr = calcSba + calcHS + calcEnf + calcAnc + calcAns
        calcMCnss = Helpers.mCnss(calcSbr)
        calcMr = calcSbr * (vTr / 100)
        calcNet = calcSbr - (calcMCnss + calcMr)

        Zsba.Text = String.Format("{0:#,##0.00}", calcSba)
        zhsTotal.Text = String.Format("{0:#,##0.00}", calcHS)
        Zseniority.Text = String.Format("{0:#,##0.00}", calcAnc)
        ZpAnne.Text = String.Format("{0:#,##0.00}", calcAns)
        Zsbr.Text = String.Format("{0:#,##0.00}", calcSbr)
        ZmCnss.Text = String.Format("{0:#,##0.00}", calcMCnss) 'calc.ToString("C2", New CultureInfo("en-MA")) 'FormatCurrency(calc)
        Zmr.Text = String.Format("{0:#,##0.00}", calcMr)
        Znet.Text = String.Format("{0:#,##0.00 DH}", calcNet)
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        cnx.Close()
        Dim commad As String
        commad = "INSERT INTO Bulletien (`N_Bulletien`, `Mois`, `Annee`, `N_HT`, `TH`, `S_Base`, `S_Brut`, `N_HS_25`, `N_HS_50`, `N_HS_100`, `HS_Total`, `P_Anciennete`, `P_Annee`, `P_Enfants`, `T_Retraite`, `M_Retraite`, `M_CNSS`, `Net_Payer`, `Mat`)" & _
                    "VALUES (@Code, @Mois, @Annee, @HT, @TH, @Sba, @Sbr, @HS25, @HS50, @HS100, @HS, @PAnc, @PAnnee, @PEnf, @TR, @MR, @MCnss, @Net, @Mat)"

        Dim cmd As OleDbCommand = New OleDbCommand(commad, cnx)
        cmd.Parameters.Add("@Code", OleDbType.VarChar).Value = Zcode.Text
        cmd.Parameters.Add("@Mois", OleDbType.VarChar).Value = monthString
        cmd.Parameters.Add("@Annee", OleDbType.VarChar).Value = Zyear.Text
        cmd.Parameters.Add("@HT", OleDbType.Integer).Value = Zht.Text
        cmd.Parameters.Add("@TH", OleDbType.Single).Value = Zth.Text
        cmd.Parameters.Add("@Sba", OleDbType.Single).Value = calcSba
        cmd.Parameters.Add("@Sbr", OleDbType.Single).Value = calcSbr
        cmd.Parameters.Add("@HS25", OleDbType.Integer).Value = Val(Zhs25.Text)
        cmd.Parameters.Add("@HS50", OleDbType.Integer).Value = Val(Zhs50.Text)
        cmd.Parameters.Add("@HS100", OleDbType.Integer).Value = Val(Zhs100.Text)
        cmd.Parameters.Add("@HS", OleDbType.Single).Value = zhsTotal.Text
        cmd.Parameters.Add("@Panc", OleDbType.Single).Value = calcAnc
        cmd.Parameters.Add("@Pannee", OleDbType.Single).Value = calcAns
        cmd.Parameters.Add("@PEnf", OleDbType.Single).Value = calcEnf
        cmd.Parameters.Add("@TR", OleDbType.Single).Value = Ztr.Text
        cmd.Parameters.Add("@MR", OleDbType.Single).Value = calcMr
        cmd.Parameters.Add("@MCnss", OleDbType.Single).Value = calcMCnss
        cmd.Parameters.Add("@Net", OleDbType.Single).Value = calcNet
        cmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Record saved")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    'Consulter
    Dim bs As New BindingSource()
    Private Sub TabConsulter_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabConsulter.Enter
        cnx.Close()
        cnx.Open()
        Dim dataAdapter As New OleDbDataAdapter("SELECT * FROM BulletienWithEmployeName", cnx)
        Dim ds As New DataSet()
        Dim dsView As New DataView
        dataAdapter.Fill(ds, "BulletienWithEmployeName")
        cnx.Close()
        dsView = ds.Tables(0).DefaultView
        bs.DataSource = dsView
        Me.DataGridView1.DataSource = bs

        LrowsCount.Text = DataGridView1.Rows.Count

        'Add Colomns Primes / Tax
        For i As Integer = 3 To 6
            DataGridView1.Columns(i).DefaultCellStyle.Format = "#,##0.00"
        Next

        'Search By
        Lby.SelectedIndex = 0
    End Sub

    Private Sub Zsearch_DatePicker_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zsearch.TextChanged, DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged, Lby.SelectionChangeCommitted
        Try
            If Zsearch.Text = "" Then
                bs.Filter = String.Format("DateMY >= #{0:MM/yyyy}# AND DateMY <= #{1:MM/yyyy}#", DateTimePicker1.Value, DateTimePicker2.Value)
            ElseIf Lby.SelectedIndex = 0 Then
                bs.Filter = String.Format(" Nom_Prenom LIKE '%{0}%' AND DateMY >= #{1:MM/yyyy}# AND DateMY <= #{2:MM/yyyy}#", Zsearch.Text, DateTimePicker1.Value, DateTimePicker2.Value)
            ElseIf Lby.SelectedIndex = 1 Then
                bs.Filter = String.Format(" Fonction LIKE '%{0}%' AND DateMY >= #{1:MM/yyyy}# AND DateMY <= #{2:MM/yyyy}#", Zsearch.Text, DateTimePicker1.Value, DateTimePicker2.Value)
            ElseIf Lby.SelectedIndex = 2 Then
                bs.Filter = String.Format(" Mat LIKE '{0}' AND DateMY >= #{1:MM/yyyy}# AND DateMY <= #{2:MM/yyyy}#", Zsearch.Text, DateTimePicker1.Value, DateTimePicker2.Value)
            Else
                bs.Filter = String.Format(" N_Bulletien LIKE '{0}' AND DateMY >= #{1:MM/yyyy}# AND DateMY <= #{2:MM/yyyy}#", Zsearch.Text, DateTimePicker1.Value, DateTimePicker2.Value)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        LrowsCount.Text = DataGridView1.Rows.Count
    End Sub

    'Total Row
    Private Sub DataGridView1_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DataBindingComplete
        Try
            Dim sumOfPrimes, sumOfCnss, sumOfMr, sumOfNet As Single
            For Each row As DataGridViewRow In DataGridView1.Rows
                Dim primesColumn As Single = CSng(row.Cells("PrimesDataGridViewTextBoxColumn").Value)
                Dim cnssColumn As Single = CSng(row.Cells("MCNSSDataGridViewTextBoxColumn").Value)
                Dim mrColumn As Single = CSng(row.Cells("MRetraiteDataGridViewTextBoxColumn").Value)
                Dim NetColumn As Single = CSng(row.Cells("NetPayerDataGridViewTextBoxColumn").Value)

                sumOfPrimes += primesColumn
                sumOfCnss += cnssColumn
                sumOfMr += mrColumn
                sumOfNet += NetColumn
            Next
            Lprimes.Text = sumOfPrimes.ToString("#,##0.00")
            Lcnss.Text = sumOfCnss.ToString("#,##0.00")
            Lmr.Text = sumOfMr.ToString("#,##0.00")
            Lnet.Text = sumOfNet.ToString("#,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Helpers.clearTextBox(Me)
        Zmat.Enabled = True
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        Dim imageBmp As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(imageBmp, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(imageBmp, -40, 100)
    End Sub

    'Show employe details
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            selectedrow = DataGridView1.Rows(e.RowIndex)
            'formBulletienDetails.ShowDialog()
            Dim objItemCategories As New formBulletienDetails
            objItemCategories.StartPosition = FormStartPosition.CenterParent
            objItemCategories.ShowDialog(Me)
        End If
    End Sub
    Public Shared Property selectedrow As DataGridViewRow

    Private Sub Bprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bprint.Click
        search = Zsearch.Text
        date1 = DateTimePicker1.Value
        date2 = DateTimePicker2.Value
        selectedIndex = Lby.SelectedIndex
        formBulletienReport.ShowDialog()
    End Sub
End Class