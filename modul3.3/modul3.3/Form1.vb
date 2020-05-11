Public Class Form1
    Sub hitung()
        Label3.Text = ListBox1.Items.Count & "item"
    End Sub
    Sub tambah()
        With ListBox1.Items
            .Add("Nasi goreng pedas")
            .Add("Ayam geprek super pedas")
            .Add("Samyang")
            .Add("Martabak manis")
        End With
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tambah()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Pilih makanan yang ingin anda pesan")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
        hitung()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox2.SelectedItem = "" Then
            MsgBox("Pilih makanan yang ingin anda pesan")
        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
        hitung()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        hitung()
        tambah()
    End Sub
End Class
