Public Class main
    Private Sub calc_Click(sender As Object, e As EventArgs) Handles calc.Click

        Dim IsSuccess As Boolean
        Dim IsSuccess_S As Boolean
        Dim IsSuccess_M As Boolean
        Dim _rou_m_S As Double
        Dim _rou_m_M As Double
        Dim _tao_f_S As Double
        Dim _tao_f_M As Double


        '输入变量赋值
        _D = T_D.Text / 1000
        _Q_o = T_Q_o.Text
        _Q_g = T_Q_g.Text
        _gama_o = T_gama_o.Text
        _gama_g = T_gama_g.Text
        _p = T_p.Text
        _p_b = T_p_b.Text
        _T = T_T.Text
        _H = T_H.Text

        '结果数组初始化赋值

        Result(0， 0) = "压力梯度dp/dz(Pa/m)"
        Result(0， 1) = "混合物平均密度ρm(kg/m^3)"
        Result(0， 2) = "摩阻压力梯度τf(Pa/m)"
        Result(0， 3) = "井段压力p(Pa)"
        Result(0， 4) = "井段温度T(K)"
        Result(0， 5) = "溶解汽油比Rs"
        Result(0， 6) = "生产汽油比Rp"
        Result(0， 7) = "原油体积系数Bo"
        Result(0， 8) = "原油密度ρo(kg/m^3)"
        Result(0， 9) = "原油粘度μo(mPa·s)"
        Result(0， 10) = "油气界面张力σ(N/m)"
        Result(0， 11) = "天然气体积系数Bg"
        Result(0， 12) = "天然气密度ρg(kg/m^3)"
        Result(0， 13) = "地面脱气原油体积流量q osc(m^3/s)"
        Result(0， 14) = "气体体积流量qG(m^3/s)"
        Result(0， 15) = "液体体积流量qL(m^3/s)"
        Result(0， 16) = "混合物质量流量Wm(kg/s)"
        Result(0， 17) = "流态参数(BSM)"



        '开始计算

        '
        '第一步计算压力和温度
        _p = (_p + 0.101) * (10 ^ 6)
        _T = _T + 273

        Dim n As Integer
        Dim i As Integer

        n = _H \ 100 + 1
        For i = 0 To n
            '取每个井段中部为该井段平均值
            If i = 1 Then
                _p = _p + _grad_p * 50
                _T = _T + 0.95
            ElseIf i > 1 Then
                _p = _p + _grad_p * 100
                _T = _T + 1.9

            End If

            '第二步确定p,T下的物性
            _R_s = R_s(_gama_o, _gama_g, _p, _T)
            _B_o = B_o(_R_s, _gama_o, _gama_g, _T)
            _rou_o = Rou_o(_gama_o, _gama_g, _R_s, _B_o)
            _miu_o = Miu_o(_gama_o, _T, _R_s, _p, _p_b)
            _sigma = Sigma(_gama_o, _T, _p)
            _B_g = (0.101 * (10 ^ 6) * _Z_g * _T) / (_p * 293)
            _rou_g = 3.4841 * (10 ^ -3) * _gama_g * _p / (_Z_g * _T)


            '计算p,T的各流量
            _R_p = _Q_g / _Q_o
            _q_osc_ = _Q_o / 86400
            _q_G_ = _B_g * _q_osc_ * (_R_p - _R_s)
            _q_L_ = _B_o * _q_osc_
            _q_m_ = _q_G_ + _q_L_
            _W_m = (1000 * _gama_o + 1.2 * _gama_g * _R_p) * _q_osc_

            '计算p,T下的各流速
            _A = Math.PI * (_D ^ 2) / 4
            _v_SG = _q_G_ / _A
            _v_SL = _q_L_ / _A
            _v_m = _v_SG + _v_SL

            '确定流型
            _rou_L = _rou_o
            _miu_L = _miu_o / 1000
            _N_GV = N_GV(_v_SG, _rou_L, _sigma)

            _L_B = L_B(_v_m, _D)
            _L_S = L_S(_N_GV, _q_L_, _q_G_)
            _L_M = L_M(_N_GV, _q_L_, _q_G_)

            If (_L_B > (_q_G_ / _q_m_)) Then
                '泡状流
                IsSuccess = Orkiszewski.Solution_1(_rou_m, _tao_f, _D, _miu_L, _rou_L, _rou_g, _v_SL, _q_m_, _q_G_, _A)
                BSM = "B"
            ElseIf (_N_GV < _L_S) Then
                '段塞流
                _Re_ = Re(_v_m, _rou_L, _miu_L, _D)
                _v_b = v_b(_Re_, _D, _miu_L, _rou_L)
                _C_0 = C_0(_v_m, _miu_L, _D, False)
                IsSuccess = Orkiszewski.Solution_2(_rou_m, _tao_f, _D, _miu_L, _rou_L, _v_m, _v_b, _W_m, _q_m_, _q_L_, _C_0, _A)
                BSM = "S"
            ElseIf (_N_GV < _L_M) Then
                '过度流
                _Re_ = Re(_v_m, _rou_L, _miu_L, _D)
                _v_b = v_b(_Re_, _D, _miu_L, _rou_L)
                _C_0 = C_0(_v_m, _miu_L, _D, False)
                IsSuccess_S = Orkiszewski.Solution_2(_rou_m_S, _tao_f_S, _D, _miu_L, _rou_L, _v_m, _v_b, _W_m, _q_m_, _q_L_, _C_0, _A)
                IsSuccess_M = Orkiszewski.Solution_3(_rou_m_M, _tao_f_M, _D, _miu_g, _miu_L, _rou_g, _rou_L, _v_SG, _q_L_, _q_G_, _sigma)

                IsSuccess = IsSuccess_S And IsSuccess_M
                If IsSuccess Then
                    _rou_m = ((_L_M - _N_GV) / (_L_M - _L_S)) * _rou_m_S + ((_N_GV - _L_S) / (_L_M - _L_S)) * _rou_m_M
                    _tao_f = ((_L_M - _N_GV) / (_L_M - _L_S)) * _tao_f_S + ((_N_GV - _L_S) / (_L_M - _L_S)) * _tao_f_M
                End If
                BSM = "S-M"
            ElseIf (_N_GV > _L_M) Then
                '雾状流
                IsSuccess = Orkiszewski.Solution_3(_rou_m, _tao_f, _D, _miu_g, _miu_L, _rou_g, _rou_L, _v_SG, _q_L_, _q_G_, _sigma)
                BSM = "M"
            Else
                IsSuccess = False
            End If


            If IsSuccess Then
                '计算梯度
                _grad_p = (_g * _rou_m + _tao_f) / (1 - (_W_m * _q_G_ / (_p * _A ^ 2)))

                '存入数据
                Result(i + 1， 0) = Format(_grad_p, "#.########")    '"压力梯度dp/dz(Pa/m)"
                Result(i + 1， 1) = Format(_rou_m, "#.########")     '"混合物平均密度ρm(kg/m^3)"
                Result(i + 1， 2) = Format(_tao_f, "#.########")    '"摩阻压力梯度τf(Pa/m)"
                Result(i + 1， 3) = Format(_p, "#.########")    '"井段压力p(Pa)"
                Result(i + 1， 4) = Format(_T, "#.########")    '"井段温度T(K)"
                Result(i + 1， 5) = Format(_R_s, "#.########")    '"溶解汽油比Rs"
                Result(i + 1， 6) = Format(_R_p, "#.########")    '"生产汽油比Rp"
                Result(i + 1， 7) = Format(_B_o, "#.########")    '"原油体积系数Bo"
                Result(i + 1， 8) = Format(_rou_o, "#.########")    '"原油密度ρo(kg/m^3)"
                Result(i + 1， 9) = Format(_miu_o, "#.########")    '"原油粘度μo(mPa·s)"
                Result(i + 1， 10) = Format(_sigma, "#.########")   '"油气界面张力σ(N/m)"
                Result(i + 1， 11) = Format(_B_g, "#.########")   '"天然气体积系数Bg"
                Result(i + 1， 12) = Format(_rou_g, "#.########")   '"天然气密度ρg(kg/m^3)"
                Result(i + 1， 13) = Format(_q_osc_, "#.########")   '"地面脱气原油体积流量q osc(m^3,s)"
                Result(i + 1， 14) = Format(_q_G_, "#.########")   '"气体体积流量qG(m^3/s)"
                Result(i + 1， 15) = Format(_q_L_, "#.########")   '"液体体积流量qL(m^3/s)"
                Result(i + 1， 16) = Format(_W_m, "#.########")   '"混合物质量流量Wm(kg/s)"
                Result(i + 1， 17) = BSM                             '"流态参数(BSM)"


            Else

                Exit For

            End If

        Next

        '输出数据
        Dim PathUserData As String = Application.StartupPath & "\划分井段计算结果.csv"
        Dim t As System.IO.StreamWriter = New System.IO.StreamWriter(PathUserData, True, System.Text.Encoding.UTF8)
        Dim j As Integer
        Dim temp_string As String

        For i = 0 To n + 1
            temp_string = ""
            For j = 0 To 17
                temp_string = temp_string & Result(i, j) & ","
            Next
            t.WriteLine(temp_string)
        Next
        t.Close()
        MsgBox("计算结果已写入文件！", vbObject, "计算成功")
    End Sub

End Class