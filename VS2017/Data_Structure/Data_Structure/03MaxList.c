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
//	printf("输入项数：\n");
//	scanf_s("%d", &MaxNum);
//	list = (int*)malloc(sizeof(int)*MaxNum);
//	printf("输入%d个数字，以空格间隔，回车结束：\n",MaxNum);
//	int i;
//	for ( i = 0; i < MaxNum; i++)
//	{
//		scanf_s("%d", &list[i]);
//	}
//	printf("最大子列和1为：%d\n", MaxSubOne(list, MaxNum));
//	printf("最大子列和2为：%d\n", MaxSubTwo(list, MaxNum));
//	printf("最大子列和2为：%d\n", MaxSubThr(list, MaxNum));
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
//	//左右子列和
//	int MaxLeftSum, MaxRightSum;
//	int MaxLeftBorder, MaxRightBorder;
//
//	//跨越边界的左右子列和
//	int LeftBorder, RightBorder;
//	//中间位置center
//	int center, i;
//	
//	//递归终止条件
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
//	//递归求左右最大子列和
//	MaxLeftSum = (list, left, center - 1);
//	MaxRightSum = (list, center, right);
//
//	//跨越边界左子列和
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