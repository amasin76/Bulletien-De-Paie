Imports System.Data.OleDb
Imports System.IO
Public Class formEmployeDetails
    Dim MyDocuments As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

    Private Sub formEmployeDetails_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim matSelected As String, imgName As String = "", cvName As String = "", pathImgString As String, pathCvString As String
        matSelected = formEmployee.selectedrow.Cells(0).Value.ToString()

        If cnx.State = ConnectionState.Closed Then
            cnx.Open()
        End If
        Dim command As String
        Dim reader As OleDbDataReader
        command = "SELECT * FROM Employe where Mat = @Mat"
        Dim cmd As OleDbCommand = New OleDbCommand(command, cnx)
        cmd.Parameters.AddWithValue("@Mat", OleDbType.VarChar).Value = matSelected
        'cmd.Parameters.AddWithValue("@Mat", matSelected)
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            Zmat_dt.Text = matSelected
            Znpr_dt.Text = reader("Nom_Prenom")
            Zfn_dt.Text = reader("Fonction")
            Csexe.Text = reader("Sexe")
            Dnas.Text = reader("Date_N")
            Zadrs_dt.Text = reader("Adresse")
            Zvil_dt.Text = reader("Ville")
            Zemail_dt.Text = reader("Email")
            Ztel_dt.Text = reader("Telephone")
            Ddem_dt.Text = reader("DEM")
            Znen_dt.Text = reader("Enfants")
            If Not IsDBNull(reader("Photo")) Then imgName = reader("Photo")
            If Not IsDBNull(reader("CV")) Then cvName = reader("CV") Else LinkLabel1.Enabled = False
        End If

        pathImgString = System.IO.Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos", imgName)
        pathCvString = System.IO.Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV", cvName)

        'Load Image
        If System.IO.File.Exists(pathImgString) Then
            Using str As Stream = File.OpenRead(pathImgString)
                Pemploye.Image = Image.FromStream(str)
            End Using
        Else
            Pemploye.Image = My.Resources.x
        End If

        'Load CV
        If System.IO.File.Exists(pathCvString) Then
            Label15.Text = cvName
        Else
            Label15.Text = "Fichier introuvable"
        End If
        cnx.Close()
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
                    imgName = Zmat_dt.Text & Path.GetExtension(OpenFileDialog1.FileName).ToLower()
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
                    cvName = Zmat_dt.Text & Path.GetExtension(OpenFileDialog2.FileName).ToLower()
                    Label15.Text = Path.GetFileName(OpenFileDialog2.FileName)
                    If Not System.IO.Directory.Exists(Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV")) Then
                        System.IO.Directory.CreateDirectory(Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV"))
                    End If
                    pathCvString = Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV", cvName)
                End If
            End With
        End Using
    End Sub

    Private Sub Bedit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bedit.Click
        Znpr_dt.ReadOnly = False
        Zfn_dt.ReadOnly = False
        Csexe.Enabled = True
        Dnas.Enabled = True
        Zadrs_dt.ReadOnly = False
        Zvil_dt.ReadOnly = False
        Zemail_dt.ReadOnly = False
        Ztel_dt.ReadOnly = False
        Ddem_dt.Enabled = True
        Znen_dt.ReadOnly = False
        Pemploye.Enabled = True
        Bcv.Enabled = True
        Lplus.Enabled = True
    End Sub

    Private Sub Bsave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bsave.Click
        Dim strsql As String
        strsql = "UPDATE Employe SET Nom_Prenom = @npr, Fonction = @fn, Date_N = @date_n, sexe = @sexe, Adresse = @adrs, Ville = @vil, Email = @email, Telephone = @tel, DEM = @dem, Enfants = @nen WHERE Mat = '" & Zmat_dt.Text & "'"

        cmd = New OleDbCommand(strsql, cnx)
        cmd.Parameters.Add("@npr", OleDbType.VarWChar).Value = Znpr_dt.Text
        cmd.Parameters.Add("@fn", OleDbType.VarChar).Value = Zfn_dt.Text
        cmd.Parameters.Add("date_n", OleDbType.Date).Value = Dnas.Value.Date
        cmd.Parameters.Add("@sexe", OleDbType.VarChar).Value = Csexe.Text
        cmd.Parameters.Add("@adrs", OleDbType.VarChar).Value = Zadrs_dt.Text
        cmd.Parameters.Add("@vil", OleDbType.VarChar).Value = Zvil_dt.Text
        cmd.Parameters.Add("@email", OleDbType.VarWChar).Value = Zemail_dt.Text
        cmd.Parameters.Add("@tel", OleDbType.VarChar).Value = Ztel_dt.Text
        cmd.Parameters.Add("@dem", OleDbType.VarChar).Value = Ddem_dt.Text
        cmd.Parameters.Add("@nen", OleDbType.VarChar).Value = Znen_dt.Text

        Try
            If cnx.State = ConnectionState.Closed Then
                cnx.Open()
            End If
            cmd.ExecuteNonQuery()
            Dim a As Image = Pemploye.Image
            If (System.IO.File.Exists(pathImgString)) Then
                MsgBox(1)
                System.IO.File.Delete(pathImgString)
                MsgBox(2)
                a.Save(pathImgString)
            End If
            File.Copy(pathSourceCvString, pathCvString, True)
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
                If cnx.State = ConnectionState.Closed Then
                    cnx.Open()
                End If
                cmd.ExecuteNonQuery()
                cnx.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Me.Close()
            End Try
        End If

    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        If Not Label15.Text = "Fichier introuvable" Then
            LinkLabel1.Enabled = True
            Dim pathCvString As String = System.IO.Path.Combine(MyDocuments, "Bio Tech", "Employés", "CV", Label15.Text)
            Process.Start(pathCvString)
        End If
    End Sub

    'Private Sub Pemploye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pemploye.Click
    '    Using OpenFileDialog1 As OpenFileDialog = New OpenFileDialog()

    '        Dim MyDocuments As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '        With OpenFileDialog1
    '            .Filter = "choose image(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png"
    '            .FileName = ""
    '            .Title = "choose a picture..."
    '            .AddExtension = True
    '            .FilterIndex = 1
    '            .Multiselect = False
    '            .ValidateNames = True
    '            If (.ShowDialog = DialogResult.OK) Then
    '                If CInt(OpenFileDialog1.OpenFile.Length) > 256000 Then
    '                    MsgBox("La taille de l'image sélectionnée " & FormatToHumanReadableFileSize(OpenFileDialog1.OpenFile.Length) & " dépasse le maximum: 256KB")
    '                    Exit Sub
    '                End If

    '                imgName = Zmat.Text & Path.GetExtension(OpenFileDialog1.FileName).ToLower()
    '                Pemploye.Image = Image.FromFile(OpenFileDialog1.FileName)
    '                If Not System.IO.Directory.Exists(Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos")) Then
    '                    System.IO.Directory.CreateDirectory(Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos"))
    '                End If
    '                pathImgString = Path.Combine(MyDocuments, "Bio Tech", "Employés", "Photos", imgName)
    '            End If
    '        End With
    '    End Using
    'End Sub
End Class