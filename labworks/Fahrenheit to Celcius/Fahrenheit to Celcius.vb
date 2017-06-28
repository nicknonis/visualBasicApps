Public Class form1

   
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        txtC.Text = (txtF.Text - 32) * 5 / 9
    End Sub


    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
End Class
