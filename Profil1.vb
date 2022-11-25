Public Class Profil1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Profil2.Show()
        Me.Close()
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Peminjaman1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Pengembalian1.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Show()
    End Sub
End Class