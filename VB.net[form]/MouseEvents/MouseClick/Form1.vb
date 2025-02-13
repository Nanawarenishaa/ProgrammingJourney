Public Class Form1
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        MessageBox.Show("Mouse Clicked at x:" & e.X & " y:" & e.Y)
    End Sub


End Class
