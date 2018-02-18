function [fun,eq] = MathModel_min_nonlcon( x )
%MATHMODEL_MIN_NONLCON 此处显示有关此函数的摘要
%   非线性约束条件

fun=-x(1)^2+x(2);   %非线性不等式约束
eq=-x(1)-x(2)^2+2;  %非线性等式约束

end

