Imports System.Data.OleDb
Imports System.Security.Cryptography

Public Class LoginForm
    Dim eyeIcon = My.Resources.eye
    Dim hiddenIcon = My.Resources.hidden
    Dim tryLimit As Integer
    Public strBarUser As String

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        PictureBox1.Image = eyeIcon
        If cnx.State = ConnectionState.Closed Then cnx.Open()
    End Sub

    Private Sub Blogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Blogin.Click
        If tryLimit = 2 Then
            MsgBox("You’ve reached the maximum logon attempts", 0, "Login Rate Limit")
            Me.Close()
        End If

        'cmd = New OleDbCommand("Select * From Account where username='" & Zuser.Text & "' AND password='" & Zpswd.Text & "'", cnx)
        cmd = New OleDbCommand("Select * From Account where username = @user and StrComp(password, @password, 0) = 0", cnx)
        cmd.Parameters.Add("@user", OleDbType.VarWChar).Value = Zuser.Text
        cmd.Parameters.Add("@password", OleDbType.VarWChar).Value = MD5Hash(Zpswd.Text)
        Try
            Dim r As OleDb.OleDbDataReader = cmd.ExecuteReader
            If r.Read() Then
                strBarUser = r("username") & " - " & r("permessions")
                cnx.Close()
                Me.Hide()
                Form1.Show()
            Else
                tryLimit += 1
                Lincorrect.Text = tryLimit & " Nom d'utilisateur ou mot de passe incorrect"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Toggle eye image
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If PictureBox1.Image Is eyeIcon Then
            PictureBox1.Image = hiddenIcon
            Zpswd.PasswordChar = Nothing
        Else
            PictureBox1.Image = eyeIcon
            Zpswd.PasswordChar = "*"
        End If
    End Sub

    'PlaceHolder Login
    Private Sub Zuser_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zuser.Enter
        If Zuser.Text = "Nom D'Utilisateur" Then
            Zuser.Text = ""
            Zuser.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Zuser_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zuser.Leave
        If Zuser.Text = "" Then
            Zuser.Text = "Nom D'Utilisateur"
            Zuser.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Zpswd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zpswd.Enter
        If Zpswd.Text = "Mot De Passe" Then
            Zpswd.Text = ""
            Zpswd.PasswordChar = "*"
            PictureBox1.Image = eyeIcon
            Zpswd.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Zpswd_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zpswd.Leave
        If Zpswd.Text = "" Then
            Zpswd.Text = "Mot De Passe"
            Zpswd.PasswordChar = ""
            PictureBox1.Image = hiddenIcon
            Zpswd.ForeColor = Color.DarkGray
        End If
    End Sub

    'PlaceHolder SignUp
    Private Sub ZuserNew_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZuserNew.Enter
        If ZuserNew.Text = "Nom D'Utilisateur" Then
            ZuserNew.Text = ""
            ZuserNew.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ZuserNew_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZuserNew.Leave
        If ZuserNew.Text = "" Then
            ZuserNew.Text = "Nom D'Utilisateur"
            ZuserNew.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub ZpwdNew_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZpwdNew.Enter
        If ZpwdNew.Text = "Mot De Passe" Then
            ZpwdNew.Text = ""
            'ZpwdNew.PasswordChar = "*"
            ZpwdNew.ForeColor = Color.Black
        End If
    End Sub

    Private Sub ZpwdNew_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZpwdNew.Leave
        If ZpwdNew.Text = "" Then
            ZpwdNew.Text = "Mot De Passe"
            'ZpwdNew.PasswordChar = ""
            ZpwdNew.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Zpwd2New_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zpwd2New.Enter
        If Zpwd2New.Text = "Répéter Mot De Passe" Then
            Zpwd2New.Text = ""
            'Zpwd2New.PasswordChar = "*"
            Zpwd2New.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Zpwd2New_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zpwd2New.Leave
        If Zpwd2New.Text = "" Then
            Zpwd2New.Text = "Répéter Mot De Passe"
            'Zpwd2New.PasswordChar = ""
            Zpwd2New.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel3.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Panel3.Visible = False
    End Sub

    'Validate The New Password
    Private Sub ZpwdNew_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZpwdNew.KeyUp
        Dim pwdScore As Integer = Helpers.ValidatePassword(ZpwdNew.Text)
        Select Case pwdScore
            Case 0
                LcharMin.Text = "Minimum des characters est 8"
                LcharMin.ForeColor = Color.Red
            Case 1
                LcharMin.Text = ""
                LpwdStatus.Text = "Faible"
                LpwdStatus.ForeColor = Color.Red
            Case 2
                LcharMin.Text = ""
                LpwdStatus.Text = "Moyen"
                LpwdStatus.ForeColor = Color.Yellow
            Case 3
                LcharMin.Text = ""
                LpwdStatus.Text = "Bien"
                LpwdStatus.ForeColor = Color.GreenYellow
            Case 4
                LcharMin.Text = ""
                LpwdStatus.Text = "Fort"
                LpwdStatus.ForeColor = Color.Lime
            Case Else
                LcharMin.Text = ""
                'Debug.WriteLine("Null")
        End Select
    End Sub

    'Validate The New Re-Password
    Private Sub Zpwd2New_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Zpwd2New.KeyUp
        If Not ZpwdNew.Text = "" Then
            If Not Zpwd2New.Text = ZpwdNew.Text Then
                LrePwdStatus.Text = "Non-conforme"
                LrePwdStatus.ForeColor = Color.Red
            ElseIf Zpwd2New.Text = ZpwdNew.Text Then
                LrePwdStatus.Text = "Conforme"
                LrePwdStatus.ForeColor = Color.Lime
            End If
        End If
    End Sub


    Private Sub Bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsave.Click
        'Validate inputs
        If ZuserNew.Text = "" Or ZuserNew.Text = "Nom D'Utilisateur" Then
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Warning
            ToolTip1.ToolTipTitle = "CHAMP VIDE"
            ToolTip1.Show("Svp donnez nom d'utilisateur", ZuserNew, New Point(0, -80), 3000)
            Exit Sub
        ElseIf ZpwdNew.Text = "" Or ZpwdNew.Text = "Mot De Passe" Then
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Warning
            ToolTip1.ToolTipTitle = "CHAMP VIDE"
            ToolTip1.Show("Svp donnez mot de passe", ZpwdNew, New Point(0, -80), 3000)
            Exit Sub
        ElseIf Zpwd2New.Text = "" Or Zpwd2New.Text = "Répéter Mot De Passe" Then
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Warning
            ToolTip1.ToolTipTitle = "CHAMP VIDE"
            ToolTip1.Show("Svp donnez mot de passe", Zpwd2New, New Point(0, -80), 3000)
            Exit Sub
        ElseIf Not Caccepte.Checked Then
            Dim ToolTip1 As New ToolTip
            ToolTip1.IsBalloon = True
            ToolTip1.UseFading = True
            ToolTip1.ToolTipIcon = ToolTipIcon.Warning
            ToolTip1.ToolTipTitle = "CHAMP VIDE"
            ToolTip1.Show("Si vous accepte", Caccepte, New Point(0, -80), 3000)
            Exit Sub
        End If

        'Save
        Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO Account (`username`, `password`) VALUES (@user, @pwd)", cnx)
        cmd.Parameters.Add("@user", OleDbType.VarWChar).Value = ZuserNew.Text
        cmd.Parameters.Add("@password", OleDbType.VarWChar).Value = MD5Hash(ZpwdNew.Text)

        Try
            cmd.ExecuteNonQuery()
            MsgBox(Zuser.Text & " est enregistré")
            Panel3.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class