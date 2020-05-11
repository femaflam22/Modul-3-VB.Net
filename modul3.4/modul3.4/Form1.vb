Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Silahkan masukkan nama makanan yang ingin dipesan")
        Else
            If ListBox1.Items.Contains(TextBox1.Text) Then
                MsgBox("Pesanan yang anda pesan sudah ada di daftar pesanan")
            Else
                ListBox1.Items.Add(TextBox1.Text)
                TextBox1.Text = ""
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Silahkan klik pesanan yang akan dihapus terlebih dahulu")
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class
