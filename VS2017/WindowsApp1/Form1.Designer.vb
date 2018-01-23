<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TCu = New System.Windows.Forms.TextBox()
        Me.TDang = New System.Windows.Forms.TextBox()
        Me.TYun = New System.Windows.Forms.TextBox()
        Me.TDong = New System.Windows.Forms.TextBox()
        Me.TLiuL = New System.Windows.Forms.TextBox()
        Me.TRou = New System.Windows.Forms.TextBox()
        Me.TLiuS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TChangDu = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ShuChu = New System.Windows.Forms.Label()
        Me.GongShi = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TYanC = New System.Windows.Forms.TextBox()
        Me.TLmd = New System.Windows.Forms.TextBox()
        Me.TLeiN = New System.Windows.Forms.TextBox()
        Me.QiuJie = New System.Windows.Forms.Button()
        Me.ChongZhi = New System.Windows.Forms.Button()
        Me.JiaoYan = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GongShi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TCu
        '
        Me.TCu.Location = New System.Drawing.Point(6, 33)
        Me.TCu.Name = "TCu"
        Me.TCu.Size = New System.Drawing.Size(62, 21)
        Me.TCu.TabIndex = 0
        '
        'TDang
        '
        Me.TDang.Location = New System.Drawing.Point(6, 68)
        Me.TDang.Name = "TDang"
        Me.TDang.Size = New System.Drawing.Size(62, 21)
        Me.TDang.TabIndex = 1
        '
        'TYun
        '
        Me.TYun.BackColor = System.Drawing.SystemColors.Window
        Me.TYun.Location = New System.Drawing.Point(6, 103)
        Me.TYun.Name = "TYun"
        Me.TYun.Size = New System.Drawing.Size(62, 21)
        Me.TYun.TabIndex = 2
        '
        'TDong
        '
        Me.TDong.Location = New System.Drawing.Point(6, 138)
        Me.TDong.Name = "TDong"
        Me.TDong.Size = New System.Drawing.Size(62, 21)
        Me.TDong.TabIndex = 3
        '
        'TLiuL
        '
        Me.TLiuL.Location = New System.Drawing.Point(6, 173)
        Me.TLiuL.Name = "TLiuL"
        Me.TLiuL.Size = New System.Drawing.Size(62, 21)
        Me.TLiuL.TabIndex = 4
        '
        'TRou
        '
        Me.TRou.Location = New System.Drawing.Point(6, 208)
        Me.TRou.Name = "TRou"
        Me.TRou.Size = New System.Drawing.Size(62, 21)
        Me.TRou.TabIndex = 5
        '
        'TLiuS
        '
        Me.TLiuS.Location = New System.Drawing.Point(6, 243)
        Me.TLiuS.Name = "TLiuS"
        Me.TLiuS.Size = New System.Drawing.Size(62, 21)
        Me.TLiuS.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 12)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Δ粗糙度（m）"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "d当量直径（m）"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 12)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ν运动粘度（m^2/s）"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 12)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "μ动力粘度（Pa·s）"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(74, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 12)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "q 体积流量（m^3/s）"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(74, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "ρ密度（kg/m^3）"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(74, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 12)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "u 流速（m/s）"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TChangDu)
        Me.GroupBox1.Controls.Add(Me.TCu)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TDang)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TYun)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TDong)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TLiuL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TRou)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TLiuS)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(201, 314)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "输入参量"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(74, 281)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 12)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "l 长度（m）"
        '
        'TChangDu
        '
        Me.TChangDu.Location = New System.Drawing.Point(6, 278)
        Me.TChangDu.Name = "TChangDu"
        Me.TChangDu.Size = New System.Drawing.Size(62, 21)
        Me.TChangDu.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.ShuChu)
        Me.GroupBox2.Controls.Add(Me.GongShi)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TYanC)
        Me.GroupBox2.Controls.Add(Me.TLmd)
        Me.GroupBox2.Controls.Add(Me.TLeiN)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(352, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 314)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "输出值"
        '
        'ShuChu
        '
        Me.ShuChu.AutoSize = True
        Me.ShuChu.Location = New System.Drawing.Point(77, 156)
        Me.ShuChu.Name = "ShuChu"
        Me.ShuChu.Size = New System.Drawing.Size(41, 12)
        Me.ShuChu.TabIndex = 8
        Me.ShuChu.Text = "未确定"
        '
        'GongShi
        '
        Me.GongShi.Location = New System.Drawing.Point(8, 180)
        Me.GongShi.Name = "GongShi"
        Me.GongShi.Size = New System.Drawing.Size(312, 101)
        Me.GongShi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GongShi.TabIndex = 7
        Me.GongShi.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 12)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "运用公式："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "hf沿程损失"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "λ阻力系数"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(82, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Re雷诺数"
        '
        'TYanC
        '
        Me.TYanC.Location = New System.Drawing.Point(7, 120)
        Me.TYanC.Name = "TYanC"
        Me.TYanC.Size = New System.Drawing.Size(66, 21)
        Me.TYanC.TabIndex = 2
        '
        'TLmd
        '
        Me.TLmd.Location = New System.Drawing.Point(7, 75)
        Me.TLmd.Name = "TLmd"
        Me.TLmd.Size = New System.Drawing.Size(66, 21)
        Me.TLmd.TabIndex = 1
        '
        'TLeiN
        '
        Me.TLeiN.Location = New System.Drawing.Point(7, 30)
        Me.TLeiN.Name = "TLeiN"
        Me.TLeiN.Size = New System.Drawing.Size(66, 21)
        Me.TLeiN.TabIndex = 0
        '
        'QiuJie
        '
        Me.QiuJie.Location = New System.Drawing.Point(243, 83)
        Me.QiuJie.Name = "QiuJie"
        Me.QiuJie.Size = New System.Drawing.Size(75, 23)
        Me.QiuJie.TabIndex = 16
        Me.QiuJie.Text = "求解"
        Me.QiuJie.UseVisualStyleBackColor = True
        '
        'ChongZhi
        '
        Me.ChongZhi.Location = New System.Drawing.Point(243, 179)
        Me.ChongZhi.Name = "ChongZhi"
        Me.ChongZhi.Size = New System.Drawing.Size(75, 23)
        Me.ChongZhi.TabIndex = 17
        Me.ChongZhi.Text = "重置输入"
        Me.ChongZhi.UseVisualStyleBackColor = True
        '
        'JiaoYan
        '
        Me.JiaoYan.Location = New System.Drawing.Point(243, 131)
        Me.JiaoYan.Name = "JiaoYan"
        Me.JiaoYan.Size = New System.Drawing.Size(75, 23)
        Me.JiaoYan.TabIndex = 18
        Me.JiaoYan.Text = "数据校验"
        Me.JiaoYan.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(230, 47)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(108, 16)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "应用巴尔公式？"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(168, 123)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(131, 12)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "g重力加速度取9.8m/s^2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(233, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "作者：都旭"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label15.Location = New System.Drawing.Point(233, 266)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(113, 12)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "联系QQ：1178946575"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(233, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 12)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "版本：v1.0.0.0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(233, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(227, 12)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "注：求解前请数据校验，避免NaN结果错误"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 361)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.JiaoYan)
        Me.Controls.Add(Me.ChongZhi)
        Me.Controls.Add(Me.QiuJie)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "工程流体力学沿程水头损失求解工具"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GongShi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TCu As TextBox
    Friend WithEvents TDang As TextBox
    Friend WithEvents TYun As TextBox
    Friend WithEvents TDong As TextBox
    Friend WithEvents TLiuL As TextBox
    Friend WithEvents TRou As TextBox
    Friend WithEvents TLiuS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents QiuJie As Button
    Friend WithEvents ChongZhi As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TYanC As TextBox
    Friend WithEvents TLmd As TextBox
    Friend WithEvents TLeiN As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents JiaoYan As Button
    Friend WithEvents GongShi As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ShuChu As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TChangDu As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
