Public Class CreditCard
    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Your credit card will be checked for processing within 5 business days.", "Credit Card Processing")
        Me.Close()
    End Sub

    Private Sub CreditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This is the credit card template.", "Credit Card Template")
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs)
        MessageBox.Show("You have canceled your application.", "Credit Card Application")
        Me.Close()
    End Sub
End Class
