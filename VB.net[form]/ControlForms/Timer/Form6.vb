Public Class Form6
    Dim Num As Integer = 0


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(DateTime.Now, "hh:mm:ss")

    End Sub


End Class