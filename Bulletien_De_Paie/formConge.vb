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
            Zseniority.Clear()
        End If
        cnx.Close()
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
            RectangleShape1.Height = 200
        End If
        cnx.Close()
    End Sub

    'Calc Credit
    Private Sub ZtotCng_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZtotCng.TextChanged
        Dim Credit As Integer
        Credit = (nAnc * 26) - Val(ZtotCng.Text)
        If Ltype.Text = "Administratif" Then
            If nAnc = 0 And Not Zmat.Text = "" Then
                Lcredit.Text = 0
                Lcredit.ForeColor = Color.IndianRed
            Else
                Lcredit.Text = Credit
                Lcredit.ForeColor = Color.Black
            End If
        Else
            Lcredit.Text = "-"
        End If
    End Sub

    Private Sub ZnJours_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZnJours.KeyUp, DateTimePicker3.ValueChanged

        Dim nbrJours As Integer
        nbrJours = Val(ZnJours.Text)

        DateTimePicker4.Value = DateTimePicker3.Value.AddDays(nbrJours)

        'Load Year
        Zannee.Text = DateTimePicker3.Value.ToString("yyyy")
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
End Class