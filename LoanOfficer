Public Class LoanOfficer
    Private Sub LoanOfficer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AccountNameLbl.BackColor = System.Drawing.Color.Transparent
        RequestLbl.BackColor = System.Drawing.Color.Transparent
        NoRad.BackColor = System.Drawing.Color.Transparent
        YesRad.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub GeneralBtn_Click(sender As Object, e As EventArgs) Handles GeneralBtn.Click
        MortgageLoanForm.lstInfo.Items.Add(AccountNameTxt.Text)
        MortgageLoanForm.Show()
    End Sub

    Private Sub RequestBtn_Click(sender As Object, e As EventArgs) Handles RequestBtn.Click
        If YesRad.Checked = True Then
            RequestForm.Show()
        ElseIf NoRad.Checked = True Then
            MessageBox.Show("Request has not been sent from the General Manager of the Bank.", "Request Send Denied")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Intro.Show()
        Me.Close()
    End Sub

End Class
