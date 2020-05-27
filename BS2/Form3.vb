Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox2.Width = 350
        PictureBox2.Height = 240
        PictureBox2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        PictureBox2.Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Sub show_PictureBox1() Handles MyBase.Load
    End Sub

    Private Sub show_PictureBox1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
    End Sub
End Class