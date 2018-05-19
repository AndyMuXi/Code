//#include <stdio.h>
//
//int main()
//{
//	int age, age_3, age_4;
//	int num[10];
//	int digit[6];
//	int i,flag=0;
//	for (age = 10; age < 32; age++) {
//		for (i = 0; i < 10; i++) { num[i] = 0; }	//数组重置
//
//		age_3 = age * age * age;//求年龄三次方
//		if (age_3 < 10000)
//		{
//			//取四位数每一位
//			digit[0] = age_3 % 10;
//			digit[1] = (age_3 % 100 - digit[0]) / 10;
//			digit[2] = (age_3 % 1000 - digit[0] - digit[1]) / 100;
//			digit[3] = (age_3 - digit[0] - digit[1] - digit[2]) / 1000;
//
//			//比较是否存在相同
//			for (i = 0; i < 4; i++) {
//				if (num[digit[i]] == 0)
//				{
//					num[digit[i]] = 1;
//				}
//				else
//				{
//
//					break;
//				}
//			}
//		}
//		else
//		{
//			//3次方超过四位数未找到
//			printf("Found %d correct value\n",flag);
//			break;
//		}
//
//		age_4 = age * age * age * age;	//取年龄4次方
//		if (age_4 < 1000000)
//		{
//			//取六位数每一位
//			digit[0] = age_4 % 10;
//			digit[1] = (age_4 % 100 - digit[0]) / 10;
//			digit[2] = (age_4 % 1000 - digit[0] - digit[1]) / 100;
//			digit[3] = (age_4 % 10000 - digit[0] - digit[1] - digit[3]) / 1000;
//			digit[4] = (age_4 % 100000 - digit[0] - digit[1] - digit[3] - digit[4]) / 10000;
//			digit[5] = (age_4 - digit[0] - digit[1] - digit[2] - digit[3] - digit[4]) / 100000;
//			
//			//比较是否重复
//			for (i = 0; i < 6; i++) {
//				if (num[digit[i]] == 0)
//				{
//					num[digit[i]] = 1;
//				}
//				else
//				{
//					break;
//				}
//			}
//			//未出现重复，输出结果，继续循环寻找下一个满足的值
//			if (i == 6) {
//				printf("Found!!Age Is:%d\n", age);
//				flag++;
//			}
//			continue;
//		}
//		else
//		{
//			printf("Found %d correct value\n",flag);
//			break;
//		}
//	}
//	
//	system("pause");
//}