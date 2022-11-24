

Imports System.Runtime.CompilerServices

Public Class Login



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles labdaftar.Click
        Daftar.Show()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Email.Text = "admin" And Pass.Text = "admin" Then
            Home.Show()
            Me.Close()


        Else
            MsgBox("Username atau password salah!")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Lupa_akun.Show()
        Me.Close()
    End Sub
End Class
