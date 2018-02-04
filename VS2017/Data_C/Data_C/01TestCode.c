//#include<stdio.h>
//#include<time.h>
//#include<math.h>
//
//#define MAXN  10
//#define MAXK  1000000000
//
//typedef double(*fun)(int, double*, double);
//
//double f1(int n, double a[], double x);
//double f2(int n, double a[], double x);
//void test(fun function, int n, double a[], double x);
//
//int main() {
//	double a[MAXN];
//	int i;
//	for ( i = 0; i < MAXN; i++)
//	{
//		a[i] = i;
//	}
//
//	clock_t start, stop;
//	double duration;
//
//	start = clock();
//	for (i = 0; i < MAXK; i++) {
//		f1(MAXN-1, a, 1.1);
//	}
//	stop = clock();
//	duration = (stop - start) / CLK_TCK;
//	printf("%f\n", (double)(stop - start));
//	printf("%f\n", duration);
//
//
//	start = clock();
//	for (i = 0; i < MAXK; i++) {
//		f2(MAXN-1, a, 1.1);
//	}
//	stop = clock();
//	duration = (stop - start) / CLK_TCK;
//	printf("%f\n", (double)(stop - start));
//	printf("%f\n", duration);
//	
//	test(f1, MAXN, a, 2);
//	test(f2, MAXN, a, 2);
//	system("pause");
//}
//
//double f1(int n, double a[],double x) {
//	int i;
//	double result = 0;
//	for (i = 0; i < n; i++) {
//		result += a[i] * pow(x, i);
//	}
//	return result;
//}
//
//double f2(int n, double a[], double x) {
//	int i;
//	double result = 0;
//	for (i = n; i > 0; i--) {
//		result = a[i - 1] + x * result;
//	}
//	return result;
//}
//
//void test(fun function,int n, double a[], double x) {
//	clock_t start, stop;
//	double duration;
//	start = clock();
//	int i;
//	double j;
//	for (i = 0; i < MAXK; i++) {
//		j = function(n, a, x);
//	}
//	stop = clock();
//	duration = (stop - start) / CLK_TCK;
//	printf("%f\n", (double)(stop - start));
//	printf("%f\n", duration);
//}


//#include<stdio.h>
//#include<time.h>
//
//int main() {
//	printf("%f", (double)(CLK_TCK));
//	system("pause");
//}