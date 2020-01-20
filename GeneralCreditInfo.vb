Public Class GeneralCreditInfo
    Dim CheckMessage As String
    Private Sub GeneralCreditInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstInfo.Items.Add("Address: 99 Wall St., New York, NY 10005")
        lstInfo.Items.Add("IP Address: 99.999.999.99")
        lstInfo.Items.Add("Last Deposit Date: 2 Apr. 2019")
        lstInfo.Items.Add("Deposit Amount: $50,000")
        lstInfo.Items.Add("Last Withdrawal Date: 26 Apr. 2019")
        lstInfo.Items.Add("Withdrawal Amount: $100,000")
        lstInfo.Items.Add("Account Savings: $942,368")

        CheckMessage = "Check has been created."

        CreatedLbl.BackColor = System.Drawing.Color.Transparent
        YesRad.BackColor = System.Drawing.Color.Transparent
        NoRad.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub ProcessBtn_Click(sender As Object, e As EventArgs) Handles ProcessBtn.Click
        If NoRad.Checked = True Then
            YesRad.Checked = True
            NoRad.Checked = False
            MessageBox.Show(CheckMessage, "Processing Check Successful")
        ElseIf YesRad.Checked = True Then
            MessageBox.Show("Check has already been created.", "Processing Check Denied")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
