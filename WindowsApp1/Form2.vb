Public Class Form2
    Dim pic_code(9) As String

    Dim i As Integer = 0
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pic_code(0) = "Resources\Image\1.json"
        pic_code(1) = "Resources\Image\2.json"
        pic_code(2) = "Resources\Image\3.json"
        pic_code(3) = "Resources\Image\4.json"
        pic_code(4) = "Resources\Image\5.json"
        pic_code(5) = "Resources\Image\6.json"
        pic_code(6) = "Resources\Image\7.json"
        pic_code(7) = "Resources\Image\8.json"
        pic_code(8) = "Resources\Image\9.json"

        PictureBox1.ImageLocation = pic_code(i)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (i + 1) = 9 Then
            MsgBox("마지막 사진입니다.", vbInformation, "Last Image")
            Return
        Else
            i += 1
            PictureBox1.ImageLocation = pic_code(i)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (i - 1) < 0 Then
            MsgBox("첫번째 사진입니다.", vbInformation, "First Image")
            Return
        Else
            i -= 1
            PictureBox1.ImageLocation = pic_code(i)
        End If
    End Sub
End Class