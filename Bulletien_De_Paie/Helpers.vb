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
End Module
