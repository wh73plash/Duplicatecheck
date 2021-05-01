Imports System.IO
Imports System.Text

Public Class Form1

    Dim load_data As String
    Dim create_data As String = "Resources\Data\Data.cpp"
    Dim last_file As String
    Dim File_Content As String
    Dim File_Name As String
    Dim file_compare As String
    Dim file_realcompare() As String
    Dim create_path As String
    Dim create_file_name As String
    Dim total_compare As String = Nothing
    Dim exit_helper As String
    Dim file_name_sec As String
    Dim datafile_path As String = "Resources\Data\Data.cpp"
    Dim copy_string(268435457) As String
    Dim contents(3) As String
    Dim title(3) As String

    Dim i As Integer = 0
    Dim length As Integer
    Dim length_compare As Integer
    Dim how_many As Integer = 0
    Dim easter_egg As Integer = 0
    Dim copy_value As Integer = 0
    Dim cnt As Integer
    Dim random_value As Integer

    Dim random As New Random

    Dim file_open_check As Boolean = False
    Dim save_check As Boolean = False
    Dim open_file As Boolean = False
    Dim copy_check As Boolean = False

    Dim clearchar As Char = Chr(34)


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Label3.Text = ""
        If TextBox1.Text = "" Then
            Label3.Text = "입력해주세요."
        End If

        TextBox1.Text = Replace(TextBox1.Text, clearchar, "")

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If File_Name = "" Then
            MsgBox("파일이 없습니다." + vbCrLf + "파일을 불러와주세요.", vbInformation, "File Not Found")
            Return
        End If

        contents(0) = "오늘은 쉬는날!!"
        contents(1) = "등록할게 없네요." + vbCrLf + "축하합니다."
        contents(2) = "없음."

        title(0) = "Today is a day off!!"
        title(1) = "Nothing to register"
        title(2) = "none"

        random_value = random.Next(0, 2)

        NumericUpDown1.Value = 0

        file_open_check = True

        file_realcompare = Nothing
        total_compare = Nothing
        file_compare = Nothing
        length = Nothing
        i = Nothing

        file_compare = TextBox1.Text
        file_realcompare = Split(file_compare, Chr(10))
        length = UBound(file_realcompare) - LBound(file_realcompare) + 1

        cnt = 0

        Dim count As Integer = 0

        Dim k As Integer = 0
        Dim l As Integer = 0
        Dim tmp As String

        While (i < length)
            If InStr(File_Content, file_realcompare(i)) Then

            Else
                total_compare = total_compare + file_realcompare(i) + vbCrLf
                copy_string(cnt) = file_realcompare(i)
                cnt += 1
                count += 1
            End If
            i = i + 1
        End While


        TextBox2.Text = Nothing
        TextBox2.Text = total_compare

        If TextBox2.Text = "" Then
            MsgBox(contents(random_value), vbExclamation, title(random_value))
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        NumericUpDown1.Value = 1

        If TextBox2.Text IsNot Nothing Then
            TextBox2.Text = ""
        End If

        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

            File_Name = OpenFileDialog1.FileName
            Dim file_name_sec As String = File_Name
            File_Content = My.Computer.FileSystem.ReadAllText(File_Name)
            open_file = True

            Label2.Text = "열린 파일 : " + File_Name

            If File_Name <> "" Then
                MsgBox("파일을 불러오는데 성공하였습니다.", vbInformation, "File loading success")
            Else
                MsgBox("파일을 불러오는데 실패하였습니다.", vbObjectError, "File loading failure")
            End If

            My.Computer.FileSystem.DeleteFile(create_data)
            System.IO.File.WriteAllText(create_data, file_name_sec)

        End If

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If File_Name = "" Then
            MsgBox("파일이 없습니다." + vbCrLf + "파일을 불러와주세요.", vbInformation, "File Not Found")
            Return
        End If

        Dim dt As Date = Date.Now
        My.Computer.FileSystem.WriteAllText(File_Name, vbCrLf + total_compare + "---" + dt + "---", True)
        save_check = True
        MsgBox("파일 저장에 성공하였습니다.", vbOKOnly, "FIle Save Success")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

        NumericUpDown1.Value = 1

        create_file_name = InputBox("파일 이름을 입력해주세요.", "Enter File Information")

        If MsgBox("'" + create_file_name + "' 이름의 파일을 생성하시겠습니까?", vbYesNo, "Confirm File Creation") = 6 Then

            MsgBox("생성된 파일은 Du-Checker응용프로그램 아래 있습니다.", vbOKOnly, "Create File Path")

            create_path = create_file_name + ".txt"

            Dim fs As FileStream = File.Create(create_path)
            If fs Is Nothing Then
                MsgBox("파일 생성에 실패하였습니다.", vbObjectError, "File Creation Failure")
            Else

            End If
            fs.Close()

            File_Name = create_path
            Dim file_name_sec As String = File_Name
            File_Content = My.Computer.FileSystem.ReadAllText(File_Name)

            open_file = True
            Label2.Text = "열린 파일 : " + File_Name

            If File_Name <> "" Then
                MsgBox("파일을 불러오는데 성공하였습니다.", vbInformation, "File loading success")
            Else
                MsgBox("파일을 불러오는데 실패하였습니다.", vbObjectError, "File loading failure")
            End If

            My.Computer.FileSystem.DeleteFile(create_data)
            System.IO.File.WriteAllText(create_data, file_name_sec)

        Else
            MsgBox("파일 생성을 취소하였습니다.", vbOKOnly, "File Creation Failure")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If File.Exists(datafile_path) = False Then

            Dim fs As FileStream = File.Create(datafile_path)
            fs.Close()

        Else
            load_data = My.Computer.FileSystem.ReadAllText(datafile_path)

            If File.Exists(load_data) = True Then
                If MsgBox("전에 작업중이던 파일(" + load_data + ")를 불러오시겠습니까?", vbYesNo, "Loading Last File") = 6 Then
                    File_Name = load_data
                    File_Content = My.Computer.FileSystem.ReadAllText(File_Name)
                    open_file = True
                    Label2.Text = "열린 파일 : " + File_Name
                Else

                    If TextBox2.Text IsNot Nothing Then
                        TextBox2.Text = ""
                    End If
                    If TextBox1.Text IsNot Nothing Then
                        TextBox1.Text = ""
                    End If

                    If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

                        File_Name = OpenFileDialog1.FileName
                        Dim file_name_sec As String = File_Name
                        File_Content = My.Computer.FileSystem.ReadAllText(File_Name)
                        open_file = True
                        Label2.Text = "열린 파일 : " + File_Name

                        My.Computer.FileSystem.DeleteFile(create_data)
                        System.IO.File.WriteAllText(create_data, file_name_sec)

                    End If
                End If
            Else
                Dim fs As FileStream = File.Create(datafile_path)
                fs.Close()
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If save_check = False And open_file = True And file_open_check = True And TextBox2.Text <> "" Then
            If MsgBox("파일이 저장되지 않았습니다." + vbCrLf + vbCrLf + "저장하시겠습니까?", vbYesNo, "File Not Saved") = 6 Then

                Dim dt As Date = Date.Now
                My.Computer.FileSystem.WriteAllText(File_Name, vbCrLf + total_compare + "---" + dt + "---", True)

            End If
        End If

    End Sub


    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Label7.Text = ""
        If TextBox2.Text = "" Then
            Label7.Text = "등록해주세요."
        End If

    End Sub


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        '버튼을 눌렀을때 file_realcompare변수의 A번째 값을 클립보드에 복사한다.'
        My.Computer.Clipboard.Clear()
        If copy_string(copy_value) Is Nothing Then
            Return
        End If
        My.Computer.Clipboard.SetText(copy_string(copy_value))
        If copy_string(copy_value + 1) = "" Then
            Label4.Text = copy_string(copy_value)
            MsgBox("마지막 값입니다." + vbCrLf + "저장하세요.", vbInformation, "Laste value")
            Return
        Else
            Label4.Text = copy_string(copy_value)
            NumericUpDown1.Value += 1
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

        copy_value = NumericUpDown1.Value

    End Sub

    Private Sub 파일불러오기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 파일불러오기ToolStripMenuItem.Click

        Label4.Text = ""

        NumericUpDown1.Value = 1

        If TextBox2.Text IsNot Nothing Then
            TextBox2.Text = ""
        End If

        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

            File_Name = OpenFileDialog1.FileName
            Dim file_name_sec As String = File_Name
            File_Content = My.Computer.FileSystem.ReadAllText(File_Name)
            open_file = True

            Label2.Text = "열린 파일 : " + File_Name

            If File_Name <> "" Then
                MsgBox("파일을 불러오는데 성공하였습니다.", vbInformation, "File loading success")
            Else
                MsgBox("파일을 불러오는데 실패하였습니다.", vbObjectError, "File loading failure")
            End If

            My.Computer.FileSystem.DeleteFile(create_data)
            System.IO.File.WriteAllText(create_data, file_name_sec)

        End If

    End Sub

    Private Sub 파일만들기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 파일만들기ToolStripMenuItem.Click


        NumericUpDown1.Value = 1

        create_file_name = InputBox("파일 이름을 입력해주세요.", "Enter File Information")

        If create_file_name = "" Then
            Return
        End If

        If MsgBox("'" + create_file_name + "' 이름의 파일을 생성하시겠습니까?", vbYesNo, "Confirm File Creation") = 6 Then

            MsgBox("생성된 파일은 Du-Checker응용프로그램 아래 있습니다.", vbOKOnly, "Create File Path")

            create_path = create_file_name + ".txt"

            Dim fs As FileStream = File.Create(create_path)
            If fs Is Nothing Then
                MsgBox("파일 생성에 실패하였습니다.", vbObjectError, "File Creation Failure")
            Else

            End If
            fs.Close()

            File_Name = create_path
            Dim file_name_sec As String = File_Name
            File_Content = My.Computer.FileSystem.ReadAllText(File_Name)

            open_file = True
            Label2.Text = "열린 파일 : " + File_Name

            If File_Name <> "" Then
                MsgBox("파일을 불러오는데 성공하였습니다.", vbInformation, "File loading success")
            Else
                MsgBox("파일을 불러오는데 실패하였습니다.", vbObjectError, "File loading failure")
            End If

            My.Computer.FileSystem.DeleteFile(create_data)
            System.IO.File.WriteAllText(create_data, file_name_sec)

        Else
            MsgBox("파일 생성을 취소하였습니다.", vbOKOnly, "File Creation Failure")
        End If

    End Sub

    Private Sub 닫기ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 닫기ToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)
        easter_egg += 1
        If easter_egg = 5 Then
            MsgBox("010-6826-0311", vbInformation, "Found Easter Egg!")
            easter_egg = 0
        End If
    End Sub
End Class