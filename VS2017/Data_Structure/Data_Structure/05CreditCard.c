//#include <stdio.h>
//#include<string.h>
//
////5086567162530780
//int main() {
//	char credit_num[20];
//	int len, position;
//	int sum_odd=0, sum_even=0;
//
//	gets(credit_num);
//	len = strlen(credit_num);
//	for (position = len - 1; position >= 0; position--) {
//		if ((len-position) % 2 != 0) {
//			sum_odd = sum_odd + (credit_num[position] - '0');
//		}
//		else
//		{
//			if ((credit_num[position] - '0') * 2 >= 10) {
//				sum_even = sum_even + (credit_num[position] - '0') - 9;
//			}
//			else
//			{
//				sum_even = sum_even + (credit_num[position] - '0');
//			}
//		}
//	}
//
//	if ((sum_even + sum_odd) % 10 == 0) {
//		printf("Corret Credit Number");
//	}
//	else
//	{
//		printf("Error Credit Number");
//	}
//	system("pause");
//}