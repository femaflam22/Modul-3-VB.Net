Public Class Form1
    Dim c1, c2, c3, c4, c5 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call goldar()
        Call syarat()
        MsgBox("NISN : " & TextBox1.Text & vbCrLf & "Nama Lengkap : " & TextBox2.Text & vbCrLf & "Alamat : " & TextBox3.Text & vbCrLf & "Tanggal Lahir : " & DateTimePicker1.Value & vbCrLf & "Agama : " & ComboBox1.Text & vbCrLf & "Golongan Darah : " & gol & vbCrLf & "Persyaratan : " & c1 & vbCrLf & c2 & vbCrLf & c3 & vbCrLf & c4 & vbCrLf & c5)
    End Sub

    Dim gol As String
    Sub goldar()
        If RadioButton1.Checked = True Then
            gol = "A"
        ElseIf RadioButton2.Checked = True Then
            gol = "O"
        ElseIf RadioButton3.Checked = True Then
            gol = "B"
        Else
            gol = "AB"
        End If
    End Sub
    Sub syarat()
        If CheckBox1.Checked = True Then
            c1 = CheckBox1.Text & " : " & "ADA"
        Else
            c1 = CheckBox1.Text & " : " & "BELUM"
        End If
        If CheckBox2.Checked = True Then
            c2 = CheckBox2.Text & " : " & "ADA"
        Else
            c2 = CheckBox2.Text & " : " & "BELUM"
        End If
        If CheckBox1.Checked = True Then
            c3 = CheckBox3.Text & " : " & "ADA"
        Else
            c3 = CheckBox3.Text & " : " & "BELUM"
        End If
        If CheckBox1.Checked = True Then
            c4 = CheckBox4.Text & " : " & "ADA"
        Else
            c4 = CheckBox4.Text & " : " & "BELUM"
        End If
        If CheckBox1.Checked = True Then
            c5 = CheckBox5.Text & " : " & "ADA"
        Else
            c5 = CheckBox5.Text & " : " & "BELUM"
        End If
    End Sub
End Class
