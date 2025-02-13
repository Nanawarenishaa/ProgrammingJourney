Public Class Form1
    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            MessageBox.Show("Left Button Clicked")
        ElseIf e.Button = MouseButtons.Right Then
            MessageBox.Show("Right Button Clicked")
        ElseIf e.Button = MouseButtons.Middle Then
            MessageBox.Show("Middle Button Clicked")
        End If
    End Sub
End Class