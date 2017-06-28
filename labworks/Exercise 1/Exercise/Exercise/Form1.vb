Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numba As Integer
        numba = Val(TextBox1.Text)
        Select Case numba
            Case 10 To 20
                Label1.Text = numba
            Case Else
                TextBox1.Clear()
                Label1.Text = "Please enter a value between 10 - 20"
        End Select
    End Sub
End Class
