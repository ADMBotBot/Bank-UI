Public Class AccountSupport
    Dim AccountName1, AccountName2, AccountName3, AccountString1, AccountString2, AccountString3 As String

    Private Sub AccountSupport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IssueLbl.BackColor = System.Drawing.Color.Transparent
        AccountName1 = "John Smith"
        AccountName2 = "Earl Timpson"
        AccountName3 = "Nathan Tiller"
        AccountString1 = "John Smith: I can't deposit."
        AccountString2 = "Earl Timpson: HELPPPPPPP!!!!! I can't withdrawal."
        AccountString3 = "Nathan Tiller: I'm broke...."
        lstInfo.Items.Add(AccountString1)
        lstInfo.Items.Add(AccountString2)
        lstInfo.Items.Add(AccountString3)
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        If IssueTxt.Text = AccountName1 Then
            lstInfo.Items.Remove(AccountString1)
            IssueTxt.Text = ""
        ElseIf IssueTxt.Text = AccountName2 Then
            lstInfo.Items.Remove(AccountString2)
            IssueTxt.Text = ""
        ElseIf IssueTxt.Text = AccountName3 Then
            lstInfo.Items.Remove(AccountString3)
            IssueTxt.Text = ""
        ElseIf lstInfo.Items.Count = 0 Then
            MessageBox.Show("All issues have been fixed.", "Remove Issue Error")
        Else
            MessageBox.Show("Issue in removing issue.", "Remove Issue Error")
        End If
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class
