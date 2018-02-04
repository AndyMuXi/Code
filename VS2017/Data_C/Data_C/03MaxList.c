#include<stdio.h>
#include<stdlib.h>

int MaxSubOne(int *list);

int main() {
	int MaxNum;
	char *lists;
	int *list;
	printf("输入项数：\n");
	scanf_s("%d", &MaxNum);
	list = (int*)malloc(sizeof(int)*MaxNum);
	printf("输入%d个数字，以空格间隔，回车结束：\n",MaxNum);
	int i;
	for ( i = 0; i < MaxNum; i++)
	{
		scanf_s("%d", &list[i]);
	}
	printf("最大子列和为：%d\n", MaxSubOne(list, MaxNum));
	//for (i = 0; i < MaxNum; i++)
	//{
	//	printf("%d ", list[i]);
	//}
	//printf("\n");

	system("pause");
}

int MaxSubOne(int *list,int MaxNum) {
	int MaxSubValue = 0;
	int MaxSubTemp = 0;
	int i;
	for (i = 0; i < MaxNum; i++) {
		if (MaxSubTemp>=0)
		{
			MaxSubTemp += list[i];
		}
		else
		{
			MaxSubTemp = 0;
		}
		if (MaxSubTemp>MaxSubValue)
		{
			MaxSubValue = MaxSubTemp;
		}
	}

	return MaxSubValue;
}