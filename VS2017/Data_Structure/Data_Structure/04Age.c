//#include <stdio.h>
//
//int main()
//{
//	int age, age_3, age_4;
//	int num[10];
//	int digit[6];
//	int i,flag=0;
//	for (age = 10; age < 32; age++) {
//		for (i = 0; i < 10; i++) { num[i] = 0; }	//��������
//
//		age_3 = age * age * age;//���������η�
//		if (age_3 < 10000)
//		{
//			//ȡ��λ��ÿһλ
//			digit[0] = age_3 % 10;
//			digit[1] = (age_3 % 100 - digit[0]) / 10;
//			digit[2] = (age_3 % 1000 - digit[0] - digit[1]) / 100;
//			digit[3] = (age_3 - digit[0] - digit[1] - digit[2]) / 1000;
//
//			//�Ƚ��Ƿ������ͬ
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
//			//3�η�������λ��δ�ҵ�
//			printf("Found %d correct value\n",flag);
//			break;
//		}
//
//		age_4 = age * age * age * age;	//ȡ����4�η�
//		if (age_4 < 1000000)
//		{
//			//ȡ��λ��ÿһλ
//			digit[0] = age_4 % 10;
//			digit[1] = (age_4 % 100 - digit[0]) / 10;
//			digit[2] = (age_4 % 1000 - digit[0] - digit[1]) / 100;
//			digit[3] = (age_4 % 10000 - digit[0] - digit[1] - digit[3]) / 1000;
//			digit[4] = (age_4 % 100000 - digit[0] - digit[1] - digit[3] - digit[4]) / 10000;
//			digit[5] = (age_4 - digit[0] - digit[1] - digit[2] - digit[3] - digit[4]) / 100000;
//			
//			//�Ƚ��Ƿ��ظ�
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
//			//δ�����ظ���������������ѭ��Ѱ����һ�������ֵ
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