Public Class Intro
    Private Sub PinTxt_GotFocus(sender As Object, e As EventArgs) Handles PinTxt.GotFocus
        If PinTxt.Text = "Pin" Then
            PinTxt.Clear()
        End If
    End Sub

    Private Sub PinTxt_LostFocus(sender As Object, e As EventArgs) Handles PinTxt.LostFocus
        If PinTxt.Text = "" Then
            PinTxt.Text = "Pin"
        End If
    End Sub

    Private Sub SSNTxt_GotFocus(sender As Object, e As EventArgs) Handles SSNTxt.GotFocus
        If SSNTxt.Text = "Social Security Number" Then
            SSNTxt.Clear()
        End If
    End Sub

    Private Sub SSNTxt_LostFocus(sender As Object, e As EventArgs) Handles SSNTxt.LostFocus
        If SSNTxt.Text = "" Then
            SSNTxt.Text = "Social Security Number"
        End If
    End Sub

    Private Sub MaidenTxt_GotFocus(sender As Object, e As EventArgs) Handles MaidenTxt.GotFocus
        If MaidenTxt.Text = "Mother's Maiden Name" Then
            MaidenTxt.Clear()
        End If
    End Sub

    Private Sub MaidenTxt_LostFocus(sender As Object, e As EventArgs) Handles MaidenTxt.LostFocus
        If MaidenTxt.Text = "" Then
            MaidenTxt.Text = "Mother's Maiden Name"
        End If
    End Sub

    Private Sub CreditInfoTxt_GotFocus(sender As Object, e As EventArgs) Handles CreditInfoTxt.GotFocus
        If CreditInfoTxt.Text = "Credit Card Info" Then
            CreditInfoTxt.Clear()
        End If
    End Sub

    Private Sub CreditInfoTxt_LostFocus(sender As Object, e As EventArgs) Handles CreditInfoTxt.LostFocus
        If CreditInfoTxt.Text = "" Then
            CreditInfoTxt.Text = "Credit Card Info"
        End If
    End Sub

    Private Sub SpecialTxt_GotFocus(sender As Object, e As EventArgs) Handles SpecialTxt.GotFocus
        If SpecialTxt.Text = "Special Pin" Then
            SpecialTxt.Clear()
        End If
    End Sub

    Private Sub SpecialTxt_LostFocus(sender As Object, e As EventArgs) Handles SpecialTxt.LostFocus
        If SpecialTxt.Text = "" Then
            SpecialTxt.Text = "Special Pin"
        End If
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If SpecialTxt.Text = "Special Pin" Then
            If PinTxt.Text <> "Pin" And SSNTxt.Text <> "Social Security Number" And
                MaidenTxt.Text <> "Mother's Maiden Name" And CreditInfoTxt.Text <> "Credit Card Info" Then
                AccountHolder.Show()
                Me.Close()
            End If
        ElseIf SpecialTxt.Text = "1" Then
            BankTeller.Show()
            Me.Close()
        ElseIf SpecialTxt.Text = "2" Then
            LoanOfficer.Show()
            Me.Close()
        ElseIf SpecialTxt.Text = "3" Then
            Manager.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid pin in special pin area.", "Special Pin Access Denied")
        End If
    End Sub
End Class
