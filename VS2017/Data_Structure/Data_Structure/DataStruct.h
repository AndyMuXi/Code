//
//	DataStruct.h
//
//	study data structure
//
//	by Andy Dx
//

#pragma once
#include<stdio.h>
#define _IN_QUENE_DATA
#define _PUSH_STACK_DATA


// Define LinkList

typedef struct LinkList {
	int data;
	struct LinkList *next;
}Quene,Stack,LNode;

//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
//	Queue			
//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

Quene CreatQuene() {

}


Quene InQuene(Quene* L,int _IN_QUENE_DATA) {

}


Quene OutQueue(Quene* L) {

}




//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
//	Stack			
//-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+

Stack CreatStack() {

}

Stack PushStack(Stack* L, int _PUSH_STACK_DATA) {

}

Stack PopStack(Stack* L) {

}



