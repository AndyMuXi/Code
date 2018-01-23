Public Class Form1
    'Dim Number
    Dim Cu As Double
    Dim Dang As Double
    Dim Yun As Double
    Dim Dong As Double
    Dim LiuL As Double
    Dim Rou As Double
    Dim LiuS As Double
    Dim ChangDu As Double
    Dim LeiN As Double
    Dim Lmd As Double
    Dim YanC As Double
    Dim ep As Double

    'Dim Function

    '雷诺数计算
    Private Function Leinuo(Rou, LiuS, Dang, Dong) As Double
        Leinuo = (Rou * LiuS * Dang) / Dong
    End Function

    '层流阻力系数计算
    Private Function CengLiu(leiN) As Double
        CengLiu = 64 / leiN
    End Function

    '水力光滑管阻力系数计算
    Private Function GuangHua(leiN) As Double
        GuangHua = 0.3164 / (leiN ^ 0.25)
    End Function

    '过渡区阻力系数计算
    Private Function GuoDu(leiN, Cu, Dang) As Double
        Dim Can As Double

        Can = -1.8 * System.Math.Log10((6.8 / leiN) + (Cu / Dang / 3.7) ^ 1.11)
        GuoDu = (1 / Can) ^ 2
    End Function

    '完全粗糙区阻力系数计算
    Private Function CuCao(Dang, Cu) As Double
        Dim Can As Double

        Can = 2 * System.Math.Log10(3.7 * Dang / Cu)
        CuCao = 1 / (Can ^ 2)
    End Function

    '巴尔公式计算阻力系数
    Private Function BaEr(Cu, Dang, Yun, LiuL) As Double
        Dim Can As Double

        Can = -2 * System.Math.Log10((Cu / Dang) + 4.1365 * (Yun * Dang / LiuL) ^ 0.89)
        BaEr = (1 / Can) ^ 2
    End Function

    Private Sub QiuJie_Click(sender As Object, e As EventArgs) Handles QiuJie.Click
        'Get Number
        Cu = Val(TCu.Text)
        Dang = Val(TDang.Text)
        Yun = Val(TYun.Text）
        Dong = Val(TDong.Text)
        LiuL = Val(TLiuL.Text)
        Rou = Val(TRou.Text)
        LiuS = Val(TLiuS.Text)
        ChangDu = Val(TChangDu.Text)

        'figure LeiN and ep
        LeiN = Leinuo(Rou, LiuS, Dang, Dong)

        '雷诺数
        TLeiN.Text = LeiN

        '常数艾普西隆
        ep = 2 * Cu / Dang


        'Analysis

        If (CheckBox1.Checked = True) Then
            '巴尔公式计算

            GongShi.Image = My.Resources.Resources.five

            Lmd = BaEr(Cu, Dang, Yun, LiuL)
            TLmd.Text = Lmd
            ShuChu.Text = "巴尔公式"

        ElseIf (LeiN <= 2000) Then
            '层流计算

            GongShi.Image = My.Resources.Resources.one

            Lmd = CengLiu(LeiN)
            TLmd.Text = Lmd
            ShuChu.Text = "层流计算公式"

        ElseIf (LeiN < (59.7 / (ep ^ (8 / 7)))) Then
            '水力光滑管计算

            GongShi.Image = My.Resources.Resources.two
            Lmd = GuangHua(LeiN)
            TLmd.Text = Lmd
            ShuChu.Text = "水力光滑管计算公式"

        ElseIf (LeiN < ((665 - 765 * System.Math.Log10(ep)) / ep)) Then
            '过渡区计算

            GongShi.Image = My.Resources.Resources.three
            Lmd = GuoDu(LeiN, Cu, Dang)
            TLmd.Text = Lmd
            ShuChu.Text = "过渡区计算公式"

        Else
            '完全粗糙区计算
            GongShi.Image = My.Resources.Resources.four
            Lmd = CuCao(Dang, Cu)
            TLmd.Text = Lmd
            ShuChu.Text = "完全粗糙区计算公式"

        End If

        YanC = Lmd * (ChangDu / Dang) * (LiuS ^ 2 / (2 * 9.8))
        TYanC.Text = YanC

    End Sub

    Private Sub JiaoYan_Click(sender As Object, e As EventArgs) Handles JiaoYan.Click
        If (TCu.Text <> "" And TDang.Text <> "" And TDong.Text <> "" And TYun.Text <> "" And TLiuL.Text <> "" And TLiuS.Text <> "" And TChangDu.Text <> "" And TRou.Text <> "") Then
            MessageBox.Show("无数据缺失", "参数检验结果", MessageBoxButtons.OK)

        ElseIf (TYun.Text = "" And TDong.Text = "" And TRou.Text = "") Then
            If (MessageBox.Show("缺少粘度及密度信息", "参数检验结果", MessageBoxButtons.OK) = DialogResult.OK) Then
                TYun.BackColor = Color.FromArgb(255, 192, 192)
                TDong.BackColor = Color.FromArgb(255, 192, 192)
                TRou.BackColor = Color.FromArgb(255, 192, 192)
            End If
        ElseIf （TYun.Text = "" And TDong.Text = ""） Then
            If (MessageBox.Show（"缺少粘度信息", "参数检验结果"， MessageBoxButtons.OK） = DialogResult.OK) Then
                TYun.BackColor = Color.FromArgb(255, 192, 192)
                TDong.BackColor = Color.FromArgb(255, 192, 192)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            End If
        ElseIf (TYun.Text = "" And TRou.Text = "") Then
            If (MessageBox.Show（"缺少运动粘度或密度信息", "参数检验结果"， MessageBoxButtons.OK） = DialogResult.OK) Then
                TYun.BackColor = Color.FromArgb(255, 192, 192)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 192, 192)
            End If
        ElseIf (TDong.Text = "" And TRou.Text = "") Then
            If (MessageBox.Show（"缺少动力粘度或密度信息", "参数检验结果"， MessageBoxButtons.OK） = DialogResult.OK) Then
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 192, 192)
                TRou.BackColor = Color.FromArgb(255, 192, 192)
            End If
        ElseIf (TYun.Text = "" And TDong.Text = "") Then
            If (MessageBox.Show（"缺少运动粘度或密度信息", "参数检验结果"， MessageBoxButtons.OK） = DialogResult.OK) Then
                TYun.BackColor = Color.FromArgb(255, 192, 192)
                TDong.BackColor = Color.FromArgb(255, 192, 192)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            End If
        ElseIf (TYun.Text = "") Then
            If (MessageBox.Show（"缺少运动粘度信息,是否自动补齐", "参数检验结果"， MessageBoxButtons.OKCancel） = DialogResult.OK) Then
                TYun.Text = Val(TDong.Text) / Val(TRou.Text)
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            Else
                TYun.BackColor = Color.FromArgb(255, 192, 192)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            End If
        ElseIf (TDong.Text = "") Then
            If (MessageBox.Show（"缺少动力粘度信息,是否自动补齐", "参数检验结果"， MessageBoxButtons.OKCancel） = DialogResult.OK) Then
                TDong.Text = Val(TYun.Text) * Val(TRou.Text)
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            Else
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 192, 192)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            End If
        ElseIf (TRou.Text = "") Then
            If (MessageBox.Show（"缺少密度信息,是否自动补齐", "参数检验结果"， MessageBoxButtons.OKCancel） = DialogResult.OK) Then
                TRou.Text = Val(TDong.Text) / Val(TYun.Text)
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            Else
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 192, 192)
            End If

        Else
            If (MessageBox.Show("请补充缺失数据", "参数检验结果", MessageBoxButtons.OK) = DialogResult.OK) Then
                TYun.BackColor = Color.FromArgb(255, 255, 255)
                TDong.BackColor = Color.FromArgb(255, 255, 255)
                TRou.BackColor = Color.FromArgb(255, 255, 255)
            End If
        End If


    End Sub

    Private Sub ChongZhi_Click(sender As Object, e As EventArgs) Handles ChongZhi.Click
        TCu.Text = ""
        TDang.Text = ""
        TYun.Text = ""
        TDong.Text = ""
        TLiuL.Text = ""
        TRou.Text = ""
        TLiuS.Text = ""
        TLeiN.Text = ""
        TLmd.Text = ""
        TYanC.Text = ""
        ShuChu.Text = "未确定"
        GongShi.Image = Nothing
    End Sub

End Class
