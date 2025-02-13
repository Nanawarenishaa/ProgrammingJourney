Public Class Form1
    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Me.Text = "Mouse Position -X:" & e.X & " y:" & e.Y
    End Sub
End Class
