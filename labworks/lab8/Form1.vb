Public Class Form1
    Dim values(9) As Integer
    Dim total As Integer = 0
    Dim big As Integer
    Dim small As Integer
    Dim letme As Integer = 10
    Dim start As Integer = 0
    Dim largeIndex As Integer







   
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        letme -= 1
        values(start) = Val(TextBox1.Text)
        start += 1

        If start = 10 Then
            Button1.Enabled = False

            For i = 0 To 9





                total = total + values(i)





            Next

            For i = 0 To 9
                If i = 0 Then
                    big = values(0)
                    largeIndex = 0
                End If
                If values(i) > big Then
                    big = values(i)
                    largeIndex = i
                End If

            Next

            For i = 0 To 9
                If i = 0 Then
                    small = values(0)
                End If
                If values(i) < small Then
                    small = values(i)
                End If

            Next

            For i = 0 To 9
                If values(i) Mod 3 = 0 Then
                    ListBox1.Items.Add(values(i))
                End If

            Next

            Label2.Text = "big = " & big
            Label3.Text = "small = " & small

            Label1.Text = "the total of the 10 values =" & total
            Label5.Text = "the largest value index is " & largeIndex


        End If

        TextBox1.Clear()
        Label4.Text = letme
    End Sub

    
End Class
