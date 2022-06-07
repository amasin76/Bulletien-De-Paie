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
        cnx.Open()
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

End Class