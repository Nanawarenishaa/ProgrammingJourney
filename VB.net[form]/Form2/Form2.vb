Public Class Form2



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String = "admin"
        Dim Password As String = "Pass@317"
        If TextBox1.Text = Username And TextBox2.Text = Password Then
            MessageBox.Show("Login Successful!")
            Me.Hide()
            Dim Dashbord As New Form3
            Dashbord.Show()
        Else
            MessageBox.Show("Login Failed!")
        End If
    End Sub
End Class