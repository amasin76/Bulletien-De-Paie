Imports System.Text
Imports System.Security.Cryptography
Module Helpers
    Public Function primeAnc(ByVal x As Integer) As Single
        Dim t As Single
        If x >= 2 Then
            t = 0.05
        ElseIf x >= 5 Then
            t = 0.1
        ElseIf x >= 12 Then
            t = 0.15
        ElseIf x >= 20 Then
            t = 0.2
        End If

        Return t
    End Function
    Public Function primeAns(ByVal x As Single, ByVal month As Integer) As Single
        Dim t As Single
        If month = 12 Then
            If x <= 2000 Then
                t = 500
            ElseIf x <= 3000 Then
                t = 800
            ElseIf x > 3000 Then
                t = 1200
            End If
        Else
            t = 0
        End If
        Return t
    End Function
    Public Function primeEnf(ByVal x As Integer) As Single
        Dim t As Single
        If x <= 3 Then
            t = x * 300
        ElseIf x <= 6 Then
            t = (3 * 300) + (x - 3 * 36)
        Else
            t = 1008
        End If

        Return t
    End Function
    Public Function mCnss(ByVal x As Integer) As Single
        Dim m As Single
        If x < 6000 Then
            m = x * 0.0429
        Else
            m = 257.4
        End If

        Return m
    End Function
    Public Function clearTextBox(ByVal parent As Control)
        Dim i As Integer = 0

        For Each child As Control In parent.Controls
            clearTextBox(child)
            If TypeOf child Is TextBox And Not child.TabIndex = 99 Then
                CType(child, TextBox).Text = String.Empty
                i += 1
            End If
        Next

        Return i
    End Function
    Function ValidatePassword(ByVal pwd As String,
    Optional ByVal minLength As Integer = 8,
    Optional ByVal numUpper As Integer = 1,
    Optional ByVal numLower As Integer = 1,
    Optional ByVal numNumbers As Integer = 1,
    Optional ByVal numSpecial As Integer = 1) As Integer

        Dim score As Integer = 0
        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return 0
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count >= numUpper Then score = score + 1
        If lower.Matches(pwd).Count >= numLower Then score = score + 1
        If number.Matches(pwd).Count >= numNumbers Then score = score + 1
        If special.Matches(pwd).Count >= numSpecial Then score = score + 1

        ' Passed all checks.
        Return score
    End Function
    Function MD5Hash(ByVal input As String) As String
        Dim MD5Hasher As MD5 = MD5.Create()
        Dim data As Byte() = MD5Hasher.ComputeHash(Encoding.Default.GetBytes(input))
        Dim sBuilder As New StringBuilder()

        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next

        Return sBuilder.ToString
    End Function
End Module
