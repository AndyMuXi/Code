#pragma once
#include<stdlib.h>
#include<stdio.h>

//������������
typedef struct LNode *List;
struct LNode {
	int Data[10];
	int Last;
};

//��ʼ��һ����List��������
List MakeEmpty() {
	List Point;
	Point = (List)malloc(sizeof(struct LNode));
	Point->Last = -1;
	return Point;
}

//�������в�������
int Find(int finding_value,List Point) {//�������Ѱ��ֵ��Ѱ������ָ��
	int i=0,result;
	while (i<=Point->Last&&Point->Data[i]!=finding_value) {
		i++;
	}
	if (i>Point->Last) {
		printf("�������ݲ�����");
		result = -1;
	}
	else
	{
		result=i;
	}
	return result;
}


//�������������
void Insert(int insert_value, int insert_position , List Point) {//�������ֵ������λ�ã�����������ָ��
	int j;
	if (Point->Last == 9) {
		printf("������������\n");
	}
	else if(insert_position<0||insert_position>Point->Last+2)
	{
		printf("����λ�÷Ƿ�\n");
	}
	else
	{
		for ( j = Point->Last; j >= insert_position ; j--)
		{
			Point->Data[j + 1] = Point->Data[j];
		}
		Point->Data[insert_position-1] = insert_value;
		Point->Last++;
	}
}

//��������ɾ������
void Delete(int Delete_position, List Point) {//����ɾ��λ�ã���ɾ������ָ��
	int i;
	if (Delete_position<1||Delete_position - 1 > Point->Last) {
		printf("���󣺵�ǰλ��Ϊ��\n");
	}
	else 
	{
		for (i = Delete_position; i <= Point->Last; i++) {
			Point->Data[i-1] = Point->Data[i];
		}
		Point->Last--;
	}
}
