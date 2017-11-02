clear
clc

%引用MathMode_min_fun.m和MathModel_min_nonlcon.m函数
%MathMode_min_fun.m函数写有目标函数
%MathModel_min_nonlcon.m函数写有非线性规划条件
[x,fval] =fmincon('MathModel_min_fun',[0 0],[],[],[],[],[0 0],[],'MathModel_min_nonlcon');