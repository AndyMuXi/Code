function [fun,eq] = MathModel_min_nonlcon( x )
%MATHMODEL_MIN_NONLCON �˴���ʾ�йش˺�����ժҪ
%   ������Լ������

fun=-x(1)^2+x(2);   %�����Բ���ʽԼ��
eq=-x(1)-x(2)^2+2;  %�����Ե�ʽԼ��

end

