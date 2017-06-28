Public Class Form1




  

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim combowhore As String
        combowhore = ComboBox1.Text
        Label1.Text = "The weather is " + combowhore
    End Sub
End Class
