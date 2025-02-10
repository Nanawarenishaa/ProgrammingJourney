Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Option 1")
        ListBox1.Items.Add("Option 2")
        ListBox1.Items.Add("Option 3")
        ListBox1.Items.Add("Option 4")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("you have Selected: " & ListBox1.SelectedItem)
    End Sub
End Class