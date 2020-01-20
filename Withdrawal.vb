Public Class Withdrawal
    Dim gdecSavings, gdecWithdrawalAmount As Decimal

    Private Sub Withdrawal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentLbl.BackColor = System.Drawing.Color.Transparent
        WithdrawalLbl.BackColor = System.Drawing.Color.Transparent
        totLbl.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        Me.Close()
    End Sub
End Class
