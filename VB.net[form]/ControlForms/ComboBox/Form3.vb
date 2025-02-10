Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("Option 1")
        ComboBox1.Items.Add("Option 2")
        ComboBox1.Items.Add("Option 3")
        ComboBox1.Items.Add("Option 4")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("You have selected: " & ComboBox1.SelectedItem)
    End Sub

End Class