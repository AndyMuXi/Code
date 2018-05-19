Module Orkiszewski

    '常数及全局变量声明
    '+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
    Const g = 9.8           '重力加速度取9.8
    Public _D As Double     '油管内径
    Public _Q_o As Double   '产油量Qo
    Public _Q_g As Double   '产气量Qg
    Public _rou_o As Double '原油密度
    Public _rou_g As Double '天然气密度
    Public _p As Double     '油压
    Public _p_b As Double   '原油饱和压力


    '相关参数计算函数声明
    '+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

    '雷诺数计算函数
    Public Function Re(ByVal v As Double, ByVal rou As Double, ByVal mu As Double, ByVal D As Double)

        Re = v * rou * D / mu

    End Function '速度、密度、粘度、和油管直径

    '流型判断函数

    'p和T下的液相密度
    Public Function rou_L(ByVal rou_o As Double, ByVal rou_w As Double, ByVal f_w As Double)

        rou_L = rou_o * (1 - f_w) + rou_w * f_w

    End Function 'p和T的的油和水密度、体积函数率q_w/q_L

    '无因次气相速度
    Public Function N_GV(ByVal v_SG As Double, ByVal rou_L As Double, ByVal sigma As Double)

        N_GV = v_SG * ((rou_L / (g * sigma)) ^ 0.25)

    End Function '气相流速、p和T下的液相密度、p和T下气液表面张力

    '泡状流界限参数
    Public Function L_B(ByVal v_m As Double, ByVal D As Double)

        Dim temp As Double
        temp = 1.071 - 0.7277 * (v_m ^ 2) / D
        If temp > 0.13 Then
            L_B = temp
        Else
            L_B = 0.13
        End If
    End Function 'v_m = v_SG + v_SL、油管直径

    '段塞流界限参数
    Public Function L_S(ByVal N_GV, ByVal q_L, ByVal q_G)

        L_S = 50 + 36 * N_GV * q_L / q_G

    End Function '无因次气相速度、液相流量、气相流量

    '环雾流界限参数
    Public Function L_M(ByVal N_GV, ByVal q_L, ByVal q_G)

        L_M = 75 + 84 * ((N_GV * (q_L / q_G)) ^ 0.75)

    End Function '无因次气相速度、液相流量、气相流量


End Module
