clear
clc

%先由excel计算得到前8天积累分布数据
%A  1601	7022	8912	13351	15054	18286	18662	19829
%B  2845	5678	10166	14720	17648	21145	23406	30327
%C  4926	7797	12244	15240	20328	23157	27050	33756
%D  2239	2482	5232	6716	11094	14687	16804	18677

%录入数据
days=1:1:8;
A=[1601	7022	8912	13351	15054	18286	18662	19829];
B=[2845	5678	10166	14720	17648	21145	23406	30327];
C=[4926	7797	12244	15240	20328	23157	27050	33756];
D=[2239	2482	5232	6716	11094	14687	16804	18677];

A_real=[1601	7022	8912	13351	15054	18286	18662	19829	21726	25463	27270	28898	30621   33205];
B_real=[2845	5678	10166	14720	17648	21145	23406	30327	31718	35298	39749	42385	45856   49710];
C_real=[4926	7797	12244	15240	20328	23157	27050	33756	41820	45206	50523	53635	57861   62381];
D_real=[2239	2482	5232	6716	11094	14687	16804	18677	20427	26365	27824	35581	38022   39395];

%拟合数据
Result_A=polyfit(days,A,1);
Result_B=polyfit(days,B,1);
Result_C=polyfit(days,C,1);
Result_D=polyfit(days,D,1);

%检验数据
days_check=1:1:14;

A_check=Result_A(1)*days_check+Result_A(2);
B_check=Result_B(1)*days_check+Result_B(2);
C_check=Result_C(1)*days_check+Result_C(2);
D_check=Result_D(1)*days_check+Result_D(2);

%求取偏差
A_tol=(A_real-A_check)./A_real;
B_tol=(B_real-B_check)./B_real;
C_tol=(C_real-C_check)./C_real;
D_tol=(D_real-D_check)./D_real;

A_tol_avg=mean( A_tol ( : ) );
B_tol_avg=mean( B_tol ( : ) );
C_tol_avg=mean( C_tol ( : ) );
D_tol_avg=mean( D_tol ( : ) );
%偏差合理可用作预测

days_pre=14:1:21;

A_pre=Result_A(1)*days_pre+Result_A(2);
B_pre=Result_B(1)*days_pre+Result_B(2);
C_pre=Result_C(1)*days_pre+Result_C(2);
D_pre=Result_D(1)*days_pre+Result_D(2);

%导出输出结果至excel求取ABCD接下来7天结果如下（结果取整）
%A   2567	2567	2567	2567	2567	2567	2567
%B   3772	3772	3772	3772	3772	3772	3772
%C   3999	3999	3999	3999	3999	3999	3999
%D   2612	2612	2612	2612	2612	2612	2612




