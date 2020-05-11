Public Class Form1
    Dim a, b As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox("Nilai Angka A lebih besa")
        ElseIf b > a Then
            MsgBox("Nilai Angka B lebih besar")
        Else
            MsgBox("Nilai Angka A & B sama besar")
        End If
    End Sub
End Class
