Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Public Class formStats

    Private Sub formStats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadChartDepr()
        LoadChartHrs()
        LoadBaseCng()
        Me.AgeRangeTableAdapter.Fill(Me.Employee_dbDataSet.AgeRange)
        LoadBaseStats()
    End Sub

    Public Sub LoadChartDepr()
        If cnx.State = ConnectionState.Closed Then cnx.Open()
        Dim da As New OleDbDataAdapter("SELECT Employe.Fonction, Count(Employe.Fonction) AS CountOfFonction FROM (Employe) GROUP BY Employe.Fonction;", cnx)
        Dim ds As New DataSet

        da.Fill(ds, "test")
        ChartDepr.DataSource = ds.Tables(0)
        Dim Series1 As Series = ChartDepr.Series("Series1")
        Series1.Name = "test"

        With ChartDepr
            .Series(Series1.Name).XValueMember = "Fonction"
            .Series(Series1.Name).YValueMembers = "CountOfFonction"
        End With
    End Sub

    Public Sub LoadChartHrs()
        If cnx.State = ConnectionState.Closed Then cnx.Open()
        Dim da As New OleDbDataAdapter("select top 5 Total_H, Nom_Prenom from(BulletienWithEmployeName) order by Total_H desc;", cnx)
        Dim ds As New DataSet

        da.Fill(ds, "test")
        ChartHrs.DataSource = ds.Tables(0)
        Dim Series1 As Series = ChartHrs.Series("Series1")
        Series1.Name = "test"

        With ChartHrs
            .Series(Series1.Name).XValueMember = "Nom_Prenom"
            .Series(Series1.Name).YValueMembers = "Total_H"
        End With
    End Sub

    Public Sub LoadBaseCng()
        If cnx.State = ConnectionState.Closed Then cnx.Open()
        Dim da As New OleDbDataAdapter("SELECT Month([D_Sortie]) AS M_Sortie, Sum(IIf(DateSerial(Year([D_Sortie]),Month([D_Sortie]),1)=DateSerial(Year([D_Retour]),Month([D_Retour]),1),DateDiff('d',[D_Sortie],[D_Retour]),DateDiff('d',[D_Sortie],DateSerial(Year([D_Sortie]),Month([D_Sortie]),31)))) AS Jour_S FROM(Conge) GROUP BY Month([D_Sortie])", cnx)
        Dim ds As New DataSet

        da.Fill(ds, "test")
        ChartCng.DataSource = ds.Tables(0)
        Dim Series1 As Series = ChartCng.Series("Series1")
        Series1.Name = "test"

        With ChartCng
            .Series(Series1.Name).XValueMember = "M_Sortie"
            .Series(Series1.Name).YValueMembers = "Jour_S"
        End With
    End Sub

    Public Sub LoadBaseStats()
        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If
        cmd = New OleDbCommand("select Count_Emp, Female, Male from GeneralStats", cnx)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        If dr.Read Then
            Lemp_count.Text &= dr("Count_Emp")
            Lemp_f.Text &= dr("Female")
            Lemp_h.Text &= dr("Male")
        End If
        dr.Close()

        cmd = New OleDbCommand("select COUNT(N_Bulletien) AS Count_Bul, SUM(Net_Payer) AS Tot_Net from Bulletien WHERE Mois = @currentMonth", cnx)
        cmd.Parameters.Add("@currentMonth", OleDbType.VarChar).Value = String.Format("{0:MM}", New Date().Month)
        dr = cmd.ExecuteReader
        If dr.Read Then
            Lbul_count.Text &= dr("Count_Bul")
            Lbul_tot.Text &= String.Format("{0:#,##0.00}", dr("Tot_Net"))
        End If
        If Lbul_tot.Text = "Total : " Then Lbul_tot.Text &= "0"
        dr.Close()

        cmd = New OleDbCommand("select COUNT(N_Conge) AS Count_Cng from Conge WHERE Month(D_Sortie) = @currentMonth OR Month(D_Retour) = @currentMonth", cnx)
        cmd.Parameters.Add("@currentMonth", OleDbType.Integer).Value = 8 'New Date().Month
        dr = cmd.ExecuteReader
        If dr.Read Then
            Lcng_count.Text &= dr("Count_Cng")
        End If
        dr.Close()

        cmd = New OleDbCommand("SELECT Fonction FROM Employe GROUP BY Fonction;", cnx)
        dr = cmd.ExecuteReader
        Dim totalFonctions As Integer = 0
        While dr.Read
            totalFonctions = totalFonctions + 1
        End While
        Lfn_count.Text &= totalFonctions
        dr.Close()
    End Sub
End Class