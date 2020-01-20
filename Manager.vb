Public Class Manager
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstInfo.Items.Add("John Smith")
        lstInfo.Items.Add("Ophelia Tellerson")
        lstInfo.Items.Add("Hamish Tiller")
        lstInfo.Items.Add("Nathan Tiller")
        lstInfo.Items.Add("Carl Timpson")
        lstInfo.Items.Add("Earl Timpson")
        lstInfo.Items.Add("Napoleon Timpson")
        lstInfo.Items.Add("Anonymous Trader")
    End Sub

    Private Sub NameTxt_GotFocus(sender As Object, e As EventArgs) Handles NameTxt.GotFocus
        If NameTxt.Text = "Account Name" Then
            NameTxt.Clear()
        End If
    End Sub

    Private Sub NameTxt_LostFocus(sender As Object, e As EventArgs) Handles NameTxt.LostFocus
        If NameTxt.Text = "" Then
            NameTxt.Text = "Account Name"
        End If
    End Sub

    Private Sub AccessBtn_Click(sender As Object, e As EventArgs) Handles AccessBtn.Click
        AllAccountInfo.Show()
    End Sub

    Private Sub LoanBtn_Click(sender As Object, e As EventArgs) Handles LoanBtn.Click
        MessageBox.Show("Request was sent to all loan officers for info specific to: " + NameTxt.Text, "Request Sent To Loan Officers")
        LoanOfficer.YesRad.Checked = True
    End Sub

    Private Sub BankBtn_Click(sender As Object, e As EventArgs) Handles BankBtn.Click
        MessageBox.Show("Request was sent to all bank tellers for info specific to: " + NameTxt.Text, "Request Sent To Bank Tellers")
        BankTeller.YesRad.Checked = True
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Intro.Show()
        Me.Close()
    End Sub

    Private Sub WalletBtn_Click(sender As Object, e As EventArgs) Handles WalletBtn.Click
        Transfer.Show()
    End Sub
End Class
