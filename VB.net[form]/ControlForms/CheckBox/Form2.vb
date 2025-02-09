Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Choices As String = "You have selected: "
        If CheckBox1.Checked Then Choices &= "option 1, "

        If CheckBox2.Checked Then Choices &= "option 2, "


        If CheckBox3.Checked Then Choices &= "option 3, "

        MessageBox.Show(Choices.TrimEnd(","c, " "c))

    End Sub
End Class