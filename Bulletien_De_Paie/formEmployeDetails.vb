Imports System.Data.OleDb
Public Class formEmployeDetails
    Private Sub formEmployeDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim matSelected As String
        matSelected = formEmployee.selectedrow.Cells(0).Value.ToString()

        cnx.Open()
        Dim command As String
        Dim reader As OleDbDataReader
        command = "SELECT * FROM Employe where Mat = @Mat"
        Dim cmd As OleDbCommand = New OleDbCommand(command, cnx)
        cmd.Parameters.AddWithValue("@Mat", OleDbType.VarChar).Value = matSelected
        'cmd.Parameters.AddWithValue("@Mat", matSelected)
        reader = cmd.ExecuteReader()
        reader.Read()

        Zmat_dt.Text = matSelected
        Znpr_dt.Text = reader("Nom_Prenom")
        Zfn_dt.Text = reader("Fonction")
        Zadrs_dt.Text = reader("Adresse")
        Zvil_dt.Text = reader("Ville")
        Zemail_dt.Text = reader("Email")
        Ztel_dt.Text = reader("Telephone")
        Zdem_dt.Text = reader("DEM")
        Znen_dt.Text = reader("Enfants")

        Zmat_dt.Enabled = False
        Znpr_dt.Enabled = False
        Zfn_dt.Enabled = False
        Zadrs_dt.Enabled = False
        Zvil_dt.Enabled = False
        Zemail_dt.Enabled = False
        Ztel_dt.Enabled = False
        Zdem_dt.Enabled = False
        Znen_dt.Enabled = False

        cnx.Close()
    End Sub

    Private Sub Bedit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bedit.Click
        Zmat_dt.Enabled = False
        Znpr_dt.Enabled = True
        Zfn_dt.Enabled = True
        Zadrs_dt.Enabled = True
        Zvil_dt.Enabled = True
        Zemail_dt.Enabled = True
        Ztel_dt.Enabled = True
        Zdem_dt.Enabled = True
        Znen_dt.Enabled = True
    End Sub

    Private Sub Bsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bsave.Click
        Dim strsql As String
        strsql = "UPDATE Employe SET Nom_Prenom = @npr, Fonction = @fn, Adresse = @adrs, Ville = @vil, Email = @email, Telephone = @tel, DEM = @dem, Enfants = @nen WHERE Mat = '" & Zmat_dt.Text & "'"

        cmd = New OleDbCommand(strsql, cnx)
        cmd.Parameters.Add("@npr", OleDbType.VarWChar).Value = Znpr_dt.Text
        cmd.Parameters.Add("@fn", OleDbType.VarChar).Value = Zfn_dt.Text
        cmd.Parameters.Add("@adrs", OleDbType.VarChar).Value = Zadrs_dt.Text
        cmd.Parameters.Add("@vil", OleDbType.VarChar).Value = Zvil_dt.Text
        cmd.Parameters.Add("@email", OleDbType.VarWChar).Value = Zemail_dt.Text
        cmd.Parameters.Add("@tel", OleDbType.VarChar).Value = Ztel_dt.Text
        cmd.Parameters.Add("@dem", OleDbType.VarChar).Value = Zdem_dt.Text
        cmd.Parameters.Add("@nen", OleDbType.VarChar).Value = Znen_dt.Text

        Try
            cnx.Open()
            cmd.ExecuteNonQuery()
            cnx.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Bdelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bdelete.Click
        Dim strsql As String
        strsql = "DELETE * FROM Employe WHERE Mat = @Mat"

        cmd = New OleDbCommand(strsql, cnx)
        cmd.Parameters.AddWithValue("@Mat", Zmat_dt.Text)

        Dim response As Integer
        response = MessageBox.Show("Are you sure want to delete this record?", "Delete Employe", MessageBoxButtons.YesNo, MessageBoxIcon.None)
        If response = vbYes Then
            Try
                cnx.Open()
                cmd.ExecuteNonQuery()
                cnx.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Me.Close()
            End Try
        End If

    End Sub
End Class