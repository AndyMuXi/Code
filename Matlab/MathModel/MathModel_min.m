clear
clc

%����MathMode_min_fun.m��MathModel_min_nonlcon.m����
%MathMode_min_fun.m����д��Ŀ�꺯��
%MathModel_min_nonlcon.m����д�з����Թ滮����
[x,fval] =fmincon('MathModel_min_fun',[0 0],[],[],[],[],[0 0],[],'MathModel_min_nonlcon');