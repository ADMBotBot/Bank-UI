Public Class BankTeller
    Dim AccountName, OpenMessage1, OpenMessage2, DeleteMessage1, DeleteMessage2, Creation As String
    Private Sub GeneralBtn_Click(sender As Object, e As EventArgs) Handles GeneralBtn.Click
        AccountName = AccountNameTxt.Text
        GeneralCreditInfo.lstInfo.Items.Add(AccountNameTxt.Text)
        GeneralCreditInfo.Show()
    End Sub

    Private Sub RequestBtn_Click(sender As Object, e As EventArgs) Handles RequestBtn.Click
        If YesRad.Checked = True Then
            RequestForm.Show()
        ElseIf NoRad.Checked = True Then
            MessageBox.Show("Request has not been sent from the General Manager of the Bank.", "Request Send Denied")
        End If
    End Sub

    Private Sub SupportBtn_Click(sender As Object, e As EventArgs) Handles SupportBtn.Click
        AccountSupport.Show()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Intro.Show()
        Me.Close()
    End Sub

    Private Sub BankTeller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenMessage1 = "Account has been opened for: "
        OpenMessage2 = "Account has already been activated for: "
        DeleteMessage1 = "Account has already been deactivated for: "
        DeleteMessage2 = "Account has been deactivated for: "
        Creation = "Yes"

        AccountNameLbl.BackColor = System.Drawing.Color.Transparent
        RequestLbl.BackColor = System.Drawing.Color.Transparent
        NoRad.BackColor = System.Drawing.Color.Transparent
        YesRad.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        AccountName = AccountNameTxt.Text
        If Creation = "No" Then
            MessageBox.Show(OpenMessage1 & AccountName, "Account Creation Successful")
            Creation = "Yes"
        ElseIf Creation <> "No" Then
            MessageBox.Show(OpenMessage2 & AccountName, "Account Creation Denied")
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        AccountName = AccountNameTxt.Text
        If Creation = "No" Then
            MessageBox.Show(DeleteMessage1 & AccountName, "Account Deletion Denied")
        ElseIf Creation <> "No" Then
            MessageBox.Show(DeleteMessage2 & AccountName, "Account Deletion Successful")
            Creation = "No"
        End If
    End Sub
End Class
