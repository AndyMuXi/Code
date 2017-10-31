//#include"stdio.h"
//#include"MaxSubSum.h"
//#include"stdlib.h"
#include"LineTable.h"


int main() {
	List PtrL;
	PtrL = MakeEmpty();
	Insert(1, 1, PtrL);
	Insert(2, 2, PtrL);
	Insert(3, 3, PtrL);
	Delete(0, PtrL);
	printf("%d\n", PtrL->Data[0]);
	printf("%d\n", PtrL->Last);
	printf("%d\n", Find(0,PtrL));
	system("pause");
}