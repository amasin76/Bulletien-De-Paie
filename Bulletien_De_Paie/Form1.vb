Public Class Form1
    Private currentBtn As Button
    Private leftBorderBtn As Panel
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        change_menu("Accueil")
        Luser.Text = LoginForm.strBarUser
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 72)
        SidePanel.Controls.Add(leftBorderBtn)
    End Sub

    Private Sub ActiveButton(ByVal senderBtn As Object, ByVal customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(55, 55, 55)
            currentBtn.ForeColor = Color.White
            'currentBtn.IconColor = Color.White

            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y + 100)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(39, 39, 39)
            currentBtn.ForeColor = Color.FromArgb(167, 160, 167)
            'currentBtn.IconColor = Color.White
        End If
    End Sub

    Private Sub addForm(ByVal frm As Form)
        PanelContainer.Controls.Clear()
        frm.TopLevel = False
        frm.TopMost = True
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()
    End Sub

    Private Sub change_menu(ByVal menu As String)
        Dim Accueil As New formAccueil
        Dim Employee As New formEmployee
        Dim Bulletien As New formBulletien
        Dim Conge As New formConge
        Dim Stats As New formStats
        Select Case menu
            Case "Accueil"
                addForm(Accueil)
            Case "Employee"
                addForm(Employee)
            Case "Bulletien"
                addForm(Bulletien)
            Case "Conge"
                addForm(Conge)
            Case "Stats"
                addForm(Stats)
        End Select
    End Sub

    Private Sub Bac_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bac.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Accueil")
    End Sub

    Private Sub Bem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bem.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Employee")
    End Sub

    Private Sub Bbu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bbu.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Bulletien")
    End Sub

    Private Sub Bco_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bco.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Conge")
    End Sub

    Private Sub Bst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bst.Click
        ActiveButton(sender, RgbColors.color3)
        change_menu("Stats")
    End Sub

    'Colse / Max / Min Buttons
    Private Sub Bclose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bclose.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure want to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.None)

        If response = vbYes Then
            Application.ExitThread()
        End If
    End Sub

    Private Sub Bmax_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bmax.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        ElseIf WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub Bmin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Bmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Dim mouse_move As System.Drawing.Point
    Private Sub HeaderPanel_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub HeaderPanel_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HeaderPanel.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.Opacity = 0.8
            Dim mPosition As Point
            mPosition = Control.MousePosition
            mPosition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mPosition
        Else
            Me.Opacity = 1
        End If
    End Sub
End Class
