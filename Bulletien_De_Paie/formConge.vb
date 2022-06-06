Imports System.Data.OleDb
Imports System.Globalization
Public Class formConge
    'Saisi Bulletien
    Dim qry As String
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Public Sub SearchEmploye()
        Dim dt As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter("SELECT Nom_Prenom, Mat FROM Employe", cnx)
        da.Fill(dt)
        Dim r As DataRow
        Znpr.AutoCompleteCustomSource.Clear()
        For Each r In dt.Rows
            Znpr.AutoCompleteCustomSource.Add(r.Item(0).ToString)
        Next
        Znpr.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Znpr.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Dim minDatePicker As Date
    Private Sub formConge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnx.Close()
        cnx.Open()
        Call SearchEmploye()
        cnx.Close()
        'Load months list

        'Load ID
        cmd = New OleDbCommand("select N_Conge from Conge order by CDate(dateRec) desc", cnx)
        Dim maxId As Object
        Dim strId As String
        Dim initId As Integer

        cnx.Open()
        maxId = cmd.ExecuteScalar
        If maxId = "" Then 'Is DBNull.Value Then
            initId = 1
        Else
            strId = CType(maxId.Remove(0, 1), String)
            initId = CType(strId, String)
            initId += 1
        End If
        Zcode.Text = "C" & initId.ToString()
        Znpr.Focus()
        cnx.Close()

        Ltype.SelectedIndex = 0
        Zannee.Text = Date.Now.Year
        minDatePicker = DateTimePicker3.Value.AddDays(1)
        DateTimePicker4.Value = minDatePicker
    End Sub

    Private Sub Znpr_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Znpr.KeyUp
        cnx.Close()
        cnx.Open()

        qry = "SELECT Mat FROM Employe WHERE Nom_Prenom = @npr "
        cmd = New OleDbCommand(qry, cnx)
        cmd.Parameters.Add("@npr", OleDbType.VarWChar).Value = Znpr.Text
        Try
            cmd.ExecuteNonQuery()
            dr = cmd.ExecuteReader()
            While (dr.Read())
                Zmat.Text = dr("Mat")
            End While
        Catch ex As Exception
        End Try

        cnx.Close()
    End Sub

    Dim nAnc As Integer
    Private Sub Zmat_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zmat.TextChanged
        cnx.Close()
        cnx.Open()
        cmd = New OleDbCommand("select Nom_Prenom, Fonction, DEM from Employe WHERE Mat = @Mat", cnx)
        cmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text
        dr = cmd.ExecuteReader
        If dr.Read Then
            Znpr.Text = dr("Nom_Prenom")
            nAnc = Math.Floor(DateDiff("d", Convert.ToDateTime(dr("DEM")), Date.Now.Date) / 365)
            Zseniority.Text = nAnc
            Zfn.Text = dr("Fonction")
        Else
            Znpr.Clear()
            Zfn.Clear()
            nAnc = 0
            Zseniority.Text = nAnc
        End If
        cnx.Close()

        ZnJours.Clear()
        DateTimePicker3.Value = Date.Now
        DateTimePicker4.Value = Date.Now.AddDays(1)
    End Sub

    'Calc Total / Recent Conges
    Private Sub Zfn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zfn.TextChanged, Ltype.SelectedValueChanged
        cnx.Close()
        cnx.Open()

        Dim qry2 As String = " SELECT Tot_Conges, Rec_Conges, Anc FROM CongeStats WHERE Mat = @Mat AND Type = @Type "
        Dim pcmd As New OleDbCommand(qry2, cnx)
        pcmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text
        pcmd.Parameters.Add("@Type", OleDbType.VarChar).Value = Ltype.Text
        Dim pdr As OleDbDataReader = pcmd.ExecuteReader()
        If pdr.Read Then
            ZtotCng.Text = pdr("Tot_Conges")
            ZrecCng.Text = pdr("Rec_Conges")
        Else
            ZtotCng.Text = 0
            ZrecCng.Text = 0
        End If

        'Show/Hide Description Box
        If Ltype.Text = "Administratif" Then
            LabelDesc.Hide()
            Zdesc.Hide()
            LabelDescCounter.Hide()
            RectangleShape1.Height = 167
        Else
            LabelDesc.Show()
            Zdesc.Show()
            LabelDescCounter.Show()
            RectangleShape1.Height = 213
        End If
        cnx.Close()
    End Sub

    'Calc Credit
    Dim Credit As Integer
    Dim maxDatePicker As Date
    Private Sub ZtotCng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZtotCng.TextChanged, Ltype.SelectedValueChanged, Zseniority.TextChanged
        Credit = (nAnc * 26) - Val(ZtotCng.Text)
        If Ltype.Text = "Administratif" Then
            If nAnc = 0 And Not Zmat.Text = "" Then
                Lcredit.Text = 0
                Lcredit.ForeColor = Color.IndianRed
                ZnJours.ReadOnly = True
                DateTimePicker3.Enabled = False
                DateTimePicker4.Enabled = False
                ZtelCng.ReadOnly = True
                ZvilCng.ReadOnly = True
                ZadrsCng.ReadOnly = True
                Zdesc.ReadOnly = True
            Else
                Lcredit.Text = Credit
                Lcredit.ForeColor = Color.Black
                ZnJours.ReadOnly = False
                DateTimePicker3.Enabled = True
                DateTimePicker4.Enabled = True
                ZtelCng.ReadOnly = False
                ZvilCng.ReadOnly = False
                ZadrsCng.ReadOnly = False
                Zdesc.ReadOnly = False
            End If
        Else
            Lcredit.Text = "-"
            Lcredit.ForeColor = Color.Black
            ZnJours.ReadOnly = False
            DateTimePicker3.Enabled = True
            DateTimePicker4.Enabled = True
            ZtelCng.ReadOnly = False
            ZvilCng.ReadOnly = False
            ZadrsCng.ReadOnly = False
            Zdesc.ReadOnly = False
        End If
        maxDatePicker = DateTimePicker3.Value.AddDays(Credit)
    End Sub

    'Validation NbrJours Accepts: integer 1 => Credit
    Private Sub ZnJours_KeyUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZnJours.TextChanged
        Dim i As Integer = 0
        Try
            If Zmat.Text = "" Then
                Dim ToolTip1 As New ToolTip
                ToolTip1.IsBalloon = True
                ToolTip1.UseFading = True
                ToolTip1.ToolTipIcon = ToolTipIcon.Warning
                ToolTip1.ToolTipTitle = "SVP SELECT EMPLOYEE"
                ToolTip1.Show("Pour calcule credit", Znpr, New Point(0, -80), 4000)
                ZnJours.Clear()
                Znpr.Focus()
                Exit Sub
            End If
            If Not ZnJours.Text = "" Then
                i = Integer.Parse(ZnJours.Text, Globalization.NumberStyles.Any)
            End If
        Catch ex As Exception
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Warning
            ToolTip1.ToolTipTitle = "MAX FROM 1 TO " & Credit
            ToolTip1.Show("Style is not an Integer value", ZnJours, New Point(0, -80), 4000)
            ZnJours.Text = ""
        End Try
        If Ltype.Text = "Administratif" And Not ZnJours.Text = "" Then
            If i >= 1 AndAlso i <= Credit Then
                Exit Sub
            Else
                Dim ToolTip1 As New ToolTip
                ToolTip1.IsBalloon = True
                ToolTip1.UseFading = True
                ToolTip1.ToolTipIcon = ToolTipIcon.Warning
                ToolTip1.ToolTipTitle = "RANGE FROM 1 TO " & Credit
                ToolTip1.Show("Value was out of range", ZnJours, New Point(0, -80), 4000)
                ZnJours.Text = Credit
            End If
        End If
    End Sub


    Private Sub ZnJours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZnJours.KeyUp, DateTimePicker3.ValueChanged
        Dim nbrJours As Integer
        nbrJours = Val(ZnJours.Text)

        If Not nbrJours = 0 Then
            DateTimePicker4.Value = DateTimePicker3.Value.AddDays(nbrJours)
        End If
        'Load Year
        Zannee.Text = DateTimePicker3.Value.ToString("yyyy")
    End Sub

    'Fix nbrJours after change datePicker4 AND check date between datepicker range
    Private Sub DateTimePicker4_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker4.LostFocus
        Dim pickerDiff As Integer = CInt(DateDiff("h", DateTimePicker3.Value, DateTimePicker4.Value) / 24)

        If pickerDiff > Credit Then
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.Show("Value was out of range", DateTimePicker4, New Point(0, -80), 3000)
            ToolTip1.ToolTipTitle = "MAX " & maxDatePicker.ToString("dd/MM/yyyy")
            DateTimePicker4.Value = maxDatePicker
        ElseIf pickerDiff <= 0 Then
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Error
            ToolTip1.Show("Value was out of range", DateTimePicker4, New Point(0, -80), 3000)
            ToolTip1.ToolTipTitle = "MIN " & minDatePicker.ToString("dd/MM/yyyy")
            DateTimePicker4.Value = minDatePicker
        Else
            ZnJours.Text = pickerDiff
        End If
    End Sub

    'Description characters counter
    Private Sub Zdesc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Zdesc.KeyPress
        If Zdesc.Text = "" And e.KeyChar = Convert.ToChar(Keys.Back) Then
            LabelDescCounter.Text = Len(Zdesc.Text) & "/512"
        ElseIf e.KeyChar = Convert.ToChar(Keys.Back) Then
            LabelDescCounter.Text = Len(Zdesc.Text) - 1 & "/512"
        ElseIf Not Len(Zdesc.Text) = 512 Then
            LabelDescCounter.Text = Len(Zdesc.Text) + 1 & "/512"
        End If
    End Sub

    'Reset datePicker3/4 & Clear textBoxes
    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Helpers.clearTextBox(Me)
        DateTimePicker3.Value = Date.Now
        DateTimePicker4.Value = Date.Now.AddDays(1)
    End Sub

    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        cnx.Close()
        Dim commad As String
        commad = "INSERT INTO Conge (`N_Conge`, `Type`, `Nbr_Jours`, `D_Sortie`, `D_Retour`, `Annee`, `Telephone`, `Ville`, `Adresse`, `Description`, `Mat`)" & _
                    "VALUES (@Code, @Type, @Nbr_Jours, @D_Sortie, @D_Retour, @Annee, @Telephone, @Ville, @Adresse, @Description, @Mat)"

        Dim cmd As OleDbCommand = New OleDbCommand(commad, cnx)
        cmd.Parameters.Add("@Code", OleDbType.VarChar).Value = Zcode.Text
        cmd.Parameters.Add("@Type", OleDbType.VarChar).Value = Ltype.Text
        cmd.Parameters.Add("@Nbr_Jours", OleDbType.Integer).Value = ZnJours.Text
        cmd.Parameters.Add("@D_Sortie", OleDbType.Date).Value = DateTimePicker3.Value.Date
        cmd.Parameters.Add("@D_Retour", OleDbType.Date).Value = DateTimePicker4.Value.Date
        cmd.Parameters.Add("@Annee", OleDbType.VarChar).Value = Zannee.Text
        cmd.Parameters.Add("@Telephone", OleDbType.VarChar).Value = ZtelCng.Text
        cmd.Parameters.Add("@Ville", OleDbType.VarWChar).Value = ZvilCng.Text
        cmd.Parameters.Add("@Adresse", OleDbType.VarWChar).Value = ZadrsCng.Text
        cmd.Parameters.Add("@Description", OleDbType.VarWChar).Value = Zdesc.Text
        cmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Info
            ToolTip1.ToolTipTitle = "SUCCESS"
            ToolTip1.Show(Zmat.Text & " conge est enregistré", Bsave, New Point(0, -80), 4000)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Dim bs As New BindingSource()
    Private Sub TabConsulter_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabConsulter.Enter
        cnx.Close()
        cnx.Open()
        Dim dataAdapter As New OleDbDataAdapter("SELECT * FROM CongeWithEmployeDetails", cnx)
        Dim ds As New DataSet()
        Dim dsView As New DataView
        dataAdapter.Fill(ds, "CongeWithEmployeDetails")
        cnx.Close()
        dsView = ds.Tables(0).DefaultView
        bs.DataSource = dsView
        Me.DataGridView1.DataSource = bs

        LrowsCount.Text = DataGridView1.Rows.Count

        'Add Colomns Primes / Tax
        'For i As Integer = 3 To 6
        '    DataGridView1.Columns(i).DefaultCellStyle.Format = "#,##0.00"
        'Next

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
    'Private Sub DataGridView1_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DataBindingComplete
    '    Try
    '        Dim sumOfPrimes, sumOfCnss, sumOfMr, sumOfNet As Single
    '        For Each row As DataGridViewRow In DataGridView1.Rows
    '            Dim primesColumn As Single = CSng(row.Cells("PrimesDataGridViewTextBoxColumn").Value)
    '            Dim cnssColumn As Single = CSng(row.Cells("MCNSSDataGridViewTextBoxColumn").Value)
    '            Dim mrColumn As Single = CSng(row.Cells("MRetraiteDataGridViewTextBoxColumn").Value)
    '            Dim NetColumn As Single = CSng(row.Cells("NetPayerDataGridViewTextBoxColumn").Value)

    '            sumOfPrimes += primesColumn
    '            sumOfCnss += cnssColumn
    '            sumOfMr += mrColumn
    '            sumOfNet += NetColumn
    '        Next
    '        Lprimes.Text = sumOfPrimes.ToString("#,##0.00")
    '        Lcnss.Text = sumOfCnss.ToString("#,##0.00")
    '        Lmr.Text = sumOfMr.ToString("#,##0.00")
    '        Lnet.Text = sumOfNet.ToString("#,##0.00")
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    ''Show employe details
    'Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
    '    If e.RowIndex >= 0 Then
    '        selectedrow = DataGridView1.Rows(e.RowIndex)
    '        'formBulletienDetails.ShowDialog()
    '        Dim objItemCategories As New formBulletienDetails
    '        objItemCategories.StartPosition = FormStartPosition.CenterParent
    '        objItemCategories.ShowDialog(Me)
    '    End If
    'End Sub
    'Public Shared Property selectedrow As DataGridViewRow
End Class