<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.파일ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.파일만들기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.파일불러오기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말보기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.피드백보내기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.문제보고ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.기술제안ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.창ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.닫기ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("굴림", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 26)
        Me.TextBox1.MaxLength = 1073741824
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(270, 426)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Font = New System.Drawing.Font("굴림", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(376, 26)
        Me.TextBox2.MaxLength = 1073741824
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(270, 427)
        Me.TextBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(281, 26)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 427)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "중" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "복" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "검" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "사"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Gainsboro
        Me.Button3.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button3.Location = New System.Drawing.Point(652, 383)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(247, 70)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "저 장"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(895, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "열린 파일 : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Gainsboro
        Me.Button5.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button5.Location = New System.Drawing.Point(652, 25)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(247, 88)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "클립보드" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "복사"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("굴림", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(11, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "입력하세요."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.UseMnemonic = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("굴림", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(652, 351)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(237, 26)
        Me.NumericUpDown1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Yellow
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(655, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 85)
        Me.Label4.TabIndex = 11
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem, Me.도움말ToolStripMenuItem, Me.창ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(905, 29)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '파일ToolStripMenuItem
        '
        Me.파일ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일만들기ToolStripMenuItem, Me.파일불러오기ToolStripMenuItem})
        Me.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem"
        Me.파일ToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.파일ToolStripMenuItem.Text = "파일(F)"
        '
        '파일만들기ToolStripMenuItem
        '
        Me.파일만들기ToolStripMenuItem.Name = "파일만들기ToolStripMenuItem"
        Me.파일만들기ToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.파일만들기ToolStripMenuItem.Text = "새로 만들기(N)"
        '
        '파일불러오기ToolStripMenuItem
        '
        Me.파일불러오기ToolStripMenuItem.Name = "파일불러오기ToolStripMenuItem"
        Me.파일불러오기ToolStripMenuItem.Size = New System.Drawing.Size(188, 26)
        Me.파일불러오기ToolStripMenuItem.Text = "열기(O)"
        '
        '도움말ToolStripMenuItem
        '
        Me.도움말ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.도움말보기ToolStripMenuItem, Me.피드백보내기ToolStripMenuItem})
        Me.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem"
        Me.도움말ToolStripMenuItem.Size = New System.Drawing.Size(92, 25)
        Me.도움말ToolStripMenuItem.Text = "도움말(H)"
        '
        '도움말보기ToolStripMenuItem
        '
        Me.도움말보기ToolStripMenuItem.Name = "도움말보기ToolStripMenuItem"
        Me.도움말보기ToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.도움말보기ToolStripMenuItem.Text = "사용법 보기(V)"
        '
        '피드백보내기ToolStripMenuItem
        '
        Me.피드백보내기ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.문제보고ToolStripMenuItem, Me.기술제안ToolStripMenuItem})
        Me.피드백보내기ToolStripMenuItem.Name = "피드백보내기ToolStripMenuItem"
        Me.피드백보내기ToolStripMenuItem.Size = New System.Drawing.Size(200, 26)
        Me.피드백보내기ToolStripMenuItem.Text = "피드백 보내기(F)"
        '
        '문제보고ToolStripMenuItem
        '
        Me.문제보고ToolStripMenuItem.Name = "문제보고ToolStripMenuItem"
        Me.문제보고ToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.문제보고ToolStripMenuItem.Text = "문제 보고(P)"
        '
        '기술제안ToolStripMenuItem
        '
        Me.기술제안ToolStripMenuItem.Name = "기술제안ToolStripMenuItem"
        Me.기술제안ToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.기술제안ToolStripMenuItem.Text = "기능 제안(S)"
        '
        '창ToolStripMenuItem
        '
        Me.창ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.닫기ToolStripMenuItem})
        Me.창ToolStripMenuItem.Name = "창ToolStripMenuItem"
        Me.창ToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
        Me.창ToolStripMenuItem.Text = "창(W)"
        '
        '닫기ToolStripMenuItem
        '
        Me.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem"
        Me.닫기ToolStripMenuItem.Size = New System.Drawing.Size(132, 26)
        Me.닫기ToolStripMenuItem.Text = "닫기(X)"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(652, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 82)
        Me.Label1.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("굴림", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(652, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 23)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "현재 물품번호"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("굴림", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(381, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(168, 29)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "등록하세요."
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.UseMnemonic = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(850, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 12)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "v1.0.2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(653, 347)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 30)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Powered by 포빌리언" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Programed by Jane Kim"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 483)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Tag = ""
        Me.Text = "Du-Checker"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 파일ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 파일불러오기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 파일만들기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 도움말ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 창ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 닫기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 도움말보기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 피드백보내기ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 문제보고ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 기술제안ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
