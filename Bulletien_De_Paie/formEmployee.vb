Imports System.Data.OleDb
Imports System.IO
Imports System.Environment.SpecialFolder
Public Class formEmployee

    Private Sub formConge_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
            End If
            LcnxState.Text = "Connected"
            LcnxState.ForeColor = Color.Lime
        Catch ex As Exception
            LcnxState.Text = "Not Connected"
            LcnxState.ForeColor = Color.Red
            MessageBox.Show(ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.None)
            Exit Sub
        End Try

        Dim maxId As Object
        Dim strId As String
        Dim initId As Integer

        cmd = New OleDb.OleDbCommand("select Mat from Employe order by CDate(dateRec) desc", cnx)

        Try
            maxId = cmd.ExecuteScalar
            If maxId Is DBNull.Value Then
                initId = 1
            Else
                strId = CType(maxId.Remove(0, 1), String)
                initId = CType(strId, String)
                initId += 1
                Zmat.Enabled = False
            End If
            Zmat.Text = "E" & initId.ToString()
            Znpr.Focus()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Browse Image
    Dim imgName As String = "", pathImgString As String
    Private Sub Pemploye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pemploye.Click, Lplus.Click
        Using OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()

            Dim MyDocuments As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            With OpenFileDialog1
                .Filter = "choose image(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
                .FileName = ""
                .Title = "choose a picture..."
                .AddExtension = True
                .FilterIndex = 1
                .Multiselect = False
                .ValidateNames = True
                If (.ShowDialog = DialogResult.OK) Then
                    If CInt(OpenFileDialog1.OpenFile.Length) > 256000 Then
                        MsgBox("La taille de l'image sélectionnée " & FormatToHumanReadableFileSize(OpenFileDialog1.OpenFile.Length) & " dépasse le maximum: 256KB")
                        Exit Sub
                    End If
                    Lplus.Dispose()
                    imgName = Zmat.Text & Path.GetExtension(OpenFileDialog1.FileName).ToLower()
                    Pemploye.Image = Image.FromFile(OpenFileDialog1.FileName)
                    If Not System.IO.Directory.Exists(Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos")) Then
                        System.IO.Directory.CreateDirectory(Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos"))
                    End If
                    pathImgString = Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos", imgName)
                End If
            End With
        End Using
    End Sub

    'Browse CV
    Dim cvName As String = "", pathCvString As String, pathSourceCvString As String
    Private Sub Bcv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bcv.Click
        Using OpenFileDialog2 As OpenFileDialog = New OpenFileDialog()

            Dim MyDocuments As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            With OpenFileDialog2
                .Filter = "choose file(*.pdf; *.doc; *.docx)|*.pdf; *.doc; *.docx"
                .FileName = ""
                .Title = "choose a pdf..."
                .AddExtension = True
                .FilterIndex = 1
                .Multiselect = False
                .ValidateNames = True
                If (.ShowDialog = DialogResult.OK) Then
                    pathSourceCvString = Path.GetFullPath(OpenFileDialog2.FileName)
                    cvName = Zmat.Text & Path.GetExtension(OpenFileDialog2.FileName).ToLower()
                    Label15.Text = Path.GetFileName(OpenFileDialog2.FileName)
                    If Not System.IO.Directory.Exists(Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV")) Then
                        System.IO.Directory.CreateDirectory(Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV"))
                    End If
                    pathCvString = Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV", cvName)
                End If
            End With
        End Using
    End Sub

    Private Sub Bajoute_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bajoute.Click
        Dim commad As String
        commad = "INSERT INTO Employe (`Mat`, `Nom_Prenom`, `Fonction`, `Sexe`, `Date_N`, `Adresse`, `Ville`, `Email`, `Telephone`, `DEM`, `Enfants`, `Photo`, `CV`)" & _
                    "VALUES (@Mat, @Nom_Prenom, @Fonction, @Sexe, @Date_N, @Adresse, @Ville, @Email, @Telephone, @DEM, @Enfants, @Picture, @CV)"

        Dim cmd As OleDbCommand = New OleDbCommand(commad, cnx)
        cmd.Parameters.Add("@Mat", OleDbType.VarChar).Value = Zmat.Text
        cmd.Parameters.Add("@Nom_Prenom", OleDbType.VarWChar).Value = Znpr.Text
        cmd.Parameters.Add("@Fonction", OleDbType.VarChar).Value = Zfn.Text
        cmd.Parameters.Add("@Sexe", OleDbType.VarChar).Value = Csexe.Text
        cmd.Parameters.Add("@Date_N", OleDbType.Date).Value = Dnas.Value.Date
        cmd.Parameters.Add("@Adresse", OleDbType.VarChar).Value = Zadrs.Text
        cmd.Parameters.Add("@Ville", OleDbType.VarChar).Value = Zvil.Text
        cmd.Parameters.Add("@Email", OleDbType.VarChar).Value = Zemail.Text
        cmd.Parameters.Add("@Telephone", OleDbType.VarChar).Value = Ztel.Text
        cmd.Parameters.Add("@DEM", OleDbType.Date).Value = Ddem.Value.Date
        cmd.Parameters.Add("@Enfants", OleDbType.Integer).Value = Znen.Text
        cmd.Parameters.Add("@Picture", OleDbType.VarChar).Value = imgName
        cmd.Parameters.Add("@CV", OleDbType.VarChar).Value = cvName

        Dim nbrId As Integer
        nbrId = Convert.ToInt32((Zmat.Text).Remove(0, 1)) + 1

        Try
            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
            End If
            cmd.ExecuteNonQuery()
            MsgBox("Record saved")
            Zmat.Text = "E" & nbrId.ToString()
            cmd.Dispose()
            Dim a As Image = Pemploye.Image
            a.Save(pathImgString)
            File.Copy(pathSourceCvString, pathCvString)
            Pemploye.Image = Nothing
            Helpers.clearTextBox(Me)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnx.Close()
        End Try
    End Sub


    'Consulter Tab
    Dim bs As New BindingSource()
    Private Sub TabConsulter_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles TabConsulter.Enter
        Dim dataAdapter As New OleDbDataAdapter("SELECT * from Employe", cnx)
        Dim ds As New DataSet()
        Dim dsView As New DataView
        Try
            dataAdapter.Fill(ds, "Employe")
            dsView = ds.Tables(0).DefaultView
            bs.DataSource = dsView
            Me.DataGridView1.DataSource = bs
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cnx.Close()

        LrowsCount.Text = DataGridView1.Rows.Count
    End Sub

    Private Sub Zsearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles Zsearch.TextChanged

        bs.Filter = " Mat LIKE '" & Zsearch.Text & "' or Nom_Prenom LIKE '" & Zsearch.Text & "*' or Fonction LIKE '" & Zsearch.Text & "*' or Adresse LIKE '" & Zsearch.Text & "*' or Ville LIKE '" & Zsearch.Text & "*'  or Email LIKE '" & Zsearch.Text & "*'  or Telephone LIKE '" & Zsearch.Text & "*' "
        'Me.DataGridView1.DataSource = bs
        LrowsCount.Text = DataGridView1.Rows.Count
    End Sub

    Private Sub BtableNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtableNext.Click
        bs.MoveNext()
    End Sub

    Private Sub BtableLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtableLast.Click
        bs.MoveLast()
    End Sub

    Private Sub BtablePrev_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtablePrev.Click
        bs.MovePrevious()
    End Sub

    Private Sub BtableFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtableFirst.Click
        bs.MoveFirst()
    End Sub

    'Show employe details
    Private Sub DataGridView1_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        If e.RowIndex >= 0 Then
            selectedrow = DataGridView1.Rows(e.RowIndex)
            Dim objItemCategories As New formEmployeDetails
            objItemCategories.StartPosition = FormStartPosition.CenterParent
            objItemCategories.ShowDialog(Me)
        End If
    End Sub
    Public Shared Property selectedrow As DataGridViewRow

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Helpers.clearTextBox(Me)
    End Sub
End Class