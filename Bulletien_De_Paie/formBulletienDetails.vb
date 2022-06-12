Imports System.Threading
Imports System.Data.OleDb
Public Class formBulletienDetails
    Private Sub formEmployeDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim N_Selected As String
        N_Selected = formBulletien.selectedrow.Cells(0).Value.ToString()
        cnx.Open()
        Dim command As String
        Dim reader As OleDbDataReader
        command = "SELECT * FROM BulletienWithEmployeName where N_Bulletien = @N_Bulletien"
        Dim cmd As OleDbCommand = New OleDbCommand(command, cnx)
        cmd.Parameters.Add("@N_Bulletien", OleDbType.VarChar).Value = N_Selected
        reader = cmd.ExecuteReader()
        reader.Read()

        ZnBull.Text = N_Selected
        ZmatAndNom.Text = reader("Nom_Prenom") & " - " & reader("Mat")
        Zfn.Text = reader("Fonction")
        Zsba.Text = String.Format("{0:#,##0.00}", reader("S_Base"))
        Zhs.Text = String.Format("{0:#,##0.00}", reader("HS_Total"))
        Zprimes.Text = String.Format("{0:#,##0.00}", reader("Primes"))
        Zcnss.Text = String.Format("{0:#,##0.00}", reader("M_CNSS"))
        Zmr.Text = String.Format("{0:#,##0.00}", reader("M_Retraite"))
        Zsbr.Text = String.Format("{0:#,##0.00}", reader("S_Brut"))
        Ztaxes.Text = String.Format("{0:#,##0.00}", reader("Taxes"))
        Znet.Text = String.Format("{0:#,##0.00}", reader("Net_Payer"))

        cnx.Close()
    End Sub
End Class