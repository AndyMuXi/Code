//直接法1--O(N^3)
int MaxSubseqSum1(int A[], int N) {
	int ThisSum, MaxSum=0;
	int i, j, k;
	for (i = 0; i < N; i++) {
		for (j = i; j < N; j++) {
			ThisSum = 0;
			for (k = i; k <= j; k++) {
				ThisSum += A[k];
				if (ThisSum > MaxSum) {
					MaxSum = ThisSum;
				}
			}
		}
	}
	return MaxSum;
}
//直接法2--O(N^2)
int MaxSubseqSum2(int A[], int N) {
	int ThisSum , MaxSum = 0;
	int i, j;
	for (i = 0; i < N; i++) {
		ThisSum = 0;
		for (j = i; j < N; j++) {
			ThisSum += A[j];
			if (ThisSum > MaxSum) {
				MaxSum = ThisSum;
			}
		}
	}
	return MaxSum;
}
//在线处理--O(N)
int MaxSubseqSum3(int A[], int N) {
	int ThisSum=0, MaxSum=0 ;
	int i;
	for (i = 0; i < N; i++) {
		ThisSum += A[i];
		if (ThisSum > MaxSum) {
			MaxSum = ThisSum;
		}
		if (ThisSum < 0) {
			ThisSum = 0;
		}
	}
	return MaxSum;
}

//分而治之--O(NlogNS)

int Max(int A, int B, int C) {
	//取ABC最大值
	return A > B ? A > C ? A : C : B > C ? B : C;
}

int DivideAndConquer(int list[], int left, int right) {
	int MaxLeftSum, MaxRightSum;
	int MaxLeftBorderSum, MaxRightBorderSum;
	int LeftBorderSum, RightBorderSum;
	int center, i;
	if (left == right) {
		if (list[left] > 0) {
			return list[left];
		}
		else
		{
			return 0;
		}
	}
	
	//求中心位置
	center = (left + right) / 2;
	
	//递归求子列最大和
	MaxLeftSum = DivideAndConquer(list, left, center);
	MaxRightSum = DivideAndConquer(list, center+1, right);

	//分界线最大和
	MaxLeftBorderSum = 0; LeftBorderSum = 0;
	for ( i = center; i >=left; i--)
	{
		LeftBorderSum += list[i];
		if (LeftBorderSum > MaxLeftBorderSum) {
			MaxLeftBorderSum = LeftBorderSum;
		}
	}

	MaxRightBorderSum = 0; RightBorderSum = 0;
	for (i = center+1; i <= right; i++)
	{
		RightBorderSum += list[i];
		if (RightBorderSum > MaxRightBorderSum) {
			MaxRightBorderSum = RightBorderSum;
		}
	}

	return Max(MaxLeftSum, MaxRightSum, MaxLeftBorderSum + MaxRightBorderSum);

}

int MaxSubseqSum4(int list[], int N) {
	return DivideAndConquer(list, 0, N);
}