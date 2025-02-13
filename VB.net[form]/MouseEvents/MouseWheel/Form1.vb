Public Class Form1
    Private Sub Form1_Wheel(sender As Object, e As MouseEventArgs) Handles Me.MouseWheel
        If e.Delta > 0 Then

            MessageBox.Show("Mouse wheel scrolled up")
        Else
            MessageBox.Show("Mouse wheel scrolled down")
        End If

    End Sub
End Class
