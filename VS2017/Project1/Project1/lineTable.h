#pragma once
#include<stdlib.h>
#include<stdio.h>

//定义链表类型
typedef struct LNode *List;
struct LNode {
	int Data[10];
	int Last;
};

//初始化一个空List类型链表
List MakeEmpty() {
	List Point;
	Point = (List)malloc(sizeof(struct LNode));
	Point->Last = -1;
	return Point;
}

//在链表中查找数据
int Find(int finding_value,List Point) {//输入参数寻找值和寻找链表指针
	int i=0,result;
	while (i<=Point->Last&&Point->Data[i]!=finding_value) {
		i++;
	}
	if (i>Point->Last) {
		printf("错误：数据不存在");
		result = -1;
	}
	else
	{
		result=i;
	}
	return result;
}


//向链表添加数据
void Insert(int insert_value, int insert_position , List Point) {//输入插入值，插入位置，被插入链表指针
	int j;
	if (Point->Last == 9) {
		printf("错误：链表已满\n");
	}
	else if(insert_position<0||insert_position>Point->Last+2)
	{
		printf("错误：位置非法\n");
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

//在链表中删除数据
void Delete(int Delete_position, List Point) {//输入删除位置，被删除链表指针
	int i;
	if (Delete_position<1||Delete_position - 1 > Point->Last) {
		printf("错误：当前位置为空\n");
	}
	else 
	{
		for (i = Delete_position; i <= Point->Last; i++) {
			Point->Data[i-1] = Point->Data[i];
		}
		Point->Last--;
	}
}
