#include<stdio.h>
#include<stdlib.h>

int MaxSubOne(int *list);

int main() {
	int MaxNum;
	char *lists;
	int *list;
	printf("����������\n");
	scanf_s("%d", &MaxNum);
	list = (int*)malloc(sizeof(int)*MaxNum);
	printf("����%d�����֣��Կո������س�������\n",MaxNum);
	int i;
	for ( i = 0; i < MaxNum; i++)
	{
		scanf_s("%d", &list[i]);
	}
	printf("������к�Ϊ��%d\n", MaxSubOne(list, MaxNum));
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