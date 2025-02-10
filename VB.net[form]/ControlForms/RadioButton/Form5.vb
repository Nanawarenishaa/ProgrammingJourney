

Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim choice As String = ""

        If RadioButton1.Checked Then
            choice = "You selected: Option 1"
        ElseIf RadioButton2.Checked Then
            choice = "You selected: Option 2"
        ElseIf RadioButton3.Checked Then
            choice = "You selected: Option 3"
        Else
            choice = "Please select an option."
        End If

        MessageBox.Show(choice)
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
