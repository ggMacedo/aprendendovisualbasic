Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If chk1.Checked = True Then
            MsgBox("Opção 1 marcada!")
        End If

        If chk2.Checked = True Then
            MsgBox("Opção 2 marcada!")
        End If

        MsgBox(NumericUpDown1.Value)

        MsgBox(DateTimePicker1.Value)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Danilo")
        ComboBox1.Items.Add("João")
        ComboBox1.Items.Add("Sergio")
        ComboBox1.Items.Add("Leandro")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex >= 0 Then
            MsgBox(ComboBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = New Bitmap("C:\Danilo\Penguins.jpg")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image = New Bitmap("C:\Danilo\Koala.jpg")
    End Sub
End Class
