Public Class AccountHolder
    Dim gdecWithdrawal, gdecDepo, gdecSavings As Decimal
    Dim savingsmessage1, savingsmessage2 As String

    Private Sub AccountHolder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gdecSavings = 1000000
        savingsmessage1 = "There is currently "
        savingsmessage2 = " in your account."
        WelcomeLbl.BackColor = System.Drawing.Color.Transparent
        LoanLbl.BackColor = System.Drawing.Color.Transparent
        LoanTxt.Text = "$0.00"
        MortgageLbl.BackColor = System.Drawing.Color.Transparent
        MortgageTxt.Text = "$0.00"
        DepoLbl.BackColor = System.Drawing.Color.Transparent
        DepoTxt.Text = "$0.00"
        WithdrawalLbl.BackColor = System.Drawing.Color.Transparent
        WithdrawalTxt.Text = "$0.00"
    End Sub

    Private Sub LoanBtn_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        If LoanTxt.Text <> "$0.00" Then
            MessageBox.Show("Loan amount will be processed once verified in 5 business days.", "Loan Verification")
            MortgageLoanForm.lstInfo.Items.Add("Loan Request Amount: " + LoanTxt.Text)
            MortgageLoanForm.LoanCheck.Checked = True
        Else
            MessageBox.Show("Invalid amount displayed.", "Loan Verification Error")
        End If
    End Sub

    Private Sub LoanTxt_Click(sender As Object, e As EventArgs) Handles LoanTxt.Click
        If LoanTxt.Text <> "$0.00" Then
            LoanTxt.SelectAll()
        End If
    End Sub

    Private Sub LoanTxt_GotFocus(sender As Object, e As EventArgs) Handles LoanTxt.GotFocus
        If LoanTxt.Text = "$0.00" Then
            LoanTxt.Clear()
        End If
    End Sub

    Private Sub LoanTxt_LostFocus(sender As Object, e As EventArgs) Handles LoanTxt.LostFocus
        If LoanTxt.Text = "" Then
            LoanTxt.Text = "$0.00"
        Else
            LoanTxt.Text = Format(LoanTxt.Text, "Currency")
        End If
    End Sub

    Private Sub MortgageBtn_Click(sender As Object, e As EventArgs) Handles MortgageBtn.Click
        If MortgageTxt.Text <> "$0.00" Then
            MessageBox.Show("Mortgage amount will be processed once verified in 20 business days.", "Mortgage Verification")
            MortgageLoanForm.lstInfo.Items.Add("Mortgage Request Amount: " + MortgageTxt.Text)
            MortgageLoanForm.MortgageCheck.Checked = True
        Else
            MessageBox.Show("Invalid amount displayed.", "Mortgage Verification Error")
        End If
    End Sub

    Private Sub MortgageTxt_Click(sender As Object, e As EventArgs) Handles MortgageTxt.Click
        If MortgageTxt.Text <> "$0.00" Then
            MortgageTxt.SelectAll()
        End If
    End Sub

    Private Sub MortgageTxt_GotFocus(sender As Object, e As EventArgs) Handles MortgageTxt.GotFocus
        If MortgageTxt.Text = "$0.00" Then
            MortgageTxt.Clear()
        End If
    End Sub

    Private Sub MortgageTxt_LostFocus(sender As Object, e As EventArgs) Handles MortgageTxt.LostFocus
        If MortgageTxt.Text = "" Then
            MortgageTxt.Text = "$0.00"
        Else
            MortgageTxt.Text = Format(MortgageTxt.Text, "Currency")
        End If
    End Sub

    Private Sub DepositBtn_Click(sender As Object, e As EventArgs) Handles DepositBtn.Click
        Deposit.Show()
        gdecDepo = CDec("0" & Format(DepoTxt.Text, "Standard"))
        Deposit.SavingsTxt.Text = Format(gdecSavings, "Currency")
        Deposit.DepoAmountTxt.Text = Format(gdecDepo, "Currency")
        Deposit.totSavingsTxt.Text = Format(gdecSavings + gdecDepo, "Currency")
        gdecSavings = gdecSavings + gdecDepo
    End Sub

    Private Sub DepoTxt_Click(sender As Object, e As EventArgs) Handles DepoTxt.Click
        If DepoTxt.Text <> "$0.00" Then
            DepoTxt.SelectAll()
        End If
    End Sub

    Private Sub DepoTxt_GotFocus(sender As Object, e As EventArgs) Handles DepoTxt.GotFocus
        If DepoTxt.Text = "$0.00" Then
            DepoTxt.Clear()
        End If
    End Sub

    Private Sub DepoTxt_LostFocus(sender As Object, e As EventArgs) Handles DepoTxt.LostFocus
        If DepoTxt.Text = "" Then
            DepoTxt.Text = "$0.00"
        Else
            DepoTxt.Text = Format(DepoTxt.Text, "Currency")
        End If
    End Sub

    Private Sub WithdrawalBtn_Click(sender As Object, e As EventArgs) Handles WithdrawalBtn.Click
        Withdrawal.Show()
        gdecWithdrawal = CDec("0" & Format(WithdrawalTxt.Text, "Standard"))
        Withdrawal.SavingsTxt.Text = Format(gdecSavings, "Currency")
        Withdrawal.WithdrawalAmountTxt.Text = Format(gdecWithdrawal, "Currency")
        Withdrawal.totSavingsTxt.Text = Format(gdecSavings - gdecWithdrawal, "Currency")
        gdecSavings = gdecSavings - gdecWithdrawal
    End Sub

    Private Sub WithdrawalTxt_Click(sender As Object, e As EventArgs) Handles WithdrawalTxt.Click
        If WithdrawalTxt.Text <> "$0.00" Then
            WithdrawalTxt.SelectAll()
        End If
    End Sub

    Private Sub WithdrawalTxt_GotFocus(sender As Object, e As EventArgs) Handles WithdrawalTxt.GotFocus
        If WithdrawalTxt.Text = "$0.00" Then
            WithdrawalTxt.Clear()
        End If
    End Sub

    Private Sub WithdrawalTxt_LostFocus(sender As Object, e As EventArgs) Handles WithdrawalTxt.LostFocus
        If WithdrawalTxt.Text = "" Then
            WithdrawalTxt.Text = "$0.00"
        Else
            WithdrawalTxt.Text = Format(WithdrawalTxt.Text, "Currency")
        End If
    End Sub

    Private Sub CheckBtn_Click(sender As Object, e As EventArgs) Handles CheckBtn.Click
        Check.Show()
    End Sub

    Private Sub Wealth_Click(sender As Object, e As EventArgs) Handles Wealth.Click
        Rich.Show()
    End Sub

    Private Sub BalanceBtn_Click(sender As Object, e As EventArgs) Handles BalanceBtn.Click
        MessageBox.Show(savingsmessage1 & Format(gdecSavings, "Currency") & savingsmessage2, "Balance")
    End Sub

    Private Sub CreditBtn_Click(sender As Object, e As EventArgs) Handles CreditBtn.Click
        CreditCard.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Intro.Show()
        Me.Close()
    End Sub
End Class
