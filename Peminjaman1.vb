Public Class Peminjaman1
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Profil1.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Pengembalian1.Show()
        Me.Close()
    End Sub

    Private Sub Peminjaman1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class