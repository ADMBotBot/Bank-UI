Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeLbl.BackColor = System.Drawing.Color.Transparent
        BankLbl.BackColor = System.Drawing.Color.Transparent
        ProceedBtn.BackColor = System.Drawing.Color.Transparent
    End Sub

    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles ProceedBtn.Click
        Intro.Show()
        Me.Close()
    End Sub
End Class
