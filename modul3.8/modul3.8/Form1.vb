Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Silahkan pilih provinsi yang akan ditambahkan")
        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedItem = "" Then
            MsgBox("Silahkan pilih provinsi yang akan dihapus")
        Else
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case Is = "Jawa"
                With ListBox1.Items
                    .Clear()
                    .Add("Jawa Barat")
                    .Add("Jawa Timur")
                    .Add("Jawa Tengah")
                    .Add("DIY")
                    .Add("Jakarta")
                    .Add("Banten")
                End With
            Case Is = "Kalimantan"
                With ListBox1.Items
                    .Clear()
                    .Add("Kalimantan Utara")
                    .Add("Kalimantan Selatan")
                    .Add("Kalimantan Barat")
                    .Add("Kalimantan Timur")
                    .Add("Kalimantan Tengah")
                End With
            Case Is = "Sumatra"
                With ListBox1.Items
                    .Clear()
                    .Add("Sumatra Utara")
                    .Add("Sumatra Barat")
                    .Add("NAD")
                    .Add("Palembang")
                    .Add("Lampung")
                    .Add("Riau")
                End With
            Case Is = "Sulawesi"
                With ListBox1.Items
                    .Clear()
                    .Add("Sulawesi Utara")
                    .Add("Sulawesi Selatan")
                    .Add("Sulawesi Tenggara")
                End With
            Case Is = "Papua"
                With ListBox1.Items
                    .Clear()
                    .Add("Papua Barat")
                End With
        End Select
    End Sub
End Class
