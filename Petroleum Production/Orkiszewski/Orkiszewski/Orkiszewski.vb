Module Orkiszewski

    '常数及全局变量声明
    '+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
    Public Const _g = 9.81              '重力加速度取9.8
    Public _D As Double                 '油管内径
    Public _Q_o As Double               '产油量Qo
    Public _Q_g As Double               '产气量Qg
    Public _gama_o As Double            '原油相对密度
    Public _gama_g As Double            '天然气相对密度
    Public _p As Double                 '油压
    Public _p_b As Double               '原油饱和压力
    Public _T As Double                 '井口温度
    Public _A As Double                 '横截面积
    Public _R_s As Double               '溶解汽油比
    Public _B_o As Double               '体积系数
    Public _rou_L As Double             '液体密度
    Public _rou_o As Double             '原油密度
    Public _miu_L As Double             '液体粘度
    Public _miu_o As Double             '原油粘度
    Public _sigma As Double             '油气界面张力
    Public Const _Z_g = 0.94            '天然气偏差系数
    Public Const _miu_g = 0.0114        '天然气粘度
    Public _B_g As Double               '天然气体积系数
    Public _rou_g As Double             '天然气密度
    Public _R_p As Double               '生产汽油比
    Public _q_osc_ As Double             '地面脱气原油体积流量
    Public _q_G_ As Double              'p,T下的气体体积流量
    Public _q_L_ As Double              'p,T下的液体体积流量
    Public _q_m_ As Double              'p,T下的混合物体积流量
    Public _W_m As Double               '混合物质量流量
    Public _v_SG As Double              'p,T下的气体流速
    Public _v_SL As Double              'p,T下的液体流速
    Public _v_m As Double               'p,T下的混合物流速
    Public _N_GV As Double              '无因次气相速度
    Public _L_B As Double               '泡状流界限参数
    Public _L_S As Double               '段塞流界限参数
    Public _L_M As Double               '环雾流界限参数
    Public _rou_m As Double             '混合物密度
    Public _tao_f As Double             '摩阻损失梯度
    Public _v_b As Double               '段塞流参数
    Public _Re_ As Double               '段塞流参数
    Public _C_0 As Double               '段塞流参数 
    Public _grad_p As Double            '压力梯度
    Public _H As Double                 '井深
    Public BSM As String                   '流态参数
    Public Result(50, 18) As String     '结果数组（最大可存井深5000m）



    '相关参数计算函数声明
    '+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

    '雷诺数计算函数
    Public Function Re(ByVal v As Double, ByVal rou As Double, ByVal miu As Double, ByVal D As Double) As Double

        Re = v * rou * D / miu

    End Function '速度、密度、粘度、和油管直径

    '物性计算公式

    '溶解汽油比
    Public Function R_s(ByVal gama_o As Double, ByVal gama_g As Double, ByVal p As Double, ByVal T As Double) As Double
        p = p / (10 ^ 6)
        T = T - 273
        R_s = 0.02124 * gama_g * (p * 10 ^ ((1.76875 / gama_o) - 0.001638 * T)) ^ 1.205
    End Function

    '原油体积系数
    Public Function B_o(ByVal R_s As Double, ByVal gama_o As Double, ByVal gama_g As Double, ByVal T As Double) As Double
        T = T - 273
        B_o = 0.972 + 1.47 * (10 ^ -4) * (5.614 * R_s * (gama_g / gama_o) ^ 0.5 + 2.25 * T + 40) ^ 1.175
    End Function

    '原油密度
    Public Function Rou_o(ByVal gama_o As Double, ByVal gama_g As Double, ByVal R_s As Double, ByVal B_o As Double) As Double
        Rou_o = (1000 * gama_o + 1.2 * gama_g * R_s) / B_o
    End Function

    '原油粘度计算公式
    Public Function Miu_o(ByVal gama_o As Double, ByVal T As Double, ByVal R_s As Double, ByVal p As Double, ByVal p_b As Double) As Double
        Dim theta As Double
        Dim API As Double
        Dim miu_od As Double    '死油粘度及其计算参数
        Dim X As Double
        Dim Y As Double
        Dim Z As Double

        Dim miu_ob As Double    '饱和粘度及其计算参数
        Dim a As Double
        Dim b As Double

        Dim m As Double         '原油粘度计算参数
        Dim n As Double


        '换算压力单位
        p = p / (10 ^ 6)

        '计算死油粘度
        API = (141.5 / gama_o) - 131.5
        theta = 1.8 * (T - 273) + 32
        Z = 3.0324 - 0.02023 * API
        Y = 10 ^ Z
        X = Y * (theta) ^ (-1.163)
        miu_od = 10 ^ X - 1

        '计算饱和粘度
        a = 10.715 * (5.615 * R_s + 100) ^ (-0.515)
        b = 5.44 * (5.615 * R_s + 150) ^ (-0.338)
        miu_ob = a * (miu_od ^ b)

        '计算非饱和粘度
        n = -5.66 * (10 ^ -3) * p - 5
        m = 956.4 * (p ^ 1.187) * (10) ^ n
        Miu_o = miu_ob * ((p / p_b) ^ m)


    End Function

    '油气界面张力计算函数
    Public Function Sigma(ByVal gama_o As Double, ByVal T As Double, ByVal p As Double) As Double

        Dim API As Double
        Dim theta As Double

        '换算压力单位
        p = p / (10 ^ 6)

        API = (141.5 / gama_o) - 131.5
        theta = 1.8 * (T - 273) + 32
        Sigma = (42.4 - 0.047 * theta - 0.267 * API) * Math.Exp(-0.101521 * p)

    End Function







    '流型判断函数

    'p和T下的液相密度
    Public Function Rou_L(ByVal rou_o As Double, ByVal rou_w As Double, ByVal f_w As Double) As Double

        Rou_L = rou_o * (1 - f_w) + rou_w * f_w

    End Function 'p和T的的油和水密度、体积函数率q_w/q_L

    '无因次气相速度
    Public Function N_GV(ByVal v_SG As Double, ByVal rou_L As Double, ByVal sigma As Double) As Double

        N_GV = v_SG * ((rou_L / (_g * sigma)) ^ 0.25)

    End Function '气相流速、p和T下的液相密度、p和T下气液表面张力

    '泡状流界限参数
    Public Function L_B(ByVal v_m As Double, ByVal D As Double) As Double

        Dim temp As Double
        temp = 1.071 - 0.7277 * (v_m ^ 2) / D
        If temp > 0.13 Then
            L_B = temp
        Else
            L_B = 0.13
        End If
    End Function 'v_m = v_SG + v_SL、油管直径

    '段塞流界限参数
    Public Function L_S(ByVal N_GV As Double, ByVal q_L As Double, ByVal q_G As Double) As Double

        L_S = 50 + 36 * N_GV * q_L / q_G

    End Function '无因次气相速度、液相流量、气相流量

    '环雾流界限参数
    Public Function L_M(ByVal N_GV As Double, ByVal q_L As Double, ByVal q_G As Double) As Double

        L_M = 75 + 84 * ((N_GV * (q_L / q_G)) ^ 0.75)

    End Function '无因次气相速度、液相流量、气相流量


    'C0计算公式
    Public Function C_0(ByVal v_m As Double, ByVal miu_L As Double, ByVal D As Double, ByVal fluent_const As Boolean) As Double
        Dim temp As Double

        If (fluent_const) Then
            If (v_m < 3.048) Then
                '1-86a
                temp = 0.00252 * Math.Log10(miu_L * 10 ^ 3) / (D ^ 1.38) - 0.782 + 0.232 * Math.Log10(v_m) - 0.482 * Math.Log10(D)
                If temp < -0.2132 * v_m Then
                    temp = -0.2132 * v_m
                End If
            Else
                '1-86b
                temp = 0.00174 * Math.Log10(miu_L * 10 ^ 3) / (D ^ 0.799) - 1.251 + 0.162 * Math.Log10(v_m) - 0.888 * Math.Log10(D)
            End If
        Else
            If (v_m < 3.048) Then
                '1-86c
                temp = 0.00236 * Math.Log10(miu_L * 10 ^ 3 + 1) / (D ^ 1.415) - 0.14 + 0.167 * Math.Log10(v_m) + 0.113 * Math.Log10(D)
                If temp < -0.2132 * v_m Then
                    temp = -0.2132 * v_m
                End If
            Else
                '1-86d
                temp = 0.00537 * Math.Log10(miu_L * 10 ^ 3 + 1) / (D ^ 1.371) + 0.455 + 0.569 * Math.Log10(D) -
                    (Math.Log10(v_m) + 0.516) * (0.0016 * Math.Log10(miu_L * 10 ^ 3 + 1) / (D ^ 1.517) + 0.722 + 0.63 * Math.Log10(D))
            End If
        End If

        C_0 = temp

    End Function '混合物速度、pT下的液体粘度、油管直径、流体类型参数(True为水，False为油)

    '摩阻计算公式
    Public Function F_(ByVal Re As Double, ByVal D As Double)
        If (Re > 2300) Then
            F_ = (1.14 - 2 * Math.Log10((0.01524 / (D * 1000)) + (21.25 / (Re ^ 0.9)))) ^ -2
        Else
            F_ = 64 / Re
        End If
    End Function

    '泡状流计算公式
    Public Function Solution_1 _
        (ByRef rou_m As Double, ByRef tao_f As Double, ByVal D As Double, ByVal miu_L As Double, ByVal rou_L As Double, ByVal rou_G As Double,
         ByVal v_SL As Double, ByVal q_m As Double, ByVal q_G As Double, ByVal A As Double) As Boolean

        '声明函数内临时变量
        Dim f_temp As Double
        Dim H_G_temp As Double
        Dim temp As Double
        Dim v_L As Double



        temp = 1 + (q_m / (0.244 * A))
        H_G_temp = 0.5 * (temp - (temp ^ 2 - 4 * q_G / 0.244 * A) ^ 0.5)
        v_L = v_SL / (1 - H_G_temp)

        f_temp = F_(Re(v_L, rou_L, miu_L, D), D)
        '输出值
        rou_m = (1 - H_G_temp) * rou_L + H_G_temp * rou_G
        tao_f = f_temp * (rou_L * v_L ^ 2) / (2 * D)

        Solution_1 = True   '成功执行计算返回成功

    End Function

    'v_b确定方法
    Public Function v_b(ByVal re_ As Double, ByVal D As Double, ByVal miu_L As Double, ByVal rou_L As Double) As Double

        Dim Re_b As Double
        Dim v_bi As Double
        Dim flag As Integer '指示雷诺数区间


        If (re_ < 3000) Then
            v_b = (0.546 + (8.74 * 10 ^ -6) * re_) * ((_g * D) ^ 0.5)
            flag = 1
        ElseIf (re_ < 8000) Then
            v_bi = (0.251 + (8.74 * 10 ^ -6) * re_) * ((_g * D) ^ 0.5)
            v_b = 0.5 * (v_bi + (v_bi ^ 2 + 11170 * miu_L / (rou_L * (D ^ 0.5))) ^ 0.5)
            flag = 2
        Else
            v_b = (0.35 + (8.74 * 10 ^ -6) * re_) * ((_g * D) ^ 0.5)
            flag = 3
        End If

        Re_b = Re(v_b, rou_L, miu_L, D)

        '递归调用求解v_b
        If (Not ((flag = 1 And Re_b < 3000) Or (flag = 2 And Re_b > 3000 And Re_b < 8000) Or (flag = 3 And Re_b > 8000))) Then
            v_b = v_b(Re_b, D, miu_L, rou_L)
        End If

    End Function

    '段塞流计算公式
    Public Function Solution_2 _
        (ByRef rou_m As Double, ByRef tao_f As Double, ByVal D As Double, ByVal miu_L As Double, ByVal rou_L As Double,
         ByVal v_m As Double, ByVal v_b As Double, ByVal W_m As Double, ByVal q_m As Double, ByVal q_L As Double,
         ByVal C_0 As Double, ByVal A As Double) As Boolean
        '声明临时变量
        Dim f_temp As Double
        Dim C_temp As Double

        rou_m = (W_m + rou_L * v_b * A) / (q_m + v_b * A) + C_0 * rou_L

        f_temp = F_(Re(v_m, rou_L, miu_L, D), D)

        If v_m > 3.048 Then
            C_temp = (-v_b * A) * (1 - rou_m / rou_L) / (q_m + v_b * A)
            If C_0 < C_temp Then
                C_0 = C_temp
            End If
        End If

        tao_f = ((f_temp * rou_L * v_m ^ 2) / （2 * D)) * ((q_L + v_b * A) / (q_m + v_b * A) + C_0)

        Solution_2 = True   '成功执行计算返回成功
    End Function

    '环雾流计算方法
    Public Function Solution_3 _
        (ByRef rou_m As Double, ByRef tao_f As Double, ByVal D As Double, ByVal miu_g As Double, ByVal miu_L As Double, ByVal rou_G As Double, ByVal rou_L As Double,
         ByVal v_SG As Double, ByVal q_L As Double, ByVal q_G As Double, ByVal sigma As Double) As Boolean

        Dim H_G_temp As Double
        Dim f_temp As Double
        Dim N_w As Double
        Dim e_D As Double

        H_G_temp = q_G / (q_G + q_L)

        rou_m = (1 - H_G_temp) * rou_L + H_G_temp * rou_G

        N_w = ((v_SG * miu_L / sigma) ^ 2) * rou_G / rou_L

        If (N_w <= 0.005) Then
            e_D = 34 * sigma / (rou_G * (v_SG ^ 2) * D)
        Else
            e_D = 174.8 * sigma * N_w ^ 0.302 / (rou_G * (v_SG ^ 2) * D)
        End If

        f_temp = (1.14 - 2 * Math.Log10(e_D + (21.25 / (Re(v_SG, rou_G, miu_g, D) ^ 0.9)))) ^ -2

        tao_f = f_temp * rou_G * (v_SG ^ 2) / (2 * D)

        Solution_3 = True '成功执行计算返回成功

    End Function


End Module
