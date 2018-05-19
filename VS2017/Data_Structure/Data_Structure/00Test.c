///*#include<stdio.h>
//
//int main(){
//
//	int a =16315;
//	a= (a%100-a%5)/10;
//	printf("%d\n",a );
//}*/
//
//#include <stdio.h>
//
//int main()
//{
//	int age, age_3, age_4;
//	int num[10];
//	int digit[6];
//	int i;
//	for (age = 10; age < 32; age++) {
//		
//		for (i = 0; i < 10; i++) 
//		{ 
//			num[i] = 0; 
//		}
//
//		age_3 = age * age * age;
//		if (age_3 < 10000)
//		{
//			digit[0] = age_3 % 10;
//			digit[1] = (age_3 % 100 - digit[0]) / 10;
//			digit[2] = (age_3 % 1000 - digit[0] - digit[1]) / 100;
//			digit[3] = (age_3 - digit[0] - digit[1] - digit[3]) / 1000;
//
//			for (i = 0; i < 4; i++) {
//				if (num[digit[i]] == 0)
//				{
//					num[digit[i]] = 1;
//				}
//				break;
//			}
//			continue;
//		}
//		else
//		{
//			printf("未能找到1\n");
//			break;
//		}
//
//		age_4 = age * age*age*age;
//		if (age_4 < 1000000)
//		{
//			digit[0] = age_4 % 10;
//			digit[1] = (age_4 % 100 - digit[0]) / 10;
//			digit[2] = (age_4 % 1000 - digit[0] - digit[1]) / 100;
//			digit[3] = (age_4 % 10000 - digit[0] - digit[1] - digit[3]) / 1000;
//			digit[4] = (age_4 % 100000 - digit[0] - digit[1] - digit[3] - digit[4]) / 10000;
//			digit[5] = (age_4 - digit[0] - digit[1] - digit[3] - digit[4] - digit[5]) / 100000;
//
//			for (i = 0; i < 6; i++) {
//				if (num[digit[i]] == 0)
//				{
//					num[digit[i]] = 1;
//				}
//				break;
//			}
//			if (i == 6) {
//				break;
//			}
//			else
//			{
//				continue;
//			}
//		}
//		else
//		{
//			printf("未能找到2\n");
//			break;
//		}
//	}
//	printf("%d", age);
//}
//
