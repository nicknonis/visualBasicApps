Public Class Form1




  

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        
        Select Case ComboBox1.SelectedItem
            Case "Sunny"
                Label1.Text = "Sunny bro."
            Case "Rainy"
                Label1.Text = "rainy broz"
            Case "Snowy"
                Label1.Text = "snow la dei"
            Case "Cloudy"
                Label1.Text = "care clouds"
        End Select


    End Sub
End Class
