Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Clear()

    End Sub
    Private Sub ListBox1_SelectIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MessageBox.Show(ListBox1.SelectedItems(0).ToString())
    End Sub




End Class