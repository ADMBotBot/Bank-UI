Public Class MortgageLoanForm
    Private Sub MortgageLoanForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstInfo.Items.Add("Address: 99 Wall St., New York, NY 10005")
        lstInfo.Items.Add("IP Address: 99.999.999.99")
        lstInfo.Items.Add("Last Deposit Date: 2 Apr. 2019")
        lstInfo.Items.Add("Deposit Amount: $50,000")
        lstInfo.Items.Add("Last Withdrawal Date: 26 Apr. 2019")
        lstInfo.Items.Add("Withdrawal Amount: $100,000")
        lstInfo.Items.Add("Account Savings: $942,368")
        lstInfo.Items.Add("Number of Cars Acquired: 10")
        lstInfo.Items.Add("Number of Houses Acquired: 5")
        lstInfo.Items.Add("Last Loan Requested Date: 23 Mar. 2015")
        lstInfo.Items.Add("Loan Amount: $530,000")
        lstInfo.Items.Add("Was Loan Paid?: Yes")
        lstInfo.Items.Add("Last Mortgage Requested Date: 5 Dec. 2016")
        lstInfo.Items.Add("Mortgage Amount: $750,000")
        lstInfo.Items.Add("Was Mortgage Paid?: Yes")
    End Sub

    Private Sub MortgageBtn_Click(sender As Object, e As EventArgs) Handles MortgageBtn.Click
        If MortgageCheck.Checked = True Then
            MessageBox.Show("Mortgage has been confirmed and will be sent to account holder.", "Mortgage Confirmation")
            MortgageCheck.Checked = False
        ElseIf MortgageCheck.Checked = False Then
            MessageBox.Show("Mortgage was not requested for account holder.", "Mortgage Confirmation Error")
        End If
    End Sub

    Private Sub LoanBtn_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        If LoanCheck.Checked = True Then
            MessageBox.Show("Loan has been confirmed and will be sent to account holder.", "Loan Confirmation")
            LoanCheck.Checked = False
        ElseIf LoanCheck.Checked = False Then
            MessageBox.Show("Loan was not requested for account holder.", "Loan Confirmation Error")
        End If
    End Sub

    Private Sub DenyMortBtn_Click(sender As Object, e As EventArgs) Handles DenyMortBtn.Click
        If MortgageCheck.Checked = True Then
            MessageBox.Show("Mortgage has been denied and account holder will be notified.", "Mortgage Denial")
            MortgageCheck.Checked = False
        ElseIf MortgageCheck.Checked = False Then
            MessageBox.Show("Mortgage was not requested for account holder.", "Mortgage Denial Error")
        End If
    End Sub

    Private Sub DenyLoanBtn_Click(sender As Object, e As EventArgs) Handles DenyLoanBtn.Click
        If LoanCheck.Checked = True Then
            MessageBox.Show("Loan has been denied and account holder will be notified.", "Loan Denial")
            LoanCheck.Checked = False
        ElseIf LoanCheck.Checked = False Then
            MessageBox.Show("Loan was not requested for account holder.", "Loan Denial Error")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
