//#include<stdio.h>
//#include<stdlib.h>
//
//int MaxThree(int a, int b, int c);
//int DivideAndConquer(int *list, int left, int right);
//
//int MaxSubOne(int *list, int MaxNum);
//int MaxSubTwo(int *list, int MaxNum);
//int MaxSubThr(int *list, int MaxNum);
//
//int main() {
//	int MaxNum;
//	int *list;
//	printf("����������\n");
//	scanf_s("%d", &MaxNum);
//	list = (int*)malloc(sizeof(int)*MaxNum);
//	printf("����%d�����֣��Կո������س�������\n",MaxNum);
//	int i;
//	for ( i = 0; i < MaxNum; i++)
//	{
//		scanf_s("%d", &list[i]);
//	}
//	printf("������к�1Ϊ��%d\n", MaxSubOne(list, MaxNum));
//	printf("������к�2Ϊ��%d\n", MaxSubTwo(list, MaxNum));
//	printf("������к�2Ϊ��%d\n", MaxSubThr(list, MaxNum));
//
//	//for (i = 0; i < MaxNum; i++)
//	//{
//	//	printf("%d ", list[i]);
//	//}
//	//printf("\n");
//
//	system("pause");
//}
//
//int MaxSubOne(int *list,int MaxNum) {
//	int MaxSubValue = 0;
//	int MaxSubTemp = 0;
//	int i;
//	for (i = 0; i < MaxNum; i++) {
//		if (MaxSubTemp>=0)
//		{
//			MaxSubTemp += list[i];
//		}
//		else
//		{
//			MaxSubTemp = 0;
//		}
//		if (MaxSubTemp>MaxSubValue)
//		{
//			MaxSubValue = MaxSubTemp;
//		}
//	}
//
//	return MaxSubValue;
//}
//
//int MaxSubTwo(int *list, int MaxNum) {
//	int i, j;
//	int MaxSubTemp;
//	int MaxSubValue = 0;
//	for (i = 0; i < MaxNum; i++) {
//		MaxSubTemp = 0;
//		for (j = i; j < MaxNum; j++) {
//			MaxSubTemp += list[j];
//			if (MaxSubTemp>MaxSubValue) {
//				MaxSubValue = MaxSubTemp;
//			}
//		}
//	}
//	return MaxSubValue;
//}
//
//int MaxSubThr(int *list, int MaxNum) {
//	int left=0, right=MaxNum;
//	return DivideAndConquer(list, left, right);
//}
//
//int DivideAndConquer(int *list, int left, int right) {
//	//�������к�
//	int MaxLeftSum, MaxRightSum;
//	int MaxLeftBorder, MaxRightBorder;
//
//	//��Խ�߽���������к�
//	int LeftBorder, RightBorder;
//	//�м�λ��center
//	int center, i;
//	
//	//�ݹ���ֹ����
//	if (left == right) {
//		if (list[left] > 0) {
//			return list[left];
//		}
//		else
//		{
//			return 0;
//		}
//	}
//
//	center = (left + right) / 2;
//	
//	//�ݹ�������������к�
//	MaxLeftSum = (list, left, center - 1);
//	MaxRightSum = (list, center, right);
//
//	//��Խ�߽������к�
//	MaxLeftBorder = 0; MaxRightBorder = 0;
//	LeftBorder = 0; RightBorder = 0;
//	for (i = center - 1; i >= left; i--) {
//		LeftBorder += list[i];
//		if (LeftBorder>MaxLeftBorder)
//		{
//			MaxLeftBorder = LeftBorder;
//		}
//	}
//
//	for (i = center; i < right; i++) {
//		RightBorder += list[i];
//		if (RightBorder>MaxRightBorder)
//		{
//			MaxRightBorder = RightBorder;
//		}
//	}
//
//	return MaxThree(MaxLeftBorder + MaxRightBorder, MaxLeftSum, MaxRightSum);
//}
//
//int MaxThree(int a, int b, int c) {
//	return a > b ? a > c ? a : c : b > c ? b : c;
//}